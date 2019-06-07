<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApproveQuotation.aspx.cs" Inherits="MixERP.Net.FrontEnd.Public.ApproveQuotation" %>

<%@ Import Namespace="MixERP.Net.i18n.Resources" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Scripts/semantic-ui/semantic.min.css" rel="stylesheet" />
    <title></title>
    <style>
        table {
            border-collapse: collapse;
        }

        table, th, td {
            border: 1px solid #DEDEDF;
            padding: 4px;
        }

        span {
            display: block;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="ui page grid">
            <div class="column">
                <div style="padding-top: 32px;">
                </div>

                <asp:PlaceHolder runat="server" ID="Placeholder1"></asp:PlaceHolder>

                <asp:Label runat="server" ID="MessageLabel" Visible="false" />

                <div style="padding: 12px 0;" class="ui buttons">
                    <asp:Button runat="server" ID="AcceptButton" CssClass="ui positive button" Visible="false" OnClick="AcceptButton_OnClick" />
                    <a class="ui small red button" href="javascript:history.go(-1);"><%= Titles.ReturnBack %></a>
                </div>


            </div>
        </div>
    </form>
</body>
</html>
