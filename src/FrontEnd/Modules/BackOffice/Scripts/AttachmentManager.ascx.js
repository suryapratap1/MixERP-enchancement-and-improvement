function save(book, id, attachmentsJSON) {
    var url = "/Modules/BackOffice/Services/Attachments.asmx/Save";
    var data = appendParameter("", "book", book);
    data = appendParameter(data, "id", id);
    data = appendParameter(data, "attachmentsJSON", attachmentsJSON);
    data = getData(data);

    return getAjax(url, data);
};

function getAttachments(book, id) {
    var url = "/api/core/attachment-view/get-where/1";

    var filters = [];

    filters.push(window.getAjaxColumnFilter("WHERE", "book", window.FilterConditions.IsEqualTo, book));
    filters.push(window.getAjaxColumnFilter("AND", "resource_id", window.FilterConditions.IsEqualTo, id));

    var data = JSON.stringify(filters);

    return getAjaxRequest(url, "POST", data);
};

function deleteAttachment(id) {
    var url = "/Modules/BackOffice/Services/Attachments.asmx/DeleteAttachment";
    var data = appendParameter("", "id", id);

    data = getData(data);

    return getAjax(url, data);
};

MixERPApp.controller("AttachmentController", function ($scope, $sce, $window) {

    $scope.displayAttachments = function() {
        var book = getQueryStringByName("Book");
        var id = parseFloat2(getQueryStringByName("Id"));

        if (isNullOrWhiteSpace(book) || id <= 0) {
            return;
        };

        var ajaxGetAttachments = getAttachments(book, id);

        ajaxGetAttachments.success(function (msg) {
            var data = msg;

            $.each(data, function (i, v) {
                v.ImagePath = "/api/core/attachment/document/250/300/" + v.FilePath;
                v.RawUrl = "/api/core/attachment/document/raw/" + v.FilePath;
                v.AddedOn = v.AddedOn.toString().toMoment();
            });

            $scope.$apply(function () {
                $scope.attachments = data;
            });
        });
    };

    $scope.displayAttachments();

    $scope.getResource = function (func) {
        return $window.executeFunctionByName(func, $window);
    };

    $scope.initializeModal = function (attachment) {
        $('#opener .header').html("<i class='photo icon'></i>" + attachment.OriginalFileName);
        $('#opener img').attr('src', '/api/core/attachment/document/900/500/' + attachment.FilePath);
        $('#opener p').html(attachment.Comment);

        $("#opener").modal('setting', 'transition', 'vertical flip').modal("show");
    };

    $scope.removeAttachment = function (attachment) {
        var id = attachment.AttachmentId;

        if (confirm(Resources.Questions.AreYouSure())) {
            var ajaxDeleteAttachment = deleteAttachment(id);

            ajaxDeleteAttachment.success(function () {
                $("#card" + id).remove();
                displaySuccess();
            });

            ajaxDeleteAttachment.fail(function (xhr) {
                logAjaxErrorMessage(xhr);
            });
        };
    };


    var saveButton = $("#SaveButton");

    saveButton.click(function () {
        var uploads = uploadedFilesHidden.val();
        if (isNullOrWhiteSpace(uploads)) {
            $.notify("Nothing to save.");
            return;
        };

        var book = getQueryStringByName("Book");
        var id = getQueryStringByName("Id");

        var ajaxSave = save(book, id, uploads);

        ajaxSave.success(function (msg) {
            if (msg.d) {
                resetAttachmentForm();
                displaySuccess();
                $scope.displayAttachments();
            };
        });

        ajaxSave.fail(function (xhr) {
            logAjaxErrorMessage(xhr);
        });
    });
});






