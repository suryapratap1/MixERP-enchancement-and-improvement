<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CostCenters.ascx.cs" Inherits="MixERP.Net.Core.Modules.Finance.Setup.CostCenters" %>

<script src="/Scripts/underscore/underscore-min.js"></script>
<script>
    var scrudFactory = new Object();
    scrudFactory.title = window.Resources.Titles.CostCenters();

    scrudFactory.viewAPI = "/api/office/cost-center-scrud-view";
    scrudFactory.viewTableName = "office.cost_center_scrud_view";

    scrudFactory.formAPI = "/api/office/cost-center";
    scrudFactory.formTableName = "office.cost_centers";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.live = "CostCenterName";
    scrudFactory.queryStringKey = "AccountId";
</script>

<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
