function jsonToCsv(json) {
    var header = "";
    var rows = "";

    $.each(json[0], function (name) {
        if (header) {
            header += ",";
        };

        header += '"' + name.replace(/"/g, '""') + '"';
    });

    header += "\r\n";

    $.each(json, function (i, value) {
        var row = "";

        $.each(value, function (key, val) {
            if (row) {
                row += ",";
            };

            if (val == null) {
                row += '""';
            }
            else {
                row += '"' + val.toString().replace(/"/g, '""') + '"';
            };
        });

        row += "\r\n";
        rows += row;
    });

    var csv = header + rows;
    return csv;
};


$("#DownloadTemplateButton").click(function () {
    function request() {
        var url = scrudFactory.formAPI + "/export";
        return getAjaxRequest(url);
    };

    var ajax = request();
    var el = this;

    if (!el.href) {
        $(el).addClass("loading");

        ajax.success(function (response) {
            var csv = jsonToCsv(response);
            var uri = 'data:text/csv;charset=utf-8,' + escape(csv);
            el.href = uri;
            el.target = "_blank";
            el.download = scrudFactory.title + ".csv";

            $(el).removeClass("loading");

            el.click();
        });

        ajax.fail(function () {
            $(el).removeClass("loading");
        });
    };
});