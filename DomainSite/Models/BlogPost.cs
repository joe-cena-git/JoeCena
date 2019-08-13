using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DomainSite.Models
{
    public class BlogPost
    {
        private Category Category;
        private TitleFull TitleFull;
        private TitleShort TitleShort;
        private DateTime DateCreated;
        private DateTime DateLastModified;
        private DateTime DatePublished;

        private SummaryShort SummaryShort;
        private SummaryLong SummaryLong;
        private Body Body;

        public BlogPost(Category Category)
        {

        }
    }

    public enum Category
    {
        World,
        US,
        Technology,
        Design,
        Culture,
        Business,
        Politics,
        Opinion,
        Science,
        Health,
        Style,
        Travel
    }

    internal class TitleShort
    {
        private readonly string Text;
        
        protected TitleShort(string text)
        {
            if (text == null)
            {
                throw new IndexOutOfRangeException("TitleShort expects a non-null string, input was null.");
            } 
            else if(text.Length < 1 || text.Length > 15)
            {
                throw new IndexOutOfRangeException("TitleShort expects a string between 1 and 15 characters. Input was '" + text + "' (" + text.Length + " chars).");
            }
            else
            {
                this.Text = text;
            }
        }
        
        public override string ToString()
        {
            return this.Text;
        }
    }

    internal class TitleFull
    {
        private readonly string Text;

        protected TitleFull(string text)
        {
            if (text == null)
            {
                throw new IndexOutOfRangeException("TitleFull expects a non-null string, input was null.");
            }
            else if (text.Length < 1 || text.Length > 50)
            {
                throw new IndexOutOfRangeException("TitleFull expects a string between 1 and 50 characters. Input was '" + text + "' (" + text.Length + " chars).");
            }
            else
            {
                this.Text = text;
            }
        }

        public override string ToString()
        {
            return this.Text;
        }
    }

    internal class SummaryShort
    {
        private readonly string Text;

        protected SummaryShort(string text)
        {
            if (text == null)
            {
                throw new IndexOutOfRangeException("SummaryShort expects a non-null string, input was null.");
            }
            else if (text.Length < 1 || text.Length > 30)
            {
                throw new IndexOutOfRangeException("SummaryShort expects a string between 1 and 30 characters. Input was '" + text + "' (" + text.Length + " chars).");
            }
            else
            {
                this.Text = text;
            }
        }

        public override string ToString()
        {
            return this.Text;
        }
    }

    internal class SummaryLong
    {
        private readonly string Text;

        protected SummaryLong(string text)
        {
            if (text == null)
            {
                throw new IndexOutOfRangeException("SummaryLong expects a non-null string, input was null.");
            }
            else if (text.Length < 1 || text.Length > 255)
            {
                throw new IndexOutOfRangeException("SummaryLong expects a string between 1 and 255 characters. Input was '" + text + "' (" + text.Length + " chars).");
            }
            else
            {
                this.Text = text;
            }
        }

        public override string ToString()
        {
            return this.Text;
        }
    }

    internal class Body
    {
        private readonly string Text;

        protected Body(string text)
        {
            if (text == null)
            {
                throw new IndexOutOfRangeException("Body expects a non-null string, input was null.");
            }
            else if (text.Length < 1 || text.Length > 10000)
            {
                throw new IndexOutOfRangeException("Body expects a string between 1 and 10,000 characters. Input was '" + text + "' (" + text.Length + " chars).");
            }
            else
            {
                this.Text = text;
            }
        }

        public override string ToString()
        {
            return this.Text;
        }
    }
}