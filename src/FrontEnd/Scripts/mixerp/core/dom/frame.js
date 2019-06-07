function getParentWindow() {
    var parent;

    if (window.opener && window.opener.document) {
        parent = window.opener;
    };

    if (parent == undefined) {
        parent = window.parent;
    };

    return parent;
};

function closeWindow() {
    if (window.opener && window.opener.document) {
        top.close();
    } else {
        parent.jQuery.colorbox.close();
    };
};

function isFrame() {
    return window.self !== window.top;
};
