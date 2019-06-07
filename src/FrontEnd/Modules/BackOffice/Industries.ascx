<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Industries.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Industries" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.Industries();

    scrudFactory.viewAPI = "/api/core/industry-scrud-view";
    scrudFactory.viewTableName = "core.industry_scrud_view";

    scrudFactory.formAPI = "/api/core/industry";
    scrudFactory.formTableName = "core.industries";
    scrudFactory.live = "IndustryName";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.keys = [
        {
            property: "ParentIndustryId",
            url: '/api/core/industry-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>
<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
