using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DomainSite.ViewModels
{
    public class ArticleJumbotronVM
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime RevisedDate { get; set; }
    }
}