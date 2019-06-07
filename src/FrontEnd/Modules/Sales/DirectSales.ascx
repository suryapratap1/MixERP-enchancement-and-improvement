<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DirectSales.ascx.cs" Inherits="MixERP.Net.Core.Modules.Sales.DirectSales" %>
<script>
    var scrudFactory = new Object();
    scrudFactory.title = Resources.Titles.DirectSales();

    scrudFactory.hiddenAnnotation = ["UserId", "Book", "OfficeId"];
    
    scrudFactory.addNewUrl = "/Modules/Sales/Entry/DirectSales.mix";

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
    		value: "Sales.Direct"
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
			href : "/Modules/Sales/Confirmation/DirectSales.mix?TranId={id}",
			icon : "list icon"
		},
		{
			title: Resources.Titles.Print(),
			onclick : "showWindow('/Modules/Sales/Reports/DirectSalesInvoiceReport.mix?TranId={id}');",
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

        var url = "/Modules/Sales/Entry/Return.mix?TranId=" + id;
        window.location = url;
    };
</script>

<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
