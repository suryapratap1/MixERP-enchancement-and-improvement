$("#FilterName").text(Resources.Titles.Untitled());

function getFilterName() {
    if ($("#DefaultFilterSelect").val()) {
        var filter = $("#DefaultFilterSelect").getSelectedText();
        return filter;
    };

    return "";
};

function getAjaxFilters(queryStrings) {
    var filters = [];

    $.each(queryStrings, function (index, value) {
        filters.push(getAjaxColumnFilter("WHERE", toUnderscoreCase(value.key), 0, value.value));
    });

    return filters;
};


function loadFilterConditions() {
    var el = $("#FilterConditionSelect");
    bindSelect(el, filterConditions, "value", "text");
    el.dropdown();
};

function loadColumns() {
    var el = $("#ColumnSelect");
    el.html("");
    bindSelect(el, localizedHeaders, "columnName", "localized");
    el.dropdown();
};

$("#FilterNameInputText").keyup(function () {
    $("#FilterName").html(Resources.Titles.Untitled());
    if ($(this).val()) {
        var filterName = stringFormat(window.Resources.Labels.NamedFilter(), $(this).val());
        $("#FilterName").html(filterName);
    };
});

filterConditionSelect.change(function () {
    var val = parseFloat(filterConditionSelect.val() || 0);

    if (val >= 6 && val <= 7) {
        andInputText.removeAttr("readonly");
        return;
    };

    andInputText.attr("readonly", "readonly");
    andInputText.val("");
});


function validateFilters() {
    var isValid = true;

    $("#FilterForm [required]").each(function () {
        var el = $(this);

        if (isNullOrWhiteSpace(el.val())) {
            isValid = false;
            makeDirty(el);
            return;
        };

        removeDirty(el);
    });

    return isValid;
};

$("#AddFilterButton").click(function () {
    var grid = $("#FilterTable");

    var isValid = validateFilters();
    if (!isValid) {
        return;
    };

    var selectedColumn = columnSelect.getSelectedText();
    var filterCondition = filterConditionSelect.getSelectedText();

    var value = valueInputText.val();
    var and = andInputText.val();

    var duplicate = false;

    grid.find("tbody tr").each(function () {
        var el = $(this);
        var columnName = el.find("td:nth-child(2)").text();
        var condition = el.find("td:nth-child(3)").text();

        if (columnName === selectedColumn &&
            condition === filterCondition) {

            el.find("td:nth-child(4)").text(value);
            el.find("td:nth-child(5)").text(and);

            el.addClass("warning");
            duplicate = true;
            return false;
        };
    });


    if (!duplicate) {
        addFilterRow(selectedColumn, filterCondition, value, and);
    };
});

function addFilterRow(selectedColumn, filterCondition, value, and, css) {
    var html = "<tr>";
    html += "<td>" + commandItems + "</td>";
    html += "<td>" + selectedColumn + "</td>";
    html += "<td>" + filterCondition + "</td>";
    html += "<td>" + value + "</td>";
    html += "<td>" + and + "</td>";
    html += "</tr>";

    var row = $(html);

    if (css) {
        row.addClass(css);
    };

    $("#FilterTable").removeClass("inverted red").find("tbody").append(row);
    columnSelect.parent().find(".search").focus();
};

$("#ManageFiltersButton").click(function () {
    $('.filter.modal').modal('show');
});

$("#SaveFilterButton").click(function () {
    function request(filterName, filters) {
        var url = "/api/core/filter/recreate/" + scrudFactory.viewTableName + "/" + filterName;
        var data = JSON.stringify(filters);

        return getAjaxRequest(url, "PUT", data);
    };

    var table = $("#FilterTable");
    var filterNameInputText = $("#FilterNameInputText");

    if (isNullOrWhiteSpace(filterNameInputText.val())) {
        makeDirty(filterNameInputText);
        return;
    };

    removeDirty(filterNameInputText);

    if (!table.find("tbody tr").length) {
        table.addClass("inverted red");
        return;
    };

    table.removeClass("inverted red");

    var error = table.find("tr.error td:nth-child(2)").text();

    if (error.length) {
        var message = window.Resources.Questions.ColumnInvalidAreYouSure();

        var confirmed = confirm(stringFormat(message, error));
        if (!confirmed) {
            return;
        };
    };

    var filters = [];

    $("#FilterTable tbody tr").each(function () {
        var el = $(this);
        var columnName = el.find("td:nth-child(2)").text();
        var condition = el.find("td:nth-child(3)").text();

        var filter = new Object();

        filter.FilterId = window.filterId;
        filter.FilterStatement = "AND";
        filter.ObjectName = scrudFactory.viewTableName;
        filter.FilterName = filterNameInputText.val();

        filter.ColumnName = Enumerable.From(localizedHeaders)
            .Where(function (x) { return x.localized === columnName }).ToArray()[0].columnName;

        filter.FilterCondition = parseInt(
            Enumerable.From(filterConditions)
            .Where(function (x) { return x.text === condition })
            .ToArray()[0].value
            || 0);

        filter.FilterValue = el.find("td:nth-child(4)").text();
        filter.FilterAndValue = el.find("td:nth-child(5)").text();
        filters.push(filter);
    });

    var ajax = request(filterNameInputText.val(), filters);

    ajax.success(function () {
        window.filterId = 0;
        displayMessage(Resources.Titles.TaskCompletedSuccessfully(), "success");
    });

    ajax.fail(function (xhr) {
        logAjaxErrorMessage(xhr);
    });
});


function createFilters(filters) {
    $("#FilterTable").find("tbody").html("");

    $.each(filters, function (i, filter) {
        var selectedColumn = filter.ColumnName;
        var filterCondition = filter.FilterCondition;
        var value = filter.FilterValue;
        var and = (filter.FilterAndValue || "");

        var css = "";

        filterCondition = Enumerable.From(filterConditions)
            .Where(function (x) { return x.value === filterCondition.toString() })
            .Select(function (x) { return x.text }).ToArray()[0];

        column = Enumerable.From(localizedHeaders)
            .Where(function (x) { return x.columnName === selectedColumn }).ToArray()[0];

        if (column) {
            selectedColumn = column.localized;
        } else {
            css = "error";
        };

        addFilterRow(selectedColumn, filterCondition, value, and, css);
    });
};


function deleteFilter(el) {
    if (confirmAction()) {
        $(el).parent().parent().remove();
    };

};


$("#MakeUserDefaultFilterButton").click(function () {
    function request(filterName) {
        var url = "/api/core/filter/make-default/" + scrudFactory.viewTableName + "/" + filterName;
        return getAjaxRequest(url, "PUT");
    };

    var filterName = $("#FilterSelect").getSelectedText();
    var ajax = request(filterName);

    ajax.success(function () {
        displayMessage(Resources.Labels.TaskCompletedSuccessfully(), "success");

        $(".filter.modal").modal("close");
    });

    ajax.fail(function (xhr) {
        logAjaxErrorMessage(xhr);
    });
});

