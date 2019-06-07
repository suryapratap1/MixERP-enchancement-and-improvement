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
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RecurringInvoices.ascx.cs" Inherits="MixERP.Net.Core.Modules.Sales.Setup.RecurringInvoices" %>

<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.RecurringInvoices();

    scrudFactory.viewAPI = "/api/core/recurring-invoice-scrud-view";
    scrudFactory.viewTableName = "core.recurring_invoice_scrud_view";

    scrudFactory.formAPI = "/api/core/recurring-invoice";
    scrudFactory.formTableName = "core.recurring_invoices";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];


    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;


    scrudFactory.live = "RecurringInvoiceName";
    scrudFactory.queryStringKey = "RecurringInvoiceId";

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
            property: "RecurrenceTypeId",
            url: '/api/core/recurrence-type-scrud-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "RecurringFrequencyId",
            url: '/api/core/frequency/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "AccountId",
            url: '/api/core/recurring-invoice-account-selector-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "PaymentTermId",
            url: '/api/core/payment-term-scrud-view/display-fields',
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
        var itemIdDropdownlist = $("#item_id");
        var compoundItemIdDropdownlist = $("#compound_item_id");
        var recurringAmountTextbox = $("#recurring_amount_textbox");

        var itemId = parseInt2(itemIdDropdownlist.getSelectedValue());
        var compoundItemId = parseInt2(compoundItemIdDropdownlist.getSelectedValue());
        var recurringAmount = parseFloat2(recurringAmountTextbox.val());

        if (!itemId  && ! compoundItemId || itemId && compoundItemId) {
            displayMessage(Resources.Warnings.ItemErrorMessage());
            return false;
        };
        if (recurringAmount <= 0) {
            displayMessage(Resources.Warnings.RecurringAmountErrorMessage());
            return false;
        };
        return true;
    };
</script>