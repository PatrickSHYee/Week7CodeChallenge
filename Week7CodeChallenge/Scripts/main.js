$(document).ready(function () {
    $.get('Home/Home', function(data){
        $('.container').html(data);
    })
    $('.nav-links a').on('click', function(event){
        event.preventDefault();
        var aTagger = $(this).attr('href');
        $.get(aTagger, function(data){
            $('#body').html(data);
        })
    })

    var arr_Href = ['/Home/Who', '/Home/What/', '/Home/Why/', '/Home/How/', '/Home/Where/'];

    function About(input) {
        $.get(arr_Href[input], function (data) {
            $('.about').html(data);
        })
    }
})