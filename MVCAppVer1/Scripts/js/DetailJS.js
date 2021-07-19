let inputValue = document.getElementById('inputValue');
var newVal;
const xhttp = new XMLHttpRequest();
xhttp.status
function handleChange() {
    inputValue = document.getElementById('inputValue');
    alert(inputValue.value);
}

function decreaseValue() {
    if (inputValue.value > 1) {
        newVal = Number(inputValue.value) - 1;
    } else newVal = 1;
    inputValue.setAttribute('value', newVal);
    }
function increaseValue() {
    newVal = Number(inputValue.value) + 1;
    inputValue.setAttribute('value', newVal);
}
