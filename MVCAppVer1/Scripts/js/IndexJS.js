'use strict'



function loadDoc() {
    var xhttp = new XMLHttpRequest();
    xhttp.onload = function () {
        if (this.readyState == 4 && this.status == 200) {
            document.getElementById("demo").innerHTML =
                this.responseText;
        }
    }
    xhttp.open("GET", "Content/txt/TextFile1.txt", true);
    xhttp.send();
}

function loadXML() {
    const xhttp = new XMLHttpRequest();
    xhttp.onload = function () {
        const xmlDoc = this.responseXML;
        const x = xmlDoc.getElementsByTagName("ARTIST");
        let txt = "";
        for (let i = 0; i < x.length; i++) {
            txt = txt + x[i].childNodes[0].nodeValue + "<br>";
        }
        document.getElementById("demo").innerHTML = txt;
    }
    xhttp.open("GET", "Content/txt/XMLFile1.xml");
    xhttp.send();
}

$("#searchInput").on("keydown", function () {
    var inputValue = $(this).val().toLowerCase();
    let obj = $(".product-name");
    let numberObj = Object.keys(obj);
    numberObj.forEach(function (value, index) {
        if (index < numberObj.length - 2) {
            if (obj[index].textContent.toLowerCase().includes(inputValue)) {
                console.log(`Search found ${obj[index].textContent}`);
            }
        }
    })
    console.log('--------------')
})

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
                if (result.remain == 0) {
                    $('#btnViewMore').remove();
                }
            }
        }
    });
    //$.get(url, { end }, function (response, status) {
    //    console.log(response);
    //    $('.grid-container').append(response);
    //})
})
