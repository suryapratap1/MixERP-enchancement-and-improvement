function bindSelect(el, data, valueField, textField) {
    $.each(data, function () {
        var option = "<option value='" + this[valueField] + "'>" + this[textField] + "</option>";
        el.append(option);
    });
};
