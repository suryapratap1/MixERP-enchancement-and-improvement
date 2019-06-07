var el = document.getElementById('map-container');
var colors = ['#A8F792', '#F2C3FA', '#E892F7', '#D4C3FA', '#C3C4FA', '#DB9E58', '#58DB91', '#F792B4', '#DBCC58', '#DB9E58', '#58DBDB', '#D558DB', '#D6313C', '#3134D6', '#A1CCA2'];
var table = $("#SalesByGeographyGridView");

function parseTable() {
    var items = [];
    var data = {};
    var fills = {};

    var counter = 0;
    table.find("tbody tr").each(function () {
        counter++;
        var countryCode = $(this).find("td:first-child").html();
        var sales = parseFloat2($(this).find("td:last-child").html());

        var code = iso3Countries[countryCode];

        data[code] = {
            fillKey: code,
            isoCode: countryCode,
            sales: getFormattedNumber(sales)
        };

        fills[code] = colors[counter];
    });

    fills['defaultFill'] = '#DCE3E8';

    items.push(data);
    items.push(fills);

    table.remove();

    return items;
};

function createMap() {
    var items = parseTable();

    var map = new Datamap({
        element: document.getElementById('map-container'),
        fills: items[1],
        dataType: 'json',
        data: items[0],
        geographyConfig: {
            popupTemplate: function (geo, data) {
                if (data) {
                return ['<div class="ui compact segment">' +
                    '<div class="ui small header"><i class="' + data.isoCode.toLowerCase() + ' flag"></i><div class="content">'
                    + geo.properties.name + '</div>',
                    '<div class="sub header">' + Resources.Titles.TotalSales() + " " + baseCurrencyCode + data.sales,
                    '</div></div>'].join('');
                }
            }
        }
    });
};

$(document).ready(function () {
    createMap();
});


