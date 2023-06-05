using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ObserverPattern.DAL;
using ObserverPattern.Models;
using ObserverPattern.ObserverPattern;

namespace ObserverPattern.Controllers
{
    public class Default : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ObserverObject _observerObject;

        public Default(ObserverObject observerObject, UserManager<AppUser> userManager)
        {
            _observerObject = observerObject;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel model)
        {
            var appUser = new AppUser()
            {
                Name = model.Name,
                Surname = model.Surname,
                Email = model.Email,
                UserName = model.Username
            };
            var result = await _userManager.CreateAsync(appUser, model.Password);
            if (result.Succeeded)
            {
                _observerObject.NotifyObserver(appUser);
            }
            return View();
        }
    }
}
