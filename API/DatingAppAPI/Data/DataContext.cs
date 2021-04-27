using DatingAppAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.DatingAppAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
    }
}