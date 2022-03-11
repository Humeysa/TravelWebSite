using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelWebSite.Models.Siniflar;

namespace TravelWebSite.Controllers
{
    public class HomeController : Controller
    {
        Context c=new Context();
        // GET: Home
        public ActionResult Index()
        {
            var degerler = c.Blogs.OrderByDescending(x=>x.Id).Take(5).ToList();
            return View(degerler);
        }

        public PartialViewResult Partial1()
        {
            var degerler=c.Blogs.OrderByDescending(x=>x.Id).Take(2).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial2()
        {
            var degerler = c.Blogs.Where(x => x.Id==1).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial3()
        {
            var degerler = c.Blogs.Take(10).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial4()
        {
            var degerler = c.Blogs.Take(3).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial5()
        {
            var degerler = c.Blogs.OrderByDescending(x=>x.Id).Take(3).ToList();
            return PartialView(degerler);
            
        }
    }
}