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