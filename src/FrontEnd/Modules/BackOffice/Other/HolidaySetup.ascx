<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HolidaySetup.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Other.HolidaySetup" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title =  window.Resources.Titles.HolidaySetup();

    scrudFactory.viewAPI = "/api/office/holiday";
    scrudFactory.viewTableName = "office.holidays";
    scrudFactory.description = "";

    scrudFactory.formAPI = "/api/office/holiday";
    scrudFactory.formTableName = "office.holidays";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.live = "HolidayName";

    scrudFactory.layout = [
        {
            tab: "",
            fields: [
                ["HolidayId", ""],
                ["OfficeId", "HolidayName", "", ""],
                ["OccursOn", "EndsOn", "", ""],
                ["Description", ""]
            ]
        }
    ];

    scrudFactory.keys = [
        {
            property: "OfficeId",
            url: '/api/office/office/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>


<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
