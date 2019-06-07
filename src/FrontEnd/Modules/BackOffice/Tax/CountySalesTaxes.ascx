<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CountySalesTaxes.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Tax.CountySalesTaxes" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.CountySalesTaxes();

    scrudFactory.viewAPI = "/api/core/county-sales-tax-scrud-view";
    scrudFactory.viewTableName = "core.county_sales_tax_scrud_view";

    scrudFactory.formAPI = "/api/core/county-sales-tax";
    scrudFactory.formTableName = "core.county_sales_taxes";
    scrudFactory.live = "CountySalesTaxName";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.keys = [
        {
            property: "CountyId",
            url: '/api/core/county-scrud-view/display-fields',
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
