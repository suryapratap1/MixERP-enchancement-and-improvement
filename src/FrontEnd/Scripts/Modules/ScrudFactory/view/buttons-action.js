$(".action.buttons .button").click(function () {
    $(".action.buttons .button").removeClass("active");
    var el = $(this);
    var target = el.attr("data-target");

    if (target) {
        showTarget(target);
    };

    var url = updateQueryString("View", target);
    window.history.pushState({ path: url }, '', url);
});
