<%--
Copyright (C) MixERP Inc. (http://mixof.org).

This file is part of MixERP.

MixERP is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, version 2 of the License.


MixERP is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with MixERP.  If not, see <http://www.gnu.org/licenses />.
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BonusSlabs.ascx.cs"
    Inherits="MixERP.Net.Core.Modules.Sales.Setup.BonusSlabs" %>

<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.AgentBonusSlabs();

    scrudFactory.viewAPI = "/api/core/bonus-slab-scrud-view";
    scrudFactory.viewTableName = "core.bonus_slab_scrud_view";

    scrudFactory.formAPI = "/api/core/bonus-slab";
    scrudFactory.formTableName = "core.bonus_slabs";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];


    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;


    scrudFactory.live = "BonusSlabName";

    scrudFactory.queryStringKey = "BonusSlabId";

    scrudFactory.keys = [
        {
            property: "CheckingFrequencyId",
            url: '/api/core/frequency/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "AccountId",
            url: '/api/core/bonus-slab-account-selector-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>


<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
<script type="text/javascript">
    function customFormValidator() {
        var effectiveFromTextbox = $("#effective_from");
        var endsOnTextbox = $("#ends_on");

        var effectiveFrom = parseLocalizedDate(effectiveFromTextbox.val());
        var endsOn = parseLocalizedDate(endsOnTextbox.val());

        if (endsOn <= effectiveFrom) {
            makeDirty(endsOnTextbox);
            displayMessage(Resources.Warnings.InvalidDate());
            return false;
        };

        return true;
    };

</script>



