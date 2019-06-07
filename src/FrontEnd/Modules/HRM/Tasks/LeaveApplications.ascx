<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LeaveApplications.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Tasks.LeaveApplications" %>

<script>
    var employeeId = parseInt(window.getQueryStringByName("EmployeeId") || 0);
    var filters = [];
    filters.push(window.getAjaxColumnFilter("WHERE", "user_id", window.FilterConditions.IsEqualTo, window.userId));

    var url = "/api/hrm/employee/get-where/1";
    var data = JSON.stringify(filters);

    var getEmployees = window.getAjaxRequest(url, "POST", data);

    getEmployees.success(function (msg) {
        if (msg && msg[0]) {
            if (employeeId !== msg[0].EmployeeId) {
                window.location = window.updateQueryString("EmployeeId", msg[0].EmployeeId, window.location.href);
            };
        };
    });
</script>

<script>
    var scrudFactory = new Object();

    scrudFactory.title = window.Resources.Titles.MyLeaveApplications();

    scrudFactory.viewAPI = "/api/hrm/leave-application-scrud-view";
    scrudFactory.viewTableName = "hrm.leave_application_scrud_view";

    scrudFactory.formAPI = "/api/hrm/leave-application";
    scrudFactory.formTableName = "hrm.leave_applications";

    scrudFactory.excludedColumns = ["Photo"];
    scrudFactory.hiddenColumns = ["EnteredBy", "AppliedOn", "EmployeeId", "VerificationStatusId", "VerifiedByUserId", "VerifiedOn", "VerificationReason"];

    scrudFactory.live = "EmployeeId";

    scrudFactory.layout = [
        {
            tab: "",
            fields: [
                ["LeaveApplicationId", "LeaveTypeId", "", ""],
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