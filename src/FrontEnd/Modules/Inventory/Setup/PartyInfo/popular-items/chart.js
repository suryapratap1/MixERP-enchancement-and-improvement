function showPopularItems() {
    var partyId = getQueryStringByName("PartyId");
    var ajaxGetPartyItemChartView = getPartyItemChartView(partyId);

    ajaxGetPartyItemChartView.success(function (msg) {
        createPopularItemChart(msg.d);
    });
};

function createPopularItemChart(d) {
    var el = $("#ItemChart");
    var canvas = $("<canvas height='300'/>");
    var legendEl = $("<div class='legend'/>");
    canvas.attr("width", el.width());
    el.html("").append(canvas).append(legendEl);

    var data = [];

    for (var i = 0; i < d.length; i++) {
        var item = new Object();
        item.value = d[i].Total;
        item.color = chartColors[i];
        item.highlight = chartColors[i];
        item.label = d[i].ItemName;
        item.title = d[i].ItemName;

        data.push(item);
    };

    var options = {
        animationSteps: 100
    };

    var ctx = canvas.get(0).getContext("2d");
    new Chart(ctx).Pie(data, options);

    legend(legendEl.get(0), data);
};