<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SalesTaxes.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Tax.SalesTaxes" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.SalesTaxes();

    scrudFactory.viewAPI = "/api/core/sales-tax-scrud-view";
    scrudFactory.viewTableName = "core.sales_tax_scrud_view";

    scrudFactory.formAPI = "/api/core/sales-tax";
    scrudFactory.formTableName = "core.sales_taxes";
    scrudFactory.live = "SalesTaxName";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.keys = [
        {
            property: "TaxMasterId",
            url: '/api/core/tax-master-scrud-view/display-fields',
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
        },
        {
            property: "TaxBaseAmountTypeCode",
            url: '/api/core/tax-base-amount-type-selector-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "ItemGroupId",
            url: '/api/core/item-group-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>
<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
