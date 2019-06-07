<%@ Control 
    Language="C#" 
    AutoEventWireup="true" 
    CodeBehind="TransferRequest.ascx.cs" 
    Inherits="MixERP.Net.Core.Modules.Inventory.Entry.TransferRequest"
    OverridePath="/Modules/Inventory/TransferRequest.mix"
     %>
<asp:PlaceHolder runat="server" ID="Placeholder1"></asp:PlaceHolder>
<input type="hidden" id="ItemIdHidden" />

<script type="text/javascript">
    function StockAdjustmentFactory_FormvView_SaveButton_Callback() {
        var valueDate = window.parseLocalizedDate(valueDateTextBox.val());
        var referenceNumber = referenceNumberInputText.val();
        var statementReference = statementReferenceTextArea.val();
        var tableData = tableToJSON(transferGridView);

        var ajaxSaveTransfer = SaveTransfer(valueDate, referenceNumber, statementReference, tableData);

        ajaxSaveTransfer.success(function (msg) {
            var id = msg.d;
            window.location = "/Modules/Inventory/Confirmation/TransferRequest.mix?TranId=" + id;
        });

        ajaxSaveTransfer.fail(function (xhr) {
            logAjaxErrorMessage(xhr);
        });
    };

    function SaveTransfer(valueDate, referenceNumber, statementReference, tableData) {

        url = "/Modules/Inventory/Services/Entry/TransferRequest.asmx/Save";

        data = appendParameter("", "valueDate", valueDate);
        data = appendParameter(data, "referenceNumber", referenceNumber);
        data = appendParameter(data, "statementReference", statementReference);
        data = appendParameter(data, "data", tableData);
        data = getData(data);
        return getAjax(url, data);
    };
</script>