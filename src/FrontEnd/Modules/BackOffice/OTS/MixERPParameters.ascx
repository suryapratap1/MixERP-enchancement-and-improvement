<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MixERPParameters.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.OTS.MixERPParameters" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.MixERPParameters();

    scrudFactory.viewAPI = "/api/config/mixerp-scrud-view";
    scrudFactory.viewTableName = "config.mixerp_scrud_view";

    scrudFactory.formAPI = "/api/config/mixerp";
    scrudFactory.formTableName = "config.mixerp";
    scrudFactory.removeKanban = true;
    scrudFactory.removeFilter = true;
    scrudFactory.removeImport = true;

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];
    scrudFactory.hidePrimaryKey = false;

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
</script>
<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
