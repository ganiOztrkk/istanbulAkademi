using Microsoft.AspNetCore.Mvc;
using SpryStore.DataAccessLayer.Concrete;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace SpryStore.PresentationLayer.Controllers
{
    public class StaticticController : Controller
    {
        public IActionResult Index()
        {
            Context context = new Context();
            ViewBag.categoryCount = context.Categories.Count();
            ViewBag.productCount = context.Products.Count();
            ViewBag.productCountByElectronic = context.Products.Count(x => x.Category.CategoryName == "Elektronik");
            ViewBag.priceUnder5000 = context.Products.Count(x => x.Price <= 5000);
            ViewBag.avgPrice = context.Products.Average(x => x.Price);

            return View();
        }
    }
}
