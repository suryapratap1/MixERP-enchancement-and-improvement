<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LeaveBenefits.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.LeaveBenefits" %>
<script>
    var scrudFactory = new Object();
    
    scrudFactory.title =  window.Resources.Titles.LeaveBenefits();
    
    scrudFactory.viewAPI = "/api/hrm/leave-benefit";
    scrudFactory.viewTableName = "hrm.leave_benefits";

    scrudFactory.formAPI = "/api/hrm/leave-benefit";
    scrudFactory.formTableName = "hrm.leave_benefits";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.live = "LeaveBenefitName";
</script>


<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
