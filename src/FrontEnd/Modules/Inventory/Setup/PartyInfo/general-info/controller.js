MixERPApp.controller("GeneralInfoController", function ($scope, $sce, $window) {
    var partyId = getQueryStringByName("PartyId");

    var ajaxGetPartyView = getPartyView(partyId);

    ajaxGetPartyView.success(function (msg) {
        $scope.$apply(function () {
            $scope.partyView = msg.d;
        });

        $scope.getResource = function (func) {
            return $window.executeFunctionByName(func, $window);
        };
    });

    $scope.getCountryCode = function (countryName) {
        return $window._.find($window.countries, { countryName: countryName }).countryCode.toLowerCase();
    };
});