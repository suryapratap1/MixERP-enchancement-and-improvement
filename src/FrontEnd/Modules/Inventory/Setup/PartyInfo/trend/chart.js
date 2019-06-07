function showTrend() {
    var sales, purchases;

    var partyId = getQueryStringByName("PartyId");
    var ajaxGetSalesChartView = getSalesChartView(partyId);

    ajaxGetSalesChartView.success(function (msg) {
        sales = msg.d;

        var ajaxGetPurchaseChartView = getPurchaseChartView(partyId);
        ajaxGetPurchaseChartView.success(function (msg) {
            purchases = msg.d;

            createTrendChart(sales, purchases);
        });
    });
};

function createTrendChart(sales, purchases) {
    var el = $("#TrendChart");
    var canvas = $("<canvas height='300'/>");
    var legend = $("<div class='legend'/>");
    canvas.attr("width", el.width());

    el.html("").append(canvas).append(legend);

    var max = Math.max(sales.length, purchases.length);
    var labels = [];
    var salesData = [];
    var purchaseData = [];

    var i;

    for (i = 0; i < max; i++) {
        labels.push(i.toString());
    };


    for (i = 0; i < sales.length; i++) {
        salesData.push(sales[i].Amount);
    };

    for (i = 0; i < purchases.length; i++) {
        purchaseData.push(purchases[i].Amount);
    };



    var data = {
        labels: labels,
        datasets: [
            {
                label: "Sales",
                fillColor: "rgba(220,220,220,0.2)",
                strokeColor: chartColors[1],
                pointColor: chartColors[1],
                pointStrokeColor: "#fff",
                pointHighlightFill: "#fff",
                pointHighlightStroke: "rgba(220,220,220,1)",
                data: salesData
            },
            {
                label: "Purchase",
                fillColor: "rgba(220,220,220,0.2)",
                strokeColor: "rgba(220,220,220,1)",
                pointColor: "rgba(220,220,220,1)",
                pointStrokeColor: "#fff",
                pointHighlightFill: "#fff",
                pointHighlightStroke: "rgba(220,220,220,1)",
                data: purchaseData
            }
        ]
    };

    var ctx = canvas.get(0).getContext("2d");
    new Chart(ctx).Line(data);
};