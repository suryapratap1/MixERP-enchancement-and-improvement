<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SalesTaxTypes.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Tax.SalesTaxTypes" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.SalesTaxTypes();

    scrudFactory.viewAPI = "/api/core/sales-tax-type-scrud-view";
    scrudFactory.viewTableName = "core.sales_tax_type_scrud_view";

    scrudFactory.formAPI = "/api/core/sales-tax-type";
    scrudFactory.formTableName = "core.sales_tax_types";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];
    scrudFactory.live = "SalesTaxTypeName";

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
