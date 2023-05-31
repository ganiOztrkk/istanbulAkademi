﻿using Microsoft.EntityFrameworkCore;

namespace MediatorAkademiPlusPostgre.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context>  options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
