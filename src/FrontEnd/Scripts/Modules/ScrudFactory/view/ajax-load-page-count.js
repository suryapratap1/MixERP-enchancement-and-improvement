function loadPageCount(callback) {
    function filteredRequest(queryStrings) {
        var filters = getAjaxFilters(queryStrings);

        var url = scrudFactory.viewAPI + "/count-where";
        var data = JSON.stringify(filters);

        return getAjaxRequest(url, "POST", data);
    };

    function request(filterName) {
        if (getFilterQueryStringCount()) {
            var qs = getQueryStrings();
            return filteredRequest(qs);
        };

        var url = scrudFactory.viewAPI + "/count";

        if (filterName) {
            url = scrudFactory.viewAPI + "/count-filtered/" + filterName;
        };

        return getAjaxRequest(url);
    };

    $(".view.dimmer").addClass("active");

    if (checkIfProcedure()) {
        if (typeof callback === "function") {
            callback();
        };

        return;
    };

    var filterName = getFilterName();

    var ajax = request(filterName, false);

    ajax.success(function (response) {
        var pages = (Math.ceil(parseInt(response) / 10) || 1);

        $(".total.pages.anchor").text(pages);

        if (typeof callback === "function") {
            callback();
        };
    });

    ajax.fail(function (xhr) {
        logAjaxErrorMessage(xhr);
    });
};
