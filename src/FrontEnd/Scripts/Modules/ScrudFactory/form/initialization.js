var metaInfo;
var metaCustomFields;//custom fields
var saveButton = $("#SaveButton");
var scrud = $("#scrud");
var cancelButton = $("#CancelButton");
var scrudForm = $(".form.factory");
var scrudView = $(".view.factory");
var editData;
var dropdownsLoaded = false;
var defaultValuesLoaded = false;
var formReady = false;

if (typeof (scrudFactory.hidePrimaryKey) ==="undefined") {
    scrudFactory.hidePrimaryKey = false;
};

if (typeof (scrudFactory.tabs) === "undefined") {
    scrudFactory.tabs = [];
};

var formTitle = scrudFactory.title;

var titleSuffix = getQueryStringByName("TitleSuffix");

if(titleSuffix){
    formTitle += " / " + titleSuffix;
};

createTabs();

function createTabEls(tabId, name, active) {
    var item = $("<a class='item' />");
    var tab = $("<div class='ui tab form' />");

    if (active) {
        item.addClass("active");
        tab.addClass("active");
    };

    item.attr("data-tab", tabId);
    tab.attr("data-tab", tabId);

    tab.attr("id", "tab-" + tabId);

    item.html(name);


    $("#scrud-tab-menus").append(item);
    $("#scrud-tab-members").append(tab);


    $(".ui.tabular.menu .item").tab();    
};

function createTabs() {
    var sorted = Enumerable.From(scrudFactory.tabs).OrderBy(function (x) { return x.sort; }).ToArray();

    $.each(sorted, function () {
        createTabEls(this.id, this.name, this.active);
    });
};

