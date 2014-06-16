using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class MonthEventController : Controller
    {
        private SHEMOEntities1 db = new SHEMOEntities1();
        //
        // GET: /MonthEvent/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Search(string bulan)
        {
            switch (bulan)
            {
                case "January":
                    var Jan = from w in db.EVENTs
                              where w.Tanggal_Mulai.Value.Month.Equals(1)

                              select w;
                    if (Jan.Count() > 0)
                        return View(Jan.ToList());
                    else return View("Index");
                    break;
                case "February":
                    var Feb = from w in db.EVENTs
                              where w.Tanggal_Mulai.Value.Month.Equals(2) ||
                                      w.Tanggal_Selesai.Value.Month.Equals(2)
                              select w;
                    if (Feb.Count() > 0)
                        return View(Feb.ToList());
                    else return View("Index");
                    break;
                case "March":
                    var Mar = from w in db.EVENTs
                              where w.Tanggal_Mulai.Value.Month.Equals(3) ||
                                  w.Tanggal_Selesai.Value.Month.Equals(3)
                              select w;
                    if (Mar.Count() > 0)
                        return View(Mar.ToList());
                    else return View("Index");
                    break;
                case "April":
                    var Apr = from w in db.EVENTs
                              where w.Tanggal_Mulai.Value.Month.Equals(4) ||
                                  w.Tanggal_Selesai.Value.Month.Equals(4)
                              select w;
                    if (Apr.Count() > 0)
                        return View(Apr.ToList());
                    else return View("Index");
                    break;
                case "May":
                    var May = from w in db.EVENTs
                              where w.Tanggal_Mulai.Value.Month.Equals(5) ||
                                  w.Tanggal_Selesai.Value.Month.Equals(5)
                              select w;
                    if (May.Count() > 0)
                        return View(May.ToList());
                    else return View("Index");
                    break;
                case "June":
                    var Jun = from w in db.EVENTs
                              where w.Tanggal_Mulai.Value.Month.Equals(6) ||
                                  w.Tanggal_Selesai.Value.Month.Equals(6)
                              select w;
                    if (Jun.Count() > 0)
                        return View(Jun.ToList());
                    else return View("Index");
                    break;
                case "July":
                    var Jul = from w in db.EVENTs
                              where w.Tanggal_Mulai.Value.Month.Equals(7) ||
                                  w.Tanggal_Selesai.Value.Month.Equals(7)
                              select w;
                    if (Jul.Count() > 0)
                        return View(Jul.ToList());
                    else return View("Index");
                    break;
                case "August":
                    var Aug = from w in db.EVENTs
                              where w.Tanggal_Mulai.Value.Month.Equals(8) ||
                                  w.Tanggal_Selesai.Value.Month.Equals(8)
                              select w;
                    if (Aug.Count() > 0)
                        return View(Aug.ToList());
                    else return View("Index");
                    break;
                case "September":
                    var Sep = from w in db.EVENTs
                              where w.Tanggal_Mulai.Value.Month.Equals(9) ||
                                  w.Tanggal_Selesai.Value.Month.Equals(9)
                              select w;
                    if (Sep.Count() > 0)
                        return View(Sep.ToList());
                    else return View("Index");
                    break;
                case "October":
                    var Oct = from w in db.EVENTs
                              where w.Tanggal_Mulai.Value.Month.Equals(10) ||
                                  w.Tanggal_Selesai.Value.Month.Equals(10)
                              select w;
                    if (Oct.Count() > 0)
                        return View(Oct.ToList());
                    else return View("Index");
                    break;
                case "November":
                    var Nov = from w in db.EVENTs
                              where w.Tanggal_Mulai.Value.Month.Equals(11) ||
                                  w.Tanggal_Selesai.Value.Month.Equals(11)
                              select w;
                    if (Nov.Count() > 0)
                        return View(Nov.ToList());
                    else return View("Index");
                    break;
                case "December":
                    var Dec = from w in db.EVENTs
                              where w.Tanggal_Mulai.Value.Month.Equals(12) ||
                                  w.Tanggal_Selesai.Value.Month.Equals(12)
                              select w;
                    if (Dec.Count() > 0)
                        return View(Dec.ToList());
                    else return View("Index");
                    break;
                default:
                    return View();
                    break;
            }
        }
	}
}