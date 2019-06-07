function getClassName() {
    if (scrudFactory.className) {
        return scrudFactory.className;
    };

    var table = scrudFactory.formTableName;

    if (!table) {
        table = scrudFactory.viewTableName;
    }

    var plural = toProperCase(table.split(".")[1]);
    return plural.singularize();
};