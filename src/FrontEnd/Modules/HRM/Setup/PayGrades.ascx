<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PayGrades.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.PayGrades" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title =  window.Resources.Titles.PayGrades();
    
    scrudFactory.viewAPI = "/api/hrm/pay-grade";
    scrudFactory.viewTableName = "hrm.pay_grades";

    scrudFactory.formAPI = "/api/hrm/pay-grade";
    scrudFactory.formTableName = "hrm.pay_grades";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.layout = [
        {
            tab: "",
            fields: [
                ["PayGradeId", ""],
                ["PayGradeCode", "PayGradeName", "", ""],
                ["MinimumSalary", "MaximumSalary", "", ""],
                ["Description", ""]
            ]
        }
    ];

    scrudFactory.live = "PayGradeName";
</script>


<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
