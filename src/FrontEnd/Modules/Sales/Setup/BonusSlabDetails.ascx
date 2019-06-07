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
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BonusSlabDetails.ascx.cs"
    Inherits="MixERP.Net.Core.Modules.Sales.Setup.BonusSlabDetails" %>

<style>
    .disableClick {
        pointer-events: none;
    }
</style>

<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.BonusSlabDetails();

    scrudFactory.viewAPI = "/api/core/bonus-slab-detail-scrud-view";
    scrudFactory.viewTableName = "core.bonus_slab_details_scrud_view";

    scrudFactory.formAPI = "/api/core/bonus-slab-detail";
    scrudFactory.formTableName = "core.bonus_slab_details";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];


    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.queryStringKey = "BonusSlabDetailsId";

    scrudFactory.keys = [
        {
            property: "BonusSlabId",
            url: '/api/core/bonus-slab-scrud-view/display-fields',
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
        var amountFromTextBox = $("#amount_from");
        var amountToTextBox = $("#amount_to");
        var from = parseFloat2(amountFromTextBox.val());
        var to = parseFloat2(amountToTextBox.val());

        if (to <= from) {
            makeDirty(amountToTextBox);
            displayMessage(Resources.Warnings.CompareAmountErrorMessage());
            return false;
        };
        return true;
    };

</script>

