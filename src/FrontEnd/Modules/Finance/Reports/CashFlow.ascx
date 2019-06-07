<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CashFlow.ascx.cs" Inherits="MixERP.Net.Core.Modules.Finance.Reports.CashFlow" %>
<asp:PlaceHolder runat="server" ID="Placeholder1"></asp:PlaceHolder>
<script type="text/javascript">
    var semanticGrid = $("#CashFlowStatementGridView");

    $(document).ready(function () {
        semanticGrid.find("tr").each(function () {
            var isSummation = $(this).find("td:last, th:last");

            if (isSummation.find("input").is(":checked") === true) {
                $(this).addClass("warning");
                $(this).find("td").addClass("strong");
            };

            isSummation.remove();

            $(this).find("td").not(":eq(0)").each(function () {
                var value = parseFloat2($(this).html());

                if (value < 0) {
                    $(this).addClass("error");
                };
            });

        });

        semanticGrid.find("tr").each(function () {
            if ($(this).is(".positive, .negative") === false) {
                var cell = $(this).find("td:first-child");
                cell.html("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + cell.html());
            };
        });

        semanticGrid.find("tr:nth-child(1), tr:last-child").each(function () {
            $(this).addClass("positive");
        });

    });

    var printButton = $("#PrintButton");

    printButton.click(function () {
        var templatePath = "/Reports/Print.html";
        var headerPath = "/Reports/Assets/Header.aspx";
        var title = $("h2").html();
        var targetControlId = "CashFlowStatementGridView";
        var date = now;
        var windowName = "CashFlowStatementGridView";
        var offsetFirst = 0;
        var offsetLast = 0;

        printGridView(templatePath, headerPath, title, targetControlId, date, user, office, windowName, offsetFirst, offsetLast);
    });
</script>