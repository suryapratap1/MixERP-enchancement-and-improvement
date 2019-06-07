<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Currencies.ascx.cs" Inherits="MixERP.Net.Core.Modules.Finance.Setup.Currencies" %>

<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.Currencies();

    scrudFactory.viewAPI = "/api/core/currency-scrud-view";
    scrudFactory.viewTableName = "core.currency_scrud_view";

    scrudFactory.formAPI = "/api/core/currency";
    scrudFactory.formTableName = "core.currencies";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.live = "CurrencyName";
</script>

<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
