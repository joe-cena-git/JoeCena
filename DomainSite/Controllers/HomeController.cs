using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomainSite.Models;
using DomainSite.Services;

namespace DomainSite.Controllers
{
    public class HomeController : Controller
    {
        private PostService PostService = null;

        private PostService GetSingletonPostService()
        {
            if(this.PostService == null)
            {
                this.PostService = new PostService();
            }
            return this.PostService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var postService = GetSingletonPostService();
            return View(postService.Get());
        }

        [HttpGet]
        public ActionResult Get(int id)
        {
            var blogPostService = GetSingletonPostService();
            return View(blogPostService.Get(id));
        }
    }
}