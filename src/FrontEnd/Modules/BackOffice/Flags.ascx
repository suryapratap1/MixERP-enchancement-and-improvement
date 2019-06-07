<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Flags.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.Flags" %>



<script src="/Scripts/colorpicker/jquery.colorpicker.js"></script>
<link href="/Scripts/colorpicker/jquery.colorpicker.css" rel="stylesheet" type="text/css" />
<script src="/Scripts/colorpicker/i18n/jquery.ui.colorpicker-nl.js"></script>
<script src="/Scripts/colorpicker/swatches/jquery.ui.colorpicker-pantone.js"></script>
<script src="/Scripts/colorpicker/parts/jquery.ui.colorpicker-rgbslider.js"></script>
<script src="/Scripts/colorpicker/parts/jquery.ui.colorpicker-memory.js"></script>
<script src="/Scripts/colorpicker/parsers/jquery.ui.colorpicker-cmyk-parser.js"></script>
<script src="/Scripts/colorpicker/parsers/jquery.ui.colorpicker-cmyk-percentage-parser.js"></script>

<div style="position: fixed; left: 980px; top: 250px; z-index: 2;" class="ui small segment center initially hidden lorem ipsum">
Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
</div>


<script>
    var scrudFactory = new Object();

    scrudFactory.title = Resources.Titles.Flags();

    scrudFactory.viewAPI = "/api/core/flag-type-scrud-view";
    scrudFactory.viewTableName = "core.flag_type_scrud_view";
    scrudFactory.removeKanban = true;
    scrudFactory.removeFlag = true;

    scrudFactory.formAPI = "/api/core/flag-type";
    scrudFactory.formTableName = "office.flag_types";
    scrudFactory.live = "FlagTypeName";

    scrudFactory.excludedColumns = ["AuditUserId", "AuditTs"];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
</script>
<div data-ng-include="'/Modules/ScrudFactory/View.html'"></div>
<div data-ng-include="'/Modules/ScrudFactory/Form.html'"></div>

<script src="/Modules/BackOffice/Scripts/Flags.ascx.js"></script>