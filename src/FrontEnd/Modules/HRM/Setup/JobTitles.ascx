<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="JobTitles.ascx.cs" Inherits="MixERP.Net.Core.Modules.HRM.Setup.JobTitles" %>
<script>
	var scrudFactory = new Object();
    
    scrudFactory.title =  window.Resources.Titles.JobTitles();

    scrudFactory.viewAPI = "/api/hrm/job-title";
    scrudFactory.viewTableName = "hrm.job_titles";

    scrudFactory.formAPI = "/api/hrm/job-title";
    scrudFactory.formTableName = "hrm.job_titles";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.layout = [
        {
            tab: "",
            fields: [
                ["JobTitleId", ""],
                ["JobTitleCode", "JobTitleName", "", ""],
                ["Description", ""]
            ]
        }
    ];

    scrudFactory.live = "JobTitleName";
</script>


<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
