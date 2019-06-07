function getAccountStatement(partyId) {
    url = "/Modules/Inventory/Services/Setup/PartyInfo.asmx/GetAccountStatement";
    data = appendParameter("", "partyId", partyId);
    data = getData(data);

    return getAjax(url, data);
};
