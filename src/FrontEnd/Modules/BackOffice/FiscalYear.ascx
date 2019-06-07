<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FiscalYear.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.FiscalYear" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.FiscalYear();

    scrudFactory.viewAPI = "/api/core/fiscal-year-scrud-view";
    scrudFactory.viewTableName = "core.fiscal_year_scrud_view";
    scrudFactory.removeKanban = true;

    scrudFactory.formAPI = "/api/core/fiscal-year";
    scrudFactory.formTableName = "core.fiscal_year";
    scrudFactory.live = "FiscalYearName";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
</script>
<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
