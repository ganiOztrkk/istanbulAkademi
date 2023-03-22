using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Akademi_Transportation.Models;

namespace Akademi_Transportation.Controllers
{
    public class LoginController : Controller
    {
        DbTransportEntities db = new DbTransportEntities();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TblAdmin tblAdmin)
        {
            var values = db.TblAdmin.Where(x => x.UserName == tblAdmin.UserName && x.Password == tblAdmin.Password)
                .FirstOrDefault();
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.UserName,false);
                Session["UserName"] = tblAdmin.UserName;
                return RedirectToAction("Index", "Admin");
            }
            return View();
        }
    }
}