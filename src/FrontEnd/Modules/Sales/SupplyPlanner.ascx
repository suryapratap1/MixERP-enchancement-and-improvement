<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SupplyPlanner.ascx.cs" OverridePath="/Modules/Sales/Order.mix" Inherits="MixERP.Net.Core.Modules.Sales.SupplyPlanner" %>
<h1>Supply Planner</h1>
<div class="ui positive message">
    The supply planner feature enables you to plan and verify 
    if there are enough inventory items to deliver against this Sales Order.    
</div>
<div class="ui form">
    <table class="ui supply planner attached table">
        <thead>
            <tr>
                <th>Item Id</th>
                <th>Item Name</th>
                <th>Quantity</th>
                <th>Unit Name</th>
                <th style="width: 120px;">Available</th>
                <th style="width: 120px;">Adjusted</th>
                <th style="width: 200px;">Price</th>
                <th style="width: 200px;">Discount</th>
                <th>Shipping Charge</th>
                <th>Tax</th>
            </tr>
        </thead>
        <tbody>
        </tbody>
    </table>
</div>
<div class="vpad8"></div>
<div class="ui form attached segment" style="width: 500px;">
    <div class="field">
        <label>Select Store</label>
        <select class="ui dropdown" id="StoreIdSelect"></select>
    </div>
    <div class="field">
        <label>Party Name</label>
        <input type="text" id="PartyInputText" readonly />
    </div>
    <div class="two fields">
        <div class="field">
            <label>Price Type</label>
            <input type="text" id="PriceTypeInputText" readonly />
        </div>
        <div class="field">
            <label>Entered By</label>
            <input type="text" id="UserNameInputText" readonly />
        </div>
    </div>
    <div class="two fields">
        <div class="field">
            <label>Ref #</label>
            <input type="text" id="ReferenceNumberInputText" readonly />
        </div>
        <div class="field">
            <label>Salesperson</label>
            <input type="text" id="SalespersonInputText" readonly />
        </div>
    </div>
        <div class="field">
            <label>Statement Reference</label>
            <textarea id="StatementReferenceTextArea" rows="2"></textarea>
        </div>
    <input type="button" id="ValidateButton" class="ui green button" value="Validate" />
    <input type="button" id="DirectSalesButton" class="ui button" value="Proceed to Direct Sales" />
</div>

<script>
    (function () {
        window.ajaxDataBind("/api/office/store/display-fields", $("#StoreIdSelect"), null, null, null, null, "Key", "Value");


        function displayInfo() {
            function request(orderId) {
                const url = "/Modules/Sales/Services/Order.asmx/GetSupplyPlannerView";

                var data = "";
                data = appendParameter(data, "orderId", orderId);
                data = getData(data);

                return getAjax(url, data);
            };

            function getAdjustmentCell(model, key, cssClass) {
                const cell = $("<td />");
                const input = $("<input type='text' />");

                input.off("change, blur").on("change, blur", function () {
                    const el = $(this);
                    const adjusted = parseInt(el.val());
                    const row = el.closest("tr");

                    const available = parseInt(row.find("td:nth-child(5)").attr("data-available-quantity"));

                    if (adjusted === 0) {
                        row.remove();
                        return;
                    } else if (adjusted < 0) {
                        return;
                    };

                    if (adjusted <= available) {
                        row.removeClass("error");
                    } else {
                        row.addClass("error");
                    };
                });

                if (cssClass) {
                    input.addClass(cssClass);
                };

                if (model && key) {
                    const value = model[key];
                    input.val(value);
                };

                cell.append(input);

                return cell;
            };

            function getCell(model, key, cssClass) {
                const cell = $("<td />");

                if (model && key) {
                    const value = model[key];
                    cell.text(value);
                };

                if (cssClass) {
                    cell.addClass(cssClass);
                };

                return cell;
            };

            function displayRow(table, model) {
                const row = $("<tr />");
                row.append(getCell(model, "item_id"));
                row.append(getCell(model, "item_name"));
                row.append(getCell(model, "quantity"));
                row.append(getCell(model, "unit_name"));
                row.append(getCell(null, null, "available"));
                row.append(getAdjustmentCell(null, null, "integer adjustment"));
                row.append(getCell(model, "price", "price decimal"));
                row.append(getCell(model, "discount", "discount decimal"));
                row.append(getCell(model, "shipping_charge"));
                row.append(getCell(model, "tax"));

                row.attr("data-item-id", model.item_id);
                row.attr("data-meta", JSON.stringify(model));
                table.append(row);
            };

            function displayTable(model) {
                const table = $("table.supply.planner");
                table.find("tbody").html("");

                for (var i = 0; i < model.length; i++) {
                    displayRow(table, model[i]);
                };

                window.setNumberFormat();
            };

            function displayDetails(model) {
                setTimeout(function() {
                    $("#StoreIdSelect").dropdown("set selected", model.store_id.toString());
                    $("#PartyInputText").val(model.party_name);
                    $("#PartyInputText").attr("data-party-id", model.party_id);
                    $("#PartyInputText").attr("data-party-code", model.party_code);
                    $("#PriceTypeInputText").val(model.price_type_name);
                    $("#PriceTypeInputText").attr("data-price-type-id", model.price_type_id);
                    $("#UserNameInputText").val(model.user_name);
                    $("#ReferenceNumberInputText").val(model.reference_number);
                    $("#StatementReferenceTextArea").val(model.statement_reference);
                    $("#SalespersonInputText").val(model.salesperson_name);
                }, 500);
            };

            const id = window.getQueryStringByName("OrderId");

            if (!id) {
                return;
            };
            const ajax = request(id);

            ajax.success(function (response) {
                const model = JSON.parse(response.d);
                displayTable(model);
                displayDetails(model[0]);
            });

            ajax.fail(function (xhr) {
                displayMessage(getAjaxErrorMessage(xhr));
            });
        };

        displayInfo();

        function validateItem(row, actual) {
            const expected = JSON.parse(row.attr("data-meta"));
            row.find("td:nth-child(5)").text((actual.Quantity || 0) + " " + actual.UnitName);
            row.find("td:nth-child(5)").attr("data-available-quantity", actual.Quantity);
            const requested = parseInt(row.find("td:nth-child(3)").text().trim());
            var quantity = requested;

            if (requested > actual.Quantity) {
                quantity = actual.Quantity;
                row.addClass("error");
            } else {
                row.removeClass("error");
            };

            row.find("td:nth-child(6) input").val(quantity);
        };

        function validateItems(model) {
            $("table.supply.planner tr td:nth-child(5)").html("");
            $("table.supply.planner tr td").removeAttr("data-available-quantity");
            $("table.supply.planner tr").addClass("error");

            for (var i = 0; i < model.length; i++) {
                const item = model[i];
                const itemId = item.ItemId;
                const row = $("tr[data-item-id='" + itemId + "']");

                validateItem(row, item);
            };
        };

        $("#ValidateButton").off("click").on("click", function () {
            function request(storeId, itemIds) {
                const url = "/Modules/Sales/Services/Order.asmx/ListStock";

                var data = "";
                data = appendParameter(data, "storeId", storeId);
                data = appendParameter(data, "itemIds", itemIds);
                data = getData(data);

                return getAjax(url, data);
            };

            const storeId = $("#StoreIdSelect").val();

            if (!storeId) {
                window.displayMessage("Please select a store!");
                return;
            };

            const ids = $("table.supply.planner tbody tr td:first-child").map(function () {
                return $(this).text().trim();
            }).get();

            const ajax = request(storeId, ids);

            ajax.success(function (response) {
                const model = JSON.parse(response.d);
                validateItems(model);
            });

            ajax.fail(function (xhr) {
                displayMessage(getAjaxErrorMessage(xhr));
            });
        });

        function getRowModel(row) {
            const partyId = parseInt($("#PartyInputText").attr("data-party-id"));
            const partyCode = $("#PartyInputText").attr("data-party-code");
            const priceTypeId = parseInt($("#PriceTypeInputText").attr("data-price-type-id"));
            const referenceNumber = $("#ReferenceNumberInputText").val();
            const statementReference = $("StatementReferenceTextArea").val();
            const storeId = parseInt($("#StoreSelect").val());
            const rowdata = JSON.parse(row.attr("data-meta"));

            const unitName = rowdata.unit_name;
            const adjustedQuantity = parseInt(row.find("input.adjustment").val());



            return {
                PartyId: partyId,
                PartyCode: partyCode,
                PriceTypeId: priceTypeId,
                ReferenceNumber: referenceNumber,
                StatementReference: statementReference,
                NonTaxable: rowdata.non_taxable,
                SalespersonId: rowdata.salesperson_id,
                ShipperId: rowdata.shipper_id,
                StoreId: storeId,
                ItemCode: rowdata.item_code,
                ItemName: rowdata.item_name,
                Quantity: adjustedQuantity,
                UnitName: unitName,
                Price: rowdata.price,
                ShippingCharge: rowdata.shipping_charge,
                ShippingAddresssCode: rowdata.shipping_address_code,
                TaxCode: rowdata.tax_code,
                Tax: rowdata.tax,
                Discount: rowdata.discount,
                DisableEdit: true
            };
        };

        function getModel(tbody) {
            const candidates = tbody.find("tr");
            const model = [];

            $.each(candidates, function() {
                const row = $(this);
                const item = getRowModel(row);
                model.push(item);
            });

            return model;
        };

        $("#DirectSalesButton").off("click").on("click", function() {
            $("input.integer.adjustment").trigger("blur");

            const errors = $("table.supply.planner tbody tr.error").length;
            if (errors) {
                return;
            };

            const tbody = $("table.supply.planner tbody");
            const model = getModel(tbody);

            const id = window.getQueryStringByName("OrderId");
            window.localStorage.setItem('MergeModel', JSON.stringify(model));
            window.localStorage.setItem('TranIds', id);

            window.location.href = "/Modules/Sales/Entry/DirectSales.mix";
        });
    })();


</script>
