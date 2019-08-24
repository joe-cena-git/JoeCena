using DomainSite.Enums;
using System;
using System.Web.Mvc;

namespace DomainSite.Controllers
{
    public class ArticlesController : Controller
    {
        // GET: Articles
        public ActionResult Index(string category = null, string id = null)
        {
            // if the category or id is null or of length 0, or the category we received isn't in our category list...
            if (category == null || id == null || category.Length == 0 || id.Length == 0 || !Enum.IsDefined(typeof(Category), category.ToUpper()))
            {
                return View();
            }
            else // return the article to the user
            {
                return View("~/Views/Articles/" + category + "/" + id + ".cshtml");
            }
        }
    }
}