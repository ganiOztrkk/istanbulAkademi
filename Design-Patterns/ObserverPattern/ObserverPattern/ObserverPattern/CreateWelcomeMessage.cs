using System;
using ObserverPattern.DAL;

namespace ObserverPattern.ObserverPattern
{
    public class CreateWelcomeMessage : IObserver // sisteme giriş yapan kullanıcıya merhaba mesajı iletiyor olacağız
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly Context _context = new Context();

        public CreateWelcomeMessage(IServiceProvider serviceProvider)
         {
             _serviceProvider = serviceProvider;
         }


         public void CreateNewUser(AppUser appUser)
         {
             _context.WelcomeMessages.Add(new WelcomeMessage()
             {
                 NameSurname = appUser.Name + " " + appUser.Surname,
                 Content = "Bültenimize abone olduğunuz için teşekkür ederiz. Hoşgeldiniz."
             });
             _context.SaveChanges();
         }
    }
}
