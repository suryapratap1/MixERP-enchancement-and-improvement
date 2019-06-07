<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Experiences.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Tasks.Employee.Experiences"
    OverridePath="/Modules/HRM/Tasks/Employees.mix"%>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = window.Resources.Titles.Experiences();

    scrudFactory.viewAPI = "/api/hrm/employee-experience-scrud-view";
    scrudFactory.viewTableName = "hrm.employee_experience_scrud_view";

    scrudFactory.formAPI = "/api/hrm/employee-experience";
    scrudFactory.formTableName = "hrm.employee_experiences";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];


    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.back = {
        Title: "Employee",
        Url: "/Modules/HRM/Tasks/EmployeeInfo.mix?EmployeeId=" + getQueryStringByName("EmployeeId")
    };

    scrudFactory.layout = [
        {
            tab: "",
            fields: [
                ["EmployeeExperienceId", "EmployeeId", "", ""],
                ["OrganizationName", "Title", "", ""],
                ["StartedOn", "EndedOn", "", ""],
                ["Details", ""]
            ]
        }
    ];

    scrudFactory.live = "Title";
    scrudFactory.keys = [
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
