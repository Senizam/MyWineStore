using MyWineStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWineStore.Controllers
{
    public class CheckoutController : Controller
    {
        // GET: Checkout
        public ActionResult Index()
        {
            CheckOutModel model = new CheckOutModel();
            using (Models.WineStoreEntities entities = new Models.WineStoreEntities())
            {
                var customer = entities.Customers.Single(x => x.EmailAddress == User.Identity.Name);
                var o = customer.Orders.First();    //TODO: this needs to find the first order without a "Submit Date";
                model.FirstName = customer.FirstName;
                model.LastName = customer.LastName;
                model.EmailAddress = customer.EmailAddress;
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(CheckOutModel model)
        {
            //TODO: Capture the updated model fields in the database
            return View();
        }
    }
}