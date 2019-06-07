var widgets;
var url;
var data;

$(document).ready(function () {
    var selectedWidgets = $(".selected-widgets .widget");
    var otherWidgets = $(".other-widgets .widget");

    selectedWidgets.each(function () {
        $(this).find(".segment:last-child").append("<div class='vpad8'><div class='ui delete button '>" + Resources.Titles.Delete() + "</div><div>");
    });

    otherWidgets.each(function () {
        $(this).find(".segment:last-child").append("<div class='vpad8'><div class='ui add button'>" + Resources.Titles.Add() + "</div><div>");
    });


    $(".add.button").click(function () {
        if (!confirmAction()) {
            return;
        };

        var order = $(".delete.button").length + 1;
        var group = $("#WidgetDropDownList").getSelectedText();
        var widget = $(this).closest(".widget").attr("id");

        var ajaxAddWidget = addWidget(order, group, widget);

        ajaxAddWidget.success(function () {
            window.location = window.location.href.split('?')[0] + "?Group=" + group;
        });

        ajaxAddWidget.fail(function (xhr) {
            logAjaxErrorMessage(xhr);
        });
    });

    $(".delete.button").click(function () {
        if (!confirmAction()) {
            return;
        };

        var group = $("#WidgetDropDownList").getSelectedText();
        var widget = $(this).closest(".widget").attr("id");

        var ajaxDeleteWidget = deleteWidget(group, widget);

        ajaxDeleteWidget.success(function () {
            window.location = window.location.href.split('?')[0] + "?Group=" + group;
        });

        ajaxDeleteWidget.fail(function (xhr) {
            logAjaxErrorMessage(xhr);
        });
    });

});

$("#ShowButton").click(function () {
    var group = $("#WidgetDropDownList").getSelectedText();

    window.location = window.location.href.split('?')[0] + "?Group=" + group;
});

$("#SavePositionButton").click(function () {
    if (!confirmAction()) {
        return;
    };

    var items = $("#sortable-container").find(".widget");
    var widgets = [];

    var i = 0;
    items.each(function () {
        i++;
        var widget = new Object();

        widget.WidgetOrder = i;
        widget.WidgetGroupName = $("#WidgetDropDownList").getSelectedText();
        widget.WidgetName = this.id;

        widgets.push(widget);
    });


    var ajaxOrderWidgets = orderWidgets(widgets);

    ajaxOrderWidgets.success(function () {
        window.location = window.location.href;
    });

    ajaxOrderWidgets.fail(function (xhr) {
        logAjaxErrorMessage(xhr);
    });
});


function addWidget(order, group, widget) {
    url = "/Services/WidgetManager.asmx/AddWidget";
    data = appendParameter("", "order", order);
    data = appendParameter(data, "group", group);
    data = appendParameter(data, "widget", widget);

    data = getData(data);

    return getAjax(url, data);
};

function deleteWidget(group, widget) {
    url = "/Services/WidgetManager.asmx/RemoveWidget";
    data = appendParameter("", "group", group);
    data = appendParameter(data, "widget", widget);

    data = getData(data);

    return getAjax(url, data);
};

function orderWidgets(widgets) {
    url = "/Services/WidgetManager.asmx/OrderWidgets";
    data = appendParameter("", "widgets", widgets);

    data = getData(data);

    return getAjax(url, data);
};
