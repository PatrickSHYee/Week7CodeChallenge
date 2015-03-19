$(document).ready(function () {

    // contact forms
    $('body').on('submit', '.ajax-form', function (event) {
        event.preventDefault();

        $.post($(this).data('posturl'), $(this).serialize(), function (data) {
            $('.ajax-form-content').html(data);
        });
    });

    // main links
    $('.nav-links a').on('click', function (event) {
        event.preventDefault();
        var aTagger = $(this).attr('href');
        $.get(aTagger, function (data) {
            $('#main-content').html(data);
        });
    });

    // loads the home page not the index
    $.get('/Home/Home', function (data) {
        $('#main-content').html(data);
    });

    // about tabs
    $('body').on('click', '.ajax-tab-links', function (event) {
        event.preventDefault();
        var showContent = $(this).data('type');
        console.log(showContent);
        $.get(showContent, function (data) {
            console.log(this);
            $('#about').html(data);
        });
    });
});