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
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Brands.ascx.cs" Inherits="MixERP.Net.Core.Modules.Inventory.Setup.Brands" %>

<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.Brands();

    scrudFactory.viewAPI = "/api/core/brand-scrud-view";
    scrudFactory.viewTableName = "core.brand_scrud_view";

    scrudFactory.formAPI = "/api/core/brand";
    scrudFactory.formTableName = "core.brands";
    scrudFactory.live = "BrandName";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

</script>

<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>
