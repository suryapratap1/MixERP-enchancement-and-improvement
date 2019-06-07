//Variables
var dataTypes;
var dataTypeOptions;
var formSelect = $("#FormSelect");

//Ajax
function getForms() {
    var url = "/Modules/BackOffice/Services/CustomFields.asmx/GetForms";
    return getAjax(url);
};

function getDataTypes() {
    var url = "/Modules/BackOffice/Services/CustomFields.asmx/GetDataTypes";
    return getAjax(url);
};

function getCustomFieldSetups(formName) {
    var url = "/Modules/BackOffice/Services/CustomFields.asmx/GetCustomFieldSetups";
    var data = appendParameter("", "formName", formName);

    data = getData(data);

    return getAjax(url, data);
};

function saveCustomFieldSetups(formName, fields) {
    var url = "/Modules/BackOffice/Services/CustomFields.asmx/SaveCustomFieldSetups";
    var data = appendParameter("", "formName", formName);
    data = appendParameter(data, "fields", fields);

    data = getData(data);

    return getAjax(url, data);
};

//Ajax calls
var ajaxGetForms = getForms();

var ajaxGetDataTypes = getDataTypes();

ajaxGetDataTypes.success(function (msg) {
    dataTypes = msg.d;

    dataTypeOptions = "<option value=''>" + Resources.Titles.Select() + "</option>";
    for (i = 0; i < dataTypes.length; i++) {
        var val = dataTypes[i];

        dataTypeOptions += "<option value='" + val + "'>" + val + "</option>";
    };
});

ajaxGetDataTypes.fail(function (xhr) {
    logAjaxErrorMessage(xhr);
});

ajaxGetForms.success(function (msg) {
    var data = msg.d;
    var options = "<option value=''>" + Resources.Titles.Select() + "</option>";

    for (var i = 0; i < data.length; i++) {
        var val = data[i];

        options += "<option value='" + val + "'>" + val + "</option>";
    };

    formSelect.append(options);
});

ajaxGetForms.fail(function (xhr) {
    logAjaxErrorMessage(xhr);
});


function show() {
    var formName = formSelect.getSelectedValue();

    if (!formName) {
        return;
    };

    var ajaxGetCustomFieldSetups = getCustomFieldSetups(formName);

    ajaxGetCustomFieldSetups.success(function (msg) {
        var fields = msg.d;

        $("#CustomFieldContainer").html("");

        for (var i = 0; i < fields.length; i++) {
            addField(fields[i].FieldOrder, fields[i].FieldName, fields[i].FieldLabel, fields[i].DataType, fields[i].Description);
        };
    });

    ajaxGetCustomFieldSetups.fail(function (xhr) {
        logAjaxErrorMessage(xhr);
    });
};

function getOrder() {
    var values = [];

    $(".order").each(function () {
        values.push(parseInt($(this).val()));
    });

    var value = Math.max.apply(Math, values) + 1;
    if (value === -Infinity) {
        value = 1;
    };

    return value;
};

function save() {
    var el = $("#CustomFieldContainer .fields");
    var fields = [];
    var formName = formSelect.getSelectedValue();
    var invalid = false;

    el.each(function () {
        var fieldOrder = $(this).find(".order").val();
        var fieldName = $(this).find(".name").val();
        var fieldLabel = $(this).find(".label").val();
        var dataType = $(this).find(".data-type").val();
        var description = $(this).find(".description").val();


        if (!fieldName) {
            makeDirty($(this).find(".name"));
            invalid = true;
            return;
        };

        removeDirty($(this).find(".name"));

        if (!fieldLabel) {
            makeDirty($(this).find(".label"));
            invalid = true;
            return;
        };

        removeDirty($(this).find(".label"));

        if (!dataType) {
            makeDirty($(this).find(".data-type"));
            invalid = true;
            return;
        };

        removeDirty($(this).find(".data-type"));


        var field = GetCustomFieldSetup(formName, fieldOrder, fieldName, fieldLabel, dataType, description);
        fields.push(field);
    });

    if (invalid) {
        return;
    };

    var ajaxSaveCustomFieldSetups = saveCustomFieldSetups(formName, fields);

    ajaxSaveCustomFieldSetups.success(function () {
        displayMessage(Resources.Labels.TaskCompletedSuccessfully(), "success");
    });

    ajaxSaveCustomFieldSetups.fail(function (xhr) {
        logAjaxErrorMessage(xhr);
    });
};

function GetCustomFieldSetup(formName, fieldOrder, fieldName, fieldLabel, dataType, description) {
    var customFieldSetup = new Object();
    customFieldSetup.FormName = formName;
    customFieldSetup.FieldOrder = fieldOrder;
    customFieldSetup.FieldName = fieldName;
    customFieldSetup.FieldLabel = fieldLabel;
    customFieldSetup.DataType = dataType;
    customFieldSetup.Description = description;

    return customFieldSetup;
};


function addField(fieldOrder, fieldName, fieldLabel, dataType, description) {
    if (!formSelect.getSelectedValue()) {
        displayMessage(Resources.Labels.PleaseSelectAFormFirst(), "error");
        return;
    };

    var fields = $("<div class='fields'/>");

    if (!fieldOrder) {

        fieldOrder = getOrder();
    };

    var orderField = $("<div class='one wide field'>" +
        "<label>" + Resources.Titles.FieldOrder() + "</label>" +
        "<input type='text' class='order' />" +
        "</div>");

    if (fieldOrder) {
        orderField.find(".order").val(fieldOrder);
    };

    var nameField = $("<div class='three wide field'>" +
        "<label>" + Resources.Titles.FieldName() + "</label>" +
        "<input type='text' class='name' />" +
        "</div>");

    if (fieldName) {
        nameField.find(".name").val(fieldName);
    };

    var labelField = $("<div class='three wide field'>" +
        "<label>" + Resources.Titles.FieldLabel() + "</label>" +
        "<input type='text' class='label' />" +
        "</div>");

    if (fieldLabel) {
        labelField.find(".label").val(fieldLabel);
    };

    var dataTypeField = $("<div class='three wide field'>" +
        "<label>" + Resources.Titles.DataType() + "</label>" +
        "<select class='data-type'>" + dataTypeOptions + "</select>" +
        "</div>");

    if (dataType) {
        dataTypeField.find(".data-type").val(dataType);
    };

    var descriptionField = $("<div class='four wide field'>" +
        "<label>" + Resources.Titles.Description() + "</label>" +
        "<input type='text' class='description' />" +
        "</div>");

    if (description) {
        descriptionField.find(".description").val(description);
    };

    var buttonFields = $("<div class='two wide field'>" +
        "<label>&nbsp;</label>" +
        "<div class='ui basic icon buttons'>" +
        "<button type='button' class='ui button' onclick='$(this).parent().parent().parent().remove();'>" +
        "<i class='remove icon'></i>" +
        "</button>" +
        "</div>" +
        "</div>");

    fields.append(orderField);
    fields.append(nameField);
    fields.append(labelField);
    fields.append(dataTypeField);
    fields.append(descriptionField);
    fields.append(buttonFields);

    $("#CustomFieldContainer").append(fields);
};
