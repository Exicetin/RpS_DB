using System.Data.Entity;

namespace RpS2._0
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("DefaultConnection")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Report> Reports { get; set; }
    }
}