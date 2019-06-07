<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Return.ascx.cs" Inherits="MixERP.Net.Core.Modules.Sales.Return" %>
<script>
    var scrudFactory = new Object();
    scrudFactory.title = Resources.Titles.SalesReturn();

    scrudFactory.hiddenAnnotation = ["UserId", "Book", "OfficeId"];
    
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
    	    key: "Book",
    	    value: "Sales.Return"
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
			href: "/Modules/Sales/Confirmation/Return.mix?TranId={id}",
			icon : "list icon"
		},
		{
			title: Resources.Titles.Print(),
			onclick: "showWindow('/Modules/Sales/Reports/SalesReturnReport.mix?TranId={id}');",
			icon : "print icon"
		}
	];


	scrudFactory.viewAPI = "/api/transactions/procedures/get-product-view";
	scrudFactory.viewTableName = "transactions.get_product_view";
</script>


<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
