using Microsoft.EntityFrameworkCore;

namespace AkademiPlusSignalRApi.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-JOSCHSR;initial catalog=SignalRDb;integrated security=true");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }

    }
}
