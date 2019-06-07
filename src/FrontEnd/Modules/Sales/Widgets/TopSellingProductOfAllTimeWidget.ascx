<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TopSellingProductOfAllTimeWidget.ascx.cs" Inherits="MixERP.Net.Core.Modules.Sales.Widgets.TopSellingProductOfAllTimeWidget" %>

<div class="eight wide column widget" id="TopSellingProductOfAllTimeWidget">
    <div class="ui attached segment">
        <div class="ui left floated column">
        <div class="ui header">
            <asp:Literal runat="server" ID="TopSellingProductsLiteral" />
        </div>
        </div>
        <div class="right floated column">
            <i class="expand disabled icon"></i>
            <i class="move icon"></i>
            <i class="help icon"></i>
            <i class="close icon"></i>
        </div>
    </div>
    <div class="ui attached segment">
        <asp:GridView runat="server" ID="TopSellingProductsGridView" AutoGenerateColumns="True" CssClass="hidden">
        </asp:GridView>

        <canvas id="curr-office-top-selling-products-canvas" width="500" height="180"></canvas>
        <div id="curr-office-top-selling-products-legend"></div>
    </div>
</div>

<script type="text/javascript">
    $(document).ready(function () {
        prepareChart("TopSellingProductsGridView", "curr-office-top-selling-products-canvas", "curr-office-top-selling-products-legend", 'bar');
    });
</script>