<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ItemVariantDetails.ascx.cs" Inherits="MixERP.Net.Core.Modules.Inventory.Setup.ItemVariantDetails" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.ItemVariantDetails();

    scrudFactory.viewAPI = "/api/core/item-variant-detail-scrud-view";
    scrudFactory.viewTableName = "core.item_variant_detail_scrud_view";

    scrudFactory.formAPI = "/api/core/item-variant-detail";
    scrudFactory.formTableName = "core.item_variant_details";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.keys = [
        {
            property: "ItemVariantId",
            url: '/api/core/item-variant/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "VariantId",
            url: '/api/core/variant/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>

<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
