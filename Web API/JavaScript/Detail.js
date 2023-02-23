function GetURLData(id) {
    var sPageURL = window.location.search.substring(1);
    var sURLVariables = sPageURL.split('&');
    for (var i = 0; i < sURLVariables.length; i++) {
        var sParameterName = sURLVariables[i].split('=');
        if (sParameterName[0] == id) {
            var reSpace = new RegExp('%20', 'g');
            return sParameterName[1].replace(reSpace, ' ');
        }
    }
}
function cellClickCoffee(id) {
    $.ajax({
        url: 'http://localhost:3001/WebService/WebService_Coffee.asmx/UpdateCoffee',
        data: JSON.stringify({ CoffeeID: id }),
        dataType: 'json',
        type: "POST",
        contentType: "application/json; charset=utf-8",

        success: function (data) {
            $("#txtid").val(data.d.CoffeeTypeId);
            $("#txtCoffeeName").val(data.d.CoffeeTypeName);
            $("#txtPrice").val(data.d.Price);
        },
        error: function (xhr, msg) {
            LogJSError('Web Service Fail: ' + msg + '\n' + xhr.responseText);
        }
    });
}
function getData() {
    var ID = GetURLData("CoffeeTypeId");
    cellClickCoffee(ID);
}
getData();

//Coffee page save record
function saveCoffee() {

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
//Reset fields
function resetCoffee() {
    $("#txtCoffeeName").val("");
    $("#txtPrice").val("");
}