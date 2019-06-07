<%@ Page Title="" Language="C#" MasterPageFile="~/BackendMaster.Master" AutoEventWireup="true" CodeBehind="RuntimeError.aspx.cs" Inherits="MixERP.Net.FrontEnd.Site.RuntimeError" %>
<%@ Import Namespace="MixERP.Net.i18n.Resources" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ScriptContentPlaceholder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="StyleSheetContentPlaceholder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="BodyContentPlaceholder" runat="server">
    <h1 class="ui red header">An Exception Occurred</h1>   
    <div class="ui divider"></div>
    <asp:Literal ID="ExceptionLiteral" runat="server" />
    <a class="ui red button" href="javascript:history.go(-1);"><i class="long arrow left icon"></i><%= Titles.Back %></a>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="BottomScriptContentPlaceholder" runat="server">
</asp:Content>
