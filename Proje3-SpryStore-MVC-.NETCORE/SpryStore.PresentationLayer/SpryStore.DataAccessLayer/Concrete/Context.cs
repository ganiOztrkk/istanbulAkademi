﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpryStore.EntityLayer.Concrete;

namespace SpryStore.DataAccessLayer.Concrete
{
    public class Context : DbContext // kalıtım almamızın sebebi dbset metodunu kullanmamızın gerekmesidir.
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=DESKTOP-JOSCHSR;initial catalog=DbECommerce;integrated security = true");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
