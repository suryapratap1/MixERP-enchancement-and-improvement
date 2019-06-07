<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SocialNetworks.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Tasks.Employee.SocialNetworks"
    OverridePath="/Modules/HRM/Tasks/Employees.mix" %>
<script>
    var scrudFactory = new Object();
    scrudFactory.title = window.Resources.Titles.SocialNetworks();

    scrudFactory.viewAPI = "/api/hrm/employee-social-network-detail-scrud-view";
    scrudFactory.viewTableName = "hrm.employee_social_network_detail_scrud_view";

    scrudFactory.formAPI = "/api/hrm/employee-social-network-detail";
    scrudFactory.formTableName = "hrm.employee_social_network_details";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
    
    scrudFactory.back = {
        Title: "Employee",
        Url: "/Modules/HRM/Tasks/EmployeeInfo.mix?EmployeeId=" + getQueryStringByName("EmployeeId")
    };

    scrudFactory.live = "SocialNetworkId";
    scrudFactory.keys = [
        {
            property: "EmployeeId",
            url: '/api/hrm/employee-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "SocialNetworkName",
            url: '/api/core/social-network/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];

</script>


<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
