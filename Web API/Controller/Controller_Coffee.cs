using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_API.LINQ;

namespace Web_API.Controller
{
    public class Controller_Coffee
    {
        public static List<CoffeeView> GetALLCoffee()
        {
            LINQ_INVOICEDataContext dc = new LINQ_INVOICEDataContext();
            List<CoffeeView> list = (from c in dc.CoffeeViews where c.Active == true orderby c.CoffeeTypeName descending select c).ToList();
            return list;
        }
        public static CoffeeView UpdateCoffee(string CoffeeID)
        {
            LINQ_INVOICEDataContext dc = new LINQ_INVOICEDataContext();
            return (from c in dc.CoffeeViews where c.CoffeeTypeId == CoffeeID && c.Active == true select c).FirstOrDefault();
        }
        public static string SaveCoffee(string id, string name, string price)
        {
            LINQ_INVOICEDataContext dc = new LINQ_INVOICEDataContext();
            Coffee coffee = new Coffee();
            if (id == "")
            {
                coffee.CoffeeTypeId = Guid.NewGuid().ToString();
                coffee.Active = true;
                dc.Coffees.InsertOnSubmit(coffee);
            }
            else
            {
                coffee = (from c in dc.Coffees where c.CoffeeTypeId == id select c).FirstOrDefault();
            }
            coffee.CoffeeTypeName = name;
            coffee.Price = decimal.Parse(price);
            dc.SubmitChanges();
            return "Success";

        }
        public static string DeleteCoffee(string coffeeID)
        {
            LINQ_INVOICEDataContext dc = new LINQ_INVOICEDataContext();
            Coffee coffee_record = (from c in dc.Coffees where c.CoffeeTypeId == coffeeID select c).FirstOrDefault();
            coffee_record.Active = false;
            dc.SubmitChanges();
            return "Delete Success";
        }

    }
}