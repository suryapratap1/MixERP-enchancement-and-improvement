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
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PaymentTerms.ascx.cs" Inherits="MixERP.Net.Core.Modules.Sales.Setup.PaymentTerms" %>

<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.PaymentTerms();

    scrudFactory.viewAPI = "/api/core/payment-term-scrud-view";
    scrudFactory.viewTableName = "core.payment_term_scrud_view";

    scrudFactory.formAPI = "/api/core/payment-term";
    scrudFactory.formTableName = "core.payment_terms";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];


    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;


    scrudFactory.live = "PaymentTermName";
    scrudFactory.queryStringKey = "PaymentTermId";

    scrudFactory.keys = [
        {
            property: "DueFrequencyId",
            url: '/api/core/frequency/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "LateFeeId",
            url: '/api/core/late-fee-scrud-view/display-fields',
            data: null,
            isArray: false,
            valueField: "Key",
            textField: "Value"
        },
         {
             property: "LateFeePostingFrequencyId",
             url: '/api/core/frequency/display-fields',
             data: null,
             isArray: false,
             valueField: "Key",
             textField: "Value"
         },
    ];
</script>


<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>

<script type="text/javascript">
   
    function customFormValidator() {
        var dueDaysTextbox = $("#due_days");
        var dueFrequencyIdDropdownlist = $("#due_frequency_id");
        var lateFeeIdDropdownlist = $("#late_fee_id");
        var lateFeePostingFrequencyIdDropdownlist = $("#late_fee_posting_frequency_id");

        var dueDays = parseInt2(dueDaysTextbox.val());
        var dueFrequency = parseInt2(dueFrequencyIdDropdownlist.getSelectedValue());
        var lateFee = parseInt2(lateFeeIdDropdownlist.getSelectedValue());
        var lateFeePostingFrequency = parseInt2(lateFeePostingFrequencyIdDropdownlist.getSelectedValue());
        
        if (!dueFrequency && dueDays === 0 || dueFrequency && dueDays > 0) {
            displayMessage(Resources.Warnings.DueFrequencyErrorMessage());
            return false;
        };
        
        if (!lateFee && lateFeePostingFrequency || lateFee && !lateFeePostingFrequency) {
            displayMessage(Resources.Warnings.LateFeeErrorMessage());
            return false;
        };
        return true;
    };
    
</script>
