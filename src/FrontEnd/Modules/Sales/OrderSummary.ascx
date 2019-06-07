<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OrderSummary.ascx.cs" OverridePath="/Modules/Sales/Order.mix" Inherits="MixERP.Net.Core.Modules.Sales.OrderSummary" %>
<h1>Sales Order Summary</h1>
<div class="ui form attached segment">
    <div class="inline fields">
        <div class="field">
            <label>Select Party</label>
            <select id="PartySelect" style="width: 300px;"></select>
        </div>
        <input type="button" class="ui positive button" id="ShowButton" value="Show" />
    </div>
</div>

<table class="ui attached order summary table">
    <thead>
        <tr>
            <th>SO#</th>
            <th>Order Date</th>
            <th>Tran#</th>
            <th>Sales#</th>
            <th>Delivered On</th>
            <th>Lead Time</th>
            <th>Items</th>
            <th>Ordered</th>
            <th>Delivered</th>
            <th>Remaining</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
    </tbody>
</table>

<div class="ui header">Details</div>
<table class="ui attached order info table">
    <thead>
        <tr>
            <th>#</th>
            <th>Item Id</th>
            <th>Item</th>
            <th>Unit</th>
            <th>Ordered</th>
            <th>Delivered</th>
            <th>Remaining</th>
        </tr>
    </thead>
    <tbody>
    </tbody>
</table>

<script>
    function getCell(model, key, cssClass, type) {
        const cell = $("<td />");

        if (model && key) {
            var value = model[key];

            if (!value) {
                return cell;
            };

            switch (type) {
                case "date":
                    value = moment(value).format("LL");
                    break;
                case "number":
                    value = window.getFormattedNumber(parseInt(value));
                    break;
            };

            cell.text(value || "");
        };

        if (cssClass) {
            cell.addClass(cssClass);
        };

        return cell;
    };

    function displaySummary() {
        function request(partyCode) {
            const url = "/Modules/Sales/Services/Order.asmx/GetOrderSummaryView";

            var data = "";
            data = appendParameter(data, "partyCode", partyCode);
            data = getData(data);

            return getAjax(url, data);
        };

        function getActionCell(model) {
            const cell = $("<td />");

            if (!model.sales_id || !model.sales_order_id) {
                return cell;
            };

            const anchor = $("<a class='ui label' href='javascript:void(0);'>Details</a>");
            cell.append(anchor);

            anchor.off("click").on("click", function () {
                anchor.closest("tbody").find("tr").removeClass("positive");
                anchor.closest("tr").addClass("positive");
                window.displaySummaryInfo(model.sales_order_id, model.sales_id);
            });

            return cell;
        };


        function displayRow(table, model) {
            const row = $("<tr />");
            row.append(getCell(model, "sales_order_id"));
            row.append(getCell(model, "order_date", "", "date"));
            row.append(getCell(model, "tran_id"));
            row.append(getCell(model, "sales_id"));
            row.append(getCell(model, "delivered_date", "", "date"));
            row.append(getCell(model, "lead_time"));
            row.append(getCell(model, "items"));
            row.append(getCell(model, "total_ordered", "", "number"));
            row.append(getCell(model, "delivered", "", "number"));
            row.append(getCell(model, "undelivered", "", "number"));
            row.append(getActionCell(model));

            table.append(row);
        };

        function displayTable(model) {
            const table = $("table.order.summary");
            table.find("tbody").html("");

            for (var i = 0; i < model.length; i++) {
                displayRow(table, model[i]);
            };

            window.setNumberFormat();
        };

        const partyCode = $("#PartySelect").val();
        if (!partyCode) {
            return;
        };

        const ajax = request(partyCode);

        ajax.success(function (response) {
            const model = JSON.parse(response.d);
            displayTable(model);
        });

        ajax.fail(function (xhr) {
            displayMessage(getAjaxErrorMessage(xhr));
        });
    };

    function displaySummaryInfo(salesOrderId, salesId) {
        function request(partyCode) {
            const url = "/Modules/Sales/Services/Order.asmx/GetOrderSummaryInfo";

            var data = "";
            data = appendParameter(data, "salesOrderId", salesOrderId);
            data = appendParameter(data, "salesId", salesId);
            data = getData(data);

            return getAjax(url, data);
        };

        function getActionCell(model) {
            const cell = $("<td />");
            const anchor = $("<a class='ui label' href='javascript:void(0);'>Details</a>");
            cell.append(anchor);
            return cell;
        };


        function displayRow(table, model) {
            const row = $("<tr />");
            row.append(getCell(model, "row_number"));
            row.append(getCell(model, "item_id"));
            row.append(getCell(model, "item_name"));
            row.append(getCell(model, "unit_name"));
            row.append(getCell(model, "ordered", "", "number"));
            row.append(getCell(model, "delivered", "", "number"));
            row.append(getCell(model, "remaining", "", "number"));

            table.append(row);
        };

        function displayTable(model) {
            const table = $("table.order.info");
            table.find("tbody").html("");

            for (var i = 0; i < model.length; i++) {
                displayRow(table, model[i]);
            };

            window.setNumberFormat();
        };

        const partyCode = $("#PartySelect").val();
        if (!partyCode) {
            return;
        };

        const ajax = request(partyCode);

        ajax.success(function (response) {
            const model = JSON.parse(response.d);
            displayTable(model);
        });

        ajax.fail(function (xhr) {
            displayMessage(getAjaxErrorMessage(xhr));
        });
    };

    $("#ShowButton").off("click").on("click", function() {
        displaySummary();
    });

    function loadParties(tranBook) {
        url = "/Modules/Inventory/Services/PartyData.asmx/GetParties";
        var data = appendParameter("", "book", tranBook);

        data = getData(data);
        ajaxDataBind(url, $("#PartySelect"), data, null);
    };


    loadParties("Sales");
</script>