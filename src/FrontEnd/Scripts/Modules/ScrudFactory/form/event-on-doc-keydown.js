$(document).keydown(function (event) {
    if (event.ctrlKey) {
        if (event.key === "Enter") {
            if ($(".form.factory").is(":visible")) {
                $("#SaveButton").trigger("click");
                return false;
            };
        };
    };
});