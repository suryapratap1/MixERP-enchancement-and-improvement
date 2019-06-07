<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DatabaseParameters.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.OTS.DatabaseParameters" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.DatabaseParameters();

    scrudFactory.viewAPI = "/api/config/db-parameter-scrud-view";
    scrudFactory.viewTableName = "config.db_parameter_scrud_view";

    scrudFactory.formAPI = "/api/config/db-parameter";
    scrudFactory.formTableName = "config.db_parameters";
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
