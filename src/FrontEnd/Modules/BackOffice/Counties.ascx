<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Counties.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Counties" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.Counties();

    scrudFactory.viewAPI = "/api/core/county-scrud-view";
    scrudFactory.viewTableName = "core.county_scrud_view";
    scrudFactory.removeKanban = true;

    scrudFactory.formAPI = "/api/core/county";
    scrudFactory.formTableName = "core.counties";
    scrudFactory.live = "CountyName";

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
        }
    ];
</script>
<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
