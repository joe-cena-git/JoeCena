using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DomainSite.Models
{
    public class BlogPost
    {
        private Category Category;
        private string TitleShort;
        private string TitleLong;
        private DateTime DateCreated;
        private DateTime DateLastModified;
        private DateTime DatePublished;

        private string SummaryShort;
        private string SummaryLong;
        private string Body;


    }
}