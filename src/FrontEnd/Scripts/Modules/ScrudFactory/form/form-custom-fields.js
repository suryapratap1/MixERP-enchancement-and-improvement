function getCustomFieldDataType(customField) {
    var type = "varchar";

    if (customField.IsNumber) {
        type = "numeric";
    };

    if (customField.IsDate) {
        type = "date";
    };

    if (customField.IsBoolean) {
        type = "bool";
    };

    if (customField.IsLongText) {
        type = "text";
    };

    return type;
};




function createCustomFields(customFields) {
    function mapper(customField) {
        var column = new Object();
        column.ColumnName = customField.FieldName;
        column.PropertyName = customField.FieldName;
        column.FieldLabel = customField.FieldLabel;
        column.IsCustomField = true;
        column.DbDataType = getCustomFieldDataType(customField);
        column.IsNullable = true;
        column.IsSerial = false;
        column.IsPrimaryKey = false;
        column.MaxLength = 0;
        column.Value = customField.Value;
        column.Description = customField.Description;

        return column;
    };

    if (customFields.length) {
        var active = scrudFactory.tabs.length === 0;
        createTabEls("custom", window.Resources.Titles.CustomFields(), active);
    } else {
        if (!$("#scrud-tab-menus .item").length) {
            $("#scrud-tabs").remove();
        };
    };

    for (var i = 0; i < customFields.length; i += 2) {
        var fields = $("<div class='fields' />");


        var leftField = mapper(customFields[i]);
        createFieldGroup(fields, leftField, "four wide field");

        if (i + 1 < customFields.length) {
            var rightField = mapper(customFields[i + 1]);
            createFieldGroup(fields, rightField, "four wide field");
        };

        if (fields.children().length > 0) {
            $("#tab-custom").append(fields);
        };
    };
};
