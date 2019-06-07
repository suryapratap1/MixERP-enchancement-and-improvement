var uploaderInitialized = false;
var allowedExtensions = [".jpg", ".jpeg", ".bmp", ".gif", ".png"];
var uploaderTemplate = '<div class="ui uploader field">\
                            <div class="">\
                                <img src="{0}" class="ui bordered rounded image preview">\
                            </div>\
                            </div>\
                            <div class="uploader">\
                            <label for="file{1}" class="ui pink icon button">\
                                <i class="file icon"></i>\
                                Upload</label>\
                                <input id="file{1}" class="file" data-target="{1}" style="display: none" type="file">\
                            </div>';

function initializeUploader() {
    var instances = $("input.image");
    instances.each(function () {
        var el = $(this);
        el.parent().find(".uploader").remove();
        var val = el.val();
        var id = el.attr("id");
        var imagePath = "/Static/images/mixerp-logo-light.png";

        if (val) {
            imagePath = "/Resource/Static/Attachments/" + val;
        }

        el.attr("style", "display:none;");
        el.parent().append(stringFormat(uploaderTemplate, imagePath, id));
    });


    var file = $(".file");

    file.change(function () {
        if (isValidExtension(this)) {
            readURL(this);
            var el = $(this);
            var segment = el.closest(".segment");
            var target = $("#" + el.attr("data-target"));

            segment.addClass("loading");

            el.upload("/FileUploadHanlder.ashx", function (uploadedFileName) {
                target.val(uploadedFileName);
                target.attr("data-val", uploadedFileName);
                segment.removeClass("loading");
            }, function (progress, value) {
                //not implemented yet.
            });
        };
    });

    uploaderInitialized = true;
};

function isValidExtension(el) {

    if (el.type === "file") {
        var fileName = el.value;

        if (fileName.length > 0) {

            var valid = false;

            for (var i = 0; i < allowedExtensions.length; i++) {
                var extension = allowedExtensions[i];

                if (fileName.substr(fileName.length - extension.length, extension.length).toLowerCase() === extension.toLowerCase()) {
                    valid = true;
                    break;
                };
            };

            if (!valid) {
                displayMessage(Resources.Warnings.InvalidFileExtension());
                el.value = "";
                return false;
            };
        };
    };

    return true;
};

function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            var image = $(input).parent().parent().parent().find("img.preview");
            image.attr('src', e.target.result);
        };

        reader.readAsDataURL(input.files[0]);
    };
};