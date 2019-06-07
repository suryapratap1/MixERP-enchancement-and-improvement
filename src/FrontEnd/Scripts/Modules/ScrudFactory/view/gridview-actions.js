function getActions(actions) {
    if (!actions.length) {
        return "";
    };

    var els = $("<div />");

    $.each(actions, function (i, v) {
        var anchor = $("<a />");
        var href = "javascript:void(0);";

        if (v.title) {
            anchor.attr("title", v.title);
        };

        if (v.href) {
            href = v.href;
        };

        anchor.attr("href", href);

        if (v.onclick) {
            anchor.attr("onclick", v.onclick);
        };

        if (v.icon) {
            var icon = $("<i />");
            icon.addClass(v.icon);
            anchor.append(icon);
        };

        els.append(anchor);
    });

    return els.html();
};

function loadActions() {
    var deleteTemplate = "";
    var editTemplate = "";

    if (scrudFactory.allowDelete) {
        deleteTemplate = stringFormat("<a onclick='deleteRow(this);' title='{0}'><i class='delete icon'></i></a>", Resources.Titles.Delete());
    };

    if (scrudFactory.allowEdit) {
        editTemplate = stringFormat("<a onclick='editRow(this);' title='{0}'><i class='edit icon'></i></a>", Resources.Titles.Edit());
    };

    var grid = $(".scrudview.table");

    var actionCount = (!isNullOrWhiteSpace(editTemplate) + !isNullOrWhiteSpace(deleteTemplate));

    if (scrudFactory.customActions) {
        actionCount += scrudFactory.customActions.length;
    };


    var header = stringFormat("<th style='width:{0}px;'>{1}</th>", actionCount * 25, Resources.Titles.Actions());
    header += "<th class='action' style='cursor:pointer;'>" + Resources.Titles.Select() + "</th>";
    var selectTemplate = '<div class="ui toggle checkbox"> \
                                      <input type="checkbox">\
                                      <label></label>\
                                    </div>';

    var actions = editTemplate + deleteTemplate;

    if (scrudFactory.customActions) {
        var preActions = Enumerable.From(scrudFactory.customActions).Where(function (x) { return x.position === "before"; }).ToArray();
        var postActions = Enumerable.From(scrudFactory.customActions).Where(function (x) { return x.position !== "before"; }).ToArray();

        actions = getActions(preActions) + actions + getActions(postActions);
    };



    var actionTemplate = stringFormat("<td>{0}</td><td>{1}</td>", actions, selectTemplate);

    grid.find("th:first-child").before(header);


    grid.find("tbody tr").each(function () {
        var el = $(this);
        var value = el.find("td:first-child").html();
        var template = actionTemplate.replace(/{id}/g, value);

        var titleSuffix = actionTemplate.match("TitleSuffix={col:(.*)}");

        if(titleSuffix){
            var position = parseInt(titleSuffix.pop() || 0);
            var selector = "td:nth-child(" + (position - 2) + ")";
            var suffix = el.find(selector).html();
            var find = "TitleSuffix={col:" + position + "}";
            var replace = "TitleSuffix=" + suffix;

            template = template.replace(find, replace);
        };

        el.find("td:first-child").before(template);
    });

    $(".scrudview.table tr").click(function (sender) {
        var row = $(this);
        var cell = $(sender.target).closest('td');

        if (cell.index() > 1) {
            var el = row.find("input:checkbox");
            toogleSelection(el);
        };
    });

    var isSelectionToggler = true;

    $("th.action").click(function () {
        if (isSelectionToggler) {
            $(".scrudview.table input:checkbox").prop("checked", "checked");
        }
        else {
            $(".scrudview.table input:checkbox").removeProp("checked");
        };

        isSelectionToggler = !isSelectionToggler;
    });
};