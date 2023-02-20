using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Web_API.LINQ;

namespace Web_API.WebService
{
    /// <summary>
    /// Summary description for WebService_Coffee
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebService_Coffee : System.Web.Services.WebService
    {

        [WebMethod]
        public  List<CoffeeView> GetALLCoffee()
        {
            return Controller.Controller_Coffee.GetALLCoffee();
        }   
        [WebMethod]
        public CoffeeView UpdateCoffee(string CoffeeID)
        {
            return Controller.Controller_Coffee.UpdateCoffee(CoffeeID);
        }
        [WebMethod]
        public string SaveCoffee(string id, string name, string price)
        {
            return Controller.Controller_Coffee.SaveCoffee(id,name,price);
        }
        [WebMethod]
        public string DeleteCoffee(string coffeeID)
        {
            return Controller.Controller_Coffee.DeleteCoffee(coffeeID);
        }

    }
}
