using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class TourController : Controller
    {
        private SHEMOEntities1 db = new SHEMOEntities1();

        // GET: /Tour/
        public ActionResult Index()
        {
            var bus = from b in db.TRANSPORTASIs
                      where b.ID_Kategori_Transportasi.Equals(1)
                      select b;
            return View(bus);

            //var transportasis = db.TRANSPORTASIs.Include(t => t.KATEGORI_TRASPORTASI);
            //return View(transportasis.ToList());
        }

        // GET: /Tour/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRANSPORTASI transportasi = db.TRANSPORTASIs.Find(id);
            if (transportasi == null)
            {
                return HttpNotFound();
            }
            return View(transportasi);
        }

        public ActionResult Bus()
        {
            var bus = from b in db.TRANSPORTASIs
                      where b.ID_Kategori_Transportasi.Equals(1)
                      select b;
            return View(bus);

        }

        public ActionResult Bemo()
        {
            var bemo = from be in db.TRANSPORTASIs
                       where be.ID_Kategori_Transportasi.Equals(2)
                       select be;
            return View(bemo);
        }

        public ActionResult Kereta()
        {
            var kereta = from k in db.TRANSPORTASIs
                         where k.ID_Kategori_Transportasi.Equals(3)
                         select k;
            return View(kereta);
        }

        public ActionResult Pesawat()
        {
            var pesawat = from p in db.TRANSPORTASIs
                          where p.ID_Kategori_Transportasi.Equals(4)
                          select p;
            return View(pesawat);
        }

        public ActionResult Taksi()
        {
            var taksi = from t in db.TAKSIs
                        select t;
            return View(taksi);
        }

        public ActionResult Bintang1()
        {
            var bintang1 = from b1 in db.HOTELs
                           where b1.Bintang_Hotel.Equals(1)
                        select b1;
            return View(bintang1);
        }

        public ActionResult Bintang2()
        {
            var bintang2 = from b2 in db.HOTELs
                           where b2.Bintang_Hotel.Equals(2)
                           select b2;
            return View(bintang2);
        }

        public ActionResult Bintang3()
        {
            var bintang3 = from b3 in db.HOTELs
                           where b3.Bintang_Hotel.Equals(3)
                               select b3;
            return View(bintang3);
        }

        public ActionResult Bintang4()
        {
            var bintang4 = from b4 in db.HOTELs
                           where b4.Bintang_Hotel.Equals(4)
                               select b4;
            return View(bintang4);
        }

        public ActionResult Bintang5()
        {
            var bintang5 = from b5 in db.HOTELs
                           where b5.Bintang_Hotel.Equals(5)
                           select b5;
            return View(bintang5);
        }

        public ActionResult Ayam()
        {
            var ayam = from a in db.RESTORANs
                       where a.ID_Kategori_Restoran.Equals(1)
                       select a;
            return View(ayam);
        }

        public ActionResult Lontong()
        {
            var lontong = from l in db.RESTORANs
                       where l.ID_Kategori_Restoran.Equals(2)
                       select l;
            return View(lontong);
        }

        public ActionResult Soto()
        {
            var soto = from so in db.RESTORANs
                       where so.ID_Kategori_Restoran.Equals(3)
                       select so;
            return View(soto);
        }

        public ActionResult Sate()
        {
            var sate = from sa in db.RESTORANs
                       where sa.ID_Kategori_Restoran.Equals(4)
                       select sa;
            return View(sate);
        }

        public ActionResult Sop()
        {
            var sop = from s in db.RESTORANs
                       where s.ID_Kategori_Restoran.Equals(5)
                       select s;
            return View(sop);
        }

        public ActionResult Taman()
        {
            var taman = from ta in db.REKREASIs
                      where ta.KATEGORI_REKREASI.Equals(1)
                      select ta;
            return View(taman);
        }

        public ActionResult Hiburan()
        {
            var hiburan = from h in db.REKREASIs
                      where h.KATEGORI_REKREASI.Equals(2)
                      select h;
            return View(hiburan);
        }




    }
}
