using Microsoft.EntityFrameworkCore;

namespace ChainOfResponsibility.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-JOSCHSR;initial catalog=ChainOfResp;integrated security=true");
        }

        public DbSet<CustomerProcess> CustomerProcesses { get; set; }

    }
}
