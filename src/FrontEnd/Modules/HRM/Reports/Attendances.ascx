<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Attendances.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Reports.Attendances" %>
<style>
    .red.vis-box {
        background-color: #F6D5E7;
        color: #8A0F88;
        border-color: #8A0F88;
    }
</style>
<script src="https://cdnjs.cloudflare.com/ajax/libs/vis/4.8.2/vis.min.js" type="text/javascript"></script>
<link rel="stylesheet" type="text/css" href="https://cdnjs.cloudflare.com/ajax/libs/vis/4.8.2/vis.min.css" />


<div class="ui huge grey header">
<span data-localize="Titles.Attendances"></span>
</div>
<div class="ui active large inline loader"></div>

<div id="visualization" class="vpad8" style="display: none;"></div>

<script>
    function getAttendance() {
        var url = "/api/hrm/attendance-view/all";

        return window.getAjaxRequest(url);
    };

    function show() {
    };
    var employeeId = $("#EmployeeSelect").val();

    var getAttendanceAjax = getAttendance(employeeId);

    getAttendanceAjax.success(function (msg) {
        if (msg.length) {
            createTimeLine(msg);
        };
    });

</script>
<script>
    function createTimeLine(data) {
        var employeeGroup = window.Enumerable.From(data).GroupBy(function (x) { return x.EmployeeId; }).ToArray();
        var min = window.Enumerable.From(data).MinBy(function (x) { return x.AttendanceDate; }).AttendanceDate;
        var max = window.Enumerable.From(data).MaxBy(function (x) { return x.AttendanceDate; }).AttendanceDate;


        var groups = new window.vis.DataSet();

        for (var g = 0; g < employeeGroup.length; g++) {
            groups.add(
                {
                    id: employeeGroup[g].source[0].EmployeeId,
                    content: employeeGroup[g].source[0].Employee,
                    title: employeeGroup[g].source[0].Photo
                });
        };

        // create a dataset with items
        var items = new window.vis.DataSet();

        for (var i = 0; i < data.length / employeeGroup.length; i++) {
            var content = data[i].WasPresent ? "P" : "A";
            var className = data[i].WasPresent ? "" : "red";

            items.add({
                id: i,
                group: data[i].EmployeeId,
                content: content,
                start: data[i].AttendanceDate,
                type: 'box',
                className: className
            });
        };

        // create visualization
        var container = document.getElementById('visualization');
        $(container).html("");

        var options = {
            groupOrder: 'content',  // groupOrder can be a property name or a sorting function
            orientation: {
                axis: 'both',
                item: 'top'
            },
            min: min,
            max: max,
            zoomMin: 1000 * 60 * 60 * 24,             // one day in milliseconds
            zoomMax: 1000 * 60 * 60 * 24 * 31 * 3     // about three months in milliseconds
        };

        var timeline = new window.vis.Timeline(container);
        timeline.setOptions(options);
        timeline.setGroups(groups);
        timeline.setItems(items);

        var labels = $(".vis-label");
        labels.each(function () {
            var el = $(this);
            var inner = el.find(".vis-inner");

            var photo = el.attr("title");
            el.removeAttr("title");

            var header = $("<div class='ui big grey header' />");
            header.html(inner.html());

            var img = $("<img />");

            img.attr("class", "ui small centered rounded circular bordered image");
            img.attr("title", inner.html());
            img.attr("src", "/api/core/attachment/document/400/400/" + photo);

            inner.addClass("ui attached secondary segment");
            inner.prepend(img);
        });

        $(".loader").removeClass("active");
        $(container).fadeIn(1000);
    };

</script>
