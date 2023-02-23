GetALLCoffee();
//Coffee Page Show All Ajax api using jQuery
function GetALLCoffee() {
  $.ajax({
    url: 'http://localhost:3001/WebService/WebService_Coffee.asmx/GetALLCoffee',
    dataType: 'json',
    type: "POST",
    contentType: "application/json; charset=utf-8",
    success: function (data) {
      if (data.d != null) {
        var result = data.d;
        $("#tbodyCoffee").html("");
          result.forEach(item => {
              $("#tbodyCoffee").append('<tr><td>' + item.CoffeeTypeId + '</td><td>' + item.CoffeeTypeName + '</td><td>' + item.Price + '</td><td><button class="delete btn btn-danger" onclick="deleteCoffee(\'' + item.CoffeeTypeId + '\')">Delete</button></td><td><a href="http://localhost:3001/CoffeeDetail?CoffeeTypeId=' + item.CoffeeTypeId + '" class="btn btn-info active" role="button" aria-pressed="true" >Detail</a></td></tr>');
              //</td >
        });
      }
    },
    error: function (xhr, msg) {
      LogJSError('Web Service Fail: ' + msg + '\n' + xhr.responseText);

    }
  });
}



//Coffee page delete record
function deleteCoffee(id) {
  $.ajax({
    url: 'http://localhost:3001/WebService/WebService_Coffee.asmx/DeleteCoffee',
    data: JSON.stringify({ coffeeID: id }),
    dataType: 'json',
    type: "POST",
    contentType: "application/json; charset=utf-8",
    success: function (data) {
      alert("Delete success");
      GetALLCoffee();
    },
    error: function (xhr, msg) {
      LogJSError('Web Service Fail: ' + msg + '\n' + xhr.responseText);
    }
  });

};






