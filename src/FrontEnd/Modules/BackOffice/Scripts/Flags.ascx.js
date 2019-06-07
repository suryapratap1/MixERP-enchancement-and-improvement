function displayPreview() {
    var background_color_textbox = $("#background_color");
    var foreground_color_textbox = $("#foreground_color");

    var background = background_color_textbox.val();
    var foreground = foreground_color_textbox.val();
    $(".lorem.ipsum").css("background-color", "#" + background);
    $(".lorem.ipsum").css("color", "#" + foreground);

};

$(document).on("viewsuccess", function () {
    loadColor();
});

$(document).on("formready", function () {
    loadColor();
    addColorPicker();
});

function scrudCustomValidator() {
    $(".lorem.ipsum").hide(500);
};

function addColorPicker() {
    $('[data-type="color"]').colorpicker({
        parts: 'full',
        alpha: true,
        open: function () {
            $(".lorem.ipsum").show(500);
        },
        select: function () {
            displayPreview();
        },
        colorFormat: 'RGBA'
    });

};

var loadColor = function () {
    //Get an instance of the form grid.
    var grid = $("#ScrudView");

    //Set position of the column which contains color value.
    var bgColorColumnPos = "5";
    var fgColorColumnPos = "6";

    //Iterate through all the rows of the grid.
    grid.find("tr").each(function () {

        //Get the current row instance from the loop.
        var row = $(this);

        //Read the color value from the associated column.
        var background = row.find("td:nth-child(" + bgColorColumnPos + ")").html();
        var foreground = row.find("td:nth-child(" + fgColorColumnPos + ")").html();

        if (background) {
            row.css("background", background);
        }

        if (foreground) {
            row.find("td").css("color", foreground);
        }

        //Iterate through all the columns of the current row.
        row.find("td").each(function () {
            //Prevent border display by unsetting the border information for each cell.
            $(this).css("border", "none");
        });

    });
};