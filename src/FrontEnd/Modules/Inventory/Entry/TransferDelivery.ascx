<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TransferDelivery.ascx.cs" Inherits="MixERP.Net.Core.Modules.Inventory.Entry.TransferDelivery"
    OverridePath="/Modules/Inventory/TransferDelivery.mix"
     %>
<asp:PlaceHolder runat="server" ID="Placeholder1"></asp:PlaceHolder>
<script type="text/javascript">
    var semanticGrid = $("#TransferGridView");

    $(document).ready(function() {
        semanticGrid.addClass("loading");
        var requestId = parseFloat(getQueryStringByName("RequestId") || 0);

        if (!requestId) {
            return;
        };


        var ajaxGetModel = GetModel(requestId);

        ajaxGetModel.success(function (msg) {
            loadModel(msg.d);
        });

        ajaxGetModel.fail(function (xhr) {
            logAjaxErrorMessage(xhr);
        });

    });

    function loadModel(models) {

        for (i = 0; i < models.length; i++) {
            var storeName = models[i].StoreName;
            var itemCode = models[i].ItemCode;
            var itemName = models[i].ItemName;
            var unitName = models[i].UnitName;
            var quantity = models[i].Quantity;

            appendToTable("Cr", storeName, itemCode, itemName, unitName, quantity);
        };

        semanticGrid.removeClass("loading");
    };

    function GetModel(requestId) {
        url = "/Modules/Inventory/Services/Entry/TransferDelivery.asmx/GetModel";

        data = appendParameter("", "requestId", requestId);

        data = getData(data);
        return getAjax(url, data);
    };


    function StockAdjustmentFactory_FormvView_SaveButton_Callback() {
        var valueDate = window.parseLocalizedDate(valueDateTextBox.val());
        var referenceNumber = referenceNumberInputText.val();
        var statementReference = statementReferenceTextArea.val();
        var requestId = parseFloat(getQueryStringByName("RequestId") || 0);
        var sourceStoreId = parseFloat($("#SourceStoreSelect").val() || 0);
        var shipperId = parseFloat($("#ShippingCompanySelect").val() || 0);


        if (!requestId) {
            displayMessage(Resources.Warnings.InvalidRequestId(), "error");
            return;
        };

        if (!sourceStoreId) {
            displayMessage(Resources.Warnings.InvalidStore(), "error");
            makeDirty($("#SourceStoreSelect"));
            return;
        };

        if (!shipperId) {
            displayMessage(Resources.Warnings.InvalidShippingCompany(), "error");
            makeDirty($("#ShippingCompanySelect"));
            return;
        };


        var tableData = tableToJSON(transferGridView);

        var ajaxSaveDelivery = SaveDelivery(valueDate, referenceNumber, statementReference, requestId, sourceStoreId, shipperId, tableData);

        ajaxSaveDelivery.success(function (msg) {
            var id = msg.d;
            window.location = "/Modules/Inventory/Confirmation/TransferDelivery.mix?TranId=" + id;
        });

        ajaxSaveDelivery.fail(function (xhr) {
            logAjaxErrorMessage(xhr);
        });
    };

    function SaveDelivery(valueDate, referenceNumber, statementReference, requestId, sourceStoreId, shipperId, tableData) {

        url = "/Modules/Inventory/Services/Entry/TransferDelivery.asmx/Save";

        data = appendParameter("", "valueDate", valueDate);
        data = appendParameter(data, "referenceNumber", referenceNumber);
        data = appendParameter(data, "statementReference", statementReference);
        data = appendParameter(data, "requestId", requestId);
        data = appendParameter(data, "sourceStoreId", sourceStoreId);
        data = appendParameter(data, "shipperId", shipperId);
        data = appendParameter(data, "data", tableData);
        data = getData(data);
        return getAjax(url, data);
    };

</script>