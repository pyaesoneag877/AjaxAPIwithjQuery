function newCoffee() {
    $.ajax({
        url: 'http://localhost:3001/WebService/WebService_Coffee.asmx/SaveCoffee',
        data: JSON.stringify({ id: $("#txtid").val(), name: $("#txtCoffeeName").val(), price: $("#txtPrice").val() }),
        dataType: 'json',
        type: "POST",
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            alert("Success");
            $("#txtCoffeeName").val("");
            $("#txtPrice").val("");
            var url = "http://localhost:3001/Coffee";
            $(location).attr('href', url);
        },
        error: function (xhr, msg) {
            LogJSError('Web Service Fail: ' + msg + '\n' + xhr.responseText);
        }
    });
};