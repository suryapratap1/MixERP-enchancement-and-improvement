<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Entities.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Entities" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.Entities();

    scrudFactory.viewAPI = "/api/core/entity-scrud-view";
    scrudFactory.viewTableName = "core.entity_scrud_view";

    scrudFactory.formAPI = "/api/core/entity";
    scrudFactory.formTableName = "core.entities";
    scrudFactory.live = "EntityName";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
</script>
<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
