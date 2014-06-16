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
    public class Default1Controller : Controller
    {
        private SHEMOEntities1 db = new SHEMOEntities1();

        // GET: /Default1/
        public ActionResult Index()
        {
            //idx = 1;
            //var wisatas = db.WISATAs.Include(w => w.KATEGORI_WISATA);
            //return View(wisatas.ToList());
            //string choose;

            //switch(choose)
            //{
            //    case "Bersejarah" :
            //        var a = from w in db.WISATAs
            //                where w.ID_Kategori_Wisata.Equals(1)
            //                select w;
            //        return View(a.ToList());
            //        break;
            //    case "Religi" :
            //        var b = from w in db.WISATAs
            //                where w.ID_Kategori_Wisata.Equals(2)
            //                select w;
            //        return View(b.ToList());
            //        break;
            //    case "Museum" :
            //        var c = from w in db.WISATAs
            //                where w.ID_Kategori_Wisata.Equals(3)
            //                select w;
            //        return View(c.ToList());
            //        break;
            //    case "Monumen":
            //        var d = from w in db.WISATAs
            //                where w.ID_Kategori_Wisata.Equals(4)
            //                select w;
            //        return View(d.ToList());
            //        break;
            //    case "Taman Kota":
            //        var e = from w in db.WISATAs
            //                where w.ID_Kategori_Wisata.Equals(5)
            //                select w;
            //        return View (e.ToList());
            //        break;
            //    case "Mall":
            //        var f = from w in db.WISATAs
            //                where w.ID_Kategori_Wisata.Equals(6)
            //                select w;
            //        return View(f.ToList());
            //        break;
            //    case "Alam":
            //        var g = from w in db.WISATAs
            //                where w.ID_Kategori_Wisata.Equals(7)
            //                select w;
            //        return View(g.ToList());
            //        break;
            //    case "Pasar":
            //        var h = from w in db.WISATAs
            //                where w.ID_Kategori_Wisata.Equals(8)
            //                select w;
            //        return View(h.ToList());
            //        break;
            //    case "Kuliner":
            //        var i = from w in db.WISATAs
            //                where w.ID_Kategori_Wisata.Equals(9)
            //                select w;
            //        return View(i.ToList());
            //        break;
            //    case "Golf":
            //        var j = from w in db.WISATAs
            //                where w.ID_Kategori_Wisata.Equals(10)
            //                select w;
            //        return View(j.ToList());
            //        break;
            //    case "Kampung":
            //        var k = from w in db.WISATAs
            //                where w.ID_Kategori_Wisata.Equals(11)
            //                select w;
            //        return View(k.ToList());
            //        break;
            //    case "Souvenir":
            //        var l = from w in db.WISATAs
            //                where w.ID_Kategori_Wisata.Equals(12)
            //                select w;
            //        return View(l.ToList());
            //        break;
            //    default: break;
            //}
            
            var wisa = from w in db.WISATAs
                        where w.ID_Kategori_Wisata.Equals(1)
                        select w;
            return View(wisa);

        }

        // GET: /Default1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WISATA wisata = db.WISATAs.Find(id);
            if (wisata == null)
            {
                return HttpNotFound();
            }
            return View(wisata);
        }

        // GET: /Default1/Create
        public ActionResult Create()
        {
            ViewBag.ID_Kategori_Wisata = new SelectList(db.KATEGORI_WISATA, "ID_Kategori_Wisata", "Kategori_Wisata1");
            return View();
        }

        // POST: /Default1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID_Wisata,ID_Kategori_Wisata,Nama_Wisata,Alamat_Wisata,Telpon_Wisata,Foto_Wisata,Deskripsi_Wisata,Latitude_Wisata,Longitude_Wisata")] WISATA wisata)
        {
            if (ModelState.IsValid)
            {
                db.WISATAs.Add(wisata);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_Kategori_Wisata = new SelectList(db.KATEGORI_WISATA, "ID_Kategori_Wisata", "Kategori_Wisata1", wisata.ID_Kategori_Wisata);
            return View(wisata);
        }

        // GET: /Default1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WISATA wisata = db.WISATAs.Find(id);
            if (wisata == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_Kategori_Wisata = new SelectList(db.KATEGORI_WISATA, "ID_Kategori_Wisata", "Kategori_Wisata1", wisata.ID_Kategori_Wisata);
            return View(wisata);
        }

        // POST: /Default1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID_Wisata,ID_Kategori_Wisata,Nama_Wisata,Alamat_Wisata,Telpon_Wisata,Foto_Wisata,Deskripsi_Wisata,Latitude_Wisata,Longitude_Wisata")] WISATA wisata)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wisata).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_Kategori_Wisata = new SelectList(db.KATEGORI_WISATA, "ID_Kategori_Wisata", "Kategori_Wisata1", wisata.ID_Kategori_Wisata);
            return View(wisata);
        }

        // GET: /Default1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WISATA wisata = db.WISATAs.Find(id);
            if (wisata == null)
            {
                return HttpNotFound();
            }
            return View(wisata);
        }

        // POST: /Default1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WISATA wisata = db.WISATAs.Find(id);
            db.WISATAs.Remove(wisata);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
