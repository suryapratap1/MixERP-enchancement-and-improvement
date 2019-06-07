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
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SellingPrices.ascx.cs" Inherits="MixERP.Net.Core.Modules.Inventory.Setup.SellingPrices" %>

<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.ItemSellingPrices();

    scrudFactory.viewAPI = "/api/core/item-selling-price-scrud-view";
    scrudFactory.viewTableName = "core.item_selling_price_scrud_view";

    scrudFactory.formAPI = "/api/core/item-selling-price";
    scrudFactory.formTableName = "core.item_selling_prices";
    
    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];
       
    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.queryStringKey = "ItemSellingPriceId";

    scrudFactory.keys = [
        {
            property: "ItemId",
            url: '/api/core/item-scrud-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "UnitId",
            url: '/api/core/unit-scrud-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "PartyTypeId",
            url: '/api/core/party-type-scrud-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "PriceTypeId",
            url: '/api/core/price-type-selector-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>

<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
