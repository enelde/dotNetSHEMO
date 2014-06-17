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
                case "alam":
                    var alam = from w in db.WISATAs
                               where w.ID_Kategori_Wisata.Equals(7)
                               select w;
                    if (alam.Count() > 0)
                        return View(alam.ToList());
                    else return View("Index");
                    break;
                case "pasar":
                    var pas = from w in db.WISATAs
                              where w.ID_Kategori_Wisata.Equals(8)
                              select w;
                    if (pas.Count() > 0)
                        return View(pas.ToList());
                    else return View("Index");
                    break;
                case "kuliner":
                    var kul = from w in db.WISATAs
                              where w.ID_Kategori_Wisata.Equals(9)
                              select w;
                    if (kul.Count() > 0)
                        return View(kul.ToList());
                    else return View("Index");
                    break;
                case "golf":
                    var gol = from w in db.WISATAs
                              where w.ID_Kategori_Wisata.Equals(10)
                              select w;
                    if (gol.Count() > 0)
                        return View(gol.ToList());
                    else return View("Index");
                    break;
                case "kampung":
                    var kamp = from w in db.WISATAs
                               where w.ID_Kategori_Wisata.Equals(11)
                               select w;
                    if (kamp.Count() > 0)
                        return View(kamp.ToList());
                    else return View("Index");
                    break;
                case "souvenir":
                    var sou = from w in db.WISATAs
                              where w.ID_Kategori_Wisata.Equals(12)
                              select w;
                    if (sou.Count() > 0)
                        return View(sou.ToList());
                    else return View("Index");
                    break;
                default:
                    return View();
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