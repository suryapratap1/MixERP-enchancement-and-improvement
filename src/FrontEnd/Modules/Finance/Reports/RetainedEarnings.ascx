<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RetainedEarnings.ascx.cs" Inherits="MixERP.Net.Core.Modules.Finance.Reports.RetainedEarnings" %>

<asp:PlaceHolder runat="server" ID="Placeholder1"></asp:PlaceHolder>

<script type="text/javascript">
    var printButton = $("#PrintButton");
    var dateTextBox = $("#DateTextBox");
    var factorInputText = $("#FactorInputText");


    printButton.click(function () {
        var report = "RetainedEarningsReport.mix?Date={0}&Factor={1}";
        var date = dateTextBox.val();
        var factor = factorInputText.val();

        report = String.format(report, date, factor);
        showWindow(report);
    });
</script>