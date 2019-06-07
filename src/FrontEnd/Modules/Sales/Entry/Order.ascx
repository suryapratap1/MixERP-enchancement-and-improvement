<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Order.ascx.cs" Inherits="MixERP.Net.Core.Modules.Sales.Entry.Order"
    OverridePath="/Modules/Sales/Order.mix" %>
<asp:PlaceHolder runat="server" ID="Placeholder1"></asp:PlaceHolder>
<script src="../Scripts/Entry/Order.js"></script>
<script>
    const button = $("<input type='button' class='ui basic button' value='Show Undelivered Products' />");
    $("#PartySelect").closest(".ui.form").append(button);

    button.off("click").on("click", function () {
        function request(partyCode, storeId) {
            var d = "";
            d = appendParameter(d, "partyCode", partyCode);
            d = appendParameter(d, "storeId", storeId);

            d = getData(d);
            url = "/Modules/Sales/Services/Entry/Order.asmx/GetUndeliveredProducts";

            return getAjax(url, d);
        };

        function displayRow(model) {
            addRowToTable(model.item_code, model.item_name, model.quantity, model.unit_name, model.price, 0, 0, model.sales_tax_code, model.tax);
        };

        const partyCode = $("#PartySelect").val();
        const storeId = parseInt($("#StoreSelect").val());

        if (!partyCode) {
            window.displayMessage("Please select a party first.");
            return;
        };

        if (!storeId) {
            window.displayMessage("Please select a store.");
            return;
        };

        $("#ProductGridView tbody tr:not(:last-child)").html("");
        const ajax = request(partyCode, storeId);

        ajax.success(function (response) {
            const model = JSON.parse(response.d);
            $.each(model, function() {
                displayRow(this);
            });
        });

        ajax.fail(function (xhr) {
            const errorMessage = window.getAjaxErrorMessage(xhr);
            window.logError(errorMessage);
        });
    });
</script>