<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OfficeHours.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.OfficeHours" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title =  window.Resources.Titles.OfficeHours();
    
    scrudFactory.viewAPI = "/api/hrm/office-hour-scrud-view";
    scrudFactory.viewTableName = "hrm.office_hour_scrud_view";

    scrudFactory.formAPI = "/api/hrm/office-hour";
    scrudFactory.formTableName = "hrm.office_hours";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.live = "OfficeHourName";

    scrudFactory.keys = [
        {
            property: "OfficeId",
            url: '/api/office/office/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "ShiftId",
            url: '/api/hrm/shift/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "WeekDayId",
            url: '/api/core/week-day/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>


<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
