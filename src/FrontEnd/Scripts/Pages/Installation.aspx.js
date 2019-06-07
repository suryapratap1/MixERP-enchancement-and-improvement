var isValid = true;
var officeNameInputText = $("#OfficeNameInputText");
var officeCodeInputText = $("#OfficeCodeInputText");
var nickNameInputText = $("#NickNameInputText");
var registrationDateInputText = $("#RegistrationDateInputText");
var currencyCodeInputText = $("#CurrencyCodeInputText");
var currencySymbolInputText = $("#CurrencySymbolInputText");
var currencyNameInputText = $("#CurrencyNameInputText");
var hundredthNameInputText = $("#HundredthNameInputText");
var fiscalYearCodeInputText = $("#FiscalYearCodeInputText");
var fiscalYearNameInputText = $("#FiscalYearNameInputText");
var startsFromInputText = $("#StartsFromInputText");
var endsOnInputText = $("#EndsOnInputText");
var quotationValidDaysInputText = $("#QuotationValidDaysInputText");
var incomeTaxRateInputText = $("#IncomeTaxRateInputText");
var weekStartDaySelect = $("#WeekStartDaySelect");
var transactionStartDateInputText = $("#TransactionStartDateInputText");
var inventoryAccountingSystemSelect = $("#InventoryAccountingSystemSelect");
var inventoryValuationMethodSelect = $("#InventoryValuationMethodSelect");
var adminNameInputText = $("#AdminNameInputText");
var usernameInputText = $("#UsernameInputText");
var passwordInputPassword = $("#PasswordInputPassword");
var confirmPasswordInputPassword = $("#ConfirmPasswordInputPassword");
var saveButton = $("#SaveButton");
var file = $("#file");
var logo = "";
var allowed = [".jpg", ".jpeg", ".bmp", ".gif", ".png"];
var regionalDataSelect = $("#RegionalDataSelect");


$(document).ready(function () {
    initializeUI();
    initializeRegionalDataList();

    var year = new Date().getYear() + 1900;

    fiscalYearCodeInputText.val("FY-" + year.toString().slice(-2));
    fiscalYearNameInputText.val("FY-" + year);
});


function initializeUI() {
    $(".ui.dropdown").dropdown();
    $('.activating.element').popup();
    $('.checkbox').checkbox();
};

var validateFields = function() {
    if (isNullOrWhiteSpace(officeNameInputText.val()) ||
        isNullOrWhiteSpace(officeCodeInputText.val()) ||
        isNullOrWhiteSpace(nickNameInputText.val()) ||
        isNullOrWhiteSpace(registrationDateInputText.val()) ||
        isNullOrWhiteSpace(currencyCodeInputText.val()) ||
        isNullOrWhiteSpace(currencySymbolInputText.val()) ||
        isNullOrWhiteSpace(currencyNameInputText.val()) ||
        isNullOrWhiteSpace(hundredthNameInputText.val()) ||
        isNullOrWhiteSpace(regionalDataSelect.val()) ||
        isNullOrWhiteSpace(fiscalYearCodeInputText.val()) ||
        isNullOrWhiteSpace(fiscalYearNameInputText.val()) ||
        isNullOrWhiteSpace(startsFromInputText.val()) ||
        isNullOrWhiteSpace(endsOnInputText.val()) ||
        isNullOrWhiteSpace(weekStartDaySelect.val()) ||
        isNullOrWhiteSpace(transactionStartDateInputText.val()) ||
        isNullOrWhiteSpace(adminNameInputText.val()) ||
        isNullOrWhiteSpace(usernameInputText.val()) ||
        isNullOrWhiteSpace(passwordInputPassword.val()) ||
        isNullOrWhiteSpace(confirmPasswordInputPassword.val())) {
        isValid = false;
        alert(allFieldsRequiredLocalized);
    } else {
        isValid = true;
    };

    if (isValid) {
        validatePassword();
    };
};

var validatePassword = function() {
    if (passwordInputPassword.val() !== confirmPasswordInputPassword.val()) {
        isValid = false;
        alert(confirmedPasswordDoesNotMatch);
    } else {
        isValid = true;
    };
};

saveButton.click(function() {

    validateFields();

    if (isValid) {
        $(".form").addClass("loading");
        $(".dimmer").dimmer("show");

        var salesTaxIsVat = $("input[name=salestax]:checked").val();
        var hasstateTax = $("input[name=statetax]:checked").val();
        var hascountyTax = $("input[name=countytax]:checked").val();

        var config = new Object();

        config.OfficeCode = officeCodeInputText.val();
        config.OfficeName =officeNameInputText.val();
        config.NickName =nickNameInputText.val();
        config.RegistrationDate =registrationDateInputText.val();
        config.CurrencyCode =currencyCodeInputText.val();
        config.CurrencySymbol =currencySymbolInputText.val();
        config.CurrencyName =currencyNameInputText.val();
        config.HundredthName =hundredthNameInputText.val();
        config.RegionalDataPath = regionalDataSelect.val();
        config.FiscalYearCode =fiscalYearCodeInputText.val();
        config.FiscalYearName =fiscalYearNameInputText.val();
        config.StartsFrom =startsFromInputText.val();
        config.EndsOn =endsOnInputText.val();
        config.SalesTaxIsVat =salesTaxIsVat;
        config.HasStateSalesTax =hasstateTax;
        config.HasCountySalesTax =hascountyTax;
        config.QuotationValidDays =parseInt(quotationValidDaysInputText.val() || 0);
        config.IncomeTaxRate =parseFloat(incomeTaxRateInputText.val() || 0);
        config.WeekStartDay =weekStartDaySelect.val();
        config.TransactionStartDate =transactionStartDateInputText.val();
        config.IsPerpetual =inventoryAccountingSystemSelect.getSelectedValue();
        config.ValuationMethod =inventoryValuationMethodSelect.getSelectedValue();
        config.Logo = logo;
        config.AdminName =adminNameInputText.val();
        config.Username =usernameInputText.val();
        config.Password =passwordInputPassword.val();
        config.ConfirmPassword = confirmPasswordInputPassword.val();


        var ajaxSaveOffice = saveOffice(config);

        ajaxSaveOffice.success(function(msg) {
            if (msg.d) {
                window.location = "/SignIn.aspx";
            } else {
                alert(msg.d);
            };
        });

        ajaxSaveOffice.error(function(xhr) {
            $(".form").removeClass("loading");
            $(".dimmer").dimmer("hide");
            alert(xhr.responseText);
        });
    };
});

function initializeRegionalDataList() {    
    var url = "/Services/Install.asmx/GetRegionalDataList";
    ajaxDataBind(url, regionalDataSelect, null, null, null, null, "FilePath", "Name");
    return;
};

function getSampleCompanies() {
    var url = "/Services/Install.asmx/GetSampleCompanies";
    return getAjax(url);
};

function saveOffice(config) {
    var url = "/Services/Install.asmx/SaveOffice";

    var data = appendParameter("", "config", config);
    data = getData(data);

    return getAjax(url, data);
};


function isValidExtension(el) {

    if (el.type === "file") {
        var fileName = el.value;

        if (fileName.length > 0) {

            var valid = false;

            for (var i = 0; i < allowed.length; i++) {
                var extension = allowed[i];

                if (fileName.substr(fileName.length - extension.length, extension.length).toLowerCase() === extension.toLowerCase()) {
                    valid = true;
                    break;
                };
            };

            if (!valid) {
                alert("Invalid file extension.");
                el.value = "";
                return false;
            };
        };
    };

    return true;
};



file.change(function () {
    if (isValidExtension(this)) {
        readURL(this);
        $('#logo').parent().addClass("loading");
        $(this).upload("/FileUploadHanlder.ashx", function (uploadedFileName) {
            logo = uploadedFileName;
            $('#logo').parent().removeClass("loading");
        }, function (progress, value) {
            //not implemented yet.
        });
    };
});

function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#logo').attr('src', e.target.result);
            $('#logo').attr('style', "max-height:160px;max-width:250;");
        };

        reader.readAsDataURL(input.files[0]);
    };
};



