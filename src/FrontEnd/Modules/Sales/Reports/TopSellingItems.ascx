<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TopSellingItems.ascx.cs" Inherits="MixERP.Net.Core.Modules.Sales.Reports.TopSellingItems" %>
<iframe src="/Modules/Sales/Reports/TopSellingItemsFrame.mix" scrolling="no" seamless="seamless"></iframe>

<script type="text/javascript">
    $(document).ready(function () {
        var iframe = $("iframe");

        iframe.css("width", "100%");
        iframe.css("height", getDocHeight() + "px");
        iframe.css("border", "0");
    })
</script>