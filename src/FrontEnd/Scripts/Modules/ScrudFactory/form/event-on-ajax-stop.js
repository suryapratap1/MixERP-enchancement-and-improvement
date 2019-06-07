$(document).ajaxStop(function () {
    if (window.formReady) {
        return;
    };

    $("#scrud").show();
    $("#scrud").parent().removeClass("loading");

    loadDefaultValues();
    loadDropdowns();
    setRegionalFormat();
    loadDatepicker();
    initializeValidators();
    triggerFormReadyEvent();
});