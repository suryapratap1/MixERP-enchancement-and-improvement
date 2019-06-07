<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Counters.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Counters" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.Counters();

    scrudFactory.viewAPI = "/api/office/counter-scrud-view";
    scrudFactory.viewTableName = "office.counter_scrud_view";
    scrudFactory.removeKanban = true;

    scrudFactory.formAPI = "/api/office/counter";
    scrudFactory.formTableName = "office.counters";
    scrudFactory.live = "CounterName";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.keys = [
        {
            property: "CashRepositoryId",
            url: '/api/office/cash-repository-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "StoreId",
            url: '/api/office/store-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>
<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
