function addKanban() {
    $("#KanbanForm").modal("show");
};

function deleteKanban(el) {
    function ajax(kanbanId) {
        var url = "/api/core/kanban/delete/" + kanbanId;
        return getAjaxRequest(url, "DELETE");
    };

    el = $(el);
    var label = el.parent().parent().find(".label");
    var kanbanId = parseInt(label.attr("data-kanban-id"));

    if (kanbanId) {
        var confirmed = confirmAction();

        if (!confirmed) {
            return;
        };

        var request = ajax(kanbanId);

        request.success(function () {
            refreshKanbans();
        });
    };
};

function editKanban(el) {
    el = $(el);
    var label = el.parent().parent().find(".left.label");

    var kanbanId = parseInt(label.attr("data-kanban-id"));
    var kanbanName = label.text();
    var description = label.attr("title");


    if (kanbanId) {
        $("#KanbanIdInputText").val(kanbanId);
        $("#KanbanNameInputText").val(kanbanName);
        $("#KanbanDescriptionTextArea").val(description);

        $("#KanbanForm").modal("show");
    };
};

function saveOrUpdateKanban() {
    function request(k) {
        var url = "/api/core/kanban/add-or-edit";

        var form = [];
        form.push(k);
        form.push(null);

        var data = JSON.stringify(form);
        return getAjaxRequest(url, "POST", data);
    };

    var kanbanIdInputText = $("#KanbanIdInputText");
    var kanbanNameInputText = $("#KanbanNameInputText");
    var kanbanDescriptionTextArea = $("#KanbanDescriptionTextArea");

    if (isNullOrWhiteSpace(kanbanNameInputText.val())) {
        makeDirty(kanbanNameInputText);
        return;
    };

    removeDirty(kanbanNameInputText);

    var kanban = new Object();
    kanban.kanban_id = (kanbanIdInputText.val() || null);
    kanban.object_name = scrudFactory.viewTableName;
    kanban.user_id = window.userId;
    kanban.kanban_name = kanbanNameInputText.val();
    kanban.description = kanbanDescriptionTextArea.val();

    var ajax = request(kanban);

    ajax.success(function () {
        $("#KanbanForm").modal("hide");
        refreshKanbans();
    });
};
