<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TrialBalance.ascx.cs" Inherits="MixERP.Net.Core.Modules.Finance.Reports.TrialBalance" %>
<asp:PlaceHolder runat="server" ID="Placeholder1"></asp:PlaceHolder>

<style>
    th[rowspan] {
        border: 1px solid #D4D4D5;
    }
</style>
<script type="text/javascript">
    if (typeof perviousPeriodLocalized === "undefined") {
        perviousPeriodLocalized = "Previous Period";
    };

    if (typeof currentPeriodLocalized === "undefined") {
        currentPeriodLocalized = "Current Period";
    };

    if (typeof closingLocalized === "undefined") {
        closingLocalized = "Closing";
    };

    var semanticGrid = $("#TrialBalanceGridView");
    var fromDateTextBox = $("#FromDateTextBox");
    var toDateTextBox = $("#ToDateTextBox");
    var compactCheckBox = $("#CompactCheckBox");
    var zeroBalanceCheckBox = $("#ZeroBalanceCheckBox");
    var changeSideCheckBox = $("#ChangeSideCheckBox");
    var factorInputText = $("#FactorInputText");
    var compact = $("#CompactCheckBox");
    var changeSideCheckBox = $("#ChangeSideCheckBox");
    var zeroBalanceCheckBox = $("#ZeroBalanceCheckBox");

    var isCompactHiddenField = $("#IsCompactHidden");
    var includeZeroBalanceAccountHidden = $("#IncludeZeroBalanceAccountHidden");
    var changeSideWhenNegativeHidden = $("#ChangeSideWhenNegativeHidden");
    var printButton = $("#PrintButton");

    $(document).ready(function () {
        var html = "<tr><th></th><th></th><th colspan='2'>" + perviousPeriodLocalized + "</th><th colspan='2'>" + currentPeriodLocalized + "</th><th colspan='2'>" + closingLocalized + "</th></tr>";
        var thead = semanticGrid.find("thead");
        thead.prepend(html);

        var accountNumberCell = thead.find("tr:nth-child(2)").find("th:first-child");
        var accountCell = thead.find("tr:nth-child(2)").find("th:nth-child(2)");

        thead.find("tr:first-child").find("th:first-child").html(accountNumberCell.html()).attr("rowspan", "2");
        thead.find("tr:first-child").find("th:nth-child(2)").html(accountCell.html()).attr("rowspan", "2");

        accountNumberCell.remove();
        accountCell.remove();

        var previousDebit = sumOfColumn(semanticGrid, 2);
        var previousCredit = sumOfColumn(semanticGrid, 3);

        var debit = sumOfColumn(semanticGrid, 4);
        var credit = sumOfColumn(semanticGrid, 5);

        var closingDebit = sumOfColumn(semanticGrid, 6);
        var closingCredit = sumOfColumn(semanticGrid, 7);

        var tfoot = "<tr class='active strong text-right'><td colspan='2'>Total</td><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td></tr>";
        tfoot = String.format(tfoot, previousDebit, previousCredit, debit, credit, closingDebit, closingCredit);

        semanticGrid.append(tfoot);

    });

    compactCheckBox.change(function () {
        if (compactCheckBox.is(":checked")) {
            isCompactHiddenField.val("1");
            return;
        };

        isCompactHiddenField.val("0");
    });

    zeroBalanceCheckBox.change(function () {
        if (zeroBalanceCheckBox.is(":checked")) {
            includeZeroBalanceAccountHidden.val("1");
            return;
        };

        includeZeroBalanceAccountHidden.val("0");
    });

    changeSideCheckBox.change(function () {
        if (changeSideCheckBox.is(":checked")) {
            changeSideWhenNegativeHidden.val("1");
            return;
        };

        changeSideWhenNegativeHidden.val("0");
    });

    printButton.click(function () {
        var report = "TrialBalanceReport.mix?FromDate={0}&ToDate={1}&Factor={2}&Compact={3}&ChangeSide={4}&IncludeZeroBalanceAccounts={5}";
        var fromDate = fromDateTextBox.val();
        var toDate = toDateTextBox.val();
        var factor = factorInputText.val();
        var compact = compactCheckBox.is(":checked");
        var changeSide = changeSideCheckBox.is(":checked");
        var includeZeroBalanceAccounts = zeroBalanceCheckBox.is("checked");

        report = String.format(report, fromDate, toDate,factor,compact,changeSide,includeZeroBalanceAccounts);
        showWindow(report);
    });
</script>
