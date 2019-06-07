var referenceNumberInputText = $("#ReferenceNumberInputText");
var costCenterSelect = $("#CostCenterSelect");
var pLAppropriationAccountSelect = $("#PLAppropriationAccountSelect");
var statementReferenceTextArea = $("#StatementReferenceTextArea");
var postPLAppropriationInputButton = $("#PostPLAppropriationInputButton");
var taxOfficeSelect = $("#TaxOfficeAccountSelect");
var taxExpenseSelect = $("#TaxExpenseSelect");
var profitBeforeTaxInputText = $("#ProfitBeforeTaxInputText");
var incomeTaxRateInputText = $("#IncomeTaxRateInputText");
var incomeTaxInputText = $("#IncomeTaxInputText");

var taxOfficeAccountSelect = $("#TaxOfficeAccountSelect");
var taxExpenseSelect = $("#TaxExpenseSelect ");
var taxCostCenterSelect = $("#TaxCostCenterSelect");
var taxReferenceNumberInputText = $("#TaxReferenceNumberInputText");
var taxStatementReferenceInputText = $("#TaxStatementReferenceInputText");
var postTaxButton = $("#PostTaxButton");

var plAppropriationPanel = $("#PLAppropriationPanel");
var incomeTaxPanel = $("#IncomeTaxPanel");
var fiscalYearPanel = $("#FiscalYearPanel");
var backupPanel = $("#BackupPanel");

var fiscalYearCodeInputText = $("#FiscalYearCodeInputText ");
var fiscalYearNameInputText = $("#FiscalYearNameInputText");
var createFiscalYearButton = $("#CreateFiscalYearButton");

var url;
var data;


function showIncomeTax() {
    fiscalYearPanel.addClass("initially hidden");
    plAppropriationPanel.addClass("initially hidden");
    backupPanel.addClass("initially hidden");
    incomeTaxPanel.removeClass("initially hidden");
};

function showPLAppropriation() {
    fiscalYearPanel.addClass("initially hidden");
    incomeTaxPanel.addClass("initially hidden");
    backupPanel.addClass("initially hidden");
    plAppropriationPanel.removeClass("initially hidden");
};

function showNewFiscalYear() {
    incomeTaxPanel.addClass("initially hidden");
    plAppropriationPanel.addClass("initially hidden");
    backupPanel.addClass("initially hidden");
    fiscalYearPanel.removeClass("initially hidden");
};

function showBackup() {
    incomeTaxPanel.addClass("initially hidden");
    plAppropriationPanel.addClass("initially hidden");
    fiscalYearPanel.addClass("initially hidden");
    backupPanel.removeClass("initially hidden").find("iframe").attr("src", "/Modules/BackOffice/Admin/DatabaseBackupFrame.mix");
};

function showEOD() {
    window.location = 'EOD.mix?EOYCompleted=true';
};

MixERPApp.controller("EOYController", function ($scope, $sce) {
    function getAppropriationData() {
        url = "/Modules/Finance/Services/DayOperation/EOY.asmx/GetAppropriationData";
        return getAjax(url);
    };

    var ajaxGetAppropriationData = getAppropriationData();

    ajaxGetAppropriationData.success(function (msg) {
        $scope.$apply(function () {
            $scope.items = msg.d;

            var dr = 0;
            var cr = 0;
            for (var i = 0; i < msg.d.length; i++) {
                dr += msg.d[i].Debit;
                cr += msg.d[i].Credit;
            };

            $scope.drTotal = dr;
            $scope.crTotal = cr;
            $scope.profit = dr - cr; //Because the sides are inverted.
        });
    });

    ajaxGetAppropriationData.fail(function (xhr) {
        logAjaxErrorMessage(xhr);
    });
});

$(document).ready(function () {
    loadCostCenter();
    loadPLAppropriationAccount();
    loadTaxOfficeAccount();
    loadTaxExpensesAccount();
    loadEoyProfitSummary();
    checkNewFiscalYearExistence();



    backupPanel.find("iframe").css("height", $(document).height() + "px");
});

function checkNewFiscalYearExistence() {
    var ajaxIsNewFiscalYearCreated = isNewFiscalYearCreated();

    ajaxIsNewFiscalYearCreated.success(function (msg) {
        if (msg.d) {
            fiscalYearPanel.find("input").attr("disabled", "disabled");
        };
    });

    ajaxIsNewFiscalYearCreated.fail(function (xhr) {
        logAjaxErrorMessage(xhr);
    });
};

function loadEoyProfitSummary() {
    var ajaxGetEoyProfitSummary = getEoyProfitSummary();

    ajaxGetEoyProfitSummary.success(function (msg) {
        var data = msg.d;

        profitBeforeTaxInputText.val(data.ProfitBeforeTax);
        incomeTaxRateInputText.val(data.TaxRate);
        incomeTaxInputText.val(data.Tax);

    });

    ajaxGetEoyProfitSummary.fail(function (xhr) {
        logAjaxErrorMessage(xhr);
    });
};


createFiscalYearButton.click(function () {

    if (isNullOrWhiteSpace(fiscalYearCodeInputText.val())) {
        makeDirty(fiscalYearCodeInputText);
        return;
    };

    removeDirty(fiscalYearCodeInputText);

    if (isNullOrWhiteSpace(fiscalYearNameInputText.val())) {
        makeDirty(fiscalYearNameInputText);
        return;
    };

    removeDirty(fiscalYearNameInputText);

    var ajaxCreateNewFiscalYear = createNewFiscalYear(fiscalYearCodeInputText.val(), fiscalYearNameInputText.val());

    ajaxCreateNewFiscalYear.success(function () {
        displayMessage(Resources.Labels.TaskCompletedSuccessfully(), "success");
        fiscalYearPanel.addClass("initially hidden");
    });

    ajaxCreateNewFiscalYear.fail(function (xhr) {
        logAjaxErrorMessage(xhr);
    });

});

function isNewFiscalYearCreated() {
    url = "/Modules/Finance/Services/DayOperation/EOY.asmx/IsNewFiscalYearCreated";

    return getAjax(url);
};

function createNewFiscalYear(fiscalYearCode, fiscalYearName) {
    url = "/Modules/Finance/Services/DayOperation/EOY.asmx/CreateNewFiscalYear";
    data = appendParameter("", "fiscalYearCode", fiscalYearCode);
    data = appendParameter(data, "fiscalYearName", fiscalYearName);
    data = getData(data);

    return getAjax(url, data);
};

postTaxButton.click(function () {
    if (isNullOrWhiteSpace(taxOfficeAccountSelect.val())) {
        makeDirty(taxOfficeAccountSelect);
        return;
    };

    removeDirty(taxOfficeAccountSelect);

    if (isNullOrWhiteSpace(taxExpenseSelect.val())) {
        makeDirty(taxExpenseSelect);
        return;
    };

    removeDirty(taxExpenseSelect);

    if (parseFloat(taxCostCenterSelect.val() || 0) === 0) {
        makeDirty(taxCostCenterSelect);
        return;
    };

    removeDirty(taxCostCenterSelect);

    var ajaxPostIncomeTax = postIncomeTax
    (
        taxOfficeAccountSelect.val(),
        taxExpenseSelect.val(),
        taxCostCenterSelect.val(),
        taxReferenceNumberInputText.val(),
        taxStatementReferenceInputText.val()
    );


    ajaxPostIncomeTax.success(function () {
        window.location = "/Modules/Finance/VoucherVerification.mix";
    });

    ajaxPostIncomeTax.fail(function (xhr) {
        logAjaxErrorMessage(xhr);
    });
});

function postIncomeTax(taxOfficeAccountNumber, taxExpensesAccountNumber, costCenterId, referenceNumber, statementReference) {
    url = "/Modules/Finance/Services/DayOperation/EOY.asmx/PostIncomeTax";
    data = appendParameter("", "taxOfficeAccountNumber", taxOfficeAccountNumber);
    data = appendParameter(data, "taxExpensesAccountNumber", taxExpensesAccountNumber);
    data = appendParameter(data, "costCenterId", costCenterId);
    data = appendParameter(data, "referenceNumber", referenceNumber);
    data = appendParameter(data, "statementReference", statementReference);

    data = getData(data);

    return getAjax(url, data);
};


postPLAppropriationInputButton.click(function () {
    var referenceNumber = referenceNumberInputText.val();
    var costCenterId = parseInt(costCenterSelect.getSelectedValue() || 0);
    var accountNumber = pLAppropriationAccountSelect.getSelectedValue();
    var statementReference = statementReferenceTextArea.val();

    if (costCenterId === 0) {
        makeDirty(costCenterSelect);
        displayMessage(Resources.Warnings.InvalidCostCenter(), "error");
        return;
    };

    removeDirty(costCenterSelect);

    if (!accountNumber) {
        makeDirty(pLAppropriationAccountSelect);
        displayMessage(Resources.Warnings.InvalidAccount(), "error");
        return;
    };

    removeDirty(pLAppropriationAccountSelect);

    var ajaxPostPLAppropriation = postPLAppropriation(referenceNumber, costCenterId, accountNumber, statementReference);

    ajaxPostPLAppropriation.success(function () {
        window.location = "/Modules/Finance/VoucherVerification.mix";
    });

    ajaxPostPLAppropriation.fail(function (xhr) {
        logAjaxErrorMessage(xhr);
    });

});

function postPLAppropriation(referenceNumber, costCenterId, accountNumber, statementReference) {
    url = "/Modules/Finance/Services/DayOperation/EOY.asmx/PostPLAppropriation";
    data = appendParameter("", "referenceNumber", referenceNumber);
    data = appendParameter(data, "costCenterId", costCenterId);
    data = appendParameter(data, "accountNumber", accountNumber);
    data = appendParameter(data, "statementReference", statementReference);

    data = getData(data);

    return getAjax(url, data);
};

function getEoyProfitSummary() {
    url = "/Modules/Finance/Services/DayOperation/EOY.asmx/GetEoyProfitSummary";
    return getAjax(url);
};

function loadCostCenter() {
    var costCenters = [];
    costCenters.push(costCenterSelect, taxCostCenterSelect);

    url = "/Modules/Finance/Services/AccountData.asmx/GetCostCenters";
    ajaxDataBind(url, $(costCenters));
};


function loadPLAppropriationAccount() {
    url = "/Modules/Finance/Services/DayOperation/EOY.asmx/GetPLAppropriationAccounts";
    ajaxDataBind(url, pLAppropriationAccountSelect);
};

function loadPLAppropriationAccount() {
    url = "/Modules/Finance/Services/DayOperation/EOY.asmx/GetPLAppropriationAccounts";
    ajaxDataBind(url, pLAppropriationAccountSelect);
};

function loadTaxOfficeAccount() {
    url = "/Modules/Finance/Services/DayOperation/EOY.asmx/GetLiabilityAccounts";
    ajaxDataBind(url, taxOfficeSelect);
};

function loadTaxExpensesAccount() {
    url = "/Modules/Finance/Services/DayOperation/EOY.asmx/GetIncomeTaxExpenseAccounts";
    ajaxDataBind(url, taxExpenseSelect);
};