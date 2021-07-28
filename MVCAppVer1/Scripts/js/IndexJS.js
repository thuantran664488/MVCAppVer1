'use strict'

let PageIndex = 1;

$("#btnViewMore").click(function () {
    $.ajax({
        type: 'POST', //POST
        url: '/home/fetchData/',
        data: { PageIndex: PageIndex++ },
        cache: false,
        success: function (result) {
            if (result.html != null && result.remain >= 0) {
                $('.grid-container').append(result.html);
                $('#remain').html(result.remain);
                if (result.remain == 0) {
                    $('#btnViewMore').hide();
                }
            }
        }
    });
})
