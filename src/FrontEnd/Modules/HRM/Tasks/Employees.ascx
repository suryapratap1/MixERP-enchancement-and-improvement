<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Employees.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Tasks.Employees" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = window.Resources.Titles.Employees();

    scrudFactory.viewAPI = "/api/hrm/employee-view";
    scrudFactory.viewTableName = "hrm.employee_view";

    scrudFactory.formAPI = "/api/hrm/employee";
    scrudFactory.formTableName = "hrm.employees";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];
    scrudFactory.readonlyColumns = ["EmployeeName"];
    scrudFactory.hiddenColumns = ["Status", "ServiceEndedOn"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
    scrudFactory.viewUrl = "EmployeeInfo.mix?EmployeeId={Key}";

    scrudFactory.live = "EmployeeName";
    scrudFactory.layout = [
        {
            tab: "personal",
            fields: [
                ["Photo", ""],
                ["EmployeeId", ""],
                ["EmployeeName", "EmployeeCode", "", ""],
                ["FirstName", "MiddleName", "LastName", "GenderCode", "", "", "", ""],
                ["MaritalStatusId", "NationalityCode", "", ""],
                ["DateOfBirth", "AccountId", "", ""]
            ]
        },
        {
            tab: "employment",
            fields: [
                ["UserId", "OfficeId", "", ""],
                ["JoinedOn", "EmployeeTypeId", "", ""],
                ["CurrentDepartmentId", "CurrentRoleId", "", ""],
                ["CurrentEmploymentStatusId", "CurrentJobTitleId", "", ""],
                ["CurrentPayGradeId", "CurrentShiftId", "", ""]
            ]
        },
        {
            tab: "bank",
            fields:[
                ["BankAccountNumber", "BankName", "", ""],
                ["BankBranchName", "BankReferenceNumber", "", ""]
            ]
        },
        {
            tab: "address",
            fields: [
                ["ZipCode", "", "", "", "", "", "",],
                ["AddressLine1", ""],
                ["AddressLine2", ""],
                ["Street", "City", "", ""],
                ["CountryId", "State", "", ""],
                ["Phone", "Fax", "", ""],
                ["Cell", "Email", "", ""],
                ["Url", "", "", ""]
            ]
        },
        {
            tab: "contact",
            fields:[
                ["PhoneHome", "PhoneCell", "", ""],
                ["PhoneOfficeExtension", "", "", ""],
                ["PhoneEmergency", "PhoneEmergency2", "", ""],
                ["EmailAddress", "Website", "", ""],
                ["Blog", "", "", ""]
            ]
        },
        {
            tab: "other",
            fields: [
                ["IsSmoker", "IsAlcoholic", "", ""],
                ["WithDisabilities", "LowVision", "", ""],
                ["UsesWheelchair", "HardOfHearing", "", ""],
                ["IsAphonic", "IsCognitivelyDisabled", "", ""],
                ["IsAutistic", "", "", ""]
            ]
        }
    ];

    scrudFactory.tabs = [
        {
            sort: 0,
            id: "personal",
            name: window.Resources.Titles.PersonalInformation(),
            active: true
        },
        {
            sort: 1,
            id: "employment",
            name: window.Resources.Titles.EmploymentInformation()
        },
        {
            sort: 2,
            id: "bank",
            name: window.Resources.Titles.BankDetails()
        },
        {
            sort: 3,
            id: "address",
            name: window.Resources.Titles.AddressInformation()
        },
        {
            sort: 4,
            id: "contact",
            name: window.Resources.Titles.ContactInformation()
        },
        {
            sort: 5,
            id: "other",
            name: window.Resources.Titles.OtherDetails()
        }
    ];

    scrudFactory.returnUrl = "../Employees.mix";
    scrudFactory.queryStringKey = "EmployeeId";
    scrudFactory.keys = [
        {
            property: "GenderCode",
            url: '/api/core/gender/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "MaritalStatusId",
            url: '/api/core/marital-status/display-fields',
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
            property: "UserId",
            url: '/api/office/user/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "EmployeeTypeId",
            url: '/api/hrm/employee-type/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CurrentDepartmentId",
            url: '/api/office/department/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CurrentRoleId",
            url: '/api/office/role/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CurrentEmploymentStatusId",
            url: '/api/hrm/employment-status/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CurrentJobTitleId",
            url: '/api/hrm/job-title/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CurrentPayGradeId",
            url: '/api/hrm/pay-grade/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CurrentShiftId",
            url: '/api/hrm/shift/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "NationalityCode",
            url: '/api/core/nationality/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CountryId",
            url: '/api/core/country/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "StateId",
            url: '/api/core/state/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
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

<script>
    $(document).on("formready", function() {
        initialize();
    });


    function initialize() {
        $("#status").dropdown("set selected", "yes");
        var firstName = $("#first_name");
        var middleName = $("#middle_name");
        var lastName = $("#last_name");
        var employeeName = $("#employee_name");

        function displayEmployeeName() {
            var f = (firstName.val() || "");
            var m = (middleName.val() || "");
            var l = (lastName.val() || "");

            var name = f + " " + m;
            if (l) {
                name = l.trim() + ", " + f + " " + m;
            };


            employeeName.val(name.trim());

            employeeName.trigger("keyup");
        };


        firstName.keyup(function () { displayEmployeeName(); });
        middleName.keyup(function () { displayEmployeeName(); });
        lastName.keyup(function () { displayEmployeeName(); });

    };


</script>

