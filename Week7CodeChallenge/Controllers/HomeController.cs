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
            ViewBag.Title = "Index";
            return View();
        }

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
            return PartialView(new Models.AJAX_ContactForm());
        }

        [HttpPost]
        public ActionResult Contact(Models.AJAX_ContactForm form)
        {
            // context
            Models.AJAXContactFormsEntities db = new Models.AJAXContactFormsEntities();
            // add to table
            db.AJAX_ContactForm.Add(form);
            db.SaveChanges(); // save changes
            return Content("ThankYou");
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