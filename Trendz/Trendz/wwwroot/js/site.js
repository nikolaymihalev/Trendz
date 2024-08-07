$('.nav-search form input').on('.nav-search form input', function () {
    if ($(this).val() != '') {
        $(this).parent().find('label').css('display','none');
    } else {
        $(this).parent().find('label').css('display', 'block');
    }
});