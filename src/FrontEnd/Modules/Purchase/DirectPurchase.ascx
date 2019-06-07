<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DirectPurchase.ascx.cs" Inherits="MixERP.Net.Core.Modules.Purchase.DirectPurchase" %>
<script>
    var scrudFactory = new Object();
    scrudFactory.title = Resources.Titles.DirectPurchase();

    scrudFactory.hiddenAnnotation = ["UserId", "Book", "OfficeId"];
    
    scrudFactory.addNewUrl = "/Modules/Purchase/Entry/DirectPurchase.mix";

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
    		value: "Purchase.Direct"
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
			href: "/Modules/Purchase/Confirmation/DirectPurchase.mix?TranId={id}",
			icon : "list icon"
		},
		{
			title: Resources.Titles.Print(),
			onclick: "showWindow('/Modules/Purchase/Reports/DirectPurchaseInvoiceReport.mix?TranId={id}');",
			icon : "print icon"
		}
	];

    scrudFactory.customButtons = [
        {
            id: "ReturnButton",
            text: Resources.Titles.Return(),
            href : "",
            onclick : "onReturn();"
        }
    ];


    scrudFactory.viewAPI = "/api/transactions/procedures/get-product-view";
    scrudFactory.viewTableName = "transactions.get_product_view";    
</script>

<script>
    function onReturn(){
        var id = getSelectedCheckBoxItemIds(2, 3, $("#ScrudView"))[0];
        if(!id){
            displayMessage(Resources.Titles.NothingSelected());
            return;
        };

        var url = "/Modules/Purchase/Entry/Return.mix?TranId=" + id;
        window.location = url;
    };
</script>

<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
