<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TransferRequest.ascx.cs" Inherits="MixERP.Net.Core.Modules.Inventory.TransferRequest" %>
<%@ Import Namespace="MixERP.Net.i18n.Resources" %>
<%@ Register TagPrefix="mixerp" Namespace="MixERP.Net.WebControls.Common" Assembly="MixERP.Net.WebControls.Common, Version=1.6.0.0, Culture=neutral, PublicKeyToken=a724a47a0879d02f" %>

<h2><%= Titles.StockTransferRequest %></h2>
<div class="basic ui buttons">
    <input id="AddNewButton" value="<%= Titles.AddNew %>" class="ui button" onclick=" window.location = 'Entry/TransferRequest.mix' " type="button">
    <input id="FlagButton" value="<%= Titles.Flag %>" class="ui button" type="button">
    <input id="PrintButton" value="<%= Titles.Print %>" class="ui button" type="button">
</div>

<div id="FilterDiv" class="ui segment">
    <div class="ui form" style="margin-left: 8px;">
        <div class="eight fields">
            <div class="field">
                <label><%=Titles.From %></label>
                <mixerp:DateTextBox ID="DateFromDateTextBox" runat="server" Mode="MonthStartDate" />
            </div>
            <div class="field">
                <label><%=Titles.To %></label>
                <mixerp:DateTextBox ID="DateToDateTextBox" runat="server" Mode="MonthEndDate"></mixerp:DateTextBox>
            </div>
            <div class="field">
                <label><%=Titles.Office %></label>
                <input id="OfficeTextBox" type="text" runat="server" />
            </div>
            <div class="field">
                <label><%=Titles.Store %></label>
                <input id="StoreTextBox" type="text" runat="server" />
            </div>
            <div class="field">
                <label><%=Titles.Authorized %></label>
                <input id="AuthorizedTextBox" type="text" value="" runat="server" />
            </div>
            <div class="field">
                <label><%=Titles.Delivered %></label>
                <input id="DeliveredTextBox" type="text" value="" runat="server" />
            </div>
            <div class="field">
                <label><%=Titles.Received %></label>
                <input id="ReceivedTextBox" type="text" value="false" runat="server" />
            </div>
            <div class="field">
                <label><%=Titles.User %></label>
                <input id="UserTextBox" type="text" runat="server" />
            </div>
            <div class="field">
                <label><%=Titles.ReferenceNumberAbbreviated %></label>
                <input id="ReferenceNumberTextBox" type="text" runat="server" />
            </div>
            <div class="field">
                <label><%=Titles.StatementReference %></label>
                <input id="StatementReferenceTextBox" type="text" runat="server" />
            </div>
            <div class="field">
                <label>&nbsp;</label>
                <asp:Button runat="server" ID="ShowButton" CssClass="blue ui button" Text="Show" OnClick="ShowButton_Click" />
            </div>
        </div>
    </div>
</div>

<asp:PlaceHolder ID="GridViewPlaceholder" runat="server" />
<script src="Scripts/TransferRequest.js"></script>

<script type="text/javascript">
    var printButton = $("#PrintButton");

    printButton.click(function () {
        var templatePath = "/Reports/Print.html";
        var headerPath = "/Reports/Assets/Header.aspx";
        var title = $("h2").html();
        var targetControlId = "TransferRequestGridView";
        var date = now;
        var windowName = "TransferRequestGridView";
        var offsetFirst = 2;
        var offsetLast = 2;

        printGridView(templatePath, headerPath, title, targetControlId, date, user, office, windowName, offsetFirst, offsetLast);
    });
</script>

