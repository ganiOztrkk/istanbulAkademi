using Microsoft.AspNetCore.Mvc;
using SpryStore.BusinessLayer.Abstract;
using SpryStore.DataAccessLayer.Abstract;
using SpryStore.EntityLayer.Concrete;

namespace SpryStore.PresentationLayer.ViewComponents
{
    public class _SendMessage : ViewComponent
    {
        private readonly IContactService _contactService;

        public _SendMessage(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }

        //[HttpPost]
        //public IViewComponentResult Invoke(Contact contact)
        //{
        //    _contactService.TInsert(contact);
        //    return View();
        //}
    }
}
