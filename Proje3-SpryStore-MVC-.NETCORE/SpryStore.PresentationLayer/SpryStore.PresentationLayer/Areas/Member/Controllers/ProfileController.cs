using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SpryStore.EntityLayer.Concrete;
using SpryStore.PresentationLayer.Areas.Member.Models;

namespace SpryStore.PresentationLayer.Areas.Member.Controllers
{
	[Area("Member")]
	public class ProfileController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

		public ProfileController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
			userEditViewModel.Name = values.Name;
			userEditViewModel.Surname = values.Surname;
			userEditViewModel.City = values.City;
            userEditViewModel.Mail = values.Email;
            userEditViewModel.Phone = values.PhoneNumber;
            return View(userEditViewModel);
		}

		[HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel userEditViewModel)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            values.Name = userEditViewModel.Name;
            values.Surname = userEditViewModel.Surname;
            values.City = userEditViewModel.City;
            values.Email = userEditViewModel.Mail;
            values.PhoneNumber = userEditViewModel.Phone;
            await _userManager.UpdateAsync(values);
            return View();
        }
    }
}
