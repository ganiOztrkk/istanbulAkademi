using System;
using AkademiPlusSignalR_2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Linq;
using AkademiPlusSignalR_2.DAL;

namespace AkademiPlusSignalR_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorController : ControllerBase
    {
        private readonly VisitorServices _visitorServices;

        public VisitorController(VisitorServices visitorServices)
        {
            _visitorServices = visitorServices;
        }

        [HttpGet]
        public IActionResult CreateVisitor()
        {
            Random random = new Random();
            Enumerable.Range(1, 10).ToList().ForEach(x =>
            {
                foreach (ECity item in Enum.GetValues(typeof(ECity)))
                {
                    var newVisitor = new Visitor()
                    {
                        City = item,
                        CityVisitCount = random.Next(1000, 5000),
                        VisitDate = DateTime.Now.AddDays(x)
                    };
                    _visitorServices.SaveVisitor(newVisitor).Wait();
                    System.Threading.Thread.Sleep(1000);
                }
            });
            return Ok("Ziyaretçiler Eklendi.");
        }
    }
}
