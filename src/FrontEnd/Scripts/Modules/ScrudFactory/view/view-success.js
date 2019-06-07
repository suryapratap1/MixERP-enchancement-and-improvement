function onViewSuccess(response) {
    window.json = response;
    var el = $("#json");
    createGridView(el, window.json);
    localizeHeaders(el);
    loadColumns();
    loadActions();
    loadButtons();
    triggerViewReadyEvent();
    $(".view.dimmer").removeClass("active");
    createCards();
    $(".view.factory").fadeIn();
    initializeFlag();
    $(document).trigger("viewsuccess");
};