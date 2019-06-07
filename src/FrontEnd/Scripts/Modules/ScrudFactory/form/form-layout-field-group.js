function createFieldGroup(el, column, cssClass) {
    function getLabel(columnName) {
        return tryParseLocalizedResource(columnName);
    };

    if (typeof (column) === "undefined") {
        return;
    };

    if (["audit_user_id", "audit_ts"].indexOf(column.ColumnName) >= 0) {
        return;
    };

    var field = $("<div/>");
    field.addClass(cssClass);

    var label = $("<label/>");

    if (column.FieldLabel) {
        label.text(column.FieldLabel);
    } else {
        label.text(getLabel(column.ColumnName));
    };

    label.attr("for", column.ColumnName);


    var element = getField(column.PropertyName, column.DbDataType, column.IsNullable);


    element.attr("id", column.ColumnName);

    if (column.DbDataType.indexOf("strict") > -1) {
        element.attr("data-validation", column.DbDataType);
    };

    element.attr("data-property", column.PropertyName);
    element.attr("data-type", column.DbDataType);

    if (typeof (scrudFactory.live) !== "undefined") {
        if (column.PropertyName === scrudFactory.live) {
            element.addClass("live");
        };
    };

    if (typeof (scrudFactory.readonlyColumns) === "undefined") {
        scrudFactory.readonlyColumns = [];
    };

    if (typeof (scrudFactory.hiddenColumns) === "undefined") {
        scrudFactory.hiddenColumns = [];
    };

    if (scrudFactory.readonlyColumns.indexOf(column.PropertyName) > -1) {
        element.attr("readonly", "");
    };

    if (scrudFactory.hiddenColumns.indexOf(column.PropertyName) > -1) {
        field.addClass("hidden column");
    };

    if (column.IsSerial) {
        element.attr("readonly", "readonly");
    };

    if (column.IsPrimaryKey) {
        element.attr("data-primaryKey", "");
        element.removeClass();
        if (scrudFactory.hidePrimaryKey) {
            field.addClass("hidden column");
        };
    };

    if (column.MaxLength > 0) {
        element.attr("maxlength", column.MaxLength);
    };

    if (!column.IsNullable) {
        element.attr("required", "required");
        field.addClass("required");
    };

    var value = column.Value;

    if (window.editData) {
        if (window.editData.hasOwnProperty(column.PropertyName)) {
            value = window.editData[column.PropertyName];
        };
    };

    if (element.hasClass("date")) {
        value = value.toFormattedDate();
    };

    if (element.attr("data-type") === "time") {
        value = getTime(value);
    };

    if (column.DbDataType === "bool") {
        value = value ? "yes" : "no";
    };

    if (value) {
        element.attr("data-value", value);
        element.val(value);
    };

    if (column.IsCustomField) {
        element.addClass("custom-field");
    } else {
        element.addClass("form-field");
    };

    if (window.editData) {
        if (scrudFactory.disabledOnEdit) {
            if (scrudFactory.disabledOnEdit.indexOf(column.PropertyName) !== -1) {
                element.attr("disabled", "disabled");
            };
        };
    };

    field.append(label);
    field.append(element);

    if (column.Description) {
        field.append("<span class='ui basic pointing label'>" + column.Description + "</span>");
    };

    el.append(field);
};
