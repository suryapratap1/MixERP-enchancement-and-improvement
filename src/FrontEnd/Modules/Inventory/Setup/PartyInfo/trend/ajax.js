function getSalesChartView(partyId) {
    url = "/Modules/Inventory/Services/Setup/PartyInfo.asmx/GetSalesChartView";
    data = appendParameter("", "partyId", partyId);
    data = getData(data);

    return getAjax(url, data);
};

function getPurchaseChartView(partyId) {
    url = "/Modules/Inventory/Services/Setup/PartyInfo.asmx/GetPurchaseChartView";
    data = appendParameter("", "partyId", partyId);
    data = getData(data);

    return getAjax(url, data);
};