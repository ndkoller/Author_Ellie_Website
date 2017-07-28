using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ebkoller_website.Controllers
{
    public class TeasersController : Controller
    {
        // GET: Teasers
        public ActionResult Index()
        {
            return View();
        }
    }
}