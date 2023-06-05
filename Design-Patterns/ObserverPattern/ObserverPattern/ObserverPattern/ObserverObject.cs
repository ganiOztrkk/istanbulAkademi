using System.Collections.Generic;
using ObserverPattern.DAL;

namespace ObserverPattern.ObserverPattern
{
    public class ObserverObject
    {
        private readonly List<IObserver> _observers;

        public ObserverObject() // bu sınıftan nesne ornegi alındığı anda
        {
            _observers = new List<IObserver>(); // bizim için işlemlerin listelenmesi kısmına karşılık gelecek
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObserver(AppUser appUser)
        {
            _observers.ForEach(x =>
            {
                x.CreateNewUser(appUser);
            });
        }
    }
}
