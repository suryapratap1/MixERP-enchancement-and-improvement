<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Countries.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Countries" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.Countries();

    scrudFactory.viewAPI = "/api/core/country-scrud-view";
    scrudFactory.viewTableName = "core.country_scrud_view";
    scrudFactory.removeKanban = true;

    scrudFactory.formAPI = "/api/core/country";
    scrudFactory.formTableName = "core.countries";
    scrudFactory.live = "CountryName";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
</script>
<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
