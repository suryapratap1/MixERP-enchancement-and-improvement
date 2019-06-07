function getQueryStringByName(name) {
    if (!name) {
        return "";
    };
    name = name.replace(/[\[]/, "\\[").replace(/[\]]/, "\\]");
    var regex = new RegExp("[\\?&]" + name + "=([^&#]*)"),
        results = regex.exec(location.search);
    return results === null ? "" : decodeURIComponent(results[1].replace(/\+/g, " "));
};

//http://stackoverflow.com/questions/5999118/add-or-update-query-string-parameter
function updateQueryString(key, value, url) {
    if (!url) {
        url = window.location.href;
    };

    var expression = new RegExp("([?&])" + key + "=.*?(&|#|$)(.*)", "gi");
    var urlHash;

    if (expression.test(url)) {
        if (typeof value !== 'undefined' && value !== null)
            return url.replace(expression, '$1' + key + "=" + value + '$2$3');
        else {
            urlHash = url.split('#');
            url = urlHash[0].replace(expression, '$1$3').replace(/(&|\?)$/, '');
            if (typeof urlHash[1] !== 'undefined' && urlHash[1] !== null)
                url += '#' + urlHash[1];
            return url;
        }
    }
    else {
        if (typeof value !== 'undefined' && value !== null) {
            var separator = url.indexOf('?') !== -1 ? '&' : '?';
            urlHash = url.split('#');
            url = urlHash[0] + separator + key + '=' + value;
            if (typeof urlHash[1] !== 'undefined' && urlHash[1] !== null)
                url += '#' + urlHash[1];
            return url;
        }
        else
            return url;
    }
};

//Josh Stodola and Andy E
//http://stackoverflow.com/questions/2907482/how-to-get-the-query-string-by-javascript
function getQueryStrings() {
    var queryStrings = [];

    var decoded = function (s) { return decodeURIComponent(s.replace(/\+/g, " ")); };
    var querystrings = location.search.substring(1);
    var pairs = querystrings.split('&');

    for (var i in pairs) {
        if (pairs.hasOwnProperty(i)) {
            var key = pairs[i].split('=');
            if (key.length > 1) {
                var queryString = new Object();
                queryString.key = decoded(key[0]);
                queryString.value = decoded(key[1]);

                queryStrings.push(queryString);
            };
        };
    };

    return queryStrings;
};