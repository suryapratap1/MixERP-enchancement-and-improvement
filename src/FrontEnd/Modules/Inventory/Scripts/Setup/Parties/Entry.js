var partyIdInputText = $("#PartyIdInputText");
var partyCodeInputText = $("#PartyCodeInputText");
var partyTypeSelect = $("#PartyTypeSelect");

var firstNameInputText = $("#FirstNameInputText");
var middleNameInputText = $("#MiddleNameInputText");
var lastNameInputText = $("#LastNameInputText");
var partyNameInputText = $("#PartyNameInputText");
var companyNameInputText = $("#CompanyNameInputText");

var dateOfBirthInputText = $("#DateOfBirthInputText");
var entitySelect = $("#EntitySelect");
var industrySelect = $("#IndustrySelect");
var countrySelect = $("#CountrySelect");
var stateSelect = $("#StateSelect");

var zipCodeInputText = $("#ZipCodeInputText");
var addressLine1InputText = $("#AddressLine1InputText");
var addressLine2InputText = $("#AddressLine2InputText");
var streetInputText = $("#StreetInputText");
var cityInputText = $("#CityInputText");
var phoneInputText = $("#PhoneInputText");
var faxInputText = $("#FaxInputText");
var cellInputText = $("#CellInputText");
var emailInputText = $("#EmailInputText");
var urlInputText = $("#UrlInputText");
var panNumberInputText = $("#PanInputText");
var SSTNumberInputText = $("#SSTNumberInputText");
var CSTNumberInputText = $("#CSTNumberInputText");

var currencySelect = $("#CurrencyCodeSelect");

var creditDiv = $(".allowcredit");
var allowCreditCheckbox = $("#AllowCreditCheckbox");
var maximumCreditPeriodInputText = $("#MaximumCreditPeriodInputText");
var maximumCreditAmountInputText = $("#MaximumCreditAmountInputText");

var partyTypeSelectIcon = $("#PartyTypeSelectIcon");
var entitySelectIcon = $("#EntitySelectIcon");
var industrySelectIcon = $("#IndustrySelectIcon");
var countrySelectIcon = $("#CountrySelectIcon");
var stateSelectIcon = $("#StateSelectIcon");
var currencyCodeSelectIcon = $("#CurrencyCodeSelectIcon");
var partyAccountIdHiddenField = $("#PartyAccountIdHiddenField");
var photoInputText = $("#PhotoInputText");
var saveButton = $("#SaveButton");

var partyId;
var party;
var loaded = false;

$(document).ready(function () {
    initializeAjaxData();
    checkAllowCredit();
});

function checkAllowCredit() {
    if ($(allowCreditCheckbox).is(":checked")) {
        $(creditDiv).attr("style", "display:block");
    } else {
        $(creditDiv).attr("style", "display:none");
    }
};

$(allowCreditCheckbox).change(function () {
    checkAllowCredit();
});

$(document).ajaxStop(function () {
    $("#FormPanel").fadeIn(500);
    if (!loaded) {
        showParty();

        var select = $("select");

        select.each(function() {
            var el = $(this);
            var selectedValue = el.attr("data-value");

            el.addClass("search").dropdown("refresh");

            if (selectedValue) {
                setTimeout(function() {
                    el.dropdown("set selected", selectedValue);
                }, 100);
            };
        });

    };

    if (!window.uploaderInitialized) {
        initializeUploader();
    };

});


function getParty() {
    partyId = parseFloat(getQueryStringByName("PartyId") || 0);
    if (partyId <= 0) {
        return;
    };

    var ajaxGetPartyData = getPartyData(partyId);

    ajaxGetPartyData.success(function (msg) {
        party = msg.d;
    });

    ajaxGetPartyData.error(function (xhr) {
        var err = $.parseJSON(xhr.responseText);
        logError(err, "error");
    });
};

var getPartyData = function (partyId) {
    url = "/Modules/Inventory/Services/PartyData.asmx/GetPartyData";
    data = appendParameter("", "partyId", partyId);
    data = getData(data);

    return getAjax(url, data);
};

function showParty() {
    if (!party) {
        loaded = true;
        return;
    };


    partyIdInputText.val(party.PartyId);
    partyCodeInputText.val(party.PartyCode);
    partyTypeSelect.val(party.PartyTypeId);
    firstNameInputText.val(party.FirstName);
    middleNameInputText.val(party.MiddleName);
    lastNameInputText.val(party.LastName);
    partyNameInputText.val(party.PartyName);
    companyNameInputText.val(party.CompanyName);

    var dateOfBirth = convertDate(party.DateOfBirth);
    dateOfBirth = $.datepicker.formatDate(datepickerFormat, dateOfBirth);

    dateOfBirthInputText.val(dateOfBirth);
    entitySelect.val(party.EntityId);
    industrySelect.val(party.IndustryId);
    countrySelect.val(party.CountryId);
    stateSelect.attr("data-value", party.StateId);
    zipCodeInputText.val(party.ZipCode);
    addressLine1InputText.val(party.AddressLine1);
    addressLine2InputText.val(party.AddressLine2);
    streetInputText.val(party.Street);
    cityInputText.val(party.City);
    phoneInputText.val(party.Phone);
    faxInputText.val(party.Fax);
    cellInputText.val(party.Cell);
    emailInputText.val(party.Email);
    urlInputText.val(party.Url);
    panNumberInputText.val(party.PanNumber);
    SSTNumberInputText.val(party.SstNumber);
    CSTNumberInputText.val(party.CstNumber);
    currencySelect.val(party.CurrencyCode);
    photoInputText.val(party.Photo);

    if (party.AllowCredit) {
        allowCreditCheckbox.prop("checked", "checked");
    } else {
        allowCreditCheckbox.removeProp("checked");
    };

    maximumCreditPeriodInputText.val(party.MaximumCreditPeriod);
    maximumCreditAmountInputText.val(party.MaximumCreditAmount);
    partyAccountIdHiddenField.val(party.AccountId);
    loaded = true;
};


var isValid = function () {
    var required = $("[required]");
    var bigError = $(".big.error");
    var isValid = true;

    removeDirty(required);

    required.each(function () {
        var el = $(this);
        var val = el.val();

        //False positive
        // ReSharper disable once CoercedEqualsUsing
        if (el.is("select") && val == "0") {
            isValid = false;
            makeDirty(el);
            return;
        };

        if (isNullOrWhiteSpace(val)) {
            isValid = false;
            makeDirty(el);
        };
    });

    if (!isValid) {
        bigError.removeClass("initially hidden");
    };

    return isValid;
};

function initializeAjaxData() {
    getParty();
    loadPartyTypes();
    loadEntities();
    loadIndustries();
    loadCountries();
    loadCurrencyCodes();
};

function ajaxDataBindCallBack(el) {
    $(el).find("option:first-child").val("0");
};

var getSelectedRadioValue = function (id) {
    return $("[id^=\"" + id + "\"]:checked").val();
};

function loadPartyTypes() {
    if (partyTypeSelect.length) {
        url = "/Modules/Inventory/Services/PartyData.asmx/GetPartyTypes";
        ajaxDataBind(url, partyTypeSelect);
    };
}

function loadEntities() {
    if (entitySelect.length) {
        url = "/Modules/Inventory/Services/PartyData.asmx/GetEntities";
        ajaxDataBind(url, entitySelect);
    };
}

function loadIndustries() {
    if (industrySelect.length) {
        url = "/Modules/Inventory/Services/PartyData.asmx/GetIndustries";
        ajaxDataBind(url, industrySelect);
    };
}

function loadCountries() {
    if (countrySelect.length) {
        url = "/Modules/Inventory/Services/PartyData.asmx/GetCountries";
        ajaxDataBind(url, countrySelect);
    };
};

countrySelect.change(function () {
    loadStates();
});



function loadStates() {
    if (stateSelect.length) {
        stateSelect.html("");

        var countryId = parseInt(countrySelect.val() || 0);

        var selectedValue = stateSelect.attr("data-value");

        url = "/Modules/Inventory/Services/PartyData.asmx/GetStates";
        data = appendParameter("", "countryId", countryId);
        data = getData(data);
        ajaxDataBind(url, stateSelect, data, selectedValue, null);
    };
};


function loadCurrencyCodes() {
    if (currencySelect.length) {
        url = "/Modules/Inventory/Services/PartyData.asmx/GetCurrencyCodes";
        ajaxDataBind(url, currencySelect);
    };
};

companyNameInputText.on('blur', function () {
    partyNameInputText.val(lastNameInputText.val() + ", " + firstNameInputText.val());
});

saveButton.click(function () {
    if (!isValid()) {
        return;
    };

    saveButton.addClass("loading");



    var party = new Object();

    party.PartyId = partyId;
    party.PartyCode = partyCodeInputText.val();
    party.PartyTypeId = parseInt(partyTypeSelect.getSelectedValue());
    party.FirstName = firstNameInputText.val();
    party.MiddleName = middleNameInputText.val();
    party.LastName = lastNameInputText.val();
    party.PartyName = partyNameInputText.val();
    party.CompanyName = companyNameInputText.val();
    party.DateOfBirth = window.parseLocalizedDate(dateOfBirthInputText.val());
    party.EntityId = parseInt(entitySelect.getSelectedValue());
    party.IndustryId = parseInt(industrySelect.getSelectedValue());
    party.CountryId = parseInt(countrySelect.getSelectedValue());
    party.StateId = parseInt(stateSelect.getSelectedValue() || 0);

    if (party.EntityId === 0) {
        party.EntityId = "";
    };

    if (party.IndustryId === 0) {
        party.IndustryId = "";
    };
    if (party.CountryId === 0) {
        party.CountryId = "";
    };
    if (party.StateId === 0) {
        party.StateId = "";
    };

    party.ZipCode = zipCodeInputText.val();
    party.AddressLine1 = addressLine1InputText.val();
    party.AddressLine2 = addressLine2InputText.val();
    party.Street = streetInputText.val();
    party.City = cityInputText.val();
    party.Phone = phoneInputText.val();
    party.Fax = faxInputText.val();
    party.Cell = cellInputText.val();
    party.Email = emailInputText.val();
    party.Url = urlInputText.val();
    party.PanNumber = panNumberInputText.val();
    party.SstNumber = SSTNumberInputText.val();
    party.CstNumber = CSTNumberInputText.val();
    party.CurrencyCode = currencySelect.getSelectedValue();
    party.AllowCredit = allowCreditCheckbox.is(":checked");;
    party.MaximumCreditPeriod = parseInt2(maximumCreditPeriodInputText.val());
    party.MaximumCreditAmount = parseFloat2(maximumCreditAmountInputText.val());
    party.PartyAccountId = parseFloat(partyAccountIdHiddenField.val());
    party.AccountId = parseFloat(partyAccountIdHiddenField.val());
    party.Photo = photoInputText.val();

    var ajaxsaveParty = saveOrUpdate(party);

    ajaxsaveParty.done(function (response) {
        var id = response.d;
        if (id > 0) {
            window.location = "/Modules/Inventory/Setup/Parties.mix";
        };

    });

    ajaxsaveParty.fail(function (jqXHR) {
        saveButton.removeClass("loading");
        var errorMessage = getAjaxErrorMessage(jqXHR);
        logError(errorMessage);
    });
});

var saveOrUpdate = function (party) {
    var data = appendParameter("", "party", party);
    data = getData(data);

    url = "/Modules/Inventory/Services/PartyData.asmx/SaveOrUpdate";
    return getAjax(url, data);
};


$(document).ready(function () {
    loadDatepicker();
});
