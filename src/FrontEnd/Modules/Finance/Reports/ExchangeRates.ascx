<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ExchangeRates.ascx.cs" Inherits="MixERP.Net.Core.Modules.Finance.Reports.ExchangeRates" %>
<iframe src="ExchangeRatesFrame.mix" scrolling="no" seamless="seamless"></iframe>

<script type="text/javascript">
    $(document).ready(function () {
        var iframe = $("iframe");

        iframe.css("width", "100%");
        iframe.css("height", getDocHeight() + "px");
        iframe.css("border", "0");
    })
</script>