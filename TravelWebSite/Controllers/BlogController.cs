using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelWebSite.Models.Siniflar;

namespace TravelWebSite.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        BlogYorum blogYorum = new BlogYorum();

        public ActionResult Index()
        {
            var bloglar = c.Blogs.ToList();
            return View(bloglar);
        }

        public PartialViewResult SonBlog()
        {
            blogYorum.sonblogs = c.Blogs.OrderByDescending(x => x.Id).Take(3).ToList();
            return PartialView(blogYorum);
        }

        public PartialViewResult SonYorum()
        {
            blogYorum.sonyorums = c.Yorumlars.OrderByDescending(x => x.ID).Take(3).ToList();
            return PartialView(blogYorum);
        }

        public ActionResult BlogDetay(int id)
        {
            //var blogbul = c.Blogs.Where(x => x.Id == id).ToList();
            blogYorum.Blogs = c.Blogs.Where(x => x.Id == id).ToList();
            blogYorum.Yorumlars = c.Yorumlars.Where(x => x.Blogid == id).ToList();
            return View(blogYorum);
        }

        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar yrlar)
        {
            c.Yorumlars.Add(yrlar);
            c.SaveChanges();
            return PartialView();
        }
    }
}