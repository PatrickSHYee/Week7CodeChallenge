$(document).ready(function () {
    $('.nav-links a').on('click', function (event) {
        event.preventDefault();
        var aTagger = $(this).attr('href');
        $.get(aTagger, function (data) {
            $('#main-content').html(data);
        })
    })

    $.get('/Home/Home', function (data) {
        $('#main-content').html(data);
    })
})

var arr_Href = ['/Home/Who', '/Home/What/', '/Home/Why/', '/Home/How/', '/Home/Where/'];

function OnAbout(input) {
    $.get(arr_Href[input], function (data) {
        $('#about').html(data);
    })
}

$('li a').on('click', function (e) {
    console.log("hit");
    e.preventDefault();
    var aTagger = $(this);
    $.get(aTagger.attr('href'), function (data) {
        aTagger.children('li').toggleClass('active');
    })
    About(aTagger.attr('href'));
})