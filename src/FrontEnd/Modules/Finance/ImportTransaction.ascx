<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ImportTransaction.ascx.cs"
    Inherits="MixERP.Net.Core.Modules.Finance.ImportTransaction"
    OverridePath="/Modules/Finance/JournalVoucher.mix" %>

<style>
    tfoot tr {
        background-color: #F0F1F1;
    }
</style>

<div id="ImportSegment" class="ui basic segment">
    <div class="ui huge grey header">
        Import Transaction
    </div>

    <div class="ui yellow message">
        <i class="close icon"></i>
        You can bulk import journal transaction from a CSV file into MixERP.
    Click "Export Template" button to download a CSV template file.
    Create a file that matches with the export template.
    Import the CSV file.
    </div>

    <div class="ui buttons">
        <a class="ui blue basic button"
            href="data:attachment/csv,StatementReference,AccountNumber,Account,CashRepository,Currency,Debit,Credit,ExchangeRate,LocalCurrencyDebit,LocalCurrencyCredit"
            target="_blank"
            download="ImportTransaction.csv"
            id="ExportButton">Export Template</a>
        <div class="ui blue button">
            <label for="file">
                <span data-localize="Titles.ImportData"></span>
            </label>
            <input type="file" id="file" style="display: none;">
        </div>
    </div>

    <div id="ErrorModal" class="ui small negative modal">
        <i class="close icon"></i>
        <div class="orange header">
            <i class="warning sign icon"></i>
            Import Failed!
        </div>
        <div class="content">
            <div class="description">
                <div class="ui header">Cannot Validate Your File</div>
                <p>
                    We failed to import the file you uploaded.
                </p>
                <ul id="error-list" class="error-message">
                </ul>
            </div>
        </div>
        <div class="actions">
            <div class="ui positive close button">
                Lets do this again
            </div>
        </div>
    </div>

    <table class="ui table" id="ImportTable">
        <thead>
            <tr>
                <th>
                    <span data-localize="Titles.StatementReference"></span>
                </th>
                <th>
                    <span data-localize="Titles.AccountNumber"></span>
                </th>
                <th>
                    <span data-localize="Titles.AccountName"></span>
                </th>
                <th>
                    <span data-localize="Titles.CashRepository"></span>
                </th>
                <th>
                    <span data-localize="Titles.Currency"></span>
                </th>
                <th class="right aligned">
                    <span data-localize="Titles.Debit"></span>
                </th>
                <th class="right aligned">
                    <span data-localize="Titles.Credit"></span>
                </th>
                <th class="right aligned">
                    <span data-localize="Titles.ER"></span>
                </th>
                <th class="right aligned">
                    <span data-localize="Titles.LCDebit"></span>
                </th>
                <th class="right aligned">
                    <span data-localize="Titles.LCCredit"></span>
                </th>
            </tr>
        </thead>
        <tfoot>
            <tr>
                <td colspan="8" class="right aligned">
                    <strong>
                        <span data-localize="Titles.GrandTotal"></span>
                    </strong>
                </td>
                <td class="right aligned"></td>
                <td class="right aligned"></td>
            </tr>
        </tfoot>
        <tbody>
        </tbody>
    </table>

    <div id="ViewErrorsButton" class="ui orange button">View Errors</div>
    <div id="ValidateButton" class="ui positive button">Validate</div>

    <div class="ui form segment vpad8" style="width: 500px;">
        <div class="ui grey large header">
            About to Import
        </div>
        <div class="ui divider"></div>
        <div class="two fields">
            <div class="field">
                <label>
                    <span data-localize="Titles.ValueDate"></span>
                </label>
                <input type="text" id="ValueDateInputText" class="date" value="d" />
            </div>
            <div class="field">
                <label>
                    <span data-localize="Titles.BookDate"></span>
                </label>
                <input type="text" id="BookDateInputText" class="date" value="d" />
            </div>
        </div>
        <div class="field">
            <label>
                <span data-localize="Titles.ReferenceNumber"></span>
            </label>
            <input type="text" id="ReferenceNumberInputText" />
        </div>
        <div class="field">
            <label>
                <span data-localize="Titles.CostCenter"></span>
            </label>
            <select id="CostCenterSelect" class="ui dropdown"></select>
        </div>
        <div id="NextButton" class="ui positive button">Next</div>
    </div>

</div>

<script>

    var validated = false;

    function loadCostCenters() {
        var url = "/api/office/cost-center/display-fields";
        ajaxDataBind(url, $("#CostCenterSelect"), null, null, null, null, "Key", "Value");
    };

    $(document).ready(function () {
        loadCostCenters();
    });

    function getColumn(text, cls) {
        var column = $("<td />");
        if (cls) {
            column.addClass(cls);
        };
        column.html(text);
        return column;
    };

    function getRow(entity, line) {
        var row = $("<tr />");
        row.append(getColumn(entity.StatementReference));

        if (!entity.AccountNumber && !entity.Account) {
            row.addClass("error");
            var message = 'Invalid data found on line {0}. Either "AccountNumber" or "AccountName" should contain a value.';
            makeDirty(stringFormat(message, line));
        };

        row.append(getColumn(entity.AccountNumber));
        row.append(getColumn(entity.Account));
        row.append(getColumn(entity.CashRepository));
        row.append(getColumn(entity.Currency));
        row.append(getColumn(entity.Debit, "right aligned"));
        row.append(getColumn(entity.Credit, "right aligned"));
        row.append(getColumn(entity.ExchangeRate, "right aligned"));
        row.append(getColumn(entity.LocalCurrencyDebit, "right aligned"));
        row.append(getColumn(entity.LocalCurrencyCredit, "right aligned"));

        return row;
    };

    function appendError(message) {
        var item = $("<li/>");
        item.html(message);
        $("#error-list").append(item);
    };

    function makeDirty(message) {
        $("#ImportTable").addClass("invalid red");
        appendError(message);
    };

    $("#ViewErrorsButton").click(function () {
        if ($("#ImportTable").is(".invalid")) {
            $("#ErrorModal").modal({ blurring: true }).modal("show");
        };
    });



    function reset() {
        $("#ImportTable").removeClass("invalid red");
        $("#ImportTable tr").removeClass("error");
        $("#error-list").html("");
        validated = false;
    };

    $("#file").change(function () {
        reset();
        var file = this.files[0];

        if (!file) {
            return;
        };

        var supportedFileTypes = ["text/csv", "application/csv"];

        if (supportedFileTypes.indexOf(file.type) === -1) {
            $(".big.error").addClass("vpad8").html(stringFormat(window.Resources.Labels.UploadInvalidTryAgain(), file.type));
            return;
        };

        var reader = new FileReader();
        reader.onload = function () {
            var result = reader.result;
            var entities = Papa.parse(result, { "header": true, skipEmptyLines: true }).data;

            var drTotal = 0;
            var crTotal = 0;

            $("#ImportTable tbody").html("");

            var c = 0;
            $.each(entities, function () {
                c++;
                var row = getRow(this, c);

                drTotal += parseFloat(this.LocalCurrencyDebit || 0);
                crTotal += parseFloat(this.LocalCurrencyCredit || 0);
                $("#ImportTable tbody").append(row);
            });

            $("#ImportTable tfoot td:nth-child(2)").html(drTotal.toString().bold());
            $("#ImportTable tfoot td:nth-child(3)").html(crTotal.toString().bold());

            if (drTotal !== crTotal) {
                makeDirty(window.Resources.Warnings.ReferencingSidesNotEqual());
                $("#ImportTable tfoot tr").addClass("error");
            };


            var accountNumbers = $("#ImportTable tbody td:nth-child(2)").map(function () { return $(this).text(); }).get();
            var accountNames = $("#ImportTable tbody td:nth-child(3)").map(function () { return $(this).text(); }).get();

            var numbersToQuery = [];
            var namesToQuery = [];

            $.each(accountNumbers, function (i, v) {
                if (isNullOrWhiteSpace(v)) {
                    namesToQuery.push({
                        index: i,
                        item: accountNames[i]
                    });
                };
            });

            $.each(accountNames, function (i, v) {
                if (isNullOrWhiteSpace(v)) {
                    numbersToQuery.push({
                        index: i,
                        item: accountNumbers[i]
                    });
                };
            });


            equalizeNames(numbersToQuery);
            equalizeNumbers(namesToQuery);

            displayErrors();
        };



        reader.readAsText(file);
    });

    function displayErrors() {
        if ($("#ImportTable").is(".invalid")) {
            $("#ErrorModal").modal({ blurring: true }).modal("show");
            return;
        };
    };

    $("#ValidateButton").click(function () {
        validated = false;
        reset();
        var length = $("#ImportTable tbody tr").length;

        if (!length) {
            return;
        };

        $("#ImportSegment").addClass("loading");

        var accountNumbers = $("#ImportTable tbody td:nth-child(2)").map(function () { return $(this).text(); }).get();
        var numbersToQuery = [];

        $.each(accountNumbers, function (i, v) {
            numbersToQuery.push({
                index: i,
                item: v
            });
        });

        equalizeNames(numbersToQuery, function () {
            validated = !$("#ImportTable").is(".invalid");
            $("#ImportSegment").removeClass("loading");
        });
    });

    function equalizeNames(accountNumbers, callback) {
        function request(items) {
            var url = "/api/core/account/get-multiple-by-account-numbers?accountNumbers=";
            url += items.join("&accountNumbers=");
            return getAjaxRequest(url);
        };

        var items = Enumerable.From(accountNumbers).Select(function (x) { return x.item; }).ToArray();

        var ajax = request(items);
        ajax.success(function (response) {
            $.each(accountNumbers, function (i, v) {
                var item = Enumerable.From(response)
                    .Where(function (x) { return x.AccountNumber.toString() === v.item.toString(); }).FirstOrDefault();

                var position = parseInt(v.index) + 1;
                var selector = "#ImportTable tbody tr:nth-child(" + position + ") td:nth-child(3)";

                if (item) {
                    $(selector).html(item.AccountName.bold()).parent().addClass("positive");
                    return;
                };

                var invalidAccountNumber = 'Invalid account number "{0}".';
                invalidAccountNumber = stringFormat(invalidAccountNumber, v.item);

                $(selector).html("<i class='warning sign icon'></i>" + invalidAccountNumber).parent().addClass("error");

                var message = 'You have an invalid account number "{0}" on line {1}.';
                makeDirty(stringFormat(message, v.item, v.index + 1));
            });

            displayErrors();
            if (callback) {
                callback();
            };
        });
    };

    function equalizeNumbers(accountNames) {
        function request(items) {
            var url = "/api/core/account/get-multiple-by-account-names?";

            $.each(items, function (i) {
                if (i) {
                    url += "&";
                };

                url += "accountNames=";
                url += encodeURIComponent(this);
            });

            url += items.join("&accountNames=");
            return getAjaxRequest(url);
        };

        var items = Enumerable.From(accountNames).Select(function (x) { return x.item; }).ToArray();

        var ajax = request(items);

        ajax.success(function (response) {
            $.each(accountNames, function (i, v) {
                var item = Enumerable.From(response)
                    .Where(function (x) { return x.AccountName.toString() === v.item.toString(); }).FirstOrDefault();

                var position = parseInt(v.index) + 1;
                var selector = "#ImportTable tbody tr:nth-child(" + position + ") td:nth-child(2)";

                if (item) {
                    $(selector).html(item.AccountNumber.bold()).parent().addClass("positive");
                    return;
                };

                var invalidAccountName = 'Invalid account name "{0}".';
                invalidAccountName = stringFormat(invalidAccountName, v.item);

                $(selector).html("<i class='warning sign icon'></i>" + invalidAccountName).parent().addClass("error");

                var message = 'You have an invalid account name "{0}" on line {1}.';
                makeDirty(stringFormat(message, v.item, v.index + 1));
            });

            displayErrors();
        });
    };

    var tojson = function (el) {
        var colData = [];
        var rowData = [];
        var rows = el.find("tbody tr");

        rows.each(function () {
            var row = $(this);

            colData = [];

            row.find("td").each(function () {
                colData.push($(this).text());
            });

            rowData.push(colData);
        });

        var data = JSON.stringify(rowData);

        return data;
    };

    $("#NextButton").click(function () {
        var count = $("#ImportTable tbody tr").length;
        if (!count) {
            displayMessage("You have not imported any transaction.");
            return;
        };

        if (!validated) {
            displayMessage("Imported file is invalid.");
            return;
        };

        var importModel = {
            valueDate: $("#ValueDateInputText").val(),
            bookDate: $("#BookDateInputText").val(),
            referenceNumber: $("#ReferenceNumberInputText").val(),
            costCenter: $("#CostCenterSelect").val(),
            table: JSON.parse(tojson($("#ImportTable")))
        };

        window.localStorage.setItem('ImportModel', JSON.stringify(importModel));
        window.location.href = "Entry/JournalVoucher.mix";
    });


</script>
