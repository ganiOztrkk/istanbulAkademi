using Microsoft.EntityFrameworkCore;

namespace AkademiPlusCQRS.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "server=DESKTOP-JOSCHSR;initial catalog=AkademiCQRS; integrated security=true;");
        }

        public DbSet<Product> Products { get; set; }
    }
}
