function docready() {
    window.scrudForm = $(".form.factory");
    window.scrudView = $(".view.factory");

    var defaultView = window.getQueryStringByName("View");

    if ((defaultView || "") === "FormView") {
        scrudView.hide();
    };


    loadMeta(loadFilterNames);
    loadFilterConditions();
    $("#ExportDropDown").dropdown();

    if (scrudFactory.title) {
        $(".title").html(scrudFactory.title);

        var titleSuffix = getQueryStringByName("TitleSuffix");
        if(titleSuffix){
            $(".title").append(" / " + titleSuffix);
        };
    };
    if (scrudFactory.description) {
        $("#description").html(scrudFactory.description).show();
    } else {
        $("#description").remove();
    };

    if (typeof (scrudFactory.back) === "object") {
        var title = scrudFactory.back.Title;
        var url = scrudFactory.back.Url;

        var anchor = $("<a/>");
        anchor.addClass("ui basic button");
        anchor.attr("title", Resources.Titles.Back());
        anchor.attr("href", url);
        anchor.text(title);

        $("#AddNewButton").before(anchor);
    };

    initializeViews();
    initializeCustomButtons();

    var view = getQueryStringByName("View");
    if (view) {
        showTarget(view);
    };

    $(".kanban.segments").css("width", (($(".segment").length - 1) * 300) + "px").fadeIn(500);
    refreshKanbans();
};

$(document).ready(function () {
    docready();
});
