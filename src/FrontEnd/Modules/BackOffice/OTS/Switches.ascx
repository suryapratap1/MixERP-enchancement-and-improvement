<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Switches.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.OTS.Switches" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.Switches();

    scrudFactory.viewAPI = "/api/config/switch-scrud-view";
    scrudFactory.viewTableName = "config.switch_scrud_view";

    scrudFactory.formAPI = "/api/config/switch";
    scrudFactory.formTableName = "config.switches";
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
