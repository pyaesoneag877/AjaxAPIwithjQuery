
$('.content').first().slideDown();
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

          $("#tbodyCoffee").append('<tr onclick="cellClickCoffee(\'' + item.CoffeeTypeId + '\')"><td>' + item.CoffeeTypeId +
            '</td><td>' + item.CoffeeTypeName +
            '</td><td>' + item.Price +
            '</td><td><button class="delete btn btn-danger" onclick="deleteCoffee(\'' + item.CoffeeTypeId + '\')">Delete</button></td></tr>');
        });
      }
    },
    error: function (xhr, msg) {
      LogJSError('Web Service Fail: ' + msg + '\n' + xhr.responseText);

    }
  });
}


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
      $("#txtCoffeeName").val(" ");
      $("#txtPrice").val(" ");
      GetALLCoffee();
    },
    error: function (xhr, msg) {
      LogJSError('Web Service Fail: ' + msg + '\n' + xhr.responseText);

    }
  });
};



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
//End coffee page delete record

//-- jQuery --//

$(".link-wrapper li a").click(function (event) {

  var currentHref = $(this).attr('href');

  $(".link-wrapper a").removeClass("active-link");
  $(this).addClass('active-link');

  $('.content').slideUp();

  $(currentHref).slideDown();

  event.preventDefault();
});




