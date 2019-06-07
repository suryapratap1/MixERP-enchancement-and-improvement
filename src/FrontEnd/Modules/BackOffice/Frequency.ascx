<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Frequency.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Frequency" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.Frequencies();

    scrudFactory.viewAPI = "/api/core/frequency-setup-scrud-view";
    scrudFactory.viewTableName = "core.frequency_setup_scrud_view";
    scrudFactory.removeKanban = true;

    scrudFactory.formAPI = "/api/core/frequency-setup";
    scrudFactory.formTableName = "core.frequency_setups";
    scrudFactory.live = "FrequencySetupCode";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.keys = [
        {
            property: "FrequencyId",
            url: '/api/core/frequency-selector-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "FiscalYearCode",
            url: '/api/core/fiscal-year-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>
<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
