using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MyWineStore.Controllers
{
    public class ForgotPasswordController : Controller
    {
        // GET: ForgotPassword
        public ActionResult Index()
        {
            var model = new Models.ForgotPasswordModel();
            return View(model);
        }
        [HttpPost]
        public async Task<ActionResult> Index(Models.ForgotPasswordModel model)
        {
            if (WebMatrix.WebData.WebSecurity.UserExists(model.EmailAddress))
            {
                string resetToken = WebMatrix.WebData.WebSecurity.GeneratePasswordResetToken(model.EmailAddress);
                string resetUrl = Request.Url.GetLeftPart(UriPartial.Authority) + "ForgotPassword/Reset/resetToken=" + resetToken;

                //this is how u set up ur api 
                string sendGridApiKey = ConfigurationManager.AppSettings["sendGridApiKey"];
                SendGrid.SendGridAPIClient client = new SendGrid.SendGridAPIClient(sendGridApiKey);

                Email from = new Email("admin@mywinestore.com");
                string subject = "Instructions for Ressetting your password";
                Email to = new Email("test@example.com");
                Content content = new Content("text/html", string.Format("<a href= \"{0}\">Reset your password</a>", resetUrl));
                Mail mail = new Mail(from, subject, to, content);

                var response = await client.client.mail.send.post(requestBody: mail.Get());
                string message = await response.Body.ReadAsStringAsync();

                //TO DO: setting up for email sending when email is working   u need the api key and api key id 
                // Api key: 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               
                // Api key ID: rBsJG6WkQoqj0faa9zO5ew

            }

            return RedirectToAction("ResetSent");
        }

        public ActionResult ResetSent()
        {
            return View();
        }

        public ActionResult Reset(string resetToken)
        {
            Models.ResetPasswordModel model = new Models.ResetPasswordModel();
            model.ResetToken = resetToken;
            return View(model);
        }
        [HttpPost]
        public ActionResult Reset(Models.ResetPasswordModel model)
        {
            if(ModelState.IsValid)
            {
                WebMatrix.WebData.WebSecurity.ResetPassword(model.ResetToken, model.Password);
                return RedirectToAction("Index", "Login");
            }
            return View(model);
        }
       
      

    }
}