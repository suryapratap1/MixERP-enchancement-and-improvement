function canAdd() {
    window.scrudForm = $(".form.factory");

    if (window.scrudForm.length) {
        return true;
    };

    if (scrudFactory.addNewUrl) {
        addNewButton.attr("href", scrudFactory.addNewUrl);
        return true;
    };

    return false;
};

addNewButton.click(function () {
    if (window.scrudForm.length) {
        window.scrudView.hide();
        window.scrudForm.fadeIn(500);
    };
});
