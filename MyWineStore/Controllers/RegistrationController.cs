using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MyWineStore.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            Models.RegistrationModel model = new Models.RegistrationModel();
            return View(model);
        }

      //POST
      [HttpPost]
      public ActionResult Index(Models.RegistrationModel model)
        {
            if (ModelState.IsValid)
            {
              if  (WebMatrix.WebData.WebSecurity.UserExists(model.Password))

                {
                    ModelState.AddModelError("EmailAddress", "Username is already in user");
                }else
                {
                    WebMatrix.WebData.WebSecurity.CreateUserAndAccount(model.EmailAddress, model.Password, new { FirstName = model.FirstName, LastName = model.LastName, DateOfBirth = model.DateOfBirth }, false);
                    HttpCookie authCookie = FormsAuthentication.GetAuthCookie(model.EmailAddress, true);
                    Response.Cookies.Add(authCookie);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(model);
        }
    }
}