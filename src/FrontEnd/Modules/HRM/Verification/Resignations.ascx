<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Resignations.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Verification.Resignations" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = window.Resources.Titles.VerifyResignations();

    scrudFactory.viewAPI = "/api/hrm/resignation-verification-scrud-view";
    scrudFactory.viewTableName = "hrm.resignation_verification_scrud_view";

    scrudFactory.formAPI = "/api/hrm/resignation";
    scrudFactory.formTableName = "hrm.resignations";

    scrudFactory.hasVerfication = true;
    scrudFactory.excludedColumns = ["Photo"];
</script>


<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
