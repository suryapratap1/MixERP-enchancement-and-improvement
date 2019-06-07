<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EmployeeTypes.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.EmployeeTypes" %>

<script>
	var scrudFactory = new Object();
    scrudFactory.title = window.Resources.Titles.EmployeeTypes();

    scrudFactory.viewAPI = "/api/hrm/employee-type-scrud-view";
    scrudFactory.viewTableName = "hrm.employee_type_scrud_view";

    scrudFactory.formAPI = "/api/hrm/employee-type";
    scrudFactory.formTableName = "hrm.employee_types";

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.live = "EmployeeTypeName";

    scrudFactory.keys = [
        {
            property: "AccountId",
            url: '/api/core/account/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>


<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
