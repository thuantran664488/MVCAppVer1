let PageIndex = 1;
let minPrice = 0;
let maxPrice = 0;
let isSearching = true;

function getSearchKeyword() {
    let searchUrl = window.location.search;
    if (searchUrl == "") {
        isSearching = false;
        return searchUrl;
    } else {
        isSearching = true;
        var [key, value] = window.location.search.split("=")
        return value.split("+").join(" ");
    }
}

getSearchKeyword();
if (isSearching) {
    $(".search-result-lable").removeClass("hidden");
    $(".search-keyword").html(decodeURI(getSearchKeyword()));
}

$('.btn-change-price').keydown(function (e) {
    if (e.keyCode == 189 || e.keyCode == 190 || e.keyCode == 69) {
        e.preventDefault();
    }
})

function callAjaxForPrice(PageIndex, keyword, minPrice, maxPrice) {
    $.ajax({
        type: 'POST', //POST
        url: '/search/filter/',
        data: { PageIndex: PageIndex, keyword: keyword, minPrice: minPrice, maxPrice: maxPrice },
        cache: false,
        success: function (result) {
            if (result.html != null && result.remain >= 0) {
                $('.grid-container').empty();
                $('.grid-container').append(result.html);
                $('#remain').html(result.remain);
                if (result.remain == 0) {
                    $('#btnViewMore').hide();
                } else {
                    $('#btnViewMore').show();
                }
            } else {
                $('.grid-container').empty();
                $('#btnViewMore').hide();
            }
        }
    });
}

$('input[type=radio]').on('change', function () {
    PageIndex = 1;
    let keyword = getSearchKeyword();
    radioValue = $('input[name=radioName]:checked').val();
    if (radioValue == "all") {
        minPrice = 0;
        maxPrice = 1 * 10 ^ 10;
    }
    if (radioValue == "under100") {
        minPrice = 0;
        maxPrice = 100;
    }
    if (radioValue == "between100and500") {
        minPrice = 100;
        maxPrice = 500;
    }
    if (radioValue == "between500and1mil") {
        minPrice = 500;
        maxPrice = 1000;
    }
    if (radioValue == "above1mil") {
        minPrice = 1000;
        maxPrice = 1 * 10 ^ 10;
    }
    callAjaxForPrice(0, keyword, minPrice, maxPrice);
});

$("#btnSearchByPrice").click(function () {
    PageIndex = 1;
    let keyword = getSearchKeyword();
    minPrice = Number($('#input-minPrice').val());
    maxPrice = Number($('#input-maxPrice').val());
    if (minPrice < maxPrice) {
        callAjaxForPrice(0, keyword, minPrice, maxPrice);

    } else alert("Your min is greater or equal max\n Please check your min or max price again")
})


$("#btnViewMore").click(function () {
    let keyword = getSearchKeyword();
    $.ajax({
        type: 'POST', //POST
        url: '/search/filter/',
        data: { PageIndex: PageIndex++, keyword: keyword, minPrice: minPrice, maxPrice: maxPrice },
        cache: false,
        success: function (result) {
            if (result.html != null && result.remain >= 0) {
                $('.grid-container').append(result.html);
                $('#remain').html(result.remain);
                if (result.remain == 0) {
                    $('#btnViewMore').hide();
                } else {
                    $('#btnViewMore').show();
                }
            }
        }
    });
})

