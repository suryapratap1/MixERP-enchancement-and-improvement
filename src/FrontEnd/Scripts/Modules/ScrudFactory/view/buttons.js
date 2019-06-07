function loadButtons() {
    if (canAdd()) {
        addNewButton.show();
    } else {
        addNewButton.remove();
    };

    createVerificationButton();
};