function validateChangePassword() {
    window.removeDirty($("#PasswordInputPassword"));
    window.removeDirty($("#NewPasswordInputPassword"));
    window.removeDirty($("#ConfirmPasswordInputPassword"));

    function getModel() {
        return {
            Password: $("#PasswordInputPassword").val(),
            NewPassword: $("#NewPasswordInputPassword").val(),
            ConfirmPassword: $("#ConfirmPasswordInputPassword").val()
        };
    };

    const model = getModel();

    if (window.isNullOrWhiteSpace(model.Password)) {
        window.makeDirty($("#PasswordInputPassword"));
        return false;
    };

    if (window.isNullOrWhiteSpace(model.NewPassword)) {
        window.makeDirty($("#NewPasswordInputPassword"));
        return false;
    };

    if (window.isNullOrWhiteSpace(model.ConfirmPassword)) {
        window.makeDirty($("#ConfirmPasswordInputPassword"));
        return false;
    };

    if (model.NewPassword === model.Password) {
        window.makeDirty($("#PasswordInputPassword"));
        window.makeDirty($("#NewPasswordInputPassword"));

        alert(Resources.Warnings.NewPasswordCannotBeOldPassword());
        return false;
    };

    if (model.NewPassword !== model.ConfirmPassword) {
        window.makeDirty($("#NewPasswordInputPassword"));
        window.makeDirty($("#ConfirmPasswordInputPassword"));

        alert(Resources.Warnings.ConfirmationPasswordDoesNotMatch());
        return false;
    };

    return true;
};
