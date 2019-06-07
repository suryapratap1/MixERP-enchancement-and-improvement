<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LeaveApplications.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Verification.LeaveApplications" %>

<script>
    var scrudFactory = new Object();

    scrudFactory.title = window.Resources.Titles.VerifyLeaveApplications();

    scrudFactory.viewAPI = "/api/hrm/leave-application-verification-scrud-view";
    scrudFactory.viewTableName = "hrm.leave_application_verification_scrud_view";

    scrudFactory.formAPI = "/api/hrm/leave-application";
    scrudFactory.formTableName = "hrm.leave_applications";

    scrudFactory.excludedColumns = ["Photo"];

    scrudFactory.hasVerfication = true;
</script>


<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
