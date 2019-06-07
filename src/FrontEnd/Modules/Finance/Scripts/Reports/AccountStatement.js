/*jshint -W032 */

var accountNumberSelect = $("#AccountNumberSelect");
var accountNumberInputText = $("#AccountNumberInputText");
var statementGridView = $("#StatementGridView");
var printIcon = $(".print.icon");
var printButton = $("#PrintButton");
var fromDateTextBox = $("#FromDateTextBox");
var toDateTextBox = $("#ToDateTextBox");
var reconcileModal = $("#ReconcileModal");
var currentBookDateInputText = $("#CurrentBookDateInputText");
var yearInputText = $("#YearInputText");
var monthInputText = $("#MonthInputText");
var dayInputText = $("#DayInputText");
var tranCodeInputText = $("#TranCodeInputText");
var checkBoxColumnPosition = "2";
var bookDateColumnPosition = "5";
var tranCodeColumnPosition = "3";


printIcon.click(function () {
    var selected = $(this).parent().parent().find("td:nth-child(3)").html().trim();
    if (!isNullOrWhiteSpace(selected)) {
        var report = "/Modules/Finance/Reports/GLAdviceReport.mix?TranCode=" + selected;
        showWindow(report);
    };
});

function getSelectedItems() {
    var checkBoxColumnPosition = "2";
    var idColumnPosition = "3";

    var selection = getSelectedCheckBoxItemIds(checkBoxColumnPosition, idColumnPosition, statementGridView);

    if (selection.length > 0) {
        $("#SelectedValuesHidden").val(selection.join(','));
        return true;
    } else {
        $.notify(Resources.Titles.NothingSelected(), "error");
        return false;
    }
};

$(document).ready(function () {
    loadAccounts();
    createCascadingPair(accountNumberSelect, accountNumberInputText);
    createFlaggedRows(statementGridView);
});

function loadAccounts() {
    var selected = accountNumberInputText.val();

    url = "/Modules/Finance/Services/AccountData.asmx/ListAccounts";
    ajaxDataBind(url, accountNumberSelect, null, selected, accountNumberInputText);
};

statementGridView.find('tr').click(function () {
    var checkBox = $(this).find('td input:checkbox');
    toogleSelection(checkBox);
});

printButton.click(function () {
    var report = "AccountStatementReport.mix?AccountNumber={0}&From={1}&To={2}";
    var accountNumber = accountNumberInputText.val();
    var from = fromDateTextBox.val();
    var to = toDateTextBox.val();

    report = String.format(report, accountNumber, from, to);
    showWindow(report);
});

function showReconcileWindow() {
    var selection = getSelectedCheckBoxItemIds(checkBoxColumnPosition, bookDateColumnPosition, statementGridView, 1)[0];
    var tranCode = getSelectedCheckBoxItemIds(checkBoxColumnPosition, tranCodeColumnPosition, statementGridView, 1)[0];

    var parsedDate = window.parseLocalizedDate(selection);


    if (parsedDate) {
        var year = parsedDate.getFullYear();
        var month = parsedDate.getMonth() + 1;
        var day = parsedDate.getDate();

        currentBookDateInputText.val(selection);

        yearInputText.val(year);
        monthInputText.val(month);
        dayInputText.val(day);

        tranCodeInputText.val(tranCode);

        reconcileModal.modal("show");
    };

    return false;//Prevent postback
};

function reconcile() {
    var tranCode = tranCodeInputText.val();
    var year = parseInt2(yearInputText.val());
    var month = parseInt2(monthInputText.val());
    var day = parseInt2(dayInputText.val());

    var currentDate = window.parseLocalizedDate(currentBookDateInputText.val());
    var reconciledDate = new Date(year, month - 1, day);
    //Javascript month begins with 0  ^^^^^^^^^^^

    if (reconciledDate.equals(currentDate)) {
        return;
    };

    url = "/Modules/Finance/Services/Transactions.asmx/Reconcile";
    var data = appendParameter("", "tranCode", tranCode);
    data = appendParameter(data, "year", year);
    data = appendParameter(data, "month", month);
    data = appendParameter(data, "day", day);

    data = getData(data);

    var ajaxReconcile = getAjax(url, data);

    ajaxReconcile.success(function (msg) {
        if (msg.d) {

            var selectedRowIndex = getSelectedRowIndex();

            var target = statementGridView.find("tbody tr:nth-child(" + selectedRowIndex + ")").find("td:nth-child(" + bookDateColumnPosition + ")");

            target.html(reconciledDate.toString(shortDateFormat));
            target.parent().addClass("warning");
            reconcileModal.modal("hide");
        };
    });

    ajaxReconcile.fail(function (xhr) {
        alert(JSON.parse(xhr.responseText).Message);
    });
};


// ReSharper disable once NotAllPathsReturnValue
function getSelectedRowIndex() {
    var index;

    statementGridView.find("tr").each(function (i) {
        var row = $(this);

        //Get the instance of the cell which contains the checkbox.
        var checkBoxContainer = row.select("td:nth-child(" + checkBoxColumnPosition + ")");

        //Get the instance of the checkbox from the container.
        var checkBox = checkBoxContainer.find("input");

        if (checkBox) {
            //Check if the checkbox was selected or checked.
            if (checkBox.prop("checked")) {
                index = i;
                return false;//break;
            };
        };
    });

    return index;
};