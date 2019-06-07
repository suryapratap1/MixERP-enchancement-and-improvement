<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Order.ascx.cs" Inherits="MixERP.Net.Core.Modules.Purchase.Order" %>
<script>
    var scrudFactory = new Object();
    scrudFactory.title = Resources.Titles.PurchaseOrder();
    var book = "Purchase.Order";
    scrudFactory.hiddenAnnotation = ["UserId", "Book", "OfficeId"];
    
    scrudFactory.addNewUrl = "/Modules/Purchase/Entry/Order.mix";

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
			href: "/Modules/Purchase/Confirmation/Order.mix?TranId={id}",
			icon : "list icon"
		},
		{
			title: Resources.Titles.Print(),
			onclick: "showWindow('/Modules/Purchase/Reports/PurchaseOrderReport.mix?TranId={id}');",
			icon : "print icon"
		}
	];

    scrudFactory.customButtons = [
        {
            id: "MergeButton",
            text: Resources.Titles.MergeBatchToGRN(),
            href : "",
            onclick : "onMergeToSalesDelivery();"
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
            window.location.href = "/Modules/Purchase/Entry/GRN.mix";
        });
    };
</script>

<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
