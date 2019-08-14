using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomainSite.Models;

namespace DomainSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var blogPosts = new List<BlogPost>() {

                new BlogPost()
                {
                    Category = Category.Technology,
                    IsFeatured = true,
                    AuthorName = "Joe Cenatiempo",
                    AuthorEmail = "joecenatiempo@gmail.com",
                    TitleFull = "Domain Site README",
                    TitleShort = "Domain Site README",
                    DateCreated = new DateTime(2019, 8, 13, 20, 0, 0),
                    DateLastModified = new DateTime(2019, 8, 13, 20, 0, 0),
                    DatePublished = new DateTime(2019, 8, 13, 20, 0, 0),
                    SummaryShort = "Site documentation",
                    SummaryLong = "Site documentation for the Domain Site Web Application",
                    Body = "Hello and welcome to the site documentation. This is the body of the site REAME, the very first article published in your Web Domain Application."
                },
                new BlogPost()
                {
                    Category = Category.Health,
                    IsFeatured = true,
                    AuthorName = "Joe Cenatiempo",
                    AuthorEmail = "joecenatiempo@gmail.com",
                    TitleFull = "Health Article",
                    TitleShort = "Health Article",
                    DateCreated = new DateTime(2019, 8, 13, 20, 0, 1),
                    DateLastModified = new DateTime(2019, 8, 13, 20, 0, 1),
                    DatePublished = new DateTime(2019, 8, 13, 20, 0, 1),
                    SummaryShort = "A sample health article",
                    SummaryLong = "A sample health article published to the Domain Site Web Application",
                    Body = "This is some body content in the sample health article. Health is important and computers are terrible for it."
                },
                new BlogPost()
                {
                    Category = Category.Technology,
                    IsFeatured = false,
                    AuthorName = "Joe Cenatiempo",
                    AuthorEmail = "joecenatiempo@gmail.com",
                    TitleFull = "Tech Article",
                    TitleShort = "Tech Article",
                    DateCreated = new DateTime(2019, 8, 13, 20, 0, 1),
                    DateLastModified = new DateTime(2019, 8, 13, 20, 0, 1),
                    DatePublished = new DateTime(2019, 8, 13, 20, 0, 1),
                    SummaryShort = "A sample tech article",
                    SummaryLong = "A sample tech article published to the Domain Site Web Application",
                    Body = @"<p>This blog post shows a few different types of content that’s supported and styled with Bootstrap. Basic typography, images, and code are all supported.</p>
                            <hr>
                            <p>Cum sociis natoque penatibus et magnis, nascetur ridiculus mus. Aenean eu leo quam. Pellentesque ornare sem lacinia quam venenatis vestibulum. Sed posuere consectetur est at lobortis. Cras mattis consectetur purus sit amet fermentum.</p>
                            <blockquote>
                            <p>Curabitur blandit tempus porttitor. <strong>Nullam quis risus eget urna mollis</strong> ornare vel eu leo. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                            </blockquote>
                            <p>Etiam porta <em>sem malesuada magna</em> mollis euismod. Cras mattis consectetur purus sit amet fermentum. Aenean lacinia bibendum nulla sed consectetur.</p>
                            <h2>Heading</h2>
                            <p>Vivamus sagittis lacus vel augue laoreet rutrum faucibus dolor auctor. Duis mollis, est non commodo luctus, nisi erat porttitor ligula, eget lacinia odio sem nec elit. Morbi leo risus, porta ac consectetur ac, vestibulum at eros.</p>
                            <h3>Sub-heading</h3>
                            <p>Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.</p>
                            <pre><code>Example code block</code></pre>
                            <p>Aenean lacinia bibendum nulla sed consectetur. Etiam porta sem malesuada magna mollis euismod. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa.</p>
                            <h3>Sub-heading</h3>
                            <p>Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Aenean lacinia bibendum nulla sed consectetur. Etiam porta sem malesuada magna mollis euismod. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus.</p>
                            <ul>
                            <li>Praesent commodo cursus magna, vel scelerisque nisl consectetur et.</li>
                            <li>Donec id elit non mi porta gravida at eget metus.</li>
                            <li>Nulla vitae elit libero, a pharetra augue.</li>
                            </ul>
                            <p>Donec ullamcorper nulla non metus auctor fringilla. Nulla vitae elit libero, a pharetra augue.</p>
                            <ol>
                            <li>Vestibulum id ligula porta felis euismod semper.</li>
                            <li>Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.</li>
                            <li>Maecenas sed diam eget risus varius blandit sit amet non magna.</li>
                            </ol>
                            <p>Cras mattis consectetur purus sit amet fermentum. Sed posuere consectetur est at lobortis.</p>"
                }

            };

            return View(blogPosts);
        }
    }
}