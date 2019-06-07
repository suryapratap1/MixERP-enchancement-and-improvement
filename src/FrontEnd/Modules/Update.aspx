<%@ Page Title="" Language="C#" MasterPageFile="~/BackendMaster.Master"
    AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="MixERP.Net.FrontEnd.Modules.Update"
    IsLandingPage="true"
     %>

<%@ Import Namespace="MixERP.Net.i18n.Resources" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ScriptContentPlaceholder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="StyleSheetContentPlaceholder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="BodyContentPlaceholder" runat="server">
    <asp:Panel runat="server" ID="ReleasePanel">
        <h1 class="ui purple header"><%=Titles.NewReleaseAvailable %></h1>

        <div class="ui warning icon message">
            <i class="warning circle negative icon"></i>
            <div class="content">
                <div class="ui large header">
                    <%=Titles.CreateBackupFirst %>
                </div>
                <p>
                    <%=Labels.UpdateBackupMessage %>
                </p>
            </div>
        </div>

        <asp:Label runat="server" ID="ErrorLabel" CssClass="big error" Text="" />

        <table class="ui compact definition purple table segment">
            <tbody>
                <tr>
                    <td><%=Titles.ReleaseId %></td>
                    <td><%= this._release.Id %></td>
                </tr>
                <tr>
                    <td><%=Titles.VersionName %></td>
                    <td><%= this._release.Name %></td>
                </tr>
                <tr>
                    <td><%=Titles.TagName %></td>
                    <td><%= this._release.TagName %></td>
                </tr>
                <tr>
                    <td><%= Titles.CreatedOn %></td>
                    <td><%= this._release.CreatedAt %></td>
                </tr>
                <tr>
                    <td><%=Titles.PublishedOn %></td>
                    <td><%= this._release.PublishedAt %></td>
                </tr>
                <tr>
                    <td><%=Titles.DownloadingFrom %></td>
                    <td>
                        <a href="<%= this._downloadUrl %>"><%= this._downloadUrl %></a>
                    </td>
                </tr>
                <tr>
                    <td><%=Titles.Message %></td>
                    <td><%= this._release.Body %></td>
                </tr>
            </tbody>
        </table>
        
        
        <a class="ui positive button" href="/Modules/BackOffice/Admin/DatabaseBackup.mix"><%=Titles.CreateBackupFirst %></a>
               
        <input type="button" id="UpdateButton" value="<%=Titles.Update %>" class="ui pink disabled loading button" />

        <h1 class="ui purple header"><%=Titles.UpdateConsole %></h1>
        <div id="Console" class="ui celled relaxed list segment" style="height: 500px; overflow: auto;"></div>
    </asp:Panel>
    <asp:Panel runat="server" ID="UpToDatePanel" Visible="false">
        <h1><%=Titles.CheckForUpdates %></h1>
        <div class="ui divider"></div>
        <p><%= Labels.InstanceIsUpToDate %></p>
        <a href="/" class="ui purple button"><%=Titles.ReturnHome %></a>
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="BottomScriptContentPlaceholder" runat="server">
    <script type="text/javascript">
        var console = $("#Console");

        $(function () {
            //EOD Notices from PostgreSQL Server
            $.connection.updateHub.client.updateInstallationNotification = function (timestamp, label, message) {
                disableUpdateButton();
                addToConsole(timestamp, label, message);
            };
        });

        function connectionListener() {
            $("#UpdateButton").removeClass("disabled loading");

            $("#UpdateButton").click(function () {
                if (!confirmAction()) {
                    return;
                };

                disableUpdateButton();
                $.connection.updateHub.server.installUpdates();
            });
        };

        function disableUpdateButton() {
            $("#UpdateButton").addClass("disabled loading");
        };

        function addToConsole(timestamp, label, message) {
            var item = $("<div class='item'/>");
            var icon = $("<i class='ui big settings blue icon'></i>");
            item.append(icon);

            var content = $("<div class='content'/>");


            var labelContainer = $("<div class='ui grey header' />");
            labelContainer.html(timestamp);
            content.append(labelContainer);

            var span = $("<strong/>");
            span.html(label + " : ");
            content.append(span);

            var messageContainer = $("<span />");
            messageContainer.html(message);
            content.append(messageContainer);

            item.append(content);

            console.append(item);

            var height = console[0].scrollHeight;
            console.scrollTop(height);
        };
    </script>
</asp:Content>
