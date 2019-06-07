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

<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Stores.ascx.cs" Inherits="MixERP.Net.Core.Modules.Inventory.Setup.Stores" %>

<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.Stores();

    scrudFactory.viewAPI = "/api/office/store-scrud-view";
    scrudFactory.viewTableName = "office.store_scrud_view";

    scrudFactory.formAPI = "/api/office/store";
    scrudFactory.formTableName = "office.stores";
    scrudFactory.live = "StoreName";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];


    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.queryStringKey = "StoreId";

    scrudFactory.keys = [
        {
            property: "OfficeId",
            url: '/api/office/office-scrud-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "StoreTypeId",
            url: '/api/office/store-type-scrud-view/display-fields',
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
            property: "DefaultCashAccountId",
            url: '/api/core/cash-account-selector-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "DefaultCashRepositoryId",
            url: '/api/office/cash-repository-scrud-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>


<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
