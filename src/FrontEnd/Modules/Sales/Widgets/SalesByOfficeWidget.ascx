<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SalesByOfficeWidget.ascx.cs" Inherits="MixERP.Net.Core.Modules.Sales.Widgets.SalesByOfficeWidget" %>

<div class="eight wide column widget" id="SalesByOfficeWidget">        
    <div class="ui attached segment">
        <div class="ui left floated column">
        <div class="ui header">
            <asp:Literal runat="server" ID="TitleLiteral" />
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
        <asp:GridView runat="server" ID="SalesByOfficeGridView" DataKeyNames="office" AutoGenerateColumns="False" CssClass="hidden">
            <Columns>
                <asp:BoundField HeaderText="OfficeCode" DataField="office" />
                <asp:BoundField HeaderText="Jan" DataField="jan" />
                <asp:BoundField HeaderText="Feb" DataField="feb" />
                <asp:BoundField HeaderText="Mar" DataField="mar" />
                <asp:BoundField HeaderText="Apr" DataField="apr" />
                <asp:BoundField HeaderText="May" DataField="may" />
                <asp:BoundField HeaderText="Jun" DataField="jun" />
                <asp:BoundField HeaderText="Jul" DataField="jul" />
                <asp:BoundField HeaderText="Aug" DataField="aug" />
                <asp:BoundField HeaderText="Sep" DataField="sep" />
                <asp:BoundField HeaderText="Oct" DataField="oct" />
                <asp:BoundField HeaderText="Nov" DataField="nov" />
                <asp:BoundField HeaderText="Dec" DataField="dec" />
            </Columns>
        </asp:GridView>

        <canvas id="sales-by-month-canvas" width="500" height="180"></canvas>
        <div id="sales-by-month-legend"></div>
    </div>
</div>

<script type="text/javascript">
    $(document).ready(function () {
        prepareChart("SalesByOfficeGridView", "sales-by-month-canvas", "sales-by-month-legend", 'bar');
    });
</script>