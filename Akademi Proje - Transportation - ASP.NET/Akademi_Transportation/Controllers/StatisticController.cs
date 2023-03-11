using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Akademi_Transportation.Models;

namespace Akademi_Transportation.Controllers
{
    public class StatisticController : Controller
    {
        DbTransportEntities db = new DbTransportEntities();
        public ActionResult Index()
        {
            //viewbag - viewdata - tempdata ??
            //viewbag controller kısmından view kısmına çıktı vermek icin veri taşımamızı sağlar.

            ViewBag.customerCount = db.TblCustomer.Count();
            ViewBag.cityAnkara = db.TblCustomer.Where(x => x.CustomerCity == "Tekirdag").Count();
            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.citySelect = db.TblCustomer.Where(x => x.CustomerID == 1).Select(y => y.CustomerCity).FirstOrDefault();

            return View();
        }
    }
}