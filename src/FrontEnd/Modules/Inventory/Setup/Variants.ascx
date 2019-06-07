<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Variants.ascx.cs" Inherits="MixERP.Net.Core.Modules.Inventory.Setup.Variants" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.Variants();

    scrudFactory.viewAPI = "/api/core/variant-scrud-view";
    scrudFactory.viewTableName = "core.variant_scrud_view";

    scrudFactory.formAPI = "/api/core/variant";
    scrudFactory.formTableName = "core.variants";
    scrudFactory.live = "VariantName";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.keys = [
        {
            property: "AttributeId",
            url: '/api/core/attribute/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>

<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
