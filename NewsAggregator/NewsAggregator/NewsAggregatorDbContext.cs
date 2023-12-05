using Microsoft.EntityFrameworkCore;
using NewsAggregator.Entities;

namespace NewsAggregator
{
    public class NewsAggregatorDbContext : DbContext
    {
        public NewsAggregatorDbContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<CategoryNews> CategoryNews { get; set; }
        DbSet<News> News { get; set; }
        DbSet<User> Users{ get; set; }
        DbSet<Source> Sources { get; set; }
        DbSet<Role> Roles { get; set; }
    }
}
