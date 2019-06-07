<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PartiesPopup.ascx.cs" 
    Inherits="MixERP.Net.Core.Modules.Inventory.Setup.PartiesPopup" 
    MasterPageId="MixERPBlankMaster.Master"
    OverridePath="/Modules/Inventory/Setup/Parties.mix"
     %>

<script src="/Scripts/mixerp/utitlities/countries.js"></script>
<script src="/Scripts/underscore/underscore-min.js"></script>

<div id="PartyController" class="ui attached segment" style="border: none; max-width: 900px;" data-ng-controller="PartyController" data-ng-cloak>
    <div class="ui huge grey header">{{getResource('Resources.Titles.Parties')}}</div>
    <div class="ui stackable grid">
        <div class="twelve wide column">
            <div class="ui form">
                <div class="fields">
                    <div class="five wide field">
                        <div class="ui icon input">
                            <input id="SearchInputText"
                                   placeholder="Search"
                                   data-ng-model="filters.Name" type="text">
                            <i class="search icon"></i>
                        </div>
                    </div>
                    <div class="seven wide field">
                        <select id="PartyTypeSelect"></select>
                    </div>

                    <div class="four wide field">
                        <input type="button" class="ui purple button" data-ng-click="search();" value="{{getResource('Resources.Titles.Search')}}"/>
                    </div>
                </div>
            </div>
        </div>
        <div class="four wide right floated right aligned column">
            <div class="ui buttons">
                <a class="ui positive button" target="_parent" href="Parties/Entry.mix">
                    {{getResource('Resources.Titles.AddNew')}}
                </a>
            </div>
        </div>
    </div>
    <div class="ui divider"></div>
    <div class="ui link four doubling stackable cards">
        <div class="card" data-ng-repeat="party in parties">
            <div class="image">
                <img src="/api/core/attachment/document/250/300/{{party.Photo}}" 
                    data-value="{{party.PartyId}}" onclick="selectParty(this)">
            </div>
            <div class="content">
                <div class="header">{{party.PartyName}}</div>
                <div class="meta">
                    <a>{{party.PartyType}}</a>
                </div>
                <div class="description">
                    <span>
                        {{party.City}} {{party.State}}
                    </span>
                    <br />
                    <span>
                        <i class="currency icon"></i>
                        {{party.CurrencyCode}}
                    </span>
                    <br />

                    <div class="ui basic icon buttons right floated right aligned">
                        <a data-ng-if="party.Email.length > 0" class="ui basic button" href="mailto:{{party.Email}}">
                            <i class="mail outline icon"></i>
                        </a>
                        <a data-ng-if="party.Url.length > 0" class="ui basic button" href="{{party.Url}}" target="_blank">
                            <i class="linkify icon"></i>
                        </a>
                        <a data-ng-if="party.Phone.length > 0" class="ui basic button" href="tel:{{party.Phone}}">
                            <i class="phone icon"></i>
                        </a>
                        <a data-ng-if="party.Fax.length > 0" class="ui basic button" href="tel:{{party.Fax}}">
                            <i class="fax icon"></i>
                        </a>
                        <a data-ng-if="party.Cell.length > 0" class="ui basic button" href="tel:{{party.Cell}}">
                            <i class="mobile icon"></i>
                        </a>
                    </div>

                    <div class="ui tiny grey header" data-ng-if="party.CompanyName.length > 0">
                        {{party.CompanyName}}
                    </div>
                </div>
            </div>
            <div class="extra center content">
                <div class="ui three basic buttons">
                    <a class="ui basic button"  target="_parent" href="Parties/Entry.mix?PartyId={{party.PartyId}}">
                        {{getResource('Resources.Titles.Edit')}}
                    </a>
                    <a class="ui basic button"  target="_parent"  href="PartyInfo.mix?PartyId={{party.PartyId}}">
                        {{getResource('Resources.Titles.View')}}
                    </a>
                    <a class="ui basic button" data-ng-click="delete(party);">
                        {{getResource('Resources.Titles.Delete')}}
                    </a>
                </div>
            </div>
            <div class="extra content">
                <span class="right floated">
                    <i class="{{getCountryCode(party.Country)}} flag"></i>
                    {{party.Country}}
                </span>
                <span>
                    <i class="user icon"></i>
                    <span>{{party.PartyCode}}</span>

                </span>
            </div>
        </div>
    </div>
    <div class="ui stackable grid">
        <div class="four wide column">
            <div class="ui breadcrumb" style="padding-top: 8px;">
                <a id="CurrentPageAnchor" class="active item">1</a>
                <div class="divider">/ </div>
                <a id="TotalPagesAnchor" class="active item"></a>
            </div>

        </div>
        <div class="twelve wide right aligned right floated column">
            <div class="ui basic buttons">
                <div class="ui basic button" data-ng-click="showFirst()">
                    {{getResource('Resources.Titles.First')}}
                </div>
                <div class="ui basic button" data-ng-click="showPrevious()">
                    {{getResource('Resources.Titles.Previous')}}
                </div>
                <div class="ui basic button" data-ng-click="showNext()">
                    {{getResource('Resources.Titles.Next')}}
                </div>
                <div class="ui basic button" data-ng-click="showLast()">
                    {{getResource('Resources.Titles.Last')}}
                </div>
            </div>
        </div>
    </div>
</div>

<script src="../Scripts/Setup/Parties.js"></script>
<script>
    $(window).on("resize", function() {
        adjustiframe();
    });

    $(document).ajaxStop(function () {
        adjustiframe();
    });


    function selectParty(el) {
        if (!isFrame()) {
            return;
        };

        var parent = getParentWindow();

        if (parent) {
            var partyId = $(el).data("value");
            var associatedControl = parent.$('#' + getQueryStringByName('AssociatedControlId'));
            var callback = getQueryStringByName('CallBackFunctionName');

            if (partyId > 0) {
                associatedControl.val(partyId);

                if (callback) {
                    parent[callback]();
                };

                closeWindow();
            };
        };
    };


    function adjustiframe() {
        if (!isFrame()) {
            return;
        };

        var height = $("#PartyController").height() + 100;
        var iframe = window.parent.$('iframe');
        iframe.height(height + "px");
    };
</script>