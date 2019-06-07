function editRow(el, isCard) {
    function customFieldRequest(tableName, primaryKeyValue) {
        var url = "/api/core/custom-field-view/get-where/1";

        var filters = [];

        filters.push(window.getAjaxColumnFilter("WHERE", "table_name", FilterConditions.IsEqualTo, tableName));
        filters.push(window.getAjaxColumnFilter("AND", "resource_id", FilterConditions.IsEqualTo, primaryKeyValue));

        var data = JSON.stringify(filters);

        return getAjaxRequest(url, "POST", data, false);
    };

    function request(primaryKeyValue) {
        var url = scrudFactory.formAPI + "/" + primaryKeyValue;
        return getAjaxRequest(url);
    };

    var confirmed = confirmAction();

    if (!confirmed) {
        return;
    };

    var primaryKeyValue = getPrimaryKeyValue($(el), isCard);

    if (scrudFactory.editUrl) {
        window.location = scrudFactory.editUrl + primaryKeyValue;
        return;
    };

    if (window.scrudForm === "undefined") {
        displayMessage(window.Resources.Labels.NoFormFound());
        return;
    };

    var tableName = scrudFactory.formTableName;

    if (checkIfProcedure()) {
        return;
    };

    var ajax = request(primaryKeyValue);

    if (scrudFactory.disabledOnEdit) {
        $.each(scrudFactory.disabledOnEdit, function () {
            var t = $('[data-property="' + this + '"]');
            t.attr("disabled", "disabled");
        });
    };

    ajax.success(function (response) {
        window.editData = response;
        displayEdit(response, false);

        customFieldRequest(tableName, primaryKeyValue).success(function (msg) {
            displayCustomFields(msg);
            window.scrudView.hide();
            window.scrudForm.fadeIn(500);
        });
    });
};