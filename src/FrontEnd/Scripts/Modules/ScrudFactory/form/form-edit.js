function loadEdit(id) {
    function request(primaryKeyValue) {
        var url = scrudFactory.formAPI + "/" + primaryKeyValue;
        return getAjaxRequest(url);
    };

    var ajax = request(id);

    ajax.success(function (response) {
        editData = response;
        $("#scrud").html("");
        $("#scrud-tab-menus").html("");
        $("#scrud-tab-members").html("");
        createForm();
    });
};
