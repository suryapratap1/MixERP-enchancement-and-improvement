var candidates = {
    primary: ["Code", "Number", "Name"],
    secondary: [
        "Party", "PartyName", "Item", "ItemName",
        "Employee",
        "EmployeeName", "EmployeeCode", "Office", "CurrencyCode",
        "Reason", "NoticeDate", "ApprovedOn"
    ]
};

function getQualified(dynamic, prefix, suffixes) {
    var qualified = "";

    $.each(suffixes, function (i, v) {
        if (!qualified) {
            var candidate = prefix + v;

            if (dynamic.hasOwnProperty(candidate)) {
                qualified = candidate;
                return false;
            };
        };
    });

    return qualified;
};

function getExtraContent(key) {
    var extraContent = $('<div class="extra center content" />');

    var buttons = $('<div class="ui small basic buttons" />');

    if (scrudFactory.viewUrl) {
        var url = scrudFactory.viewUrl.replace("{Key}", key);
        var viewButton = $('<a class="ui basic button" />');
        viewButton.attr("href", url);
        viewButton.text(Resources.Titles.View());
        buttons.append(viewButton);
    };

    if (scrudFactory.allowEdit) {
        var editButton = $('<a class="ui basic button" href="javascript:void(0);" onclick="editRow(this, true);" />');
        editButton.text(Resources.Titles.Edit());
        buttons.append(editButton);
    }

    if (scrudFactory.allowDelete) {
        var deleteButton = $('<a class="ui basic button" href="javascript:void(0);" onclick="deleteRow(this, true);" />');
        deleteButton.text(Resources.Titles.Delete());
        buttons.append(deleteButton);
    };


    extraContent.append(buttons);

    return extraContent;
};

function getExtra(kanbanDetail) {
    var extra = $('<div class="extra" />');

    var text = $("<span />");
    text.text(Resources.Titles.Rating());
    extra.append(text);

    var dataRating = (kanbanDetail.Rating || 0);

    var rating = $('<div class="ui star rating" data-max-rating="5" />');
    rating.attr("data-rating", dataRating);

    extra.append(rating);


    return extra;
};

function getHeaderField(dynamic) {
    var className = getClassName();

    var primary = candidates.primary;
    var qualified = getQualified(dynamic, className, primary);

    if (!qualified) {
        var secondary = candidates.secondary;

        qualified = getQualified(dynamic, "", secondary);
    };

    return qualified;
};

function getMetaField(dynamic, headerField) {
    var className = getClassName();

    var primary = Enumerable.From(candidates.primary)
        .Where(function (x) { return x !== headerField.replace(className, "") })
        .ToArray();

    var qualified = getQualified(dynamic, className, primary);

    if (!qualified) {
        var secondary = Enumerable.From(candidates.secondary)
            .Where(function (x) { return x !== headerField })
            .ToArray();

        qualified = getQualified(dynamic, "", secondary);
    };

    return qualified;
};

function getIdField() {
    var className = getClassName();
    return className + "Id";
};

function getCardKey(dynamic) {
    var keyField = (scrudFactory.card.keyField || getIdField());
    return dynamic[keyField];
};

function getImageField(entity) {
    var imageField;

    $.each(entity, function (i) {
        if (!imageField) {
            if (i.toLowerCase().indexOf("image") !== -1) {
                imageField = i;
            };
        };

        if (!imageField) {
            if (i.toLowerCase().indexOf("logo") !== -1) {
                imageField = i;
            };
        };

        if (!imageField) {
            if (i.toLowerCase().indexOf("photo") !== -1) {
                imageField = i;
            };
        };
    });

    return imageField;
};

function getDescriptionField(entity) {
    var candidates = ["Email", "Url", "City", "Phone", "CompanyName", "Currency"];
    return getQualified(entity, "", candidates);
};

function getCardField(card, field) {
    var isExpression = field.substring(2, 0) === "{{" && field.slice(-2) === "}}";
    if (isExpression) {
        var expression = field.replace("{{", "").replace("}}", "");
        return eval(expression);
    };

    return card[field];
};

function createCard(dynamic, key, kanbanDetail) {
    var kanbanId = (kanbanDetail.KanbanId || 0);

    var text;
    var imageField = (scrudFactory.card.image || getImageField(dynamic));
    var headerField = (scrudFactory.card.header || getHeaderField(dynamic));
    var metaField = (scrudFactory.card.meta || getMetaField(dynamic, headerField));
    var descriptionField = (scrudFactory.card.description || getDescriptionField(dynamic));

    var card = $('<div class="ui card" />');
    card.attr("data-kanban-detail-id", kanbanDetail.KanbanDetailId);
    card.attr("data-key", key);


    if (imageField) {
        var src = getCardField(dynamic, imageField);
        if (src) {
            var image = $('<div class="image" />');
            var img = $("<img />");
            img.attr("src", "/api/core/attachment/document/300/250/" + src);

            image.append(img);
            card.append(image);
        };
    };

    var content = $('<div class="content" />');

    var checkbox = $('<div class="ui toggle checkbox" />');
    var input = $('<input name="public" type="checkbox">');

    checkbox.append(input);

    content.append(checkbox);

    if (headerField) {
        text = getCardField(dynamic, headerField);
        if (text) {
            var header = $('<div class="header" />');

            header.text(text);
            content.append(header);
        };
    };

    if (metaField) {
        text = getCardField(dynamic, metaField);
        if (text) {
            var meta = $('<div class="meta" />');

            meta.text(text);
            content.append(meta);
        };
    };

    if (descriptionField) {
        text = getCardField(dynamic, descriptionField);
        if (text) {
            var description = $('<div class="meta" />');

            description.text(text);
            content.append(description);
        };
    };

    card.append(content);
    card.append(getExtraContent(key));
    card.append(getExtra(kanbanDetail));

    $("#kanban" + kanbanId + " .kanban.holder").append(card);
    $(".checkbox").checkbox();
};