<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UpdateExchangeRates.ascx.cs" Inherits="MixERP.Net.Core.Modules.Finance.UpdateExchangeRates" %>
<%@ Import Namespace="MixERP.Net.i18n.Resources" %>
<style type="text/css">
    #ExchangeRatesGridView th:nth-child(5) {
        width: 125px;
    }

    #ExchangeRatesGridView th:nth-child(6) {
        width: 250px;
    }
</style>
<h1>
    <%=Titles.UpdatedExchangeRates %>
</h1>
<div class="ui divider"></div>

<div class="ui form">
    <div class="fields">
        <div class="field">
            <label for="OfficeInputText">
                <%=Titles.Office %>
            </label>
            <input type="text" id="OfficeInputText" readonly="readonly" runat="server" />
        </div>
        <div class="field">
            <label for="CurrencyInputText">
                <%=Titles.BaseCurrency %>
            </label>
            <input type="text" id="CurrencyInputText" readonly="readonly" runat="server" />
        </div>

        <div class="field">
            <label for="OfficeInputText">
                <%=Titles.SelectApi %>
            </label>
            <select id="ModuleSelect" class="ui dropdown"></select>
        </div>
        <div class="field">
            <label for="RequestButton">
                &nbsp;
            </label>
            <input type="button" id="RequestButton" value="<%=Titles.Request %>" class="ui pink button" />
        </div>
    </div>
</div>

<table class="ui very compact small striped collapsing table" id="ExchangeRatesGridView">
    <thead>
        <tr>
            <th><%=Titles.CurrencyCode %></th>
            <th><%=Titles.CurrencySymbol %></th>
            <th><%=Titles.CurrencyName %></th>
            <th><%=Titles.HundredthName %></th>
            <th><%=Titles.ExchangeRate %></th>
            <th><%=Titles.Description %></th>
        </tr>
    </thead>
    <tbody>
    </tbody>
</table>

<input type="button" id="SaveButton" value="<%=Titles.Save %>" class="ui green button" />

<script src="Scripts/UpdateExchangeRates.js"></script>
