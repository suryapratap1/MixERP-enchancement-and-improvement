function getShippingAddressView(partyId) {
    url = "/Modules/Inventory/Services/Setup/PartyInfo.asmx/GetShippingAddressView";
    data = appendParameter("", "partyId", partyId);
    data = getData(data);

    return getAjax(url, data);
};
