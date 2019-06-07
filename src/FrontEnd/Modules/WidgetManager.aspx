<%@ Page Title="" Language="C#" MasterPageFile="~/BackendMaster.Master" 
    AutoEventWireup="true" 
    CodeBehind="WidgetManager.aspx.cs" 
    Inherits="MixERP.Net.FrontEnd.Modules.WidgetManager"
    IsLandingPage="true"
     %>

<%@ Import Namespace="MixERP.Net.i18n.Resources" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ScriptContentPlaceholder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="StyleSheetContentPlaceholder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="BodyContentPlaceholder" runat="server">
    <div class="ui large purple header">
        <%=Titles.WidgetManager %>
    </div>

    <div class="ui divider"></div>

    <div class="ui form">
        <div class="fields">
            <div class="field">
                <label><%=Titles.SelectGroup %></label>
                <asp:DropDownList ID="WidgetDropDownList" runat="server" CssClass="ui dropdown" />
            </div>
            <div class="field">
                <label>&nbsp;</label>
                <a class="ui purple button" id="ShowButton"><%= Titles.Show %></a>
            </div>
        </div>
    </div>


    <div class="ui large purple header"><%=Titles.SelectedWidgets %></div>
    <div id="sortable-container" class="ui selected-widgets grid">
        <asp:PlaceHolder runat="server" ID="SelectedWidgetPlaceholder"></asp:PlaceHolder>
    </div>

    <div class="vpad16">
        <a class="ui teal button" id="SavePositionButton"><%=Titles.SaveOrder %></a>
    </div>


    <div class="ui large purple header"><%=Titles.OtherWidgets %></div>
    <div class="ui other-widgets grid">
        <asp:PlaceHolder runat="server" ID="OtherWidgetPlaceholder" />
    </div>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="BottomScriptContentPlaceholder" runat="server">
    <script src="../Scripts/Pages/Modules/WidgetManager.aspx.js"></script>
</asp:Content>
