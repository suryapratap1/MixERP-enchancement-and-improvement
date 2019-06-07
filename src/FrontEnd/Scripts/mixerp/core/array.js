function chunk_array(arr, len) {
    return arr.map(function (e, i) {
        return i % len === 0 ? arr.slice(i, i + len) : null;
    })
        .filter(function (e) { return e; });
};