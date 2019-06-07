function loadFilterNames() {
    function request() {
        var url = "/api/core/filter-name-view/get-where/1";
        var where = [];

        where.push(getAjaxColumnFilter("WHERE", "object_name", FilterConditions.IsEqualTo, scrudFactory.viewTableName));
        var data = JSON.stringify(where);

        return getAjaxRequest(url, "POST", data, false);
    };


    var ajax = request();

    ajax.success(function (response) {
        var selected = "";

        var option = "<option value=''>";
        option += window.Resources.Titles.SelectAFilter();
        option += "</option>";

        $.each(response, function () {
            var isDefault = this.IsDefault;

            if (isDefault) {
                selected = this.FilterName;
            };

            option += stringFormat("<option value='{0}'>{0}</option>", this.FilterName);
        });


        $("#DefaultFilterSelect").html(option);

        if (selected) {
            $("#DefaultFilterSelect").dropdown({ placeholder: false }).dropdown("set selected", selected);
            loadPageCount(loadGrid);
        } else {
            $("#DefaultFilterSelect").dropdown({ placeholder: false });
            loadPageCount(loadGrid);
        };

        $("#FilterSelect").html(option).dropdown();


        $("#DefaultFilterSelect").change(function () {
            loadPageCount(loadGrid);
        });
    });
};

function loadFilter() {
    function request(filterName) {
        var url = "/api/core/filter/get-where/-1";
        var where = [];

        where.push(getAjaxColumnFilter("WHERE", "object_name", FilterConditions.IsEqualTo, scrudFactory.viewTableName));
        where.push(getAjaxColumnFilter("AND", "filter_name", FilterConditions.IsEqualTo, filterName));

        var data = JSON.stringify(where);
        return getAjaxRequest(url, "POST", data);
    };

    var filterName = $("#FilterSelect").getSelectedText();
    $("#FilterName").html(filterName);
    $("#FilterNameInputText").val(filterName);

    var ajax = request(filterName);

    ajax.success(function (response) {
        createFilters(response);
        $('.filter.modal').modal('hide');
    });

    ajax.fail(function (xhr) {
        logAjaxErrorMessage(xhr);
    });
};

function deleteSavedFilter() {
    function request(filterName) {
        var url = "/api/core/filter/delete/by-name/" + filterName;
        return getAjaxRequest(url, "DELETE");
    };

    var filterName = $("#FilterSelect").val();
    if (filterName) {
        var ajax = request(filterName);
        ajax.success(function () {
            loadFilterNames();
            displayMessage(Resources.Labels.TaskCompletedSuccessfully(), "success");
        });
    };
};
