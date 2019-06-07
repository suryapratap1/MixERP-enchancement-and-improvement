<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CustomFields.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.CustomFields" %>
<%@ Import Namespace="MixERP.Net.i18n.Resources" %>
<div>
    <div class="ui purple large header"><%=Titles.CustomFields %></div>
    <div class="ui divider"></div>

    <div class="ui form">
        <div class="fields">
            <div class="three wide field">
                <label for="FormSelect"><%=Titles.SelectForm %></label>
                <select id="FormSelect" class="ui dropdown"></select>
            </div>

            <div class="field">
                <label>&nbsp;</label>
                <a class="ui purple button" href="javascript:show();"><%=Titles.Show %></a>
            </div>

        </div>

    </div>
    <div class="ui divider"></div>

    <div class="ui form">
        <div id="CustomFieldContainer">
        </div>
        <div class="vpad8">
            <a class="ui pink button" href="javascript:window.addField();">
                <%=Titles.AddNew %>
            </a>
            <a class="ui positive button" onclick="save()"><%=Titles.Save %></a>
        </div>
    </div>
</div>


<script src="Scripts/CustomFields.ascx.js"></script>
