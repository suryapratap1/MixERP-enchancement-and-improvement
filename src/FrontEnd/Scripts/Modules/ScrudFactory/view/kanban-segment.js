var kanbanTemplate = '<div id="kanban{KanbanId}" class="ui segment">\
                    <span class="ui teal left large label" data-kanban-id="{KanbanId}" title="{Description}">{KanbanName}</span>\
                    <div class="ui right floated tiny basic icon buttons">\
                        <a title="{AddNewCheckListLocalized}" class="ui basic button" href="javascript:void(0);" onclick="addKanban();"><i class="add icon"></i></a>\
                        <a title="{EditThisCheckListLocalized}" class="ui basic button" href="javascript:void(0);" onclick="editKanban(this);"><i class="edit icon"></i></a>\
                        <a title="{DeleteThisCheckListLocalized}" class="ui basic button" href="javascript:void(0);" onclick="deleteKanban(this);"><i class="delete icon"></i></a>\
                    </div>\
                    <div class="ui clearing padded divider"></div> \
                    <div class="kanban holder"></div> \
                </div>';

function createKanbanSegment(kanban) {
    var local = kanbanTemplate;
    local = local.replace(/{KanbanId}/g, kanban.KanbanId);
    local = local.replace(/{KanbanName}/g, kanban.KanbanName);
    local = local.replace(/{Description}/g, kanban.Description);
    local = local.replace("{AddNewCheckListLocalized}", window.Resources.Titles.AddNewChecklist());
    local = local.replace("{EditThisCheckListLocalized}", window.Resources.Titles.EditThisChecklist());
    local = local.replace("{DeleteThisCheckListLocalized}", window.Resources.Titles.DeleteThisChecklist());

    var el = $(local);

    $("#kanban").append(el);
};

function createKanbans(kanbans) {
    $("#kanban").html("");

    var kanban = new Object();
    kanban.KanbanId = "0";
    kanban.KanbanName = Resources.Titles.Untitled();
    createKanbanSegment(kanban);

    $.each(kanbans, function (i, kanban) {
        createKanbanSegment(kanban);
    });

    createCards();
};

function getKanbans() {
    var url = "/api/core/kanban/get-where/1";

    var filters = [];
    filters.push(getAjaxColumnFilter("WHERE", "object_name", FilterConditions.IsEqualTo, scrudFactory.viewTableName));
    filters.push(getAjaxColumnFilter("WHERE", "user_id", FilterConditions.IsEqualTo, window.userId));

    var data = JSON.stringify(filters);

    return getAjaxRequest(url, "POST", data, false);
};

function isKanban() {
    var target = window.getQueryStringByName("View");
    return target.toLowerCase() === "kanban";
};

function refreshKanbans() {
    var ajax = getKanbans();

    ajax.success(function (response) {
        window.kanbans = response;

        if (!window.kanbans.length) {
            if (!isKanban()) {
                var defaultView = window.getQueryStringByName("View") || "grid";
                showView(defaultView);
            };
        };

        createKanbans(response);
    });
};
