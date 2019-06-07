<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LeaveApplication.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Tasks.Employee.LeaveApplication"
    OverridePath="/Modules/HRM/Tasks/Employees.mix" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = window.Resources.Titles.LeaveApplications();

    scrudFactory.viewAPI = "/api/hrm/leave-application-scrud-view";
    scrudFactory.viewTableName = "hrm.leave_application_scrud_view";

    scrudFactory.formAPI = "/api/hrm/leave-application";
    scrudFactory.formTableName = "hrm.leave_applications";

    scrudFactory.excludedColumns = ["Photo", "AuditUserId", "AuditTs"];
    scrudFactory.hiddenColumns = ["EnteredBy", "AppliedOn", "VerificationStatusId", "VerifiedByUserId", "VerifiedOn", "VerificationReason"];

    scrudFactory.live = "EmployeeId";

    scrudFactory.back = {
        Title: "Employee",
        Url: "/Modules/HRM/Tasks/EmployeeInfo.mix?EmployeeId=" + getQueryStringByName("EmployeeId")
    };

    scrudFactory.layout = [
        {
            tab: "",
            fields: [
                ["LeaveApplicationId", ""],
                ["LeaveTypeId", "EmployeeId", "", ""],
                ["StartDate", "EndDate", "", ""],
                ["Reason", ""]
            ]
        }
    ];

    scrudFactory.keys = [
        {
            property: "LeaveTypeId",
            url: '/api/hrm/leave-type/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "EmployeeId",
            url: '/api/hrm/employee-view/display-fields',
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
        $("#applied_on").val(window.today);
        $("#entered_by").val(window.userId);
        $("#verification_status_id").val("0");
    });
</script>