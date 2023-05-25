using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkademiPlusApi.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace AkademiPlusApi.DataAccsessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=DESKTOP-JOSCHSR; initial catalog=DbAkademiApi; integrated security=true");
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Balance> Balances { get; set; }
        public DbSet<Activity> Activities { get; set; }
    }
}
