<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MixERPReportMaster.Master" 
    CodeBehind="ReportViewer.aspx.cs" Inherits="MixERP.Net.FrontEnd.Reports.ReportViewer" ValidateRequest="false"
    IsLandingPage="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContentPlaceholder" runat="server">

    <asp:Panel runat="server" ID="ReportParameterPanel" class="report-parameter hide">
        <asp:Table ID="ReportParameterTable" runat="server"/>
        <a href="#" onclick=" $('.report-parameter').toggle(500); " class="ui red button" style="float: right; padding: 4px;">Close This Form</a>
    </asp:Panel>

    <div style="padding: 12px">
        <asp:PlaceHolder runat="server" ID="Placeholder1"></asp:PlaceHolder>
    </div>

</asp:Content>