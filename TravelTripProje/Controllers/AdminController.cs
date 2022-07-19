using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
   
        Context c = new Context();
        [Authorize]
        // GET: Admin
        public ActionResult Index()
        {
            var listele = c.Blogs.ToList();
            return View(listele);
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        public ActionResult BlogSil(int id)
        {
            var listele = c.Blogs.Find(id);
            c.Blogs.Remove(listele);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        //blogları textboxlara yazdırdım blog getir fonksiyonunda
        public ActionResult BlogGetir(int id)
        {
            var getir = c.Blogs.Find(id); //blogları textboxlara yazdırdım
            return View("BlogGetir",getir);
        }
        public ActionResult Guncelle(Blog b)
        {
            var sorgu = c.Blogs.Find(b.id);
            sorgu.Baslik = b.Baslik;
            sorgu.Tarih = b.Tarih;
            sorgu.Aciklama = b.Aciklama;
            sorgu.BlogImage = b.BlogImage;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Yorum()
        {
            var sorgu = c.Yorumlars.ToList();
            return View("Yorum",sorgu);
        }
        public ActionResult YorumSil (int id)
        {
            var sorgu = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(sorgu);
            c.SaveChanges();
            return RedirectToAction("Yorum");
        }
        public ActionResult YorumGetir(int id)
        {
            var sorgu = c.Yorumlars.Find(id);
            return View("YorumGetir",sorgu);
        }
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var sorgu = c.Yorumlars.Find(y.id);
            sorgu.KullaniciAdi = y.KullaniciAdi;
            sorgu.Mail = y.Mail;
            sorgu.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("Yorum");
        }
        public ActionResult iletisim()
        {
            var sorgu = c.iletisims.ToList();
            return View("iletisim",sorgu);

        }
        public ActionResult iletisil(int id)
        {
            var getir = c.iletisims.Find(id);
            c.iletisims.Remove(getir);
            c.SaveChanges();
            return RedirectToAction("iletisim");
        }
        public ActionResult Hakkimizda()
        {
            var getir = c.Hakkimizdas.ToList();
            return View("Hakkimizda", getir);
        }
        public ActionResult HakkimizdaGetir(int id)
        {

            var getir = c.Hakkimizdas.Find(id);
            return View("HakkimizdaGetir", getir);
        }
        public ActionResult HakkimizdaGuncelle(Hakkimizda g)
        {
            var guncelle = c.Hakkimizdas.Find(g.id);
            guncelle.FotoUrl = g.FotoUrl;
            guncelle.Aciklama = g.Aciklama;
            c.SaveChanges();
            return RedirectToAction("Hakkimizda");
        }


    }
}