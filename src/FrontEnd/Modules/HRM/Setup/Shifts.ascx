<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Shifts.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.Shifts" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title =  window.Resources.Titles.Shifts();

    scrudFactory.viewAPI = "/api/hrm/shift";
    scrudFactory.viewTableName = "hrm.shifts";

    scrudFactory.formAPI = "/api/hrm/shift";
    scrudFactory.formTableName = "hrm.shifts";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.layout = [
        {
            tab: "",
            fields: [
                ["ShiftId", ""],
                ["ShiftCode", "ShiftName", "", ""],
                ["BeginsFrom", "EndsOn", "", ""],
                ["Description", ""]
            ]
        }
    ];

    scrudFactory.live = "ShiftName";
</script>
<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
