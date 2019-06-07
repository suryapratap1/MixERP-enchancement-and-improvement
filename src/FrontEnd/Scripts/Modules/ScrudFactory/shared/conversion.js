function toUnderscoreCase(name) {
    const letters = [name[0]];

    const length = name.length;

    for (let i = 1; i < length; i++) {
        const letter = name[i];
        const isNumer = $.isNumeric(letter);

        if (!isNumer && letter.toUpperCase() === letter) {
            letters.push("_");
            letters.push(letter);
        }
        else if (isNumer) {
            const previous = name[i - 1];

            if (!$.isNumeric(previous)) {
                letters.push("_");
            };

            letters.push(letter);


            if (i + 1 >= length) {
                continue;
            };

            const next = name[i + 1];

            if (next && !$.isNumeric(next)) {
                letters.push("_");
            };
        }
        else {
            letters.push(letter);
        };
    };

    const result = letters.join("").toLowerCase();
    return result;
};

function toProperCase(str) {
    const result = str.replace(/_([a-z0-9])/g, function (g) { return g[1].toUpperCase(); });
    return result.charAt(0).toUpperCase() + result.slice(1);
};
