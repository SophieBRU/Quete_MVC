using Microsoft.EntityFrameworkCore;
using Quete_MVC.Models;

namespace Quete_MVC.Data
{
    public class Quete_MVCContext : DbContext
    {
        public Quete_MVCContext(DbContextOptions<Quete_MVCContext> options)
                : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
    }
}
