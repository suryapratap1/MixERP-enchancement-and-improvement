<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Transfer.ascx.cs" Inherits="MixERP.Net.Core.Modules.Inventory.Transfer" %>
<script>
    var scrudFactory = new Object();
    scrudFactory.title = Resources.Titles.StockTransferJournal();

    scrudFactory.hiddenAnnotation = ["UserId", "Book", "OfficeId"];
    
    scrudFactory.addNewUrl = "/Modules/Inventory/Entry/Transfer.mix";

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
    		key : "Book",
    		value: "Inventory.Transfer"
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
			href: "/Modules/Inventory/Confirmation/Transfer.mix?TranId={id}",
			icon : "list icon"
		},
		{
			title: Resources.Titles.Print(),
			onclick: "showWindow('/Modules/Inventory/Reports/InventoryTransferReport.mix?TranId={id}');",
			icon : "print icon"
		}
	];


    scrudFactory.viewAPI = "/api/transactions/procedures/get-product-view";
    scrudFactory.viewTableName = "transactions.get_product_view";
</script>
<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
