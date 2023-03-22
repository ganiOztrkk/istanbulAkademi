using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Akademi_Transportation.Controllers
{
    public class ProfileController : Controller
    {
        // Partial View ? - Parçalara ayırma - sayfayı daha rahat kontrol edebilmek ve mudahalede bulunabilmek icin bol parcala yonet metodunu uyguluyoruz. // 
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Partial1()
        {
            return PartialView();
        }
        public PartialViewResult Partial2()
        {
            return PartialView();
        }

    }
}