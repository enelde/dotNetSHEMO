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
    }
}
