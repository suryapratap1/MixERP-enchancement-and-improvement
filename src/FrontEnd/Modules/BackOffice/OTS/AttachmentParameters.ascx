<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AttachmentParameters.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.OTS.AttachmentParameters" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.AttachmentParameters();

    scrudFactory.viewAPI = "/api/config/attachment-factory-scrud-view";
    scrudFactory.viewTableName = "config.attachment_factory_scrud_view";

    scrudFactory.formAPI = "/api/config/attachment-factory";
    scrudFactory.formTableName = "config.attachment_factory";
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
