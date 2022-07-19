using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;


namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Blogs.OrderByDescending(p=>p.id).Take(4).ToList();
            return View(degerler);
        }
        public PartialViewResult Partial1()
        {
            var sorgu = c.Blogs.OrderByDescending(p => p.id).Take(2).ToList();
            return PartialView(sorgu);

        }
        public PartialViewResult Partial2()
        {
            var sorgu = c.Blogs.Where(p => p.id == 1).ToList();
            return PartialView(sorgu);
        }
        public PartialViewResult Partial3()
        {
             var sorgu = c.Blogs.OrderByDescending(p=>p.id).Take(10).ToList();
            return PartialView(sorgu);

        }
       public PartialViewResult Partial4()
        {
            var sorgu = c.Blogs.Take(4).ToList();
            return PartialView(sorgu);
        }
        public PartialViewResult Partial5()
        {
            var sorgu = c.Blogs.OrderByDescending(p => p.id).Take(4).ToList();
            return PartialView(sorgu);
        }
        [HttpGet]
        public ActionResult iletisim()
        {
            return View();
        }
        [HttpPost]
        public ActionResult iletisim(iletisim ileti)
        {
            c.iletisims.Add(ileti);
            c.SaveChanges();
            return View();
        }

    }
}