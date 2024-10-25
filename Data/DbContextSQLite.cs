using Microsoft.EntityFrameworkCore;
using BrickStoreBackend.Models;

namespace BrickStoreBackend.Data
{
    public class DbContextSqLite : DbContext
    {
        public DbContextSqLite(DbContextOptions<DbContextSqLite> options) 
            : base(options) { }

        public DbSet<BrickProduct?> BrickProducts { get; set; }
        public DbSet<User?> Users { get; set; }
    }
}

