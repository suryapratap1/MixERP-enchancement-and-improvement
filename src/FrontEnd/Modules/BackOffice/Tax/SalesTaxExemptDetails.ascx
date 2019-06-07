<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SalesTaxExemptDetails.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Tax.SalesTaxExemptDetails" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.SalesTaxExemptDetails();

    scrudFactory.viewAPI = "/api/core/sales-tax-exempt-detail-scrud-view";
    scrudFactory.viewTableName = "core.sales_tax_exempt_detail_scrud_view";

    scrudFactory.formAPI = "/api/core/sales-tax-exempt-detail";
    scrudFactory.formTableName = "core.sales_tax_exempt_details";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.keys = [
        {
            property: "SalesTaxExemptId",
            url: '/api/core/sales-tax-exempt-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "EntityId",
            url: '/api/core/entity-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "IndustryId",
            url: '/api/core/industry-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "PartyId",
            url: '/api/core/party-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "PartyTypeId",
            url: '/api/core/party-type-scrud-view/display-fields',
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
        },
        {
            property: "ItemId",
            url: '/api/core/item-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>
<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
