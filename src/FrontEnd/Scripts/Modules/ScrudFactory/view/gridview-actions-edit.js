function displayEdit(items) {
    for (var id in items) {
        if (items.hasOwnProperty(id)) {
            var value = items[id];
            if (value != null) {
                var el = $("#" + toUnderscoreCase(id));
                editScrudFormElement(el, value);
            };
        };
    };
};

function displayCustomFields(items) {
    $.each(items, function (i, v) {
        var id = v.FieldName;
        var value = v.Value;
        var el = $("#" + toUnderscoreCase(id));

        editScrudFormElement(el, value);
    });
};