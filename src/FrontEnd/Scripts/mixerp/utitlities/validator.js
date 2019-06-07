var validator = new function () {
    var isValid = true;
    var requiredFieldMessage = window.requiredFieldMessage || "This field is required.";//Fallback to english language.

    this.logError = function (message) {
        console.log(message);
    };

    var validateField = function (field) {
        var val = field.val();
        var errorMessage = field.closest(".field").find(".error-message");
        if (!errorMessage.length) {
            errorMessage = $("<span class='error-message' />");
            field.closest(".field").append(errorMessage);
        };

        if (window.isNullOrWhiteSpace(val)) {
            this.isValid = false;
            window.makeDirty(field);

            field.closest(".field").find(".error-message").html(window.Resources.Labels.ThisFieldIsRequired());
        } else {
            window.removeDirty(field);
            field.closest(".field").find(".error-message").html("");
        };
    };

    this.initialize = function (el) {
        el.find(".dropdown input.search").blur(function () {
            $(this).parent().find("select").trigger("blur");
        });

        el.find("[required]:not(:disabled):not([readonly])").blur(function () {
            var field = $(this);
            validateField(field);
        });
    };

    this.validate = function (el, oninvalid, log) {
        var required = el.find(".image.form-field, [required]:not(:disabled):not([readonly]):not(.hidden.column)");
        required.trigger("blur");

        if (jQuery().timepicker) {
            $(".ui-timepicker-input").timepicker("hide");
        };

        var errorFields = el.find(".error:not(.big.error)");

        isValid = errorFields.length === 0;

        $.each(errorFields, function (i, v) {
            var field = $(v);
            var label = field.closest(".field").find("label");
            var message = label.html() + " : " + requiredFieldMessage;

            if (log) {
                console.log(message);
            };

            if (typeof (oninvalid) === "function") {
                oninvalid(field);
            };
        });

        return isValid;
    };
};
