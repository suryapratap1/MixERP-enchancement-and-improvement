<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Exits.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Tasks.Exits" %>
<script>
    var scrudFactory = new Object();
    
    scrudFactory.title = window.Resources.Titles.EmployeeExits();

    scrudFactory.viewAPI = "/api/hrm/exit-scrud-view";
    scrudFactory.viewTableName = "hrm.exit_scrud_view";

    scrudFactory.formAPI = "/api/hrm/exit";
    scrudFactory.formTableName = "hrm.exits";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];
    scrudFactory.hiddenColumns = ["VerificationStatusId", "VerifiedByUserId", "VerifiedOn", "VerificationReason"];
    scrudFactory.excludedColumns = ["Photo"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.live = "EmployeeId";

    scrudFactory.layout = [
            {
            tab: "",
            fields: [
                ["ExitId", ""],
                ["EmployeeId", "Reason", "", ""],
                ["ChangeStatusTo", "ExitTypeId", "", ""],
                ["ForwardTo", "ServiceEndDate", "", ""],
                ["Details", ""],
                ["ExitInterviewDetails", ""]
            ]
        }
    ];

    scrudFactory.keys = [
        {
            property: "EmployeeId",
            url: '/api/hrm/employee-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "ExitTypeId",
            url: '/api/hrm/exit-type/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "ChangeStatusTo",
            url: '/api/hrm/employment-status/display-fields',
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
</script>


<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>

<script>
    $(document).on("formready", function() {
        $("#verification_status_id").val("0");
    });
</script>