$(document).ready(function () {
    $(".validatetext").keypress(function (e) {
        var regex = new RegExp("^[a-zA-Z ]+$");
        var strigChar = String.fromCharCode(!e.charCode ? e.which : e.charCode);
        if (regex.test(strigChar)) { return true; } return false;
    });
    $(".validatenum").keypress(function (e) {
        if (e.which != 8 && e.which != 0 && (e.which < 48 || e.which > 57 || e.which == 46)) {
            return false;
        }
    });
});
