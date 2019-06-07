<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="IdentificationDetails.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Tasks.Employee.IdentificationDetails"
    OverridePath="/Modules/HRM/Tasks/Employees.mix" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = window.Resources.Titles.EmployeeIdentificationDetails();

    scrudFactory.viewAPI = "/api/hrm/employee-identification-detail-scrud-view";
    scrudFactory.viewTableName = "hrm.employee_identification_detail_scrud_view";

    scrudFactory.formAPI = "/api/hrm/employee-identification-detail";
    scrudFactory.formTableName = "hrm.employee_identification_details";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.back = {
        Title: "Employee",
        Url: "/Modules/HRM/Tasks/EmployeeInfo.mix?EmployeeId=" + getQueryStringByName("EmployeeId")
    };
    
    scrudFactory.keys = [
        {
            property: "EmployeeId",
            url: '/api/hrm/employee-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "IdentificationTypeCode",
            url: '/api/core/identification-type/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];

</script>


<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>

<script>
    function identificationTypeExpires(filters) {
        var url = "/api/core/identification-type/get-where/1";
        var data = JSON.stringify(filters);
        return window.getAjaxRequest(url, "POST", data, false);
    };

    function checkIfExpires() {
        var value = $("#identification_type_code").getSelectedValue();

        if (!value) {
            return;
        };

        var filters = [];
        filters.push(window.getAjaxColumnFilter("WHERE", "identification_type_code", window.FilterConditions.IsEqualTo, value));

        var ajaxIdentificationTypeExpires = identificationTypeExpires(filters);

        ajaxIdentificationTypeExpires.success(function (msg) {
            var canExpire = msg[0].CanExpire;


            if (!canExpire) {
                $("#expires_on").val("");
            };

            $("#expires_on").prop("disabled", !canExpire);
        });
    };

    $(document).on("formready", function () {
        checkIfExpires();

        $("#identification_type_code").change(function () {
            checkIfExpires();
        });;
    });
</script>