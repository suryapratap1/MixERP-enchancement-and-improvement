<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Departments.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Departments" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.Departments();

    scrudFactory.viewAPI = "/api/office/department-scrud-view";
    scrudFactory.viewTableName = "office.department_scrud_view";

    scrudFactory.formAPI = "/api/office/department";
    scrudFactory.formTableName = "office.departments";
    scrudFactory.live = "DepartmentName";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
</script>
<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
