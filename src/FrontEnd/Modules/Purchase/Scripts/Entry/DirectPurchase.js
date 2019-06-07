/*jshint -W032*/
/*global getAjax, getAjaxErrorMessage, logError, saveButton, url:true, validateProductControl, errorLabelBottom, appendParameter, getData, valueDate, storeId, partyCode, referenceNumber, data, statementReference, cashRepositoryId, costCenterId, attachments, transactionType*/

if (typeof (saveButton) === "undefined") {
    saveButton = $("#SaveButton");
};


saveButton.click(function () {
    if (validateProductControl()) {
        save();
    };
});

var save = function () {
    saveButton.addClass("loading");
    var ajaxSaveDirectPurchase = saveDirectPurchase(valueDate, storeId, partyCode, referenceNumber, data, statementReference, transactionType, costCenterId, attachments);

    ajaxSaveDirectPurchase.done(function (response) {
        var id = response.d;
        window.location = "/Modules/Purchase/Confirmation/DirectPurchase.mix?TranId=" + id;
    });

    ajaxSaveDirectPurchase.fail(function (xhr) {
        saveButton.removeClass("loading");
        var errorMessage = getAjaxErrorMessage(xhr);
        errorLabelBottom.html(errorMessage);
        logError(errorMessage);
    });
};

var saveDirectPurchase = function (valueDate, storeId, partyCode, referenceNumber, data, statementReference, transactionType, costCenterId, attachments) {
    var d = "";
    d = appendParameter(d, "valueDate", valueDate);
    d = appendParameter(d, "storeId", storeId);
    d = appendParameter(d, "partyCode", partyCode);
    d = appendParameter(d, "referenceNumber", referenceNumber);
    d = appendParameter(d, "data", data);
    d = appendParameter(d, "statementReference", statementReference);
    d = appendParameter(d, "transactionType", transactionType);
    d = appendParameter(d, "costCenterId", costCenterId);
    d = appendParameter(d, "attachmentsJSON", attachments);

    d = getData(d);

    url = "/Modules/Purchase/Services/Entry/DirectPurchase.asmx/Save";
    return getAjax(url, d);
};