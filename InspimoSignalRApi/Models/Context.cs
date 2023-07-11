using Microsoft.EntityFrameworkCore;

namespace InspimoSignalRApi.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-NOMRM5V\\SQLEXPRESS;initial catalog=DbSignalR;integrated security=true;");
        }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
