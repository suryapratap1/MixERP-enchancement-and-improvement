<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Receipt.ascx.cs" Inherits="MixERP.Net.Core.Modules.Sales.Receipt" %>
<script>
    var scrudFactory = new Object();
    scrudFactory.title = Resources.Titles.SalesReceipt();

    scrudFactory.hiddenAnnotation = ["UserId", "OfficeId"];
    
    scrudFactory.addNewUrl = "/Modules/Sales/Entry/Receipt.mix";

    scrudFactory.defaultAnnotation = [
    	{ 
    		key : "UserId",
    		value: window.userId
    	},
    	{ 
    		key : "OfficeId",
    		value: window.metaView.OfficeId
    	},
    	{ 
    		key : "DateFrom",
    		value: "bom"
    	},
    	{ 
    		key : "DateTo",
    		value: "eom"
    	}
    ];

	scrudFactory.customActions = [
		{
			title: Resources.Labels.GoToChecklistWindow(),
			href: "/Modules/Sales/Confirmation/Receipt.mix?TranId={id}",
			icon : "list icon"
		},
		{
			title: Resources.Titles.Print(),
			onclick: "showWindow('/Modules/Sales/Reports/CustomerReceiptReport.mix?TranId={id}');",
			icon : "print icon"
		}
	];


	scrudFactory.viewAPI = "/api/transactions/procedures/get-receipt-view";
	scrudFactory.viewTableName = "transactions.get_receipt_view";
</script>


<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
