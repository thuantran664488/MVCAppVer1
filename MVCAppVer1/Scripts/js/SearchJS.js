let PageIndex = 1;
let minPrice = 0;
let maxPrice = 0;

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

function isValidInputPrice() {
    let patt = /(\d)+/;
    minPrice = $('#input-minPrice').val();
    maxPrice = $('#input-maxPrice').val();
    if (patt.test(minPrice) && patt.test(maxPrice)) {
        return true;
    } else return false;
}

$('#input-minPrice').keyup(function () {
    if (isValidInputPrice()) {
        console.log("Valid");
        $('#btnSearchByPrice').prop('disabled', false);
    } else {
        console.log("Not Valid");
        $('#btnSearchByPrice').prop('disabled', true);
    }
})

$('#input-maxPrice').keyup(function () {
    if (isValidInputPrice()) {
        console.log("Valid");
        $('#btnSearchByPrice').prop('disabled', false);
    } else {
        console.log("Not Valid");
        $('#btnSearchByPrice').prop('disabled', true);
    }
})


$("#btnSearchByPrice").click(function () {
    PageIndex = 1;
    let keyword = getSearchKeyword();
    minPrice = $('#input-minPrice').val();
    maxPrice = $('#input-maxPrice').val();
    $.ajax({
        type: 'POST', //POST
        url: '/search/filter/',
        data: { PageIndex: 0, keyword: keyword, minPrice: minPrice, maxPrice: maxPrice },
        cache: false,
        success: function (result) {
            if (result.html != null && result.remain >= 0) {
                console.log(" HTML=  " + result.html);
                console.log(" Remain=  " + result.remain);
                console.log(" Total=  " + result.total);
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
                console.log(" HTML=  " + result.html);
                console.log(" Remain=  " + result.remain);
                console.log(" Total=  " + result.total);
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

