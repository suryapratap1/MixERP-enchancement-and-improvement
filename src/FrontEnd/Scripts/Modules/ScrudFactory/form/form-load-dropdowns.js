function loadDropdowns() {
    if (!dropdownsLoaded) {
        var dropdowns = $(".form.factory select");

        dropdowns.each(function (i, v) {
            var dropdown = $(v);

            var selectedValue = "";

            if (dropdown.val()) {
                selectedValue = (dropdown.val().toString() || "");
            };

            if (!selectedValue) {
                selectedValue = dropdown.attr("data-value");

                if (selectedValue) {
                    dropdown.val(selectedValue.toString());
                };
            };

            dropdown.dropdown({ placeholder: false });
        });

        dropdownsLoaded = true;
    };
};