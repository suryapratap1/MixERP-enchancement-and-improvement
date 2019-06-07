<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Contracts.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Tasks.Contracts" %>
<script>
    var scrudFactory = new Object();
    
    scrudFactory.title = window.Resources.Titles.Contracts();

    scrudFactory.viewAPI = "/api/hrm/contract-scrud-view";
    scrudFactory.viewTableName = "hrm.contract_scrud_view";

    scrudFactory.formAPI = "/api/hrm/contract";
    scrudFactory.formTableName = "hrm.contracts";

    scrudFactory.excludedColumns = ["Photo"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.live = "EmployeeId";


    scrudFactory.readonlyColumns = ["EndedOn"];
    scrudFactory.hiddenColumns = ["VerificationStatusId", "VerifiedByUserId", "VerifiedOn", "VerificationReason"];

    scrudFactory.keys = [
        {
            property: "EmployeeId",
            url: '/api/hrm/employee-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "OfficeId",
            url: '/api/office/office/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "DepartmentId",
            url: '/api/office/department/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "RoleId",
            url: '/api/office/role/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "LeaveBenefitId",
            url: '/api/hrm/leave-benefit/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "EmploymentStatusCodeId",
            url: '/api/hrm/employment-status-code/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>


<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>

<script>
    $(document).on("formready", function() {
        $("#verification_status_id").val("0");
    });
</script>