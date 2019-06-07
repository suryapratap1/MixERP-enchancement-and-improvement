<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="IdentificationTypes.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Other.IdentificationTypes" %>
<script>
	var scrudFactory = new Object();

    scrudFactory.title = window.Resources.Titles.IdentificationTypes();

    scrudFactory.viewAPI = "/api/core/identification-type";
    scrudFactory.viewTableName = "core.identification_types";

    scrudFactory.formAPI = "/api/core/identification-type";
    scrudFactory.formTableName = "core.identification_types";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.live = "IdentificationTypeName";
</script>


<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
