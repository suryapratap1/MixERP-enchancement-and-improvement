$("#CreateDuplicateButton").click(function () {
    var id = $("[data-primarykey]").val();

    if (id) {
        $(".form.factory").hide();
        $("[data-primarykey]").val("");
        window.displayMessage(window.Resources.Labels.ItemDuplicated, "success");
        $(".form.factory").fadeIn(1000);
    };
});

$("#ReturnToViewButton").click(function() {
    $(".form.factory").hide();
    $(".view.factory").fadeIn();
});