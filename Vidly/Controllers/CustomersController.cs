using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {

        private VidlyDb _context;

        public CustomersController()
        {
            _context = new VidlyDb();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }



        // GET: Customers
        public ActionResult Index()
        {

            //var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            var customers = (from _c in _context.Customers.Include(c => c.MembershipType) select _c).ToList();
            return View(customers);
        }


        public ActionResult Details(int? Id)
        {

            //var customer = (from _c in _context.Customers where _c.Id == Id select _c).FirstOrDefault();
            var customer = _context.Customers.SingleOrDefault(c => c.Id == Id);

            if (customer != null)
            {
                return View(customer);
            }
            else
            {
                return HttpNotFound();
            }

        }


    }
}