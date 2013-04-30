


$(function () {

    $("input[data-autocomplete-source]").each(function () {
        var target = $(this);
        target.autocomplete({ source: target.attr("data-autocomplete-source") });
    });

    $(".title").mouseover(function () {
        $(this).effect("bounce", { time: 2, distance: 20 });
    });
});