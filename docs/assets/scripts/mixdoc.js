//Gumbo (StackOverflow)
//http://stackoverflow.com/questions/6238351/fastest-way-to-detect-external-urls
function isExternal(url) {
    var match = url.match(/^([^:\/?#]+:)?(?:\/\/([^\/?#]*))?([^?#]+)?(\?[^#]*)?(#.*)?/);
    if (typeof match[1] === "string" && match[1].length > 0 && match[1].toLowerCase() !== location.protocol) return true;
    if (typeof match[2] === "string" && match[2].length > 0 && match[2].replace(new RegExp(":(" + { "http:": 80, "https:": 443 }[location.protocol] + ")?$"), "") !== location.host) return true;
    return false;
};


function processSocialSharing() {
    var url = encodeURIComponent(window.location.href);
    var title = encodeURIComponent($("h1:first").html());
    var tweet = encodeURIComponent("#mixerp documentation " + title + "\r\n" + url);
    var message = 'Hi,' + escape("\n\n") + 'The following link is related to the topic %22' + title + '%22 from MixERP documentation.' + escape("\n\n") + url + escape("\n\n");

    $(".social.sharing a").each(function () {
        var el = $(this);
        var href = el.attr("href");

        href = href.replace("{url}", url);
        href = href.replace("{title}", title);
        href = href.replace("{tweet}", tweet);
        href = href.replace("{message}", message);

        el.attr("href", href);
    });
};


$(document).ready(function () {
    $("img:not(.logo)").addClass("ui bordered centered rounded image");
    processSocialSharing();
});