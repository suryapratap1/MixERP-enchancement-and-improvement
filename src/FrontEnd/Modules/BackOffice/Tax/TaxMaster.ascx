<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TaxMaster.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Tax.TaxMaster" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.TaxMaster();

    scrudFactory.viewAPI = "/api/core/tax-master-scrud-view";
    scrudFactory.viewTableName = "core.tax_master_scrud_view";

    scrudFactory.formAPI = "/api/core/tax-master";
    scrudFactory.formTableName = "core.tax_master";
    scrudFactory.live = "TaxMasterName";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
</script>
<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
