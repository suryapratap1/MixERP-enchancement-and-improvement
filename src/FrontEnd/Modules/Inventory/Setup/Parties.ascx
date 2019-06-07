<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PartiesPopup.ascx.designer.cs"
    Inherits="MixERP.Net.Core.Modules.Inventory.Setup.PartiesPopup" %>

<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.Parties();

    scrudFactory.viewAPI = "/api/core/party-scrud-view";
    scrudFactory.viewTableName = "core.party_scrud_view";

    scrudFactory.formAPI = "/api/core/party";
    scrudFactory.formTableName = "core.parties";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];
    scrudFactory.readonlyColumns = ["PartyCode"];
    scrudFactory.hiddenColumns = ["AccountId"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
    scrudFactory.viewUrl = "PartyInfo.mix?PartyId={Key}";

    scrudFactory.live = "PartyName";

    scrudFactory.layout = [
        {
            tab: "party",
            fields: 
            [
                ["Photo", ""],
                ["PartyId", "PartyCode", "", ""],
                ["EmployeeId", "EmployeeName", "", ""],
                ["FirstName", "MiddleName", "LastName", "PartyTypeId", "", "", "", ""],
                ["CompanyName", ""],
                ["PartyName", ""],
                ["DateOfBirth", "", "", ""],
                ["EntityId", "IndustryId", "", ""],
                ["PanNumber", "SstNumber", "CstNumber", "", "", "", "", ""],
                ["CurrencyCode", "AllowCredit", "", ""],
                ["MaximumCreditPeriod", "MaximumCreditAmount", "", ""]
            ]
        },
        {
            tab: "address",
            fields: [
                ["ZipCode", "", "", "", "", "", "",],
                ["AddressLine1", ""],
                ["AddressLine2", ""],
                ["Street", "City", "", ""],
                ["CountryId", "StateId", "", ""],
                ["Phone", "Fax", "", ""],
                ["Cell", "Email", "", ""],
                ["Url", "", "", ""]
            ]
        }
    ];

    scrudFactory.tabs = [
        {
            sort: 0,
            id: "party",
            name: window.Resources.Titles.PartyInformation(),
            active: true
        },
        {
            sort: 1,
            id: "address",
            name: window.Resources.Titles.AddressAndContactInformation()
        }
    ];

    scrudFactory.returnUrl = "../Employees.mix";
    scrudFactory.queryStringKey = "EmployeeId";
    scrudFactory.keys = [
        {
            property: "PartyTypeId",
            url: '/api/core/party-type/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "EntityId",
            url: '/api/core/entity/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "IndustryId",
            url: '/api/core/industry/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CountryId",
            url: '/api/core/country/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "StateId",
            url: '/api/core/state/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CurrencyCode",
            url: '/api/core/currency/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>

<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>

<script>
    $(document).on("formready", function() {
        initialize();

        $("#country_id").change(function(){
            displayStates($("#country_id").val());
        });
    });

    function displayStates(countryId){
        function ajax(){
            var url = "/api/core/state/get-where/1";

            var filters = [];
            filters.push(window.getAjaxColumnFilter("WHERE", "country_id", window.FilterConditions.IsEqualTo, countryId));
            
            var data = JSON.stringify(filters);
            return getAjaxRequest(url, "POST", data);
        };

        var request = ajax();

        request.success(function(response){
            $("#state_id").bindAjaxData(response, false, null, "StateId", "StateName", false);
        });

    };

    function initialize() {
        var firstName = $("#first_name");
        var middleName = $("#middle_name");
        var lastName = $("#last_name");
        var partyName = $("#party_name");

        function displayPartyName() {
            var f = (firstName.val() || "");
            var m = (middleName.val() || "");
            var l = (lastName.val() || "");

            var name = f + " " + m;
            if (l) {
                name = l.trim() + ", " + f + " " + m;
            };


            partyName.val(name.trim());

            partyName.trigger("keyup");
        };


        firstName.keyup(function () { displayPartyName(); });
        middleName.keyup(function () { displayPartyName(); });
        lastName.keyup(function () { displayPartyName(); });

    };

</script>