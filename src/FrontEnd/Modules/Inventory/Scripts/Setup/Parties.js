
var url, data;
var partyTypeSelect = $("#PartyTypeSelect");
var searchInputText = $("#SearchInputText");
var currentPageAnchor = $("#CurrentPageAnchor");
var totalPagesAnchor = $("#TotalPagesAnchor");
var pageQueryStringKey = "Page";

var count = 0;
var filter, partyTypeId;

function getCurrentPage() {
    var current = parseInt(getQueryStringByName(pageQueryStringKey) || 0);

    if (!current) {
        current = 1;
    };

    return current;
};

function setCurrentPage(page) {
    if (!page) {
        page = getCurrentPage();
    };

    var url = updateQueryString(pageQueryStringKey, page);
    currentPageAnchor.text(page);
    window.history.pushState({ path: url }, '', url);
};

function loadPartyTypes(callback) {
    url = "/Modules/Inventory/Services/Setup/Parties.asmx/GetPartyTypes";

    ajaxDataBind(url, partyTypeSelect, null, null, null, callback, "PartyTypeId", "PartyTypeName");
};

function partyTypeSelectLoaded() {
    partyTypeSelect.find("option:first-child").val("0");
    partyTypeSelect.dropdown();
};

function getCount(filter, partyTypeId) {
    url = "/Modules/Inventory/Services/Setup/Parties.asmx/GetCount";
    data = appendParameter("", "filter", filter);
    data = appendParameter(data, "partyTypeId", partyTypeId);

    data = getData(data);

    return getAjax(url, data);
};

function deleteParty(partyId) {
    url = "/Modules/Inventory/Services/Setup/Parties.asmx/DeleteParty";
    data = appendParameter("", "filter", filter);
    data = appendParameter(data, "partyId", partyId);

    data = getData(data);

    return getAjax(url, data);
};


function getParties(filter, partyTypeId, page) {
    url = "/Modules/Inventory/Services/Setup/Parties.asmx/GetParties";
    data = appendParameter("", "filter", filter);
    data = appendParameter(data, "partyTypeId", partyTypeId);
    data = appendParameter(data, "page", page);

    data = getData(data);

    return getAjax(url, data);
};

$(document).ready(function () {
    loadPartyTypes(partyTypeSelectLoaded);
});

MixERPApp.controller("PartyController", function ($scope, $sce, $window) {
    setCurrentPage();

    $scope.loadCards = function () {
        $("#PartyController").addClass("loading");

        filter = searchInputText.val();
        partyTypeId = parseFloat(partyTypeSelect.getSelectedValue() || 0);

        var ajaxGetCount = getCount(filter, partyTypeId);

        ajaxGetCount.success(function (msg) {
            count = parseInt(msg.d || 1);
            totalPagesAnchor.text(count);
            var current = getCurrentPage();

            var ajaxGetParties = getParties(filter, partyTypeId, current);

            ajaxGetParties.success(function (msg) {
                $scope.$apply(function () {
                    $scope.parties = msg.d;
                    $("#PartyController").removeClass("loading");
                });
            });

            ajaxGetParties.fail(function (xhr) {
                $window.logAjaxErrorMessage(xhr);
                $("#PartyController").removeClass("loading");
            });
        });
    };

    $scope.search = function () {
        setCurrentPage("1");
        $scope.loadCards();
    };

    $scope.getCountryCode = function (countryName) {
        return $window._.find(countries, { countryName: countryName }).countryCode.toLowerCase();
    };

    $scope.delete = function (p) {
        if (confirmAction()) {
            var ajaxDeleteParty = deleteParty(p.PartyId);

            ajaxDeleteParty.success(function () {
                $scope.loadCards();
            });

            ajaxDeleteParty.fail(function (xhr) {
                $window.logAjaxErrorMessage(xhr);
            });
        };
    };

    $scope.showNext = function () {
        var nextPage = getCurrentPage() + 1;

        nextPage = Math.min(nextPage, count);

        setCurrentPage(nextPage);
        $scope.loadCards();
    };

    $scope.showPrevious = function () {
        var previousPage = getCurrentPage() - 1;

        previousPage = Math.max(previousPage, 1);

        setCurrentPage(previousPage);
        $scope.loadCards();
    };


    $scope.showFirst = function () {
        setCurrentPage(1);
        $scope.loadCards();
    };

    $scope.showLast = function () {
        setCurrentPage(count);
        $scope.loadCards();
    };

    $scope.loadCards();

    $scope.getResource = function (func) {
        return $window.executeFunctionByName(func, $window);
    };
});
