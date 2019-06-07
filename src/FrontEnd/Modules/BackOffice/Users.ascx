<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Users.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Users" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.Users();

    scrudFactory.viewAPI = "/api/office/user-view";
    scrudFactory.viewTableName = "office.user_view";
    scrudFactory.removeKanban = true;

    scrudFactory.formAPI = "/api/office/user";
    scrudFactory.formTableName = "office.users";
    scrudFactory.live = "UserName";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];
    scrudFactory.disabledOnEdit = ["Password", "UserName"];
    scrudFactory.queryStringKey = "UserId";

    scrudFactory.allowDelete = window.metaView.IsAdmin;
    scrudFactory.allowEdit = window.metaView.IsAdmin;

    scrudFactory.keys = [
        {
            property: "OfficeId",
            url: '/api/office/office-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "RoleId",
            url: '/api/office/role-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "DepartmentId",
            url: '/api/office/department-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "StoreId",
            url: '/api/office/store-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>
<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
