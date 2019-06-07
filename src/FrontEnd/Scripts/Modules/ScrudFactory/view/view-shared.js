function getKeyColumnPosition() {
    if (typeof (scrudFactory.keyColumnPosition) === "undefined") {
        scrudFactory.keyColumnPosition = "3";
    };

    return scrudFactory.keyColumnPosition;
};
