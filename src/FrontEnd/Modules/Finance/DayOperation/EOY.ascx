<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EOY.ascx.cs" Inherits="MixERP.Net.Core.Modules.Finance.DayOperation.EOY" %>
<%@ Import Namespace="MixERP.Net.i18n.Resources" %>
<div class="ui purple large header"><%=Titles.EndOfYearProcessing %></div>
<div class="ui divider"></div>
<asp:Panel ID="EOYPanel" runat="server" Visible="False">
    <div class="ui basic buttons">
        <a class="ui button" onclick="showIncomeTax();"><%=Titles.BookIncomeTax %></a>
        <a class="ui button" onclick="showBackup();"><%=Titles.CreateBackup %></a>
        <a class="ui button" onclick="showPLAppropriation();"><%=Titles.PLAppropriation %></a>
        <a class="ui button" onclick="showBackup();"><%=Titles.CreateBackup %></a>
        <a class="ui button" onclick="showNewFiscalYear();"><%=Titles.NewFiscalYear %></a>
        <a class="ui button" onclick="showEOD();"><%=Titles.PerformEOD %></a>
    </div>
    
    <div class="ui initially hidden" id="BackupPanel">
        <iframe style="border: 0; width: 100%; overflow: hidden;" seamless="seamless" scrolling="no">
            
        </iframe>
    </div>
    <div class="ui initially hidden segment" id="IncomeTaxPanel">
        <h1><%=Titles.BookIncomeTax %></h1>
        <div class="ui divider"></div>

        <div class="ui form">
            <div class="fields">
                <div class="three wide field">
                    <label for="TaxOfficeAccountSelect"><%=Titles.SelectTaxOfficeGL %></label>
                    <select class="ui search selection dropdown" id="TaxOfficeAccountSelect"></select>
                </div>
                <div class="three wide field">
                    <label for="TaxExpenseSelect"><%=Titles.SelectExpensesGL %></label>
                    <select class="ui search selection dropdown" id="TaxExpenseSelect"></select>
                </div>
                <div class="three wide field">
                    <label for="TaxCostCenterSelect"><%=Titles.CostCenter %></label>
                    <select class="ui search selection dropdown" id="TaxCostCenterSelect"></select>
                </div>
                <div class="two wide field">
                    <label for="ProfitBeforeTaxInputText"><%=Titles.ProfitBeforeTax %></label>
                    <input type="text" id="ProfitBeforeTaxInputText" readonly />
                </div>
                <div class="two wide field">
                    <label for="IncomeTaxRateInputText"><%=Titles.TaxRate %></label>
                    <input type="text" id="IncomeTaxRateInputText" readonly />
                </div>
                <div class="two wide field">
                    <label for="IncomeTaxInputText"><%=Titles.IncomeTax %></label>
                    <input type="text" id="IncomeTaxInputText" readonly />
                </div>
            </div>
            <div class="fields">
                <div class="four wide field">
                    <label for="TaxReferenceNumberInputText"><%=Titles.ReferenceNumber %></label>
                    <input type="text" id="TaxReferenceNumberInputText" />
                </div>
                <div class="twelve wide field">
                    <label for="TaxStatementReferenceInputText"><%=Titles.StatementReference %></label>
                    <input type="text" id="TaxStatementReferenceInputText" />
                </div>
            </div>

            <input type="button" class="ui purple button" id="PostTaxButton" value="<%=Titles.PostTransaction %>" />
        </div>
    </div>

    <div class="ui initially hidden segment" id="PLAppropriationPanel">
        <h1><%=Titles.PLAppropriation %></h1>
        <div class="ui divider"></div>

        <table class="ui striped celled table" data-ng-controller="EOYController" data-ng-cloak>
            <thead>
                <tr>
                    <th><%= Titles.AccountId %></th>
                    <th><%= Titles.AccountNumber %></th>
                    <th><%= Titles.Account %></th>
                    <th><%= Titles.Debit %></th>
                    <th><%= Titles.Credit %></th>
                </tr>
            </thead>
            <tbody>
                <tr data-ng-repeat="item in items">
                    <td>{{item.AccountId}}</td>
                    <td>{{item.AccountNumber}}</td>
                    <td>{{item.AccountName}}</td>
                    <td>{{item.Debit}}</td>
                    <td>{{item.Credit}}</td>
                </tr>
            </tbody>
            <tfoot>
                <tr>
                    <th class="right aligned" colspan="3"><%= Titles.Total %></th>
                    <th>{{drTotal}}</th>
                    <th>{{crTotal}}</th>
                </tr>
                <tr>
                    <th class="right aligned" colspan="4"><%=Titles.ProfitOrLoss %></th>
                    <td class="{{profit > 0 ? 'positive' : 'warning'}}">{{profit}}</td>
                </tr>
            </tfoot>
        </table>
        <div class="ui form" style="width: 500px;">
            <div class="two fields">
                <div class="field">
                    <label><%= Titles.ReferenceNumber %></label>
                    <input type="text" value="PL-APPR-2015" maxlength="24" id="ReferenceNumberInputText" />
                </div>
                <div class="field">
                    <label><%= Titles.CostCenter %></label>
                    <select class="ui dropdown" id="CostCenterSelect"></select>
                </div>
            </div>
            <div class="field">
                <label><%=Titles.SelectPLAppropriationAccount %></label>
                <select class="ui dropdown" id="PLAppropriationAccountSelect"></select>
            </div>
            <div class="field">
                <label><%= Titles.StatementReference %></label>
                <textarea rows="2" id="StatementReferenceTextArea"><%=Titles.ToPLAppropriationAC %></textarea>
            </div>


            <input id="PostPLAppropriationInputButton" type="button" class="ui purple button" value="<%= Titles.PostTransaction %>" />
        </div>

    </div>

    <div class="ui initially hidden segment" id="FiscalYearPanel">
        <h1><%=Titles.NewFiscalYear %></h1>
        <div class="ui divider"></div>

        <div class="ui form">
            <div class="fields">
                <div class="field">
                    <label><%=Titles.FiscalYearCode %></label>
                    <input type="text" id="FiscalYearCodeInputText" />
                </div>
                <div class="field">
                    <label><%=Titles.FiscalYearName %></label>
                    <input type="text" id="FiscalYearNameInputText" />
                </div>
            </div>

            <input type="button" id="CreateFiscalYearButton" class="ui purple button" value="<%=Titles.CreateNewFiscalYear %>" />
        </div>
    </div>
</asp:Panel>

<asp:Panel runat="server" ID="MessagePanel" Visible="False">
    <div class="ui warning message">
        <div class="header">
            <%=DbErrors.P5105 %>
        </div>

        <p class="vpad8">
            <a class="ui pink button" href="/Modules/Finance/VoucherVerification.mix"><%=Titles.VoucherVerification %></a>

        </p>
    </div>
</asp:Panel>

<script src="/Modules/Finance/Scripts/DayOperation/EOY.ascx.js"></script>
