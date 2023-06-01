using ObserverPattern.DAL;

namespace ObserverPattern.ObserverPattern
{
    public interface IObserver
    {
        void CreateNewUser(AppUser  appUser);
    }
}
