function getFileName() {
    var filterName = ($("#DefaultFilterSelect").val() || "");

    if (filterName) {
        filterName += "-";
    };

    return scrudFactory.title + "-" + filterName + stringFormat(Resources.Titles.PageN(), getPageNumber());
};

function createPDF() {
    printGridView(reportExportTemplatePath, reportHeaderPath, scrudFactory.title, "ScrudView", date, user, office, '', 2, 0, $("#MarkupHidden"), null, downloadPDF);
};

function createXls() {
    printGridView(reportExportTemplatePath, reportHeaderPath, scrudFactory.title, "ScrudView", date, user, office, '', 2, 0, $("#MarkupHidden"), null, downloadXls);
};

function createDoc() {
    printGridView(reportExportTemplatePath, reportHeaderPath, scrudFactory.title, "ScrudView", date, user, office, '', 2, 0, $("#MarkupHidden"), null, downloadDoc);
};

function print() {
    printGridView(reportExportTemplatePath, reportHeaderPath, scrudFactory.title, "ScrudView", date, user, office, '', 2, 0);
};

function downloadXls() {
    function request(html, documentName) {
        var url = "/Services/CreateDocument.asmx/CreateXls";
        var data = appendParameter("", "html", html);
        data = appendParameter(data, "documentName", documentName);
        data = getData(data);

        return getAjax(url, data);
    };

    var html = $("#MarkupHidden").val();
    var fileName = getFileName() + ".xls";
    var ajax = request(html, fileName);

    ajax.success(function (response) {
        startDownload(response.d);
    });
};

function downloadDoc() {
    function request(html, documentName) {
        var url = "/Services/CreateDocument.asmx/CreateDoc";
        var data = appendParameter("", "html", html);
        data = appendParameter(data, "documentName", documentName);
        data = getData(data);

        return getAjax(url, data);
    };

    var html = $("#MarkupHidden").val();
    var fileName = getFileName() + ".doc";
    var ajax = request(html, fileName);

    ajax.success(function (response) {
        startDownload(response.d);
    });
};


function downloadPDF() {
    function request(html, documentName) {
        var url = "/Services/CreateDocument.asmx/CreatePdf";
        var data = appendParameter("", "html", html);
        data = appendParameter(data, "documentName", documentName);
        data = getData(data);

        return getAjax(url, data);
    };

    var html = $("#MarkupHidden").val();
    var fileName = getFileName() + ".pdf";
    var ajax = request(html, fileName);

    ajax.success(function (response) {
        startDownload(response.d);
    });
};

function startDownload(path) {
    var anchor = $("#DownloadAnchor");
    anchor.attr("href", path);
    anchor[0].click();
};

