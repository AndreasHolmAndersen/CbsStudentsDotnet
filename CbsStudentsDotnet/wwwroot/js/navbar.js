$(document).ready(function () {
    var url = window.location;
    $('.nav-bar .nav-links').find('.active').removeClass('active');
    $('.nav-bar .nav-links li a').each(function () {
        if (this.href == url) {
            $(this).parent().addClass('active');
        }
    }); 
});
