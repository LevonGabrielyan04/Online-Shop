using Microsoft.EntityFrameworkCore;
using Models;
using WebApplication1.Models;

namespace WebApplication1.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories {get; set; }
		public DbSet<CoverType> CoverTypes { get;set; }
        public DbSet<Product> Products { get; set; }
    }
}
