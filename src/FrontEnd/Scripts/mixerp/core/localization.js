$(document).ready(function () {
    setCurrencyFormat();
    setNumberFormat();

    if (typeof Sys !== "undefined") {
        Sys.WebForms.PageRequestManager.getInstance().add_endRequest(Page_EndRequest);
    }
});

//Fired on ASP.net Ajax Postback
function Page_EndRequest() {
    setRegionalFormat();
    if (typeof (AsyncListener) === "function") {
        AsyncListener();
    };
};

function setRegionalFormat()
{
    setCurrencyFormat();
    setNumberFormat();
};
var setCurrencyFormat = function () {
    if (typeof currencyDecimalPlaces === "undefined" || typeof decimalSeparator === "undefined" || typeof thousandSeparator === "undefined") {
        return;
    };

    $('input.currency').number(true, currencyDecimalPlaces, decimalSeparator, thousandSeparator);
};

var setNumberFormat = function () {
    if (typeof decimalSeparator === "undefined" || typeof thousandSeparator === "undefined") {
        return;
    };

    $('input.decimal').number(true, currencyDecimalPlaces, decimalSeparator, thousandSeparator);
    $('input.decimal4').number(true, 4, decimalSeparator, thousandSeparator);
    $('input.integer').number(true, 0, decimalSeparator, thousandSeparator);
};

var parseFormattedNumber = function (input) {
    if (typeof window.thousandSeparator === "undefined") {
        window.thousandSeparator = ",";
    };

    if (typeof window.decimalSeparator === "undefined") {
        window.decimalSeparator = ".";
    };

    var result = input.split(thousandSeparator).join("");
    result = result.split(decimalSeparator).join(".");
    return result;
};

var getFormattedNumber = function (input, isInteger) {
    if (typeof window.currencyDecimalPlaces === "undefined") {
        window.currencyDecimalPlaces = 2;
    };

    if (typeof window.thousandSeparator === "undefined") {
        window.thousandSeparator = ",";
    };

    if (typeof window.decimalSeparator === "undefined") {
        window.decimalSeparator = ".";
    };

    var decimalPlaces = currencyDecimalPlaces;

    if (isInteger) {
        decimalPlaces = 0;
    };

    return $.number(input, decimalPlaces, decimalSeparator, thousandSeparator);
};

stringFormat = function () {
    var s = arguments[0];

    for (var i = 0; i < arguments.length - 1; i++) {
        var reg = new RegExp("\\{" + i + "\\}", "gm");
        s = s.replace(reg, arguments[i + 1]);
    };

    return s;
};

String.prototype.toFormattedDate = function () {
    if (isNullOrWhiteSpace(this)) {
        return "";
    };

    return new Date(this).toString(window.shortDateFormat);
};

function converToUTC(date) {
    return new Date(date.getUTCFullYear(), date.getUTCMonth(), date.getUTCDate(), date.getUTCHours(), date.getUTCMinutes(), date.getUTCSeconds());
};

String.prototype.toMoment = function () {
    if (isNullOrWhiteSpace(this)) {
        return "";
    };

    var d = converToUTC(new Date(this));

    return window.moment(d).fromNow();
};

String.prototype.toTime = function () {
    function padded(num, size) {
        var s = size - num.toString().length + 1;
        return Array(+(s > 0 && s)).join("0") + num;
    };

    if (isNullOrWhiteSpace(this)) {
        return "";
    };

    var val = this;

    if (val.indexOf("Z", val.length - 1) === -1) {
        val += "Z";
    };

    var d = new Date(val);

    return padded(d.getUTCHours(), 2) + ":" + padded(d.getUTCMinutes(), 2);
};

String.prototype.toFormattedHours = function () {
    if (isNullOrWhiteSpace(this)) {
        return "";
    };

    if (!window.Resources.Labels.NHours) {
        return this;
    };


    var val = stringFormat(window.Resources.Labels.NHours(), this);
    return val;
};

String.prototype.toFormattedMinutes = function () {
    if (isNullOrWhiteSpace(this)) {
        return "";
    };

    if (!window.Resources.Labels.NMinutes) {
        return this;
    };


    var val = stringFormat(window.Resources.Labels.NMinutes(), this);
    return val;
};