function urlCheck(url, existsCallback, errorCallback) {
	$.ajax({
		url: url,
		type: 'HEAD',
		type: "get",
		async: true,
		error: function () {
			errorCallback();
		},
		success: function () {
			existsCallback();
		}
	});
}

$(document).ready(function () {
	loadDatePickerLocale(
		window.datepickerLanguagePath,
		function (datepickerLanguagePath) {
			addScriptReference(datepickerLanguagePath);
		},
		function () {
			window.datepickerLanguagePath = "";
		});
});

function loadDatePickerLocale(datepickerLanguagePath, existsCallback, otherwiseCallback) {
	datepickerLanguagePath = window.jqueryUIi18nPath + '/datepicker-' + window.culture + '.js';

	urlCheck(datepickerLanguagePath,
		function () {
			existsCallback(datepickerLanguagePath);
		},
		function () {
			datepickerLanguagePath = window.jqueryUIi18nPath + '/datepicker-' + window.language + '.js';

			urlCheck(datepickerLanguagePath,
				function () {
					existsCallback(datepickerLanguagePath);
				},
				function () {
					otherwiseCallback();
				});
		}
	);
};

function addScriptReference(path) {
    var script = document.createElement('script');
    script.type = 'text/javascript';
    script.async = true;
    script.src = path;

    var element = document.body.getElementsByTagName('script')[0];
    element.parentNode.insertBefore(script, element);
};