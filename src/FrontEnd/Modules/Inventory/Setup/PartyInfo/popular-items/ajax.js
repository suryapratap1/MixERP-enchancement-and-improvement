function getPartyItemChartView(partyId) {
    url = "/Modules/Inventory/Services/Setup/PartyInfo.asmx/GetPartyItemChartView";
    data = appendParameter("", "partyId", partyId);
    data = getData(data);

    return getAjax(url, data);
};