MixERPApp.controller("AccountStatementController", function ($scope, $sce) {
    var partyId = getQueryStringByName("PartyId");

    var ajaxGetAccountStatement = getAccountStatement(partyId);

    ajaxGetAccountStatement.success(function (msg) {
        $scope.$apply(function () {
            $scope.statement = msg.d;
        });
    });
});