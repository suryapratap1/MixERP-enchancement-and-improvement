<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SalesTaxDetails.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Tax.SalesTaxDetails" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.SalesTaxDetails();

    scrudFactory.viewAPI = "/api/core/sales-tax-detail-scrud-view";
    scrudFactory.viewTableName = "core.sales_tax_detail_scrud_view";

    scrudFactory.formAPI = "/api/core/sales-tax-detail";
    scrudFactory.formTableName = "core.sales_tax_details";
    scrudFactory.live = "SalesTaxDetailName";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.keys = [
        {
            property: "SalesTaxTypeId",
            url: '/api/core/sales-tax-type-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "SalesTaxId",
            url: '/api/core/sales-tax-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "StateSalesTaxId",
            url: '/api/core/state-sales-tax-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CountySalesTaxId",
            url: '/api/core/county-sales-tax-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "TaxRateTypeCode",
            url: '/api/core/tax-rate-type-selector-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "ReportingTaxAuthorityId",
            url: '/api/core/tax-authority-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CollectingTaxAuthorityId",
            url: '/api/core/tax-authority-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CollectingAccountId",
            url: '/api/core/account-selector-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "UseTaxCollectingAccountId",
            url: '/api/core/account-selector-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "RoundingMethodCode",
            url: '/api/core/rounding-method-selector-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>
<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
