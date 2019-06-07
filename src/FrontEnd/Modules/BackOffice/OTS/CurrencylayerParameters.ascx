<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CurrencylayerParameters.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.OTS.CurrencylayerParameters" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.CurrencylayerParameters();

    scrudFactory.viewAPI = "/api/config/currency-layer-scrud-view";
    scrudFactory.viewTableName = "config.currency_layer_scrud_view";

    scrudFactory.formAPI = "/api/config/currency-layer";
    scrudFactory.formTableName = "config.currency_layer";
    scrudFactory.removeKanban = true;
    scrudFactory.removeFilter = true;
    scrudFactory.removeImport = true;

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];
    scrudFactory.hidePrimaryKey = false;

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
</script>
<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
