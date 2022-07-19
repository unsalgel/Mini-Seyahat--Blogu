using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        Context c = new Context();
        BlogYorum by = new BlogYorum();
        // GET: Blog
        public ActionResult Index()
        {
            //var sorgu = c.Blogs.ToList();
    
            by.Deger1 = c.Blogs.OrderByDescending(p=>p.id).ToList();
            by.Deger3 = c.Blogs.OrderByDescending(p=>p.id).Take(5).ToList();
            by.Deger4 = c.Yorumlars.OrderByDescending(p => p.id).Take(5).ToList();
            return View(by);
        }

        public ActionResult BlogDetay(int id)
        {

            by.Deger1 = c.Blogs.Where(p => p.id == id).ToList();
            by.Deger3 = c.Blogs.OrderByDescending(p => p.id).Take(5).ToList();
            by.Deger2 = c.Yorumlars.Where(p => p.Blogid == id).ToList();
            by.Deger4 = c.Yorumlars.OrderByDescending(p => p.id).Take(5).ToList();
            // var blogbul = c.Blogs.Where(p => p.id == id).ToList();
            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.degerler = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }

    }
}