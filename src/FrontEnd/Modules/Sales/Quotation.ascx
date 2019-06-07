<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Quotation.ascx.cs" Inherits="MixERP.Net.Core.Modules.Sales.Quotation" %>

<script>
    var scrudFactory = new Object();
    scrudFactory.title = Resources.Titles.SalesQuotation();
    var book = "Sales.Quotation";

    scrudFactory.hiddenAnnotation = ["UserId", "Book", "OfficeId"];

    scrudFactory.addNewUrl = "/Modules/Sales/Entry/Quotation.mix";

    scrudFactory.defaultAnnotation = [
    	{
    	    key: "UserId",
    	    value: window.userId
    	},
    	{
    	    key: "OfficeId",
    	    value: window.metaView.OfficeId
    	},
    	{
    	    key: "Book",
    	    value: book
    	},
    	{
    	    key: "DateFrom",
    	    value: "bom"
    	},
    	{
    	    key: "DateTo",
    	    value: "eom"
    	}
    ];

    scrudFactory.customActions = [
		{
		    title: Resources.Labels.GoToChecklistWindow(),
		    href: "/Modules/Sales/Confirmation/Quotation.mix?TranId={id}",
		    icon: "list icon"
		},
		{
		    title: Resources.Titles.Print(),
		    onclick: "showWindow('/Modules/Sales/Reports/SalesQuotationReport.mix?TranId={id}');",
		    icon: "print icon"
		}
    ];

    scrudFactory.customButtons = [
        {
            id: "MergeBatchToSalesOrderButton",
            text: Resources.Titles.MergeBatchToSalesOrder(),
            href: "",
            onclick: "onMerge('/Modules/Sales/Entry/Order.mix');"
        },
        {
            id: "MergeBatchToSalesDeliveryButton",
            text: Resources.Titles.MergeBatchToSalesDelivery(),
            href: "",
            onclick: "onMerge('/Modules/Sales/Entry/Delivery.mix');"
        }
    ];

    scrudFactory.viewAPI = "/api/transactions/procedures/get-non-gl-product-view";
    scrudFactory.viewTableName = "transactions.get_non_gl_product_view";
</script>

<script>
    function onMerge(mergeUrl) {
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
            var json = JSON.stringify(response);
            window.localStorage.setItem('MergeModel', json);
            window.localStorage.setItem('TranIds', ids.join(","));
            window.location.href = mergeUrl;
        });
    };
</script>

<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
