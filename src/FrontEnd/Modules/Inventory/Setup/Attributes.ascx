<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Attributes.ascx.cs" Inherits="MixERP.Net.Core.Modules.Inventory.Setup.Attributes" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.Attributes();

    scrudFactory.viewAPI = "/api/core/attribute";
    scrudFactory.viewTableName = "core.attributes";

    scrudFactory.formAPI = "/api/core/attribute";
    scrudFactory.formTableName = "core.attributes";
    scrudFactory.live = "AttributeName";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
</script>

<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
