function deleteRow(el, isCard) {
    function request(primaryKeyValue) {
        var url = scrudFactory.formAPI + "/delete/" + primaryKeyValue;
        return getAjaxRequest(url, "DELETE");
    };

    var confirmed = confirmAction();

    if (!confirmed) {
        return;
    };

    var primaryKeyValue = getPrimaryKeyValue($(el), isCard);


    if (typeof (scrudFactory.deleteHandler) === "function") {
        scrudFactory.deleteHandler(primaryKeyValue);
        return;
    };

    var ajax = request(primaryKeyValue);

    ajax.success(function () {
        var confirmed = confirm(window.Resources.Labels.TaskCompletedSuccessfullyRefreshView());

        if (confirmed) {
            loadPageCount(loadGrid);
        };
    });
};