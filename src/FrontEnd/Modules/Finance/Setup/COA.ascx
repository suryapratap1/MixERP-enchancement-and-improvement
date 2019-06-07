<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="COA.ascx.cs" Inherits="MixERP.Net.Core.Modules.Finance.Setup.COA" %>
<script src="/Scripts/underscore/underscore-min.js"></script>
<script>
    var scrudFactory = new Object();
    scrudFactory.title = window.Resources.Titles.ChartOfAccounts();

    scrudFactory.viewAPI = "/api/core/account-scrud-view";
    scrudFactory.viewTableName = "core.account_scrud_view";

    scrudFactory.formAPI = "/api/core/account";
    scrudFactory.formTableName = "core.accounts";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.layout = [
        {
            tab: "",
            fields: [
                ["AccountId", ""],
                ["AccountMasterId", ""],
                ["AccountNumber", "AccountName", "", ""]
            ]
        }
    ];

    scrudFactory.live = "AccountName";
    scrudFactory.queryStringKey = "AccountId";

    scrudFactory.keys = [
        {
            property: "AccountMasterId",
            url: '/api/core/account-master/display-fields',
            data: null,
            isArray:false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CurrencyCode",
            url: '/api/core/currency/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "ParentAccountId",
            url: '/api/core/account/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        }
    ];


</script>

<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
