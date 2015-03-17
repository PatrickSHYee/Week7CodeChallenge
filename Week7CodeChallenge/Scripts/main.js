$(document).ready(function () {
    
    // contact forms
    $('body').on('submit', '.ajax-form', function (event) {
        event.preventDefault();
        $.post($(this).data('posturl'), $(this).serialize(), function (data) {
            $('.ajax-form-content').html(data);
        })
    })

    // main links
    $('.nav-links').on('click', function (event) {
        event.preventDefault();
        var aTagger = $(this).attr('href');
        $.get(aTagger, function (data) {
            $('#main-content').html(data);
        })
    })

    // loads the home page not the index
    $.get('/Home/Home', function (data) {
        $('#main-content').html(data);
    })
})

// loads based on tab click for the about page
function onAbout(input) {
    $('.nav-tab-link').on('click', function (event) {
        event.preventDefault();
        $.get('/Home/', input, function (data) {
            console.log(data);
            $('#about').html(data);
        })
    })
    $.get($(this), input, function (data) {
        $('#about').html(data);
    })
}