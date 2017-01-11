using MyWineStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWineStore.Controllers
{
    public class WinesController : Controller
    {
        // GET: Wines/Random
        public ActionResult Index()
        {
            using (WineStoreEntities entities = new WineStoreEntities())
            {
                var wines = entities.Wines.Select(x => new WineModel
                {
                    Name = x.Name,
                    Id = x.Id,
                    WineType = x.Type,
                    Quantity = 0
                }).ToArray();
                return View(wines);
            }


            // when you dont find the product and u  want to return the homepage  use below code
            //  return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        [HttpPost]
        public ActionResult Index(WineModel model)
        {
            int orderId = -1;
            using (WineStoreEntities entities = new WineStoreEntities())
            {
                Order o = new Order();
                o.Wines.Add(entities.Wines.Single(x => x.Id == model.Id));
                entities.Customers.Single(x => x.EmailAddress == User.Identity.Name).Orders.Add(o);
                entities.SaveChanges();
                orderId = o.Id;

            }

                return RedirectToAction("Index", "Checkout", new { OrderId = orderId });
        }
    }
}