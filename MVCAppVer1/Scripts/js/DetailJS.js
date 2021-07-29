var newVal = 1;

$('#inputValue').keydown(function (e) {
    if (e.keyCode == 189 || e.keyCode == 190 || e.keyCode == 69) {
        e.preventDefault();
    } else {
    }
})

$('#inputValue').change(function () {
    newVal = Number($('#inputValue').val())
})

$('#btn-decrease').click(function () {
    console.log("Current value = " + newVal);
    newVal = newVal - 1;
    console.log("New Value = " + newVal);
    if (newVal < 1) newVal = 1;
    else $('#inputValue').val(newVal);
})

$('#btn-increase').click(function () {
    console.log("Current value = " + newVal);
    newVal = newVal + 1;
    console.log("New Value = " + newVal);
    $('#inputValue').val(newVal);

})
