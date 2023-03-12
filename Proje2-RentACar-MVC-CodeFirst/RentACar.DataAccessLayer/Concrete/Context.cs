using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar.EntityLayer.Concrete;

namespace RentACar.DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        public DbSet<Category> Categories { get; set; }  // pluralize yapısı - sınıf ismiyle tablo ismi birbirine karışmasın diye boyle bir metot uygulanır. category sınıf ismini simgelerken çoğul hali tablo ismini simgeler
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Car> Cars { get; set; }

    }
}
