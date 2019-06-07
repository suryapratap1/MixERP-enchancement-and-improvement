function getPartyView(partyId) {
    url = "/Modules/Inventory/Services/Setup/PartyInfo.asmx/GetPartyView";
    data = appendParameter("", "partyId", partyId);
    data = getData(data);

    return getAjax(url, data);
};