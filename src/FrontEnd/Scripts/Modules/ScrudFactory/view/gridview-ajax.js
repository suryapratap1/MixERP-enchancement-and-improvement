function loadGrid() {
    function filteredRequest(pageNumber, queryStrings) {
        var url = scrudFactory.viewAPI + "/get-where/" + pageNumber;
        data = JSON.stringify(getAjaxFilters(queryStrings));
        return getAjaxRequest(url, "POST", data);
    };

    function request(pageNumber, filterName, byOffice) {
        if (getFilterQueryStringCount()) {
            var queryStrings = getQueryStrings();
            return filteredRequest(pageNumber, queryStrings, byOffice);
        };

        var url = scrudFactory.viewAPI + "/page/" + pageNumber;

        if (filterName) {
            url = scrudFactory.viewAPI + "/get-filtered/" + pageNumber + "/" + filterName;
        };

        return getAjaxRequest(url);
    };

    var pageNumber = getPageNumber();
    var filterName = getFilterName();

    if (checkIfProcedure()) {
        $(".view.dimmer").removeClass("active");
        $("#Pager").remove();
        loadAnnotation();
        return;
    };

    $(".current.page.anchor").text(pageNumber);
    var ajax = request(pageNumber, filterName, false);

    ajax.success(function (response) {
        onViewSuccess(response);
    });

    ajax.fail(function (xhr) {
        logAjaxErrorMessage(xhr);
    });
};