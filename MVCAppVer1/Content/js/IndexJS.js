let productName = document.getElementsByClassName("product-name");
for (let i = 0; i < productName.length; i++) {
    proElem = productName[i].innerHTML;
    if (proElem.length >= 30) {
        productName[i].innerHTML = proElem.slice(0, 30) + " ...";
    }
}