<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AgeingSlabs.ascx.cs" Inherits="MixERP.Net.Core.Modules.Finance.Setup.AgeingSlabs" %>
<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.AgeingSlabs();

    scrudFactory.viewAPI = "/api/core/ageing-slab-scrud-view";
    scrudFactory.viewTableName = "core.ageing_slab_scrud_view";

    scrudFactory.formAPI = "/api/core/ageing-slab";
    scrudFactory.formTableName = "core.ageing_slabs";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];


    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;


    scrudFactory.live = "AgeingSlabName";
</script>


<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>


<script type="text/javascript">
    function scrudCustomValidator() {
        var fromDaysTextbox = $("#from_days_textbox");
        var toDaysTextbox = $("#to_days_textbox");

        var fromDays = parseInt2(fromDaysTextbox.val());
        var toDays = parseInt2(toDaysTextbox.val());

        if (toDays <= fromDays) {
            displayMessage(Resources.Warnings.CompareDaysErrorMessage());
            return false;
        };
        return true;
    };
</script>