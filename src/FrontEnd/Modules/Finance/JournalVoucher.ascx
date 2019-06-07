<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="JournalVoucher.ascx.cs" Inherits="MixERP.Net.Core.Modules.Finance.JournalVoucher" %>
<script>
    var scrudFactory = new Object();
    scrudFactory.title = Resources.Titles.JournalVoucher();

    scrudFactory.hiddenAnnotation = ["UserId", "OfficeId"];
    
    scrudFactory.addNewUrl = "Entry/JournalVoucher.mix";

    scrudFactory.defaultAnnotation = [
    	{ 
    		key : "UserId",
    		value: window.userId
    	},
    	{
    	    key: "OfficeId",
    	    value: window.metaView.OfficeId
    	},
    	{
    	    key: "Book",
    	    value: "Journal"
    	},
    	{
    	    key: "Status",
    	    value: "Approved"
    	},
    	{
    	    key: "OfficeName",
    	    value: window.metaView.OfficeName
    	},
    	{
    		key : "From",
    		value: "bom"
    	},
    	{ 
    		key : "To",
    		value: "eom"
    	}
    ];

    scrudFactory.customButtons = [
        {
            id: "Import",
            text: Resources.Titles.Import(),
            href: "ImportTransaction.mix",
            onclick: ""
        }
    ];

    scrudFactory.customActions = [
		{

		    title: Resources.Labels.GoToChecklistWindow(),
		    href: "/Modules/Finance/Confirmation/JournalVoucher.mix?TranId={id}",
		    icon: "list icon"
		},
		{
			title: Resources.Titles.Print(),
			onclick: "showWindow('/Modules/Finance/Reports/GLAdviceReport.mix?TranId={id}');",
			icon : "print icon"
		}
	];


    scrudFactory.viewAPI = "/api/transactions/procedures/get-journal-view";
    scrudFactory.viewTableName = "transactions.get_journal_view";
</script>
<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
