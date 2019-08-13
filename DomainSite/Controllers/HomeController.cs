using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DomainSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var BlogPosts = new List<Models.BlogPost>();



            return View();
        }
    }
}