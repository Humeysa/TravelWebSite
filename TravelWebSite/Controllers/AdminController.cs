using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelWebSite.Models.Siniflar;

namespace TravelWebSite.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();

        // GET: Admin
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniBlog(Blog blog)
        {
            c.Blogs.Add(blog);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogDelete(int id)
        {
            var bul = c.Blogs.Find(id);
            c.Blogs.Remove(bul);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogGet(int id)
        {
            var blog = c.Blogs.Find(id);
            return View("BlogGet", blog);
        }

        public ActionResult BlogUpdate(Blog blog)
        {
            var blg = c.Blogs.Find(blog.Id);
            blg.Baslik = blog.Baslik;
            blg.Tarih = blog.Tarih;
            blg.Aciklama = blog.Aciklama;
            blg.BlogImage = blog.BlogImage;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogDetail(int id)
        {
            var blog = c.Blogs.Find(id);
            return View("BlogDetail", blog);
        }

        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }

        public ActionResult YorumDelete(int id)
        {
            var bul = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(bul);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

        public ActionResult YorumGet(int id)
        {
            var yr = c.Yorumlars.Find(id);
            return View("YorumGet", yr);
        }

        public ActionResult YorumUpdate(Yorumlar yorum)
        {
            var yrm = c.Yorumlars.Find(yorum.ID);
            yrm.KullaniciAdi = yorum.KullaniciAdi;
            yrm.Mail = yorum.Mail;
            yrm.Yorum = yorum.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
    }
}