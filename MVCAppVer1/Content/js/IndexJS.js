﻿let productName = document.getElementsByClassName("product-name");
for (let i = 0; i < productName.length; i++) {
    proElem = productName[i].innerHTML;
    if (proElem.length >= 30) {
        productName[i].innerHTML = proElem.slice(0, 30) + " ...";
    }
}

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