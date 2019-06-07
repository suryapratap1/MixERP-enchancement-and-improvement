<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MerchantFeeSetup.ascx.cs" Inherits="MixERP.Net.Core.Modules.Finance.Setup.MerchantFeeSetup" %>
<script src="/Scripts/underscore/underscore-min.js"></script>
<script>
    var scrudFactory = new Object();
    scrudFactory.title = window.Resources.Titles.MerchantFeeSetup();

    scrudFactory.viewAPI = "/api/core/merchant-fee-setup-scrud-view";
    scrudFactory.viewTableName = "core.merchant_fee_setup_scrud_view";

    scrudFactory.formAPI = "/api/core/merchant-fee-setup";
    scrudFactory.formTableName = "core.merchant_fee_setup";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.keys = [
        {
            property: "MerchantAccountId",
            url: '/api/core/merchant-account-selector-view/display-fields',
            data: null,
            isArray:false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "PaymentCardId",
            url: '/api/core/payment-card-scrud-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "AccountId",
            url: '/api/core/merchant-fee-setup-account-selector-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        }
    ];


</script>

<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
