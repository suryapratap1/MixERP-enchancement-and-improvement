function getAnnotation() {
    var els = $("#Annotation .fields .field .data-member");

    var annotation = new Object();

    els.each(function () {
        var el = $(this);
        var key = el.attr("data-model");
        var value = el.val();

        annotation[key] = value;
    });

    return annotation;
};

function loadAnnotation() {
    function request() {
        var url = scrudFactory.viewAPI + "/annotation";
        return getAjaxRequest(url);
    };

    if (!checkIfProcedure()) {
        return;
    };

    var ajax = request();
    ajax.success(function (response) {
        if (!annotationLoaded) {
            createAnnotationFields(response);
        };

        annotationLoaded = true;
    });
};

function createAnnotationFields(annotation) {
    $.each(annotation.Columns, function (i, v) {
        if (scrudFactory.hiddenAnnotation) {
            var isHidden = Enumerable.From(scrudFactory.hiddenAnnotation).Where(function (x) { return x === v.PropertyName; }).Count() === 1;
            annotation.Columns[i].IsHidden = isHidden;
        };
    });

    var visible = Enumerable.From(annotation.Columns).Where(function (x) { return !x.IsHidden; }).ToArray();
    var groups = window.chunk_array(visible, 6);

    var fields;

    $.each(groups, function (i, group) {
        fields = $('<div class="six fields" />');

        $.each(group, function (i, item) {
            addAnnotationField(item, fields);
        });

        $("#ShowButton").parent().before(fields);
    });

    var hidden = Enumerable.From(annotation.Columns).Where(function (x) { return x.IsHidden; }).ToArray();

    $.each(hidden, function (i, item) {
        addAnnotationField(item, fields, true);
    });


    $("#ShowButton").parent().before(fields);
    $("#ShowButton").parent().insertAfter($("#Annotation .fields").last().find(".field").last());

    setRegionalFormat();
    loadDatepicker();
    $("#Annotation").fadeIn();
    executeFunction();
};

$("#ShowButton").click(function () {
    executeFunction();
});

function simplifyAnnotationType(dbType) {
    var type = dbType.toString().toLowerCase();

    if (type === "text") {
        type = "string";
    };

    return type;
};

function addAnnotationField(item, fields, hidden) {
    var field = $('<div class="field" />');

    var type = simplifyAnnotationType(item.DbDataType);

    var el = getField(item.PropertyName, type, true);
    el.attr("placeholder", item.PropertyName);

    if (scrudFactory.defaultAnnotation) {
        var defaultValue = Enumerable.From(scrudFactory.defaultAnnotation).Where(function (x) { return x.key === item.PropertyName; }).ToArray()[0];
        var queryValue = getQueryStringByName("Annotation" + item.PropertyName);

        if (queryValue) {
            defaultValue.value = queryValue;
        };

        if (defaultValue) {
            el.val(defaultValue.value);
        };
    };

    el.addClass("data-member");
    el.attr("id", "Annotation" + item.PropertyName);
    el.attr("title", item.PropertyName);
    el.attr("data-model", item.PropertyName);

    if (hidden) {
        field.addClass("hidden");
    };

    field.append(el);
    fields.append(field);
};

function executeFunction() {
    function request(annotation) {
        var url = scrudFactory.viewAPI + "/execute";
        var data = JSON.stringify(annotation);

        return getAjaxRequest(url, "POST", data);
    };

    var annotation = getAnnotation();
    var ajax = request(annotation);

    ajax.success(function (response) {
        onViewSuccess(response);
    });
};

