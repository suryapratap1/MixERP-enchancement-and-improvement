function getReturnUrl() {
    var returnTo = getQueryStringByName("ReturnUrl");

    if (returnTo) {
        var qs = getQueryStrings();

        $.each(qs, function (i, v) {
            if (v.key !== "ReturnUrl") {
                returnTo = updateQueryString(v.key, v.value, returnTo);
            };
        });
    };

    if (!returnTo) {
        returnTo = window.returnUrl;
    };

    return (returnTo || "");
};
