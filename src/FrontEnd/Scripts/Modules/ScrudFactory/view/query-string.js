function getFilterQueryStringCount() {
    var qs = getQueryStrings();
    var ignoredQueryStrings = ["View", "Page"];
    var count = Enumerable.From(qs).Where(function (s) { return ignoredQueryStrings.indexOf(s.key) === -1; }).ToArray().length;

    return count;
};