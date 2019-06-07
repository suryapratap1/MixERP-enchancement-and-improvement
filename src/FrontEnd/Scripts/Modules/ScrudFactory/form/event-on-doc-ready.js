$(document).ready(function () {
    var queryString = getQueryStringByName(scrudFactory.queryStringKey || "");

    if (queryString) {
        loadEdit(queryString);
    } else {
        createForm();
    };
});
