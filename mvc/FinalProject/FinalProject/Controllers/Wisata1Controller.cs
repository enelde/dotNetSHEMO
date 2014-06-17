using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using System.Net;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class Wisata1Controller : Controller
    {
        private SHEMOEntities1 db = new SHEMOEntities1();
        //
        // GET: /MonthEvent/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult show(string kategori)
        {
            switch (kategori)
            {
                case "bersejarah":
                    var sej = from w in db.WISATAs
                              where w.ID_Kategori_Wisata.Equals(1)
                              select w;
                    if (sej.Count() > 0)
                        return View(sej.ToList());
                    else return View("Index");
                    break;

                case "religi":
                    var rel = from w in db.WISATAs
                              where w.ID_Kategori_Wisata.Equals(2)
                              select w;
                    if (rel.Count() > 0)
                        return View(rel.ToList());
                    else return View("Index");
                    break;
                case "museum":
                    var mus = from w in db.WISATAs
                              where w.ID_Kategori_Wisata.Equals(3)
                              select w;
                    if (mus.Count() > 0)
                        return View(mus.ToList());
                    else return View("Index");
                    break;
                case "monumen":
                    var mon = from w in db.WISATAs
                              where w.ID_Kategori_Wisata.Equals(4)
                              select w;
                    if (mon.Count() > 0)
                        return View(mon.ToList());
                    else return View("Index");
                    break;
                case "tamanKota":
                    var tam = from w in db.WISATAs
                              where w.ID_Kategori_Wisata.Equals(5)
                              select w;
                    if (tam.Count() > 0)
                        return View(tam.ToList());
                    else return View("Index");
                    break;
                case "mall":
                    var mall = from w in db.WISATAs
                               where w.ID_Kategori_Wisata.Equals(6)
                               select w;
                    if (mall.Count() > 0)
                        return View(mall.ToList());
                    else return View("Index");
                    break;
                default: return View();
                    break;

            }
        }

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
            return View(wisata); }
    }
}