<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Entry.ascx.cs"
    Inherits="MixERP.Net.Core.Modules.Inventory.Setup.Parties.Entry"
    OverridePath="/Modules/Inventory/Setup/Parties.mix" %>

<div id="FormPanel" style="display: none;">
    <div class="ui huge grey header">
        <span data-localize="Titles.Parties"></span>
    </div>
    <div class="ui message">
        <span data-localize="Labels.PartyDescription"></span>
    </div>
    <div class="ui stackable  grid">
        <div class="five wide column">
            <div class="ui form">
                <div class="field">
                    <input type="text" id="PhotoInputText" class="image" readonly="readonly" />
                </div>
            </div>
        </div>
        <div class="eleven wide column">
            <div class="ui stackable form">
                <div class="two fields">
                    <div class="field">
                        <label for="PartyIdInputText">
                            <span data-localize="ScrudResource.party_id"></span>
                        </label>
                        <input type="text" id="PartyIdInputText" readonly="readonly" />
                    </div>
                    <div class="field">
                        <label for="PartyCodeInputText">
                            <span data-localize="ScrudResource.party_code"></span>
                        </label>
                        <input type="text" id="PartyCodeInputText" readonly="readonly" />
                    </div>
                </div>

                <div class="three fields">
                    <div class="field">
                        <label for="FirstNameInputText">
                            <span data-localize="ScrudResource.first_name"></span>
                            <span data-localize="Titles.RequiredFieldIndicator"></span>
                        </label>
                        <input type="text" id="FirstNameInputText" required />
                    </div>
                    <div class="field">
                        <label for="MiddleNameInputText">
                            <span data-localize="ScrudResource.middle_name"></span>
                        </label>
                        <input type="text" id="MiddleNameInputText" />
                    </div>
                    <div class="field">
                        <label for="LastNameInputText">
                            <span data-localize="ScrudResource.last_name"></span>
                            <span data-localize="Titles.RequiredFieldIndicator"></span>
                        </label>
                        <input type="text" id="LastNameInputText" required />
                    </div>
                </div>
                <div class="two fields">
                    <div class="field">
                        <label for="PartyNameInputText">
                            <span data-localize="ScrudResource.company_name"></span>
                        </label>
                        <input type="text" id="CompanyNameInputText" />
                    </div>
                    <div class="field">
                        <label for="PartyNameInputText">
                            <span data-localize="ScrudResource.party_name"></span>
                            <span data-localize="Titles.RequiredFieldIndicator"></span>
                        </label>
                        <input type="text" id="PartyNameInputText" required />
                    </div>
                </div>
                <div class="three fields">
                    <div class="field">
                        <label for="DateOfBirthInputText">
                            <span data-localize="ScrudResource.date_of_birth"></span>
                        </label>
                        <input type="text" id="DateOfBirthInputText" class="date" />
                    </div>
                    <div class="field">
                        <label for="PartyTypeSelect">
                            <span data-localize="ScrudResource.party_type_id"></span>
                            <span data-localize="Titles.RequiredFieldIndicator"></span>
                        </label>
                        <select id="PartyTypeSelect" required></select>
                    </div>
                    <div class="field">
                        <label for="CurrencyCodeSelect">
                            <span data-localize="ScrudResource.currency_code"></span>
                            <span data-localize="Titles.RequiredFieldIndicator"></span>
                        </label>
                        <select id="CurrencyCodeSelect" required></select>
                    </div>
                </div>
                <div class="three fields">
                    <div class="field">
                        <label for="PhoneInputText">
                            <span data-localize="ScrudResource.phone"></span>
                        </label>
                        <input type="text" id="PhoneInputText" />
                    </div>
                    <div class="field">
                        <label for="FaxInputText">
                            <span data-localize="ScrudResource.fax"></span>
                        </label>
                        <input type="text" id="FaxInputText" />
                    </div>
                    <div class="field">
                        <label for="CellInputText">
                            <span data-localize="ScrudResource.cell"></span>
                        </label>
                        <input type="text" id="CellInputText" />
                    </div>
                </div>
                <div class="two fields">
                    <div class="field">
                        <label for="EmailInputText">
                            <span data-localize="ScrudResource.email"></span>
                        </label>
                        <input type="text" id="EmailInputText" />
                    </div>
                    <div class="field">
                        <label for="UrlInputText">
                            <span data-localize="ScrudResource.url"></span>
                        </label>
                        <input type="text" id="UrlInputText" />
                    </div>
                </div>
                <div class="field">
                    <label for="AddressLine1InputText">
                        <span data-localize="ScrudResource.address_line_1"></span>
                    </label>
                    <input type="text" id="AddressLine1InputText" />
                </div>
                <div class="field">
                    <label for="AddressLine2InputText">
                        <span data-localize="ScrudResource.address_line_2"></span>
                    </label>
                    <input type="text" id="AddressLine2InputText" />
                </div>
                <div class="three fields">
                    <div class="field">
                        <label for="ZipCodeInputText">
                            <span data-localize="ScrudResource.zip_code"></span>
                        </label>
                        <input type="text" id="ZipCodeInputText" />
                    </div>
                    <div class="field">
                        <label for="StreetInputText">
                            <span data-localize="ScrudResource.street"></span>
                        </label>
                        <input type="text" id="StreetInputText" />
                    </div>
                    <div class="field">
                        <label for="CityInputText">
                            <span data-localize="ScrudResource.city"></span>
                        </label>
                        <input type="text" id="CityInputText" />
                    </div>
                </div>
                <div class="two fields">

                    <div class="field">
                        <label for="CountrySelect">
                            <span data-localize="ScrudResource.country_id"></span>
                            <span data-localize="Titles.RequiredFieldIndicator"></span>
                        </label>
                        <select id="CountrySelect" required></select>
                    </div>
                    <div class="field">
                        <label for="StateSelect">
                            <span data-localize="ScrudResource.state_id"></span>
                        </label>
                        <select id="StateSelect"></select>
                    </div>

                </div>
                <div class="three fields">
                    <div class="field">
                        <label for="PanInputText">
                            <span data-localize="ScrudResource.pan_number"></span>
                        </label>
                        <input type="text" id="PanInputText" />
                    </div>
                    <div class="field">
                        <label for="SSTNumberInputText">
                            <span data-localize="ScrudResource.sst_number"></span>
                        </label>
                        <input type="text" id="SSTNumberInputText" />
                    </div>
                    <div class="field">
                        <label for="CSTNumberInputText">
                            <span data-localize="ScrudResource.cst_number"></span>
                        </label>
                        <input type="text" id="CSTNumberInputText" />
                    </div>
                </div>
                <div class="fields">
                    <div class="two wide field">
                        <label for="AllowCredit">
                            <span data-localize="ScrudResource.allow_credit"></span>
                        </label>
                        <div class="ui toggle checkbox">
                            <input name="public" type="checkbox" id="AllowCreditCheckbox" />
                        </div>
                    </div>
                    <div class="seven wide field allowcredit">
                        <label for="MaximumCreditPeriodInputText">
                            <span data-localize="ScrudResource.maximum_credit_period"></span>
                        </label>
                        <input type="text" id="MaximumCreditPeriodInputText" class="integer" />
                    </div>
                    <div class="seven wide field allowcredit">
                        <label for="MaximumCreditAmountInputText">
                            <span data-localize="ScrudResource.maximum_credit_amount"></span>
                        </label>
                        <input type="text" id="MaximumCreditAmountInputText" class="currency" />
                    </div>
                </div>

                <div class="two fields">
                    <div class="field">
                        <label for="EntitySelect">
                            <span data-localize="ScrudResource.entity_id"></span>
                        </label>
                        <select id="EntitySelect"></select>
                    </div>
                    <div class="field">
                        <label for="IndustrySelect">
                            <span data-localize="ScrudResource.industry_id"></span>
                        </label>
                        <select id="IndustrySelect"></select>
                    </div>

                </div>
                <input type="hidden" id="PartyAccountIdHiddenField" />
                <div class="big error vpad8 initially hidden"><span data-localize="Titles.RequiredFieldDetails"></span></div>
                <div class="ui basic buttons">
                    <a id="SaveButton" class="ui basic button">
                        <span data-localize="Titles.Save"></span>
                    </a>
                    <a class="ui basic button" href="../Parties.mix">
                        <span data-localize="Titles.Cancel"></span>
                    </a>
                </div>
            </div>

        </div>
    </div>

</div>

<script src="/Modules/Inventory/Scripts/Setup/Parties/Entry.js"></script>

