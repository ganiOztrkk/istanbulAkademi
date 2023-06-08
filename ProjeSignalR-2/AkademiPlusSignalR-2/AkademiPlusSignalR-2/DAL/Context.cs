using Microsoft.EntityFrameworkCore;

namespace AkademiPlusSignalR_2.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "server=DESKTOP-JOSCHSR; initial catalog=DbSignalR2; integrated security =true");
        }

        public DbSet<Visitor> Visitors { get; set; }

    }
}
