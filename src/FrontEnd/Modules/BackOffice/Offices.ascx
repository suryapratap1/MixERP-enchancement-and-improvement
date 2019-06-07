<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Offices.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Offices" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.OfficeSetup();

    scrudFactory.viewAPI = "/api/office/office-scrud-view";
    scrudFactory.viewTableName = "office.office_scrud_view";

    scrudFactory.formAPI = "/api/office/office";
    scrudFactory.formTableName = "office.offices";
    scrudFactory.live = "OfficeName";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.keys = [
        {
            property: "CurrencyCode",
            url: '/api/core/currency-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "ParentOfficeId",
            url: '/api/office/office-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>
<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
