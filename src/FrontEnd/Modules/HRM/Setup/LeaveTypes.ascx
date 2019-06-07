<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LeaveTypes.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.LeaveTypes" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title =  window.Resources.Titles.LeaveTypes();

    scrudFactory.viewAPI = "/api/hrm/leave-type";
    scrudFactory.viewTableName = "hrm.leave_types";

    scrudFactory.formAPI = "/api/hrm/leave-type";
    scrudFactory.formTableName = "hrm.leave_types";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.layout = [
        {
            tab: "",
            fields: [
                ["LeaveTypeId", ""],
                ["LeaveTypeCode", "LeaveTypeName", "", ""],
                ["Description", ""]
            ]
        }
    ];


    scrudFactory.live = "LeaveTypeName";
</script>


<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
