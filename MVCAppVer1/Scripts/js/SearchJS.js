﻿let PageIndex = 1;
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

$('.btn-change-price').keydown(function (e) {
    if (e.keyCode == 189 || e.keyCode == 190 || e.keyCode == 69) {
        e.preventDefault();
    }
})

$("#btnSearchByPrice").click(function () {
    PageIndex = 1;
    let keyword = getSearchKeyword();
    minPrice = $('#input-minPrice').val();
    maxPrice = $('#input-maxPrice').val();
    if (minPrice < maxPrice) {
        $.ajax({
            type: 'POST', //POST
            url: '/search/filter/',
            data: { PageIndex: 0, keyword: keyword, minPrice: minPrice, maxPrice: maxPrice },
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

