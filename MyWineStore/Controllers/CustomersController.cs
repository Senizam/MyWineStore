using MyWineStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWineStore.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index(int? id)
        {
            using (WineStoreEntities entities = new WineStoreEntities())
            {
                var record = entities.Customers.Single(x => x.Id == id);
                var customer = new Customer
                {
                    Id = record.Id,
                    FirstName = record.FirstName,
                    LastName = record.LastName,
                    Address = record.Address,
                    City = record.City,
                    DateOfBirth = record.DateOfBirth
                };
                return View(customer);
            }


            
        }
    }
}