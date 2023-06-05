using System;
using ObserverPattern.DAL;

namespace ObserverPattern.ObserverPattern
{
    public class CreateDiscountCode : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly Context _context = new Context();
        public CreateDiscountCode(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            _context.Discounts.Add(new Discount()
            {
                DiscountAmount = "200₺",
                DiscountCode = "dis200",
                DiscountCodeStatus = true
            });
            _context.SaveChanges();
        }
    }
}
