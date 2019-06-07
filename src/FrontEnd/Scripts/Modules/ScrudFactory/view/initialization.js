var json;
var kanbans;
var scrudForm = $(".form.factory");
var scrudView = $(".view.factory");
var addNewButton = $("#AddNewButton");
var viewReady = false;
var annotationLoaded = false;
var metaDefinition;
var falgDefinition;
var localizedHeaders = [];
var columns = [];
var columnSelect = $("#ColumnSelect");
var filterConditionSelect = $("#FilterConditionSelect");
var valueInputText = $("#ValueInputText");
var andInputText = $("#AndInputText");
var commandItems = "<a onclick='deleteFilter(this);'><i class='delete icon'></i></a><a onclick='editFilter(this);'><i class='edit icon'></i></a><a onclick='$(this).parent().parent().toggleClass(\"warning\");'><i class='check mark icon'></i></a>";
var filterPopUnder = $("#FilterPopUnder");
var flagPopUnder = $("#FlagPopUnder");
var flagButton = $("#FlagButton");
var filterButton = $("#FilterButton");
var flagSelect = $("#FlagSelect");
var updateButton = $("#UpdateButton");
var verificationPopUnder = $("#VerificationPopUnder");
var reasonTextArea = $("#ReasonTextArea");

var filterConditions = [{ "value": "0", "text": "IsEqualTo" },
{ "value": "1", "text": "IsNotEqualTo" },
{ "value": "2", "text": "IsLessThan" },
{ "value": "3", "text": "IsLessThanEqualTo" },
{ "value": "4", "text": "IsGreaterThan" },
{ "value": "5", "text": "IsGreaterThanEqualTo" },
{ "value": "6", "text": "IsBetween" },
{ "value": "7", "text": "IsNotBetween" },
{ "value": "8", "text": "IsLike" },
{ "value": "9", "text": "IsNotLike" }];

if (!scrudFactory.card) {
    scrudFactory.card = new Object();
};
