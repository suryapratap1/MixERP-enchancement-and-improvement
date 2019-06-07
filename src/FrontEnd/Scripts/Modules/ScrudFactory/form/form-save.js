saveButton.click(function () {
    triggerOnSavingEvent();

    function request(entity, customFields) {
        var url = scrudFactory.formAPI + "/add-or-edit";
        var form = [];

        form.push(entity);
        form.push(customFields);

        var data = JSON.stringify(form);
        return getAjaxRequest(url, "POST", data);
    };

    var isValid = validate();

    if (!isValid) {
        return;
    };

    saveButton.addClass("loading");
    var bigError = $(".big.error");
    var entity = new Object();
    var customFields = [];

    bigError.removeClass("vpad16").html("");

    function getFormValue(columnName, dataType, isSerial, dbDataType) {
        var el = $("#" + columnName);
        var val = null;
        if (el.length) {
            val = el.val();

            switch (dataType) {
                case "System.Boolean":
                case "bool":
                    val = val === "yes" ? true : false;
                    break;
                case "DateTime":
                    if (dbDataType === "time") {
                        val = val || null;
                    } else {
                        val = window.parseLocalizedDate(val) || null;
                    };
                    break;
                case "short":
                case "int":
                case "long":
                case "float":
                case "double":
                case "decimal":
                    val = val || null;
                    break;
                default:
                    val = val.toString().trim();

                    if (el.is("select")) {
                        if (!val) {
                            val = null;
                        };
                    };

                    break;
            };

        };

        if (isSerial) {
            if (isNullOrWhiteSpace(val)) {
                val = null;
            };
        };

        return val;
    };

    $.each(metaInfo.Columns, function (i, v) {
        var value = getFormValue(v.ColumnName, v.DataType, v.IsSerial, v.DbDataType);

        if (window.editData) {
            if (scrudFactory.disabledOnEdit) {
                if (scrudFactory.disabledOnEdit.indexOf(v.PropertyName) !== -1) {
                    return true;
                };
            };
        };

        entity[v.ColumnName] = value;
    });

    if (window.metaCustomFields) {
        $.each(window.metaCustomFields, function (i, v) {
            var dataType = getCustomFieldDataType(v);
            var value = getFormValue(v.FieldName, dataType, false);

            var customField = new Object();
            customField.FieldName = v.FieldName;
            customField.Value = value;

            customFields.push(customField);
        });
    };

    var ajax = request(entity, customFields);

    ajax.success(function () {
        saveButton.removeClass("loading");
        var confirmed = confirm(window.Resources.Labels.TaskCompletedSuccessfullyReturnToView());

        resetForm();

        if (confirmed) {
            window.scrudForm.hide();

            if (getReturnUrl()) {
                window.location.href = getReturnUrl();
            };

            if (window.scrudView.length) {
                showView();
            };
        };
    });

    ajax.fail(function (xhr) {
        var error = getAjaxErrorMessage(xhr);

        saveButton.removeClass("loading");
        bigError.addClass("vpad16").text(error);
    });
});
