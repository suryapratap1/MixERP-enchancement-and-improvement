<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TaxExemptTypes.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Tax.TaxExemptTypes" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.TaxExemptTypes();

    scrudFactory.viewAPI = "/api/core/tax-exempt-type-scrud-view";
    scrudFactory.viewTableName = "core.tax_exempt_type_scrud_view";

    scrudFactory.formAPI = "/api/core/tax-exempt-type";
    scrudFactory.formTableName = "core.tax_exempt_types";
    scrudFactory.live = "TaxExemptTypeName";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
</script>
<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
