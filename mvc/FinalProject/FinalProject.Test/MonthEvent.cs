using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalProject;
using FinalProject.Controllers;
using FinalProject.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System.Text;


namespace FinalProject.Test
{
    [TestClass]
    public class MonthEvent
    {
        MonthEventController me = new MonthEventController();
        SHEMOEntities1 db = new SHEMOEntities1();

        [TestInitialize]
        public void Init()
        {
            me = new MonthEventController();
        }

        [TestMethod]
        public void Search_Test()
        {
            var tesList = from t in db.EVENTs
                          where t.Tanggal_Mulai.Month.Equals(5) ||
                                t.Tanggal_Selesai.Month.Equals(5)
                          select t;

            var cari = "May";

            Assert.AreEqual(cari, tesList.Month());
        }




    }
}
