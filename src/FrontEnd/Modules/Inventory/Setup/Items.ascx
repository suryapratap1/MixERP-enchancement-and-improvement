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
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ItemsPopup.ascx.cs" Inherits="MixERP.Net.Core.Modules.Inventory.Setup.ItemsPopup" %>

<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.Items();

    scrudFactory.viewAPI = "/api/core/item-scrud-view";
    scrudFactory.viewTableName = "core.item_scrud_view";

    scrudFactory.formAPI = "/api/core/item";
    scrudFactory.formTableName = "core.items";
    scrudFactory.live = "ItemName";


    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs", "Photo"];
    scrudFactory.disableOnEdit = ["ItemCode", "MaintainStock", "ItemGroupId"];
    scrudFactory.hiddenColumns = ["IsVariantOf"];
           
    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.queryStringKey = "ItemId";
    
    scrudFactory.layout = [
        {
            tab: "item",
            fields: [
                ["Photo", ""],
                ["ItemId", ""],
                ["ItemCode", "ItemName", "", ""],
                ["ItemGroupId", "ItemTypeId", "", ""],
                ["BrandId", "PreferredSupplierId", "", ""],
                ["UnitId", "", "", ""],
                ["AllowSales", "AllowPurchase", "", ""],
            ]
        },
        {
            tab: "shipping",
            fields:[
                ["Machinable", "", "", ""],
                ["PreferredShippingMailTypeId", "ShippingPackageShapeId", "", ""],
                ["WeightInGrams", "", "", ""],
                ["WidthInCentimeters", "HeightInCentimeters", "", ""],
                ["LengthInCentimeters", "", "", ""],
            ]
        },
        {
            tab: "stock",
            fields:[
                ["ReorderLevel", "", "", ""],
                ["ReorderUnitId", "ReorderQuantity", "", ""],
                ["MaintainStock", "", "", ""]
            ]
        },
        {
            tab: "price",
            fields: [
                ["CostPrice", "", "", ""],
                ["SellingPrice", "SellingPriceIncludesTax", "", ""],
                ["SalesTaxId", "", "", ""]
            ]
        },
        {
            tab: "other",
            fields:[
                ["HotItem", "", "", ""],
                ["LeadTimeInDays", "", "", ""]
            ]
        }
    ];

    scrudFactory.tabs = [
        {
            sort: 0,
            id: "item",
            name: window.Resources.Titles.ItemInformation(),
            active: true
        },
        {
            sort: 1,
            id: "shipping",
            name: window.Resources.Titles.ShippingInformation()
        },
        {
            sort: 2,
            id: "price",
            name: window.Resources.Titles.PriceDetails()
        },
        {
            sort: 3,
            id: "stock",
            name: window.Resources.Titles.StockDetails()
        },
        {
            sort: 4,
            id: "other",
            name: window.Resources.Titles.OtherInformation()
        }        
    ];


    scrudFactory.keys = [
        {
            property: "ItemGroupId",
            url: '/api/core/item-group-scrud-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "ItemTypeId",
            url: '/api/core/item-type-scrud-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "BrandId",
            url: '/api/core/brand-scrud-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "PreferredShippingMailTypeId",
            url: '/api/core/shipping-mail-type-selector-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "ShippingPackageShapeId",
            url: '/api/core/shipping-package-shape-selector-view/display-fields',
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
            property: "SalesTaxId",
            url: '/api/core/sales-tax-scrud-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "ReorderUnitId",
            url: '/api/core/unit-scrud-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "PreferredSupplierId",
            url: '/api/core/supplier-selector-view/display-fields',
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
    $(document).on("onsaving", function(){
        if($("#is_variant_of").val()){
            $("#is_variant").dropdown("set selected", "yes");
        }else{
            $("#is_variant").dropdown("set selected", "no");            
        };
    });
</script>


