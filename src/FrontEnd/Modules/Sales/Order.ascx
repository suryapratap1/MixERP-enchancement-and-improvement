<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Order.ascx.cs" Inherits="MixERP.Net.Core.Modules.Sales.Order" %>

<script>
    var scrudFactory = new Object();
    scrudFactory.title = Resources.Titles.SalesOrder();
    var book = "Sales.Order";
    scrudFactory.hiddenAnnotation = ["UserId", "Book", "OfficeId"];
    
    scrudFactory.addNewUrl = "/Modules/Sales/Entry/Order.mix";

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
    		value: book
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
			href: "/Modules/Sales/Confirmation/Order.mix?TranId={id}",
			icon : "list icon"
		},
		{
			title: Resources.Titles.Print(),
			onclick: "showWindow('/Modules/Sales/Reports/SalesOrderReport.mix?TranId={id}');",
			icon : "print icon"
		}
	];

    scrudFactory.customButtons = [
        {
            id: "MergeButton",
            text: Resources.Titles.MergeBatchToSalesDelivery(),
            href : "",
            onclick : "onMergeToSalesDelivery();"
        },
        {
            id: "SupplyPlannerButton",
            text: "Planning",
            href: "",
            onclick: "onSupplyPlanner();"
        },
        {
            id: "OrderSummaryButton",
            text: "Summary",
            href: "/Modules/Sales/OrderSummary.mix",
            onclick: ""
        }
    ];

    scrudFactory.viewAPI = "/api/transactions/procedures/get-non-gl-product-view";
    scrudFactory.viewTableName = "transactions.get_non_gl_product_view";    
</script>

<script>
    function onMergeToSalesDelivery() {
        function request(annotation) {
            var url = "/api/transactions/procedures/get-merge-model/execute";
            var data = JSON.stringify(annotation);

            return window.getAjaxRequest(url, "POST", data);
        };

        var ids = getSelectedCheckBoxItemIds(2, 3, $("#ScrudView"));

        if (!ids.length) {
            window.displayMessage("Please select an item.");
            return;
        };

        var annotation = {
            TranIds: ids,
            Book: book
        };

        var ajax = request(annotation);

        ajax.success(function (response) {
            window.localStorage.setItem('MergeModel', JSON.stringify(response));
            window.localStorage.setItem('TranIds', ids.join(","));

            window.location.href = "/Modules/Sales/Entry/Delivery.mix";
        });
    };

    function onSupplyPlanner() {
        const ids = getSelectedCheckBoxItemIds(2, 3, $("#ScrudView"));

        if (!ids.length) {
            window.displayMessage("Please select an item.");
            return;
        };

        window.location.href = "/Modules/Sales/SupplyPlanner.mix?OrderId=" + ids[0];
    };
</script>

<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
