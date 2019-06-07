MixERPApp.controller("ShippingAddressController", function ($scope, $sce) {
    var partyId = getQueryStringByName("PartyId");

    var ajaxGetShippingAddressView = getShippingAddressView(partyId);

    ajaxGetShippingAddressView.success(function (msg) {
        $scope.$apply(function () {
            $scope.addresses = msg.d;
        });
    });

    $scope.getResource = function (func) {
        return $window.executeFunctionByName(func, $window);
    };
});