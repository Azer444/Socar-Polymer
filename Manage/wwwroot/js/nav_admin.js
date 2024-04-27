$(function () {
    if ($('#HasMainComponent').attr('checked')) {
        $('.photo').removeClass('d-none');
    }

    $('#HasMainComponent').change(function () {
        if (this.checked) {
            $('.photo').removeClass('d-none');
        }
        else {
            $('.photo').addClass('d-none');
        }
    });
})