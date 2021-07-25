'use strict'

let PageIndex = 1;
let isSearching;

function getSearchValue() {
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

getSearchValue();
if (isSearching) {
    $(".search-result-lable").removeClass("hidden");
    $(".search-keyword").html(decodeURI(getSearchValue()));
}

$("#btnViewMore").click(function () {
    let keyword = getSearchValue();
    $.ajax({
        type: 'POST', //POST
        url: '/home/fetchData/',
        data: { PageIndex: PageIndex++, IsSearching: isSearching, Keyword: keyword },
        cache: false,
        success: function (result) {
            if (result.html != null && result.remain >= 0) {
                $('.grid-container').append(result.html);
                $('#remain').html(result.remain);
                if (result.remain == 0) {
                    $('#btnViewMore').remove();
                }
            }
        }
    });
})
