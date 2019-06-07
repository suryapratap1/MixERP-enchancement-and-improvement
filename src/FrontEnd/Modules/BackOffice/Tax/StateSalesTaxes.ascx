<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="StateSalesTaxes.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Tax.StateSalesTaxes" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.StateSalesTaxes();

    scrudFactory.viewAPI = "/api/core/state-sales-tax-scrud-view";
    scrudFactory.viewTableName = "core.state_sales_tax_scrud_view";

    scrudFactory.formAPI = "/api/core/state-sales-tax";
    scrudFactory.formTableName = "core.state_sales_taxes";
    scrudFactory.live = "StateSalesTaxName";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.keys = [
        {
            property: "StateId",
            url: '/api/core/state-scrud-view/display-fields',
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
