<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SalesTaxExempts.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Tax.SalesTaxExempts" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.SalesTaxExempts();

    scrudFactory.viewAPI = "/api/core/sales-tax-exempt-scrud-view";
    scrudFactory.viewTableName = "core.sales_tax_exempt_scrud_view";

    scrudFactory.formAPI = "/api/core/sales-tax-exempt";
    scrudFactory.formTableName = "core.sales_tax_exempts";
    scrudFactory.live = "SalesTaxExemptName";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.keys = [
        {
            property: "TaxMasterId",
            url: '/api/core/tax-master-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "TaxExemptTypeId",
            url: '/api/core/tax-exempt-type-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "SalesTaxId",
            url: '/api/core/sales-tax-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        },
        {
            property: "StoreId",
            url: '/api/office/store-scrud-view/display-fields',
            data: null,
            valueField: "Key",
            textField: "Value"
        }
    ];
</script>
<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>

<script type="text/javascript">    
    function customFormValidator() {
        var validFromTextbox = $("#valid_from");
        var validTillTextbox = $("#valid_till");
        var priceFromTextbox = $("#price_from");
        var priceToTextbox = $("#price_to");

        var validFrom = parseDate(validFromTextbox.val());
        var validTill = parseDate(validTillTextbox.val());
        var priceFrom = parseFloat2(priceFromTextbox.val());
        var priceTo = parseFloat2(priceToTextbox.val());

        if (validTill < validFrom) {
            displayMessage(Resources.Warnings.DateErrorMessage());
            return false;
        };

        if (priceTo <= priceFrom) {
            displayMessage(Resources.Warnings.ComparePriceErrorMessage());
            return false;
        };

        return true;
    };

</script>