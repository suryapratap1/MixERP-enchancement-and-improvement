function makeRatable() {
    $('.ui.rating').rating();

    function request(kanbanDetail) {
        var url = "/api/core/kanban-detail/add-or-edit";

        var form = [];
        form.push(kanbanDetail);
        form.push(null);

        var data = JSON.stringify(form);

        return getAjaxRequest(url, "POST", data);
    };

    $('.ui.rating i').dblclick(function () {
        var el = $(this);
        var card = el.parent().parent().parent();
        var kanbanDetailId = card.attr("data-kanban-detail-id");

        if (kanbanDetailId) {
            var kanbanDetail = new Object();
            kanbanDetail.kanban_detail_id = kanbanDetailId;
            kanbanDetail.kanban_id = card.closest(".segment").attr("id").replace("kanban", "");
            kanbanDetail.resource_id = card.attr("data-key");
            kanbanDetail.rating = el.parent().find("i.active").length;

            request(kanbanDetail);
        };
    });
};
