using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;

namespace Week7CodeChallenge.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        public ActionResult Home()
        {
            return PartialView();
        }

        public ActionResult About()
        {
            return PartialView();
        }

        public ActionResult Work()
        {
            return PartialView();
        }

        public ActionResult Careers()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            return PartialView(new Models.Contact());
        }

        [HttpPost]
        public ActionResult Contact(Models.Contact form)
        {
            try
            {
                form.SentDate = DateTime.Now;
                // context
                Models.ContactFormsEntities db = new Models.ContactFormsEntities();
                // add to table
                db.Contacts.Add(form);
                db.SaveChanges(); // save changes
            }
            catch (Exception e)
            {
                ViewBag.Message = e.Message;
                return PartialView("Error");
            }

            // SMTP simple mail transfer protocol
            MailMessage message = new MailMessage(form.Email, "patrickshyee@gmail.com");
            SmtpClient client = new SmtpClient();

            client.Host = "mail.dustinkraft.com";
            client.Port = 587;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("postmaster@dustinkraft.com", "techIsFun1");

            message.Subject = form.Subject;
            message.Body = form.Body;
            message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.Send(message);

            // host: mail.dustinkraft.com
            // port: 587
            // user: postmaster@dustionkraft.com
            // password: techIsFun1

            // redirect the user to the thank you
            return RedirectToAction("ThankYou", "Home");
        }

        public string GetLorem()
        {
            string temp = null;
            for (int i = 0; i < 100; i++)
            {
                temp += "Lorem Ipsum.  ";
            }
            return temp;
        }

        public ActionResult Who()
        {
            ViewBag.Message = GetLorem();
            return PartialView();
        }
        public ActionResult How()
        {
            ViewBag.Message = GetLorem();
            return PartialView();
        }

        public ActionResult What()
        {
            ViewBag.Message = GetLorem();
            return PartialView();
        }

        public ActionResult Why()
        {
            ViewBag.Message = GetLorem();
            return PartialView();
        }

        public ActionResult Where()
        {
            ViewBag.Message = GetLorem();
            return PartialView();
        }
    }
}