using Microsoft.EntityFrameworkCore;
using BlogSite.Models;

namespace BlogSite.Data
{     
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        // Diğer DbSet'leri eklemek isterseniz buraya ekleyebilirsiniz.
    }
}
