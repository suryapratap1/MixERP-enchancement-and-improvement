<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DatabaseStatistics.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Admin.DatabaseStatistics" %>

<script>
    var scrudFactory = new Object();

    scrudFactory.title = window.Resources.Titles.DatabaseStatistics();

    scrudFactory.viewAPI = "/api/public/db-stat";
    scrudFactory.viewTableName = "public.db_stat";
    scrudFactory.ignoreMeta = true;
    scrudFactory.removeKanban = true;
    scrudFactory.removeFilter = true;
    scrudFactory.removeImport = true;

    scrudFactory.allowDelete = false;
    scrudFactory.allowEdit = false;


</script>
<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>

<script type="text/javascript">

    var effectiveFromTextbox = $("#effective_from_textbox");
    var endsOnTextbox = $("#ends_on_textbox");

    $(document).ready(function () {
        scrudCustomValidator();
    });

    function scrudCustomValidator() {
        var effectiveFrom = parseDate(effectiveFromTextbox.val());
        var endsOn = parseDate(endsOnTextbox.val());

        if (endsOn < effectiveFrom) {
            displayMessage(Resources.Warnings.DateErrorMessage());
            return false;
        };
        return true;
    };

</script>

<h1>Maintenance</h1>

<asp:Literal ID="MessageLiteral" runat="server" />

<div class="ui basic buttons">
    <asp:Button ID="VacuumButton" runat="server" 
        CausesValidation="False"        
        CssClass="ui basic button" 
        OnClick="VacuumButton_Click" />
    
    <asp:Button ID="FullVacuumButton" runat="server" 
        CausesValidation="False"
        CssClass="ui basic button" 
        OnClick="FullVacuumButton_Click" />
    
    <asp:Button ID="AnalyzeButton" runat="server" 
        CausesValidation="False"
        CssClass="ui basic button" 
        OnClick="AnalyzeButton_Click" />
</div>
