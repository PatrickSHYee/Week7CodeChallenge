using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week7CodeChallenge.Controllers
{
    public class BusinessController : Controller
    {
        // GET: Business -> Work
        public ActionResult Work()
        {
            return View();
        }

        // GET: Business -> Careers
        public ActionResult Careers()
        {
            return View();
        }
    }
}