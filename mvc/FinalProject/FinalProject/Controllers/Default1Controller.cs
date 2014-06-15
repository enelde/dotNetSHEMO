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
        private SHEMOEntities db = new SHEMOEntities();

        // GET: /Default1/
        public ActionResult Index()
        {
            var wisatas = db.WISATAs.Include(w => w.KATEGORI_WISATA);
            return View(wisatas.ToList());
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
