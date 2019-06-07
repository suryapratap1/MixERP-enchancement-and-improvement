function getField(propertyName, dataType, nullable) {
    if (typeof (scrudFactory.keys) === "undefined") {
        scrudFactory.keys = [];
    };

    if (propertyName.toString().toLowerCase() === "password") {
        dataType = "password";
    };

    var hasKey = Enumerable.From(scrudFactory.keys || [])
        .Where(function (x) { return x.property === propertyName }).ToArray()[0];

    if (hasKey) {
        return $("<select class='ui search fluid dropdown' />");
    };

    switch (dataType) {
        case "image":
            return $("<input type='text' class='image' />");
        case "int4":
        case "int8":
        case "integer_strict":
        case "integer_strict2":
            return $("<input type='text' class='integer' />");
        case "float8":
        case "decimal":
        case "decimal_strict":
        case "numeric":
            return $("<input type='text' class='decimal' />");
        case "money_strict2":
        case "money_strict":
            return $("<input type='text' class='currency' />");
        case "text":
            return $("<textarea />");
        case "date":
            return $("<input type='text' class='date' />");
        case "bool":
            var el = $("<select class='ui search dropdown' />");
            var option = "<option";

            if (nullable) {
                option += " value='Select'>";
            } else {
                option += " value=''>";
            };

            option += Resources.Titles.Select() + "</option>";
            option += "<option value='yes'>" + Resources.Titles.Yes() + "</option>";
            option += "<option value='no'>" + Resources.Titles.No() + "</option>";

            el.append(option);

            return el;
        default:
            return $("<input type='text' />");
    };
};


function editScrudFormElement(targetEl, value) {
    if (targetEl.length) {
        if (targetEl.hasClass("date")) {
            value = value.toString().toFormattedDate();
        };

        if (targetEl.attr("data-type") === "time") {
            value = getTime(value);
        };

        targetEl.val(value);

        if (targetEl.attr("data-type") === "image") {
            initializeUploader();
        };

        if (targetEl.is("select")) {
            var type = targetEl.attr("data-type");

            if (type === "bool") {
                value = value ? "yes" : "no";
            };

            targetEl.dropdown("set selected", value.toString());
            targetEl.trigger("blur");
            targetEl.trigger("change");
            return;
        };

        targetEl.trigger("blur");
        targetEl.trigger("change");
        targetEl.trigger("keyup");
    };
};