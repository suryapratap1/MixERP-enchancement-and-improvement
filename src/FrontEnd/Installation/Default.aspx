<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MixERP.Net.FrontEnd.Installation.Default" %>
<%@ Import Namespace="MixERP.Net.i18n" %>
<%@ Import Namespace="MixERP.Net.i18n.Resources" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="/Scripts/jquery-1.9.1.js"></script>
    <script src="/Scripts/semantic-ui/semantic.min.js"></script>
    <script src="/bundles/libraries.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <script src="/Resources.js?Culture=<%= CultureManager.GetCurrent().TwoLetterISOLanguageName %>"></script>
        <div class="ui page grid">
            <div class="column">
                <div class="ui purple segment">
                    <div class="ui large purple header">
                        <div class="content">
                            <%= Titles.InstallMixERP %>
                        </div>
                    </div>
                    <div class="ui form">
                        <div class="ui header">
                            <div class="content">
                                <%= Titles.AboutYourOffice %>
                            </div>
                        </div>
                        <div class="ui divider"></div>

                        <div class="ui stackable grid">
                            <div class="eight wide column" style="border-right: 1px solid #e5e2e2;">
                                <div class="field">
                                    <label for="OfficeNameInputText">
                                        <%= Titles.OfficeName %>
                                    </label>
                                    <input type="text" maxlength="150" id="OfficeNameInputText" />
                                </div>
                                <div class="three fields">
                                    <div class="field">
                                        <label for="OfficeCodeInputText">
                                            <%= Titles.OfficeCode %>
                                        </label>
                                        <input type="text" maxlength="12" id="OfficeCodeInputText" />
                                    </div>
                                    <div class="field">
                                        <label for="NickNameInputText">
                                            <%= Titles.OfficeNickName %>
                                        </label>
                                        <input type="text" maxlength="50" id="NickNameInputText" />
                                    </div>
                                    <div class="field">
                                        <label for="RegistrationDateInputText">
                                            <%= Titles.RegistrationDate %>
                                        </label>
                                        <input type="text" maxlength="50" id="RegistrationDateInputText" placeholder="<%= Labels.DateFormatYYYYMMDD %>" />
                                    </div>
                                </div>
                                <div class="ui header">
                                    <div class="content">
                                        <%= Questions.WhatIsYourHomeCurrency %>
                                    </div>
                                </div>
                                <div class="ui divider"></div>
                                <div class="four fields">
                                    <div class="field">
                                        <label for="CurrencyCodeInputText">
                                            <%= Titles.CurrencyCode %>
                                        </label>
                                        <input type="text" maxlength="12" id="CurrencyCodeInputText" />
                                    </div>
                                    <div class="field">
                                        <label for="CurrencySymbolInputText">
                                            <%= Titles.CurrencySymbol %>
                                        </label>
                                        <input type="text" maxlength="48" id="CurrencySymbolInputText" />
                                    </div>
                                    <div class="field">
                                        <label for="CurrencyNameInputText">
                                            <%= Titles.CurrencyName %>
                                        </label>
                                        <input type="text" maxlength="48" id="CurrencyNameInputText" />
                                    </div>
                                    <div class="field">
                                        <label for="HundredthNameInputText">
                                            <%= Titles.HundredthName %>
                                        </label>
                                        <input type="text" maxlength="48" id="HundredthNameInputText" />
                                    </div>
                                </div>

                                <div class="field">
                                    <label for="RegionalDataSelect"><%=Titles.RegionalDataIncludingCOA %></label>
                                    <select id="RegionalDataSelect" class="ui search dropdown"></select>
                                </div>

                            </div>
                            <div class="eight wide column">
                                <div class="field">
                                    <label><%= Titles.OfficeLogo %></label>
                                    <div class="ui segment">
                                        <img src="/Static/images/mixerp-logo-light.png" id="logo" />
                                    </div>
                                </div>
                                <div class="uploader">

                                    <label for="file" class="ui pink icon button">
                                        <i class="file icon"></i>
                                        <%= Titles.UploadLogo %>
                                    </label>
                                    <input type="file" id="file" style="display: none" />
                                </div>
                            </div>
                        </div>


                        <div class="ui divider"></div>

                        <div class="ui header">
                            <div class="content">
                                <%= Titles.GlobalParameters %>
                            </div>
                        </div>

                        <div class="five fields">
                            <div class="field">
                                <label for="StateTaxQuestionSelect">
                                    <%= Titles.PrimarySalesTaxType %>
                                </label>

                                <div class="ui form">
                                    <div class="grouped fields">
                                        <div class="field">
                                            <div class="ui radio checkbox">
                                                <input name="salestax" checked="checked" type="radio" value="false" />
                                                <label><%= Titles.NonVAT %></label>
                                            </div>
                                        </div>
                                        <div class="field">
                                            <div class="ui radio checkbox">
                                                <input name="salestax" type="radio" value="true" />
                                                <label><%= Titles.VATOrGST %></label>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                            </div>
                            <div class="field">
                                <label><%= Titles.StateSalesTax %></label>
                                <div class="ui form">
                                    <div class="grouped fields">
                                        <div class="field">
                                            <div class="ui radio checkbox">
                                                <input name="statetax" checked="checked" type="radio" value="true" />
                                                <label><%= Titles.Yes %></label>
                                            </div>
                                        </div>
                                        <div class="field">
                                            <div class="ui radio checkbox">
                                                <input name="statetax" type="radio" value="false" />
                                                <label><%= Titles.No %></label>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="field">
                                <label><%= Titles.CountySalesTax %></label>
                                <div class="ui form">
                                    <div class="grouped fields">
                                        <div class="field">
                                            <div class="ui radio checkbox">
                                                <input name="countytax" checked="checked" type="radio" value="true" />
                                                <label><%= Titles.Yes %></label>
                                            </div>
                                        </div>
                                        <div class="field">
                                            <div class="ui radio checkbox">
                                                <input name="countytax" type="radio" value="false" />
                                                <label><%= Titles.No %></label>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="field">
                                <label for="IncomeTaxRateInputText">
                                    <%= Titles.IncomeTaxRate %>
                                </label>

                                <div class="ui small right labeled input">
                                    <input type="text" id="IncomeTaxRateInputText" placeholder="00.00" />
                                    <div class="ui label">
                                        <%= Labels.PercentageSymbol %>
                                    </div>
                                </div>
                            </div>
                            <div class="field">
                                <label for="QuotationValidDaysInputText">
                                    <%= Titles.QuotationValidDays %>
                                </label>
                                <input type="text" maxlength="50" id="QuotationValidDaysInputText"
                                    placeholder="15" value="15" />
                            </div>
                            <div class="field">
                                <label for="TransactionStartDateInputText">
                                    <%= Titles.TransactionStartDate %>
                                </label>
                                <input type="text" maxlength="50" id="TransactionStartDateInputText"
                                    class="ui activating element"
                                    data-content="<%= Labels.TransactionStartDateDescription %>"
                                    placeholder="<%= Labels.DateFormatYYYYMMDD %>" />
                            </div>

                        </div>
                        <div class="three fields">
                            <div class="field">
                                <label for="WeekStartDaySelect">
                                    <%= Titles.WeekStartsOn %>
                                </label>
                                <select id="WeekStartDaySelect" class="ui dropdown">
                                    <option value="1"><%= Titles.Sunday %></option>
                                    <option value="2"><%= Titles.Monday %></option>
                                    <option value="3"><%= Titles.Tuesday %></option>
                                    <option value="4"><%= Titles.Wednesday %></option>
                                    <option value="5"><%= Titles.Thursday %></option>
                                    <option value="6"><%= Titles.Friday %></option>
                                    <option value="7"><%= Titles.Saturday %></option>
                                </select>
                            </div>
                            <div class="field">
                                <label for="InventoryAccountingSystemSelect">
                                    <%= Titles.InventoryAccountingSystem %>
                                </label>
                                <select class="ui dropdown" id="InventoryAccountingSystemSelect">
                                    <option value="true" selected="selected"><%= Titles.PerpetualInventory %></option>
                                    <option value="false"><%= Titles.PeriodicInventory %></option>
                                </select>
                            </div>
                            <div class="field">
                                <label for="InventoryValuationMethodSelect">
                                    <%= Titles.InventoryValuationMethod %>
                                </label>
                                <select class="ui dropdown" id="InventoryValuationMethodSelect">
                                    <option value="FIFO" selected="selected"><%= Titles.FIFO %></option>
                                    <option value="LIFO"><%= Titles.LIFO %></option>
                                    <option value="MAVCO"><%= Titles.MAVCO %></option>
                                </select>
                            </div>
                        </div>

                        <div class="ui header">
                            <div class="content">
                                <%= Titles.FiscalYear %>
                            </div>
                        </div>
                        <div class="four fields">
                            <div class="field">
                                <label for="FiscalYearCodeInputText">
                                    <%= ScrudResource.fiscal_year_code %>
                                </label>
                                <input type="text" maxlength="12" id="FiscalYearCodeInputText" />
                            </div>
                            <div class="field">
                                <label for="FiscalYearNameInputText">
                                    <%= ScrudResource.fiscal_year_name %>
                                </label>
                                <input type="text" maxlength="48" id="FiscalYearNameInputText" />
                            </div>
                            <div class="field">
                                <label for="StartsFromInputText">
                                    <%= ScrudResource.starts_from %>
                                </label>
                                <input type="text" maxlength="48" id="StartsFromInputText" placeholder="<%= Labels.DateFormatYYYYMMDD %>" />
                            </div>
                            <div class="field">
                                <label for="EndsOnInputText">
                                    <%= ScrudResource.ends_on %>
                                </label>
                                <input type="text" maxlength="48" id="EndsOnInputText" placeholder="<%= Labels.DateFormatYYYYMMDD %>" />
                            </div>
                        </div>

                        <div class="ui header">
                            <div class="content">
                                <%= Titles.CreateaUserAccountforYourself %>
                            </div>
                        </div>
                        <div class="ui divider"></div>
                        <div class="four fields">
                            <div class="field">
                                <label for="AdminNameInputText">
                                    <%= Titles.YourName %>
                                </label>
                                <input type="text" maxlength="100" id="AdminNameInputText" />
                            </div>
                            <div class="field">
                                <label for="UsernameInputText">
                                    <%= Titles.Username %>
                                </label>
                                <input type="text" maxlength="50" id="UsernameInputText" />
                            </div>
                            <div class="field">
                                <label for="PasswordInputPassword">
                                    <%= Titles.Password %>
                                </label>
                                <input type="password" maxlength="50" id="PasswordInputPassword" />
                            </div>
                            <div class="field">
                                <label for="ConfirmPasswordInputPassword">
                                    <%= Titles.ConfirmPassword %>
                                </label>
                                <input type="password" maxlength="50" id="ConfirmPasswordInputPassword" />
                            </div>
                        </div>

                        <button type="button" class="ui small red button" id="SaveButton">
                            <%= Titles.Save %>
                        </button>
                    </div>
                </div>
                <div class="ui page dimmer">
                    <div class="content">
                        <div class="center">
                            <div class="ui yellow huge icon header">
                                <i class="ui inverted yellow setting loading icon"></i>
                                <%= Titles.Saving %>
                                <div class="ui yellow sub header">
                                    <%= Labels.JustAMomentPlease %>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script src="/Scripts/ajax-file-upload.js"></script>
    <script src="/Scripts/Pages/Installation.aspx.js"></script>
</body>
</html>