<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BankAccounts.ascx.cs" Inherits="MixERP.Net.Core.Modules.Finance.Setup.BankAccounts" %>

<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.BankAccounts();
    scrudFactory.viewAPI = "/api/core/bank-account-scrud-view";
    scrudFactory.viewTableName = "core.bank_accounts";

    scrudFactory.formAPI = "/api/core/bank-account";
    scrudFactory.formTableName = "core.bank_accounts";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];
    scrudFactory.hiddenColumns = ["BankAccountId"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.layout = [
        {
            tab: "",
            fields: [
                ["AccountId", ""],
                ["BankName", "BankBranch", "", ""],
                ["OfficeId", "MaintainedByUserId", "", ""],
                ["BankAccountNumber", "BankContactNumber", "", ""],
                ["BankAddress", ""],
                ["BankAccountType", "RelationshipOfficerName","",""]
            ]
        }
    ];

    scrudFactory.keys = [
        {
            property: "MaintainedByUserId",
            url: '/api/office/user-selector-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "AccountId",
            url: '/api/core/bank-account-selector-view/display-fields',
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

    scrudFactory.live = "BankAccountNumber";
</script>


<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
