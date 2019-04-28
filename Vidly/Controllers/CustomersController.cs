using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {

        List<Customer> customers = new List<Customer>
        {
            new Customer {Id = 1, Name = "John Wolfla"},
            new Customer {Id = 2, Name = "Patrice Wolfla"},
            new Customer {Id = 3, Name = "Joe Wolfla"},
            new Customer {Id = 4, Name = "Patrice Wolfla"},
            new Customer {Id = 5, Name = "Madison Wolfla"},
            new Customer {Id = 6, Name = "Nick Wolfla"}
        };


        // GET: Customers
        public ActionResult Index()
        {

            return View(customers);
        }


        public ActionResult Details(int? Id)
        {

            var customer = (from _c in customers where _c.Id == Id select _c).FirstOrDefault();
            return View(customer);
        }


    }
}