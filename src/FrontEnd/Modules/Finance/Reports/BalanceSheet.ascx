<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BalanceSheet.ascx.cs" Inherits="MixERP.Net.Core.Modules.Finance.Reports.BalanceSheet" %>

<style type="text/css">
    th:first-child {
        width: 400px;
    }
</style>
<asp:PlaceHolder runat="server" ID="Placeholder1"></asp:PlaceHolder>

<script type="text/javascript">

    var previousPeriodDateTextBox = $("#PreviousPeriodDateTextBox");
    var currentPeriodDateTextBox = $("#CurrentPeriodDateTextBox");
    var factorInputText = $("#FactorInputText");
    var printButton = $("#PrintButton");

    $(function () {

        var balanceSheetGridView = $("#BalanceSheetGridView");
        var previousPeriod = window.parseLocalizedDate(previousPeriodDateTextBox.val());
        var currentPeriod = window.parseLocalizedDate(currentPeriodDateTextBox.val());
        var factor = parseInt2(factorInputText.val());

        var url;
        var accountId;
        var previousBalanceCell;
        var currentBalanceCell;
        var previousBalance;
        var currentBalance;
        var html;

        function createVisualHint() {
            balanceSheetGridView.find("tr td:nth-child(4)").each(function () {
                accountId = parseInt2($(this).html());

                if (!accountId) {
                    $(this).parent().addClass("hint");
                } else {
                    var account = $(this).parent().find("td:first-child");
                    account.html("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + account.html());
                };
            });

            balanceSheetGridView.find("tr td:nth-child(4), th:nth-child(4)").remove();
            balanceSheetGridView.find("tr td:nth-child(4), th:nth-child(4)").remove();

        };

        function createLinkedBalances() {
            url = "/Modules/Finance/Reports/AccountStatementPopup.mix?AccountId={0}&To={1}";

            balanceSheetGridView.find("tbody tr td:nth-child(4)").each(function () {
                accountId = parseInt2($(this).html());

                previousBalanceCell = $(this).parent().find("td:nth-child(2)");
                currentBalanceCell = $(this).parent().find("td:nth-child(3)");

                previousBalance = parseFloat2(previousBalanceCell.html());
                currentBalance = parseFloat2(currentBalanceCell.html());

                previousBalance = (previousBalance === 0) ? "" : previousBalance;
                currentBalance = (currentBalance === 0) ? "" : currentBalance;

                if (accountId) {
                    html = "<a class='dotted underline' href='javascript:void(0);' onclick=\"showWindow('" + String.format(url, accountId, previousPeriod) + "');\">" + previousBalanceCell.html() + "</a>";
                    previousBalanceCell.html(html);

                    html = "<a class='dotted underline' href='javascript:void(0);' onclick=\"showWindow('" + String.format(url, accountId, currentPeriod) + "');\">" + currentBalanceCell.html() + "</a>";
                    currentBalanceCell.html(html);
                };

                if (previousBalance < 0) {
                    previousBalanceCell.addClass("strong error");
                };

                if (currentBalance < 0) {
                    currentBalanceCell.addClass("strong error");
                };
            });

            balanceSheetGridView.find("tbody tr td:nth-child(5)").each(function () {
                if ($(this).html().toLowerCase() === "true") {
                    url = "/Modules/Finance/Reports/RetainedEarningsPopup.mix?Date={0}&Factor={1}";

                    previousBalanceCell = $(this).parent().find("td:nth-child(2)");
                    currentBalanceCell = $(this).parent().find("td:nth-child(3)");

                    html = "<a class='dotted underline' href='javascript:void(0);' onclick=showWindow('" + String.format(url, previousPeriod, factor) + "')>" + previousBalanceCell.html() + "</a>";
                    previousBalanceCell.html(html);

                    html = "<a class='dotted underline' href='javascript:void(0);' onclick=showWindow('" + String.format(url, currentPeriod, factor) + "')>" + currentBalanceCell.html() + "</a>";
                    currentBalanceCell.html(html);
                };

            });
        };

        createLinkedBalances();
        createVisualHint();

    });

    printButton.click(function () {
        var report = "BalanceSheetReport.mix?PreviousPeriod={0}&CurrentPeriod={1}&Factor={2}";
        var previousPeriod = previousPeriodDateTextBox.val();
        var currentPeriod = currentPeriodDateTextBox.val();
        var factor = factorInputText.val();

        report = String.format(report, previousPeriod, currentPeriod, factor);
        showWindow(report);
    });
</script>

