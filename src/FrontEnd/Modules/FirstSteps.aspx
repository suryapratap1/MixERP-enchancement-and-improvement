<%@ Page Title="" Language="C#" MasterPageFile="~/BackendMaster.Master"
    AutoEventWireup="true"
    CodeBehind="FirstSteps.aspx.cs"
    Inherits="MixERP.Net.FrontEnd.Modules.FirstSteps"
    IsLandingPage="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ScriptContentPlaceholder" runat="server">
    <script src="../Scripts/underscore/underscore-min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="StyleSheetContentPlaceholder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="BodyContentPlaceholder" runat="server">
    <div data-ng-include="'/Views/Modules/FirstSteps.aspx.html'"></div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="BottomScriptContentPlaceholder" runat="server">
    <script src="../Scripts/Pages/Modules/FirstSteps.aspx.js"></script>
</asp:Content>
