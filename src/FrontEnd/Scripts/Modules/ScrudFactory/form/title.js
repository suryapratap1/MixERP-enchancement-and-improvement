if (scrudFactory.title) {
    $(".title").html(scrudFactory.title);
};

if (scrudFactory.description) {
    $(".description").html(scrudFactory.description);
    $(".description").show();
} else {
    $(".description").remove();
};