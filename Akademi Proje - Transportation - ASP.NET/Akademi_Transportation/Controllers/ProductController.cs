using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Akademi_Transportation.Models;

namespace Akademi_Transportation.Controllers
{
    public class ProductController : Controller
    {
        DbTransportEntities db = new DbTransportEntities();
        // GET: Product
        public ActionResult Index()
        {
            var values = db.TblProduct.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddProduct()
        {
            List<SelectListItem> values = (from x in db.TblCategory
                select new SelectListItem
                {
                    Text = x.CategoryName,
                    Value = x.CategoryID.ToString(),
                }).ToList();
            ViewBag.v = values;
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(TblProduct tblProduct)
        {
            db.TblProduct.Add(tblProduct);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteProduct(int id)
        {
            var value = db.TblProduct.Find(id);
            db.TblProduct.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateProduct(int id)
        {
            var value = db.TblProduct.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateProduct(TblProduct tblProduct)
        {
            var value = db.TblProduct.Find(tblProduct.ProductID);
            value.ProductName = tblProduct.ProductName;
            value.ProductSizeType = tblProduct.ProductSizeType;
            value.ProductSize = tblProduct.ProductSize;
            value.ProductDescription = tblProduct.ProductDescription;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}