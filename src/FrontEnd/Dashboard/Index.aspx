<%@ Page Title="" Language="C#" MasterPageFile="~/BackendMaster.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="MixERP.Net.FrontEnd.Dashboard.Index" %>

<%@ Import Namespace="MixERP.Net.i18n.Resources" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ScriptContentPlaceholder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="StyleSheetContentPlaceholder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="BodyContentPlaceholder" runat="server">
    <div id="sortable-container" class="ui stackable grid">
        <asp:PlaceHolder ID="WidgetPlaceholder" runat="server" />
    </div>

    <div style="clear: both;"></div>
    <br />

    <a class="ui purple button" href="/Modules/WidgetManager.aspx"><%=Titles.WidgetManager %></a>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="BottomScriptContentPlaceholder" runat="server">
</asp:Content>
