function createForm() {
    function getSchema() {
        return scrudFactory.formTableName.split(".")[0];
    };

    function customFieldRequest() {
        var url = scrudFactory.formAPI + "/custom-fields";
        var queryString = getQueryStringByName(scrudFactory.queryStringKey || "");

        if (queryString) {
            url += "/" + queryString;
        };

        return getAjaxRequest(url);
    };

    function request() {
        var url = scrudFactory.formAPI + "/meta";
        return getAjaxRequest(url);
    };

    var ajax = request();

    ajax.success(function (response) {
        window.metaInfo = response;
        createLayout(response.Columns, scrud);

        if (getSchema()) {
            var cfAjax = customFieldRequest();
            cfAjax.success(function (reply) {
                metaCustomFields = reply;
                createCustomFields(metaCustomFields);
            });
        };
    });
};
