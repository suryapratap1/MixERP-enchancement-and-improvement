function checkIfProcedure() {
    if ((typeof (scrudFactory.isProcedure) === "undefined")) {
        return scrudFactory.viewAPI.indexOf("/procedures") !== -1;
    };

    return scrudFactory.isProcedure;
};

function hasVerfication() {
    if (!scrudFactory.hasVerfication) {
        return false;
    };

    if (!scrudFactory.formAPI) {
        return false;
    };

    var candidates = ["verification_status_id", "verification_reason"];

    var columns = Enumerable.From(metaDefinition.Columns).Select(function (x) { return x.ColumnName.toString() }).ToArray();
    var result = Enumerable.From(candidates).Except(columns).ToArray();
    return result.length === 0;
};

function isCardView() {
    var kanban = $('div[data-target="kanban"]');
    return kanban.is(":visible");
};
