<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DirectSales.ascx.cs" Inherits="MixERP.Net.Core.Modules.Sales.Confirmation.DirectSales"
    OverridePath="/Modules/Sales/DirectSales.mix" %>

<asp:PlaceHolder runat="server" ID="Placeholder1"></asp:PlaceHolder>

<script>
    $("#CustomerReportAnchor").removeAttr("onclick").on("click", function () {
        function request(model) {
            var url = "/api/core/printed-report/add-or-edit";
            var data = JSON.stringify(model);

            return window.getAjaxRequest(url, "POST", data);
        };

        var tranId = getQueryStringByName("TranId");

        var model = {
            ReportTitle: "Sales.Direct",
            TranId: tranId,
            Description: ""
        };

        var ajax = request(model);

        ajax.success(function (response) {
            if (response) {
                showWindow('/Modules/Sales/Reports/CustomerInvoiceReport.mix?TranId=' + tranId);
            }
        });
    });
</script>
