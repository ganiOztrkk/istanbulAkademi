using Microsoft.AspNetCore.Identity;

namespace ObserverPattern.DAL
{
    public class AppUser : IdentityUser<int> // burada parantez icinde verdigimiz int degeri, primary key degerinin int olmasını istedigimizi belirtiyor. cunku default olarak primary key stringtir
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string District { get; set; }
    }
}
