function triggerFormReadyEvent() {
    if (!window.formReady) {
        window.formReady = true;
        $(document).trigger("formready");
        showForm();
    };
};

function triggerOnSavingEvent() {
    $(document).trigger("onsaving");
};
