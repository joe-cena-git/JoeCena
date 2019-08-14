using DomainSite.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DomainSite.Models
{
    public class Post
    {
        public Category Category { get; set; }
        public bool IsFeatured { get; set; }
        public string AuthorName { get; set; }
        public string AuthorEmail { get; set; }
        public string TitleFull { get; set; }
        public string TitleShort { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastModified { get; set; }
        public DateTime DatePublished { get; set; }
        public string SummaryShort { get; set; }
        public string SummaryLong { get; set; }
        public string Body { get; set; }
    }
}