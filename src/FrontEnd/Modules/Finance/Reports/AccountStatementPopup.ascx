<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AccountStatement.ascx.cs"
    Inherits="MixERP.Net.Core.Modules.Finance.Reports.AccountStatement"
    MasterPageId="MixERPBlankMaster.Master"
    OverridePath="/Modules/Finance/Reports/AccountStatement.mix"
     %>

<style type="text/css">
    #AccountOverViewGrid td:nth-child(1),
    #AccountOverViewGrid th:nth-child(1) {
        width: 200px;
    }
</style>

<div style="padding: 24px;">
    <asp:PlaceHolder runat="server" ID="Placeholder1"></asp:PlaceHolder>
</div>
<script src="/Modules/Finance/Scripts/Reports/AccountStatement.js"></script>