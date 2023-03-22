using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Akademi_Transportation.Models;

namespace Akademi_Transportation.Controllers
{
    public class AdminController : Controller
    {
        DbTransportEntities db = new DbTransportEntities();

        public ActionResult Index()
        {
            ViewBag.productCount = db.TblProduct.Count();
            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.customerCount = db.TblCustomer.Count();
            ViewBag.employeeCount = db.TblEmployee.Count();
            var values = Session["UserName"];
            ViewBag.userName = values;
            return View();
        }
    }
}