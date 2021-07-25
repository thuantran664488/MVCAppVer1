function isValidInputSearch() {
    let inputValue = $('#input-search').val();
    let pattSpace = /^(\s)+/;
    if (pattSpace.test(inputValue) == true) return false;
    let patt = /(^(\d|\w|\s|\u00E0|\u00C0|\u1EA3|\u1EA2|\u00E3|\u00C3|\u00E1|\u00C1|\u1EA1|\u1EA0|\u0103|\u0102|\u1EB1|\u1EB0|\u1EB3|\u1EB2|\u1EB5|\u1EB4|\u1EAF|\u1EAE|\u1EB7|\u1EB6|\u00E2|\u00C2|\u1EA7|\u1EA6|\u1EA9|\u1EA8|\u1EAB|\u1EAA|\u1EA5|\u1EA4|\u1EAD|\u1EAC|\u0111|\u0110|\u00E8|\u00C8|\u1EBB|\u1EBA|\u1EBD|\u1EBC|\u00E9|\u00C9|\u1EB9|\u1EB8|\u00EA|\u00CA|\u1EC1|\u1EC0|\u1EC3|\u1EC2|\u1EC5|\u1EC4|\u1EBF|\u1EBE|\u1EC7|\u1EC6|\u00EC|\u00CC|\u1EC9|\u1EC8|\u0129|\u0128|\u00ED|\u00CD|\u1ECB|\u1ECA|O|\u00F2|\u00D2|\u1ECF|\u1ECE|\u00F5|\u00D5|\u00F3|\u00D3|\u1ECD|\u1ECC|\u00F4|\u00D4|\u1ED3|\u1ED2|\u1ED5|\u1ED4|\u1ED7|\u1ED6|\u1ED1|\u1ED0|\u1ED9|\u1ED8|\u01A1|\u01A0|\u1EDD|\u1EDC|\u1EDF|\u1EDE|\u1EE1|\u1EE0|\u1EDB|\u1EDA|\u1EE3|\u1EE2|\u00F9|\u00D9|\u1EE7|\u1EE6|\u0169|\u0168|\u00FA|\u00DA|\u1EE5|\u1EE4|\u01B0|\u01AF|\u1EEB|\u1EEA|\u1EED|\u1EEC|\u1EEF|\u1EEE|\u1EE9|\u1EE8|\u1EF1|\u1EF0|\u1EF3|\u1EF2|\u1EF7|\u1EF6|\u1EF9|\u1EF8|\u00FD|\u00DD|\u1EF5|\u1EF4)+$)/
    return patt.test(inputValue);
}

if (!isValidInputSearch()) {
    $('#btn-search').prop('disabled', true);
}

$('#input-search').keyup(function () {
    if (isValidInputSearch()) {
        console.log("Valid");
        $('#btn-search').prop('disabled', false);
    } else {
        console.log("Not Valid");
        $('#btn-search').prop('disabled', true);
    }
})