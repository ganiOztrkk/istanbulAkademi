using System;
using ObserverPattern.DAL;

namespace ObserverPattern.ObserverPattern
{
    public class CreateMagazineAnnouncementObserver : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly Context _context = new Context();

        public CreateMagazineAnnouncementObserver(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            _context.UserProcesses.Add(new UserProcess()
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Magazine = "Bilim Teknoloji Dergisi",
                Content = "Mayıs sayısı bayimize gelmiştir."
            });
            _context.SaveChanges();
        }
    }
}
