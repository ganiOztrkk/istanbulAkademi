using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Akademi_Transportation.Models;

namespace Akademi_Transportation.Controllers
{
    public class SettingsController : Controller
    {
        DbTransportEntities db = new DbTransportEntities();

        [HttpGet]
        public ActionResult Index()
        {
            var values = Session["UserName"];
            var userValue = db.TblAdmin.Where(x => x.UserName == values).FirstOrDefault();
            return View(userValue);
        }
        [HttpPost]
        public ActionResult Index(TblAdmin tblAdmin)
        {

            return View();
        }

    }
}