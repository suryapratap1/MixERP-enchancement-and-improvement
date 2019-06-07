<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Resignations.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Tasks.Resignations" %>
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

    scrudFactory.title = window.Resources.Titles.MyResignation();

    scrudFactory.viewAPI = "/api/hrm/resignation-scrud-view";
    scrudFactory.viewTableName = "hrm.resignation_scrud_view";

    scrudFactory.formAPI = "/api/hrm/resignation";
    scrudFactory.formTableName = "hrm.resignations";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.live = "EmployeeId";

    scrudFactory.readonlyColumns = ["EndedOn"];
    scrudFactory.hiddenColumns = ["EmployeeId", "EnteredBy", "VerificationStatusId", "VerifiedByUserId", "VerifiedOn", "VerificationReason"];
    scrudFactory.excludedColumns = ["Photo"];

    scrudFactory.keys = [
        {
            property: "EmployeeId",
            url: '/api/hrm/employee-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "ForwardTo",
            url: '/api/hrm/employee-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];

    scrudFactory.layout = [
        {
            tab: "",
            fields: [
                ["ResignationId", ""],
                ["NoticeDate", "DesiredResignDate", "", ""],
                ["ForwardTo", ""],
                ["ChangeStatusTo", ""],
                ["Reason", ""],
                ["Details", ""]
            ]
        }
    ];

    $(document).on("formready", function () {
        $("#verification_status_id").val("0");
    });
</script>


<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
<script>
    $(document).on("formready", function() {
        $("#entered_by").val(window.userId);
        $("#verification_status_id").val("0");
    });
</script>