cancelButton.click(function () {
    var confirmed = confirmAction();

    if (!confirmed) {
        return;
    };

    resetForm();

    if (window.scrudView.length) {
        showView();
    };

    if (getReturnUrl()) {
        document.location.href = getReturnUrl();
    };
});