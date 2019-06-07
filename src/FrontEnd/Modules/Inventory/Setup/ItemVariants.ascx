<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ItemVariants.ascx.cs" Inherits="MixERP.Net.Core.Modules.Inventory.Setup.ItemVariants" %>

<div id="form" style="display: none;">
    <div class="ui huge grey header">
        <span id="heading">
            <span data-localize="Titles.ItemVariants"></span>
        </span>
    </div>
    <div class="ui divider"></div>

    <div class="ui form">
        <div class="four fields">
            <div class="field">
                <label>Select Item</label>
                <select id="ItemSelect" class="ui search dropdown"></select>
            </div>
            <div class="field">
                <label>Select Variant</label>
                <select id="VariantSelect" class="ui search dropdown"></select>
            </div>
            <div class="field">
                <label>&nbsp;</label>
                <input type="button" id="ShowButton" class="ui basic button" value="Show" />
            </div>
        </div>
    </div>

    <table id="variant-table" class="ui small compact stackable form table">
        <thead>
            <tr>
                <th style="width: 300px;">
                    <span data-localize="Titles.Attribute"></span>
                </th>
                <th style="width: 300px;">
                    <span data-localize="Titles.Variant"></span>
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
        </tbody>
        <tfoot>
            <tr>
                <th>
                    <input type="text" id="ItemCodeInputText" maxlength="12" placeholder="Item Code" />
                </th>
                <th>
                    <input type="text" id="ItemNameInputText" maxlength="100" placeholder="Item Name" />
                </th>
                <th class="right aligned">
                    <input type="button" class="ui blue add button" value="Add" onclick="addRow();" />
                    <div class="ui buttons">
                        <input type="button" class="ui olive save button" id="SaveButton" value="Save" />
                        <input type="button" class="ui purple save button" id="DeleteButton" value="Delete" />
                    </div>
                </th>
            </tr>
        </tfoot>
    </table>
</div>



<script>
    var attributes;
    var variants;
    var rowTemplate =
    '<tr>\
        <td>\
            <select class="ui search attribute fluid dropdown">{attributes}</select>\
        </td>\
        <td>\
            <select class="ui search variant fluid dropdown"></select>\
        </td>\
        <td>\
            <div class="ui basic buttons">\
                <input type="button" class="ui basic delete button" value="Delete" />\
            </div>\
        </td>\
    </tr>';



    function bindItems() {
        var url = "/api/core/item/display-fields";
        var target = $("#ItemSelect");
        ajaxDataBind(url, target, null, null, null, null, "Key", "Value");
    };

    function getAttributes() {
        function request() {
            var url = "/api/core/attribute/all";
            return getAjaxRequest(url);
        };

        var ajax = request();

        ajax.success(function (response) {
            attributes = response;
        });
    };

    function getVariants() {
        function request() {
            var url = "/api/core/variant/all";
            return getAjaxRequest(url);
        };

        var ajax = request();

        ajax.success(function (response) {
            variants = response;
        });
    };


    $(document).ready(function () {
        bindItems();
        getAttributes();
        getVariants();

        $("#form").fadeIn();

        $("#ItemSelect").change(function () {
            var el = $(this);
            var heading = window.Resources.Titles.ItemVariants();
            heading += " : " + el.getSelectedText();

            $("#heading").html(heading);
        });
    });

    $("#ItemSelect").change(function () {
        function request(itemId) {
            var url = "/api/core/item/get-where/-1";
            var filters = [];
            filters.push(getAjaxColumnFilter("WHERE", "is_variant_of", window.FilterConditions.IsEqualTo, itemId));
            var data = JSON.stringify(filters);

            return getAjaxRequest(url, "POST", data);
        };

        var itemId = $(this).val();
        var target = $("#VariantSelect");
        target.dropdown("set selected", "");
        target.html("");

        if (!itemId) {
            return;
        };

        var ajax = request(itemId);

        ajax.success(function (response) {
            var placeholder = response.length ? window.Resources.Titles.Select() : window.Resources.Titles.None();
            appendItem(target, "", placeholder);

            $.each(response, function () {
                var key = this["ItemId"];
                var value = this["ItemCode"] + " (" + this["ItemName"] + ")";
                appendItem(target, key, value);
            });
        });
    });

    function addRow(attributeId, variantId) {
        function getAttributes() {
            var attributeOptions = "<option val=''>" + window.Resources.Titles.Select() + "</option>";

            $.each(attributes, function () {
                attributeOptions += "<option value='";
                attributeOptions += this.AttributeId;
                attributeOptions += "'";

                if (this.AttributeId === attributeId) {
                    attributeOptions += " selected";
                };

                attributeOptions += ">";
                attributeOptions += this.AttributeCode;
                attributeOptions += " (";
                attributeOptions += this.AttributeName;
                attributeOptions += ")";
                attributeOptions += "</option>";
            });
            return attributeOptions;
        };

        function appendVariants(target, attributeId, variantId) {
            target.dropdown("set selected", "");
            target.html("");

            var filtered = Enumerable.From(variants).Where(function (x) { return x.AttributeId.toString() === attributeId.toString() }).ToArray();

            appendItem(target, "", window.Resources.Titles.Select());

            $.each(filtered, function () {
                appendItem(target, this.VariantId, this.VariantName);
            });

            if (variantId) {
                setTimeout(function () {
                    target.dropdown("set selected", variantId);
                }, 1);
            };
        };

        var row = $(rowTemplate.replace("{attributes}", getAttributes()));

        $("#variant-table tbody").append(row);
        initalizeDropdowns();

        row.find(".attribute select").change(function () {
            var el = $(this);
            var target = row.find(".variant select");
            var val = el.val();

            appendVariants(target, val);
        });

        if (variantId) {
            var target = row.find(".variant select");
            setTimeout(function() {
                appendVariants(target, attributeId, variantId);
            }, 1);           
        };

        $("input.delete.button").unbind().click(function () {
            var confirmed = confirmAction();
            if (confirmed) {
                $(this).closest("tr").remove();
            };
        });
    };

    function showItem(variantItemId) {
        function request(itemId) {
            var url = "/api/core/item/" + itemId;
            return getAjaxRequest(url);
        };

        var ajax = request(variantItemId);
        ajax.success(function(response) {
            $("#ItemCodeInputText").val(response.ItemCode);
            $("#ItemNameInputText").val(response.ItemName);
        });
    };

    function cleanUp() {
        $("#variant-table tbody").html("");
        $("#ItemCodeInputText").val("");
        $("#ItemNameInputText").val("");
    };

    $("#ShowButton").click(function () {
        function request(variantItemId) {
            var url = "/api/core/item-variant/get-where/-1";
            var filters = [];
            filters.push(getAjaxColumnFilter("WHERE", "item_id", window.FilterConditions.IsEqualTo, variantItemId));
            var data = JSON.stringify(filters);

            return getAjaxRequest(url, "POST", data);
        };

        cleanUp();

        var variantItemId = $("#VariantSelect").val();
        if (!variantItemId) {
            return;
        };

        showItem(variantItemId);
        var ajax = request(variantItemId);

        ajax.success(function (response) {
            $.each(response, function () {
                var variantId = this.VariantId;
                var attributeId = Enumerable.From(variants).Where(function (x) { return x.VariantId === variantId }).FirstOrDefault().AttributeId;
                addRow(attributeId, variantId);
            });
        });
    });

    $("#SaveButton").click(function () {
        function request(annotation) {
            var url = "/api/core/procedures/create-item-variant/execute";
            var data = JSON.stringify(annotation);
            return getAjaxRequest(url, "POST", data);
        };

        function getDuplicates(items) {
            var unique = [];

            for (var i = 0, len = items.length; i < len; i++) {
                var item = items[i];

                if (unique.indexOf(item) > -1) {
                    return item;
                };

                unique.push(item);
            }

            return null;
        };


        var attributeIds = $(".attribute select").map(function () { return $(this).val(); }).get();
        var variantIds = $(".variant select").map(function () { return $(this).val(); }).get();
        var duplicate = getDuplicates(attributeIds);

        if (duplicate) {
            var item = Enumerable.From(attributes).Where(function (x) { return x.AttributeId.toString() === duplicate }).FirstOrDefault().AttributeName;
            displayMessage(stringFormat(window.Resources.Warnings.CannotCreateVariantHavingMultipleAttributes(), item));
            return;
        };

        var annotation = new Object();

        annotation.VariantOf = $("#ItemSelect").val();
        annotation.ItemId = $("#VariantSelect").val() || null;
        annotation.ItemCode = $("#ItemCodeInputText").val();
        annotation.ItemName = $("#ItemNameInputText").val();
        annotation.VariantIds = variantIds;
        annotation.UserId = window.userId;

        var ajax = request(annotation);

        ajax.success(function () {
            displaySuccess();
        });
    });

    $("#DeleteButton").click(function () {
        function request(itemId) {
            var url = "/api/core/procedures/delete-variant-item/execute";
            var annotation = { ItemId: itemId };
            var data = JSON.stringify(annotation);

            return getAjaxRequest(url, "POST", data);
        };

        var variantItemId = $("#VariantSelect").val();

        if (variantItemId) {
            var ajax = request(variantItemId);

            ajax.success(function() {
                cleanUp();
                $("#ItemSelect").trigger("change");
            });
        };
    });

</script>
