function showTarget(target) {
    $("div[data-target]").hide();
    var targetEl = $('div[data-target="' + target.toLowerCase() + '"]');
    targetEl.removeClass("hidden").fadeIn(500);

    $('a[data-target]').removeClass("active green");
    $('a[data-target="' + target + '"]').addClass("active green");
};

function initializeViews() {
    if (scrudFactory.removeKanban || checkIfProcedure()) {
        $('[data-target="kanban"]').remove();
        showTarget("grid");
    };

    if (scrudFactory.removeFilter || checkIfProcedure()) {
        $('[data-target="filter"]').remove();
        $("#FilterButton").remove();
        showTarget("grid");
    };

    if (scrudFactory.removeImport || checkIfProcedure()) {
        $('[data-target="import"]').remove();
        showTarget("grid");
        $('a[data-target="grid"]').remove();
    };

    if (scrudFactory.removeFlag) {
        $("#FlagPopUnder").remove();
        $("#FlagButton").remove();
    };
};
