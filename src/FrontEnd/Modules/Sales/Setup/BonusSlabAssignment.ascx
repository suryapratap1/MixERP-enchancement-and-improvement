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
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BonusSlabAssignment.ascx.cs" Inherits="MixERP.Net.Core.Modules.Sales.Setup.BonusSlabAssignment" %>

<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.AgentBonusSlabAssignment();

    scrudFactory.viewAPI = "/api/core/salesperson-bonus-setup";
    scrudFactory.viewTableName = "core.salesperson_bonus_setup_scrud_view";

    scrudFactory.formAPI = "/api/core/salesperson-bonus-setup";
    scrudFactory.formTableName = "core.salesperson_bonus_setups";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];


    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.queryStringKey = "SalesPersonBonusSetupId";

    scrudFactory.keys = [
        {
            property: "SalespersonId",
            url: '/api/core/salesperson-scrud-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        },
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
