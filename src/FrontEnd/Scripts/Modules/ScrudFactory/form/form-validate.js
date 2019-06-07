function appendError(message) {
    var item = $("<li/>");
    item.html(message);
    console.log(message);
    
    if(scrudFactory.tabs.length > 1){
        $("#ScrudFormErrorModal .error-list").append(item);
    };
};

function resetError() {
    $("#ScrudFormErrorModal .error-list").html("");
};


function validate() {
    resetError();
    var result = validator.validate($(".form.factory"), function (el) {
        var label = $(el).closest(".field").find("label");
        var message = label.html() + " : " + window.Resources.Labels.ThisFieldIsRequired();
        appendError(message);
    }, true);

    if (!result) {
        if (scrudFactory.tabs.length > 1) {
            $("#ScrudFormErrorModal").modal({ blurring: true }).modal("show");
        };

        return false;
    };

    return true;
};

function initializeValidators() {
    validator.initialize($(".form.factory"));
};