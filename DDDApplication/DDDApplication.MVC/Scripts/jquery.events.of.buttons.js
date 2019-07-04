$("#btnSearhcustomerName").click(function () {
    window.location.href = '/Customers/Search/?nameFragment=' + $('#customerName').val();
});


$('#customerName').keypress(function (e) {
    if (e.which == 13) $('#btnSearhcustomerName').click();
});