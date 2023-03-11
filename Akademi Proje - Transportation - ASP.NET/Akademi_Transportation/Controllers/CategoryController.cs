using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Akademi_Transportation.Models;

namespace Akademi_Transportation.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        DbTransportEntities db = new DbTransportEntities();
        public ActionResult Index()
        {
            var values = db.TblCategory.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(TblCategory tblCategory)
        {
            db.TblCategory.Add(tblCategory);
            db.SaveChanges();
            return View();
        }

        public ActionResult DeleteCategory(int id)
        {
            var value = db.TblCategory.Find(id);
            db.TblCategory.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var value = db.TblCategory.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateCategory(TblCategory tblCategory)
        {
            var value = db.TblCategory.Find(tblCategory.CategoryID);
            value.CategoryName = tblCategory.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}