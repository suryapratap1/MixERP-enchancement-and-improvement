function initializeCustomButtons() {
    if (!scrudFactory.customButtons) {
        return;
    };

    var buttons = scrudFactory.customButtons;

    $.each(buttons, function (i, v) {
        var anchor = $("<a class='ui basic button' />");

        if (v.id) {
            anchor.attr("id", v.id);
        };

        if (v.text) {
            anchor.text(v.text);
        };

        if (v.href) {
            anchor.attr("href", v.href);
        };

        if (v.onclick) {
            anchor.attr("onclick", v.onclick);
        };

        $("#FlagButton").before(anchor);
    });
};
