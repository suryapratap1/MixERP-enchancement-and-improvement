<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Qualifications.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Tasks.Employee.Qualifications"
    OverridePath="/Modules/HRM/Tasks/Employees.mix" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = window.Resources.Titles.Qualifications();

    scrudFactory.viewAPI = "/api/hrm/employee-qualification-scrud-view";
    scrudFactory.viewTableName = "hrm.employee_qualification_scrud_view";

    scrudFactory.formAPI = "/api/hrm/employee-qualification";
    scrudFactory.formTableName = "hrm.employee_qualifications";

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
                ["EmployeeQualificationId", "EmployeeId",  "", ""],
                ["EducationLevelId", "Institution", "", ""],
                ["Majors", "TotalYears", "", ""],
                ["Score", "", "", ""],
                ["StartedOn", "CompletedOn", "", ""],
                ["Details", ""]
            ]
        }
    ];

    scrudFactory.live = "Majors";
    scrudFactory.keys = [
        {
            property: "EmployeeId",
            url: '/api/hrm/employee-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "EducationLevelId",
            url: '/api/hrm/education-level/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];

</script>


<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
