<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Roles.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Roles" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.Roles();

    scrudFactory.viewAPI = "/api/office/role-scrud-view";
    scrudFactory.viewTableName = "office.role_scrud_view";

    scrudFactory.formAPI = "/api/office/role";
    scrudFactory.formTableName = "office.roles";
    scrudFactory.live = "RoleName";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
</script>
<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
