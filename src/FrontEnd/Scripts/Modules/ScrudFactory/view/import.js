function prepEntities(entities) {
    //var numbers = ["short", "int", "long", "float", "double", "decimal"];
    var items = [];

    $.each(entities, function (i, v) {
        var entity = new Object();

        $.each(v, function (columnName, val) {
            //var type = Enumerable.From(metaDefinition.Columns).Where(function (x) { return x.ColumnName === columnName }).ToArray()[0].DataType;

            if (isNullOrWhiteSpace(val)) {
                val = null;
            };

            entity[columnName] = val;
        });

        items.push(entity);
    });

    return items;
};

$("#file").change(function () {
    function request(entities) {
        var url = scrudFactory.formAPI + "/bulk-import";
        var data = JSON.stringify(entities);
        return getAjaxRequest(url, "POST", data);
    };

    var el = $(this);
    $(".big.error").removeClass("vpad8").html("");
    var file = this.files[0];

    if (!file) {
        return;
    };

    var supportedFileTypes = ["text/csv", "application/csv"];

    if (supportedFileTypes.indexOf(file.type) === -1) {
        $(".big.error").addClass("vpad8").html(stringFormat(window.Resources.Labels.UploadInvalidTryAgain(), file.type));
        return;
    };

    $("#ProgressBar").show();
    var progress = $(".progress");

    showProgress(progress, 25, window.Resources.Labels.ProcessingYourCSVFile());

    var reader = new FileReader();

    reader.onload = function () {
        var result = reader.result;
        showProgress(progress, 50, window.Resources.Labels.SuccessfullyProcessedYourFile());
        var entities = Papa.parse(result, { "header": true, skipEmptyLines: true }).data;

        entities = prepEntities(entities);

        showProgress(progress, 50, window.Resources.Labels.RequestingImport());

        el.closest(".segment").find(".button").addClass("loading");

        var ajax = request(entities);

        ajax.success(function () {
            var message = stringFormat(window.Resources.Labels.ImportedNItems(), entities.length);
            showProgress(progress, 100, message);
            el.closest(".segment").find(".button").removeClass("loading");
        });

        ajax.fail(function (xhr) {
            $(".big.error").addClass("vpad8").html(getAjaxErrorMessage(xhr));
            el.closest(".segment").find(".button").removeClass("loading");
            showProgress(progress, 0, window.Resources.Labels.RollingBackChanges());
            $("#ProgressBar").fadeOut(2000);
        });
    };

    reader.readAsText(file);
});

function showProgress(el, percentage, message) {
    el.attr("data-percent", percentage.toString());
    el.find(".bar").css("width", percentage.toString() + "%");
    el.find(".label").text(percentage.toString() + "% - " + message);
};

