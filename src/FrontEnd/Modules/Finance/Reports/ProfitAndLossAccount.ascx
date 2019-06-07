<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProfitAndLossAccount.ascx.cs" Inherits="MixERP.Net.Core.Modules.Finance.Reports.ProfitAndLossAccount" %>

<asp:PlaceHolder runat="server" ID="Placeholder1"></asp:PlaceHolder>

<style>
    th[rowspan] {
        border: 1px solid #D4D4D5;
    }
</style>
<script type="text/javascript">
    var semanticGrid = $("#PLAccountGridView");
    var compactCheckBox = $("#CompactCheckBox");
    var isCompactHiddenField = $("#IsCompactHidden");

    $(document).ready(function () {
        semanticGrid.find("tr").each(function () {
            var isSummation = $(this).find("td:last, th:last");

            if (isSummation.find("input").is(":checked") === true) {
                $(this).addClass("positive");
                $(this).find("td").addClass("strong");
            };

            isSummation.remove();

            var isProfit = $(this).find("td:last, th:last");

            if (isProfit.find("input").is(":checked") === true) {
                $(this).addClass("negative");
                $(this).find("td").addClass("strong");
            };
            isProfit.hide();
        });

        semanticGrid.find("tr").each(function () {
            if ($(this).is(".positive, .negative") === false) {
                var cell = $(this).find("td:first-child");
                cell.html("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + cell.html());
            };
        });

    });

    compactCheckBox.change(function () {
        if (compactCheckBox.is(":checked")) {
            isCompactHiddenField.val("1");
            return;
        };

        isCompactHiddenField.val("0");
    });

    var printButton = $("#PrintButton");

    printButton.click(function () {
        var templatePath = "/Reports/Print.html";
        var headerPath = "/Reports/Assets/Header.aspx";
        var title = $("h2").html();
        var targetControlId = "PLAccountGridView";
        var date = now;
        var windowName = "PLAccountGridView";
        var offsetFirst = 0;
        var offsetLast = 1;

        printGridView(templatePath, headerPath, title, targetControlId, date, user, office, windowName, offsetFirst, offsetLast);
    });

</script>