<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EntityAccess.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Policy.EntityAccess" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = window.Resources.Titles.EntityAccessPolicy();
    scrudFactory.description = stringFormat(window.Resources.Labels.EntityAccessPolicy(), "DefaultEntityAccess.mix");

    scrudFactory.viewAPI = "/api/policy/entity-access-scrud-view";
    scrudFactory.viewTableName = "policy.entity_access_scrud_view";

    scrudFactory.formAPI = "/api/policy/entity-access";
    scrudFactory.formTableName = "policy.entity_access";
    scrudFactory.className = "EntityAccess";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
    var valueExpression = "{{this['TableSchema'].toString() + '.' + this['TableName'].toString()}}";
    var textExpression = '{{this["TableName"].toString().split("_").join(" ").toPascalCase().singularize().split(" ").join("") \
    + " (" + this["TableSchema"].toString().split("_").join(" ").toPascalCase() + ")"\
    }}';

    scrudFactory.card = {
        header: "EntityName",
        meta: "UserName",
        description: "{{card.AccessTypeName + ' (' + card.AllowAccess + ')'}}"
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
        },
        {
            property: "AccessTypeId",
            url: '/api/policy/access-type/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "EntityName",
            url: '/api/public/procedures/get-entities/execute',
            data: {},
            valueField: valueExpression,
            textField: textExpression
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
