<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TaxAuthorities.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Tax.TaxAuthorities" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.TaxAuthorities();

    scrudFactory.viewAPI = "/api/core/tax-authority-scrud-view";
    scrudFactory.viewTableName = "core.tax_authority_scrud_view";

    scrudFactory.formAPI = "/api/core/tax-authority";
    scrudFactory.formTableName = "core.tax_authorities";
    scrudFactory.live = "TaxMasterName";

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
            property: "CountryId",
            url: '/api/core/country-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "StateId",
            url: '/api/core/state-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>
<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
