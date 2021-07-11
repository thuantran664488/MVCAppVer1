let inputValue = document.getElementById('inputValue');
var newVal;
function decreaseValue() {
    if (inputValue.value > 1) {
        newVal = Number(inputValue.value) - 1;
    } else newVal = 1;
    inputValue.setAttribute('value', newVal);
}
function increaseValue() {
    var newVal = Number(inputValue.value) + 1;
    inputValue.setAttribute('value', newVal);
}