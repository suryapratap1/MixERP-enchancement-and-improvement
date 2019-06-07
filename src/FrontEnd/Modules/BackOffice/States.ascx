<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="States.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.States" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.States();

    scrudFactory.viewAPI = "/api/core/state-scrud-view";
    scrudFactory.viewTableName = "core.state_scrud_view";
    scrudFactory.removeKanban = true;

    scrudFactory.formAPI = "/api/core/state";
    scrudFactory.formTableName = "core.states";
    scrudFactory.live = "StateName";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.keys = [
        {
            property: "CountryId",
            url: '/api/core/country-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>
<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
