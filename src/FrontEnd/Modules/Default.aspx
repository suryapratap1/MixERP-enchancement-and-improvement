<%@ Page Title="" Language="C#" MasterPageFile="~/BackendMaster.Master" AutoEventWireup="true"
CodeBehind="Default.aspx.cs"
Inherits="MixERP.Net.FrontEnd.Modules.Default" %>

<asp:Content ContentPlaceHolderID="BodyContentPlaceholder" runat="server">
    <div class="container">
        <asp:PlaceHolder runat="server" ID="DefaultContentPlaceholder"/>
    </div>
</asp:Content>