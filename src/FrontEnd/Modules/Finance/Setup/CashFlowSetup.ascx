<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CashFlowSetup.ascx.cs" Inherits="MixERP.Net.Core.Modules.Finance.Setup.CashFlowSetup" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.CashFlowSetup();

    scrudFactory.viewAPI = "/api/core/cash-flow-setup-scrud-view";
    scrudFactory.viewTableName = "core.cash_flow_setup_scrud_view";

    scrudFactory.formAPI = "/api/core/cash-flow-setup";
    scrudFactory.formTableName = "core.cash_flow_setups";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.card = {
        header:"CashFlowHeading",
        meta : "AccountMaster"
    };

    scrudFactory.keys = [
        {
            property: "CashFlowHeadingId",
            url: '/api/core/cash-flow-heading/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "AccountMasterId",
            url: '/api/core/account-master/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>


<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
