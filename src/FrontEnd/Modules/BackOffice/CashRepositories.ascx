<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CashRepositories.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.CashRepositories" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.CashRepositories();

    scrudFactory.viewAPI = "/api/office/cash-repository-scrud-view";
    scrudFactory.viewTableName = "office.cash_repository_scrud_view";

    scrudFactory.formAPI = "/api/office/cash-repository";
    scrudFactory.formTableName = "office.cash_repositories";
    scrudFactory.live = "CashRepositoryName";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.keys = [
        {
            property: "ParentCashRepositoryId",
            url: '/api/office/cash-repository-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "OfficeId",
            url: '/api/office/office-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>
<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
