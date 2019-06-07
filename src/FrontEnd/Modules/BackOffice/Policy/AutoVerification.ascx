<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AutoVerification.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Policy.AutoVerification" %>

<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.AutoVerificationPolicy();

    scrudFactory.viewAPI = "/api/policy/auto-verification-policy-scrud-view";
    scrudFactory.viewTableName = "policy.auto_verification_policy_scrud_view";

    scrudFactory.formAPI = "/api/policy/auto-verification-policy";
    scrudFactory.formTableName = "policy.auto_verification_policy";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.card = {
        keyField : "PolicyId",
        header: "UserName"
    };

    scrudFactory.keys = [
        {
            property: "OfficeId",
            url: '/api/office/office/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "UserId",
            url: '/api/office/user/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];

</script>
<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>

<script type="text/javascript">

    var effectiveFromTextbox = $("#effective_from_textbox");
    var endsOnTextbox = $("#ends_on_textbox");

    $(document).ready(function () {
        scrudCustomValidator();
    });

    function scrudCustomValidator() {
        var effectiveFrom = parseDate(effectiveFromTextbox.val());
        var endsOn = parseDate(endsOnTextbox.val());

        if (endsOn < effectiveFrom) {
            displayMessage(Resources.Warnings.DateErrorMessage());
            return false;
        };
        return true;
    };

</script>
