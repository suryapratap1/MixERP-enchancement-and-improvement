function getPrimaryKeyIndex(collection) {
    var pki;

    $.each(collection, function(i, v) {
        if (v.IsPrimaryKey) {
            pki = i;
        };
    });

    return pki;
};

function createLayout(collection, container) {
    var skip = [];

    if (!scrudFactory.layout) {
        scrudFactory.layout = [];
    };

    $.each(scrudFactory.layout, function() {
        var layoutMember = this;
        var tab = layoutMember.tab;
        var fields = layoutMember.fields;
        var target = container;

        if (tab) {
            var selector = "#tab-" + tab;
            target = $(selector);

            if (!target.length) {
                target = container;
            };
        };

        if (typeof (fields) !== "undefined") {
            $.each(fields, function (i, currentLayout) {
                var actualColumns = _.uniq(currentLayout);
                var fieldWith = 16 / currentLayout.length;

                var fields = $("<div class='fields' />");

                $.each(actualColumns, function (index, property) {
                    var value = _.findIndex(collection, { "PropertyName": property });

                    if (value >= 0) {
                        skip.push(value);

                        var weight = currentLayout.reduce(function (x, y) {
                            return x + (y === property);
                        }, 0);

                        var cssClass = semanticGrid[fieldWith * weight] + " wide field";

                        createFieldGroup(fields, collection[value], cssClass);
                    };

                });

                if (fields.children().length > 0) {
                    target.append(fields);
                };
            });
        };
    });



    var range = _.range(collection.length);
    var missing = $(range).not(skip).get();

    if (scrudFactory.hidePrimaryKey) {
        var pki = getPrimaryKeyIndex(collection);
        missing = Enumerable.From(missing).Where(function (x) { return parseInt(x || 0) !== pki; }).ToArray();
        missing.push(pki);
    };


    missing = window.chunk_array(missing, 2);


    $.each(missing, function () {
        fields = $("<div class='fields' />");
        createFieldGroup(fields, collection[this[0]], "four wide field");

        if (this[1] !== undefined) {
            createFieldGroup(fields, collection[this[1]], "four wide field");
        };

        if (fields.children().length > 0) {
            container.append(fields);
        };
    });



    initializeAjaxRequest();
    initializeUploader();

    function displayLive(val) {
        if (!val.length) {
            $(".huge.header .sub.header").html("");
            $("span.live").html("");
            $(".initial.value").html(window.formTitle);
        } else {
            $(".huge.header .sub.header").html(window.formTitle);            
            $(".initial.value").html("");
            $("span.live").html(val);
        };
    }

    $("input.live").keyup(function () {
        displayLive($(this).val());
    });

    $("select.live").change(function () {
        displayLive($(this).getSelectedText());
    });

    $("input.live").trigger("keyup");
};