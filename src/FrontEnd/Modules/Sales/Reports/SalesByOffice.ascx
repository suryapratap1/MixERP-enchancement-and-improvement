<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SalesByOffice.ascx.cs" Inherits="MixERP.Net.Core.Modules.Sales.Reports.SalesByOffice"
    %>
<iframe src="/Modules/Sales/Reports/SalesByOfficeFrame.mix" scrolling="no" seamless="seamless"></iframe>

<script type="text/javascript">
    $(document).ready(function () {
        var iframe = $("iframe");

        iframe.css("width", "100%");
        iframe.css("height", getDocHeight() + "px");
        iframe.css("border", "0");
    })
</script>