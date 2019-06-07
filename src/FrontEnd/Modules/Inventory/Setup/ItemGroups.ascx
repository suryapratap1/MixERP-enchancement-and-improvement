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
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ItemGroups.ascx.cs" Inherits="MixERP.Net.Core.Modules.Inventory.Setup.ItemGroups" %>

<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.ItemGroups();

    scrudFactory.viewAPI = "/api/core/item-group-scrud-view";
    scrudFactory.viewTableName = "core.item_group_scrud_view";

    scrudFactory.formAPI = "/api/core/item-group";
    scrudFactory.formTableName = "core.item_groups";
    scrudFactory.live = "ItemGroupName";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];
       
    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.queryStringKey = "ItemGroupId";

    scrudFactory.keys = [
        {
            property: "SalesTaxId",
            url: '/api/core/sales-tax-scrud-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "SalesAccountId",
            url: '/api/core/revenue-account-selector-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "SalesDiscountAccountId",
            url: '/api/core/expenses-account-selector-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "SalesReturnAccountId",
            url: '/api/core/sales-return-account-selector-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "PurchaseAccountId",
            url: '/api/core/purchase-account-selector-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "PurchaseDiscountAccountId",
            url: '/api/core/discount-received-account-selector-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "InventoryAccountId",
            url: '/api/core/inventory-account-selector-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "CostOfGoodsSoldAccountId",
            url: '/api/core/cost-of-sales-account-selector-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "ParentItemGroupId",
            url: '/api/core/item-group-scrud-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>

<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
