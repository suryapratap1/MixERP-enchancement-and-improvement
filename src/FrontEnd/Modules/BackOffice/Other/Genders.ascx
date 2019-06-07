<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Genders.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Other.Genders" %>

<script>
	var scrudFactory = new Object();

    scrudFactory.title = window.Resources.Titles.Genders();

    scrudFactory.viewAPI = "/api/core/gender";
    scrudFactory.viewTableName = "core.genders";

    scrudFactory.formAPI = "/api/core/gender";
    scrudFactory.formTableName = "core.genders";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.live = "GenderName";
</script>


<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
