function getPrimaryKeyValue(sender, isCard) {
    if (!isCard) {
        if (isCardView()) {
            var kanban = $('div[data-target="kanban"]');
            var selected = kanban.find("input:checked:first-child");
            isCard = true;
            sender = selected;
        };
    };


    if (isCard) {
        var card = sender.closest(".card");
        return card.attr("data-key");
    };

    var selector = "td:nth-child(" + getKeyColumnPosition() + ")";
    var primaryKeyValue = sender.closest("tr").find(selector).text();
    return primaryKeyValue;
};