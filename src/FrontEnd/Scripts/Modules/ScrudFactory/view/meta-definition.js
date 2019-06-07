function loadMeta(callback) {
    function request() {
        var api = scrudFactory.formAPI;

        if (typeof (api) === "undefined") {
            api = scrudFactory.viewAPI;
        };

        var url = api + "/meta";
        return getAjaxRequest(url);
    };

    if (scrudFactory.ignoreMeta) {
        metaDefinition = [];
        if (typeof (callback) === "function") {
            callback();
        };

        return;
    };

    var getMetaAjax = request();

    getMetaAjax.success(function (response) {
        metaDefinition = response;
        if (typeof (callback) === "function") {
            callback();
        };
    });
};