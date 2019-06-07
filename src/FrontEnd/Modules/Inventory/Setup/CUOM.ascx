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
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CUOM.ascx.cs" Inherits="MixERP.Net.Core.Modules.Inventory.Setup.CUOM" %>

<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.CompoundUnitsOfMeasure();

    scrudFactory.viewAPI = "/api/core/compound-unit-scrud-view";
    scrudFactory.viewTableName = "core.compound_unit_scrud_view";

    scrudFactory.formAPI = "/api/core/compound-unit";
    scrudFactory.formTableName = "core.commpound_units";
    
    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];
       
    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.queryStringKey = "CompoundUnitId";

    scrudFactory.keys = [
        {
            property: "BaseUnitId",
            url: '/api/core/unit-scrud-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CompareUnitId",
            url: '/api/core/unit-scrud-view/display-fields',
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
        var baseUnitIdDropdownlist = $("#base_unit_id_dropdownlist");
        var compareUnitIdDropdownlist = $("#compare_unit_id_dropdownlist");

        var baseUnit = parseInt2(baseUnitIdDropdownlist.getSelectedValue());
        var compareUnit = parseInt2(compareUnitIdDropdownlist.getSelectedValue());

        if (baseUnit === compareUnit) {
            displayMessage(Resources.Errors.CompoundUnitOfMeasureErrorMessage());
            return false;
        };
        return true;
    };
</script>