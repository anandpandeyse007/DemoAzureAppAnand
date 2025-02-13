using Microsoft.EntityFrameworkCore;
using mvc_web_azure_app_anand.Models;

namespace mvc_web_azure_app_anand.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

    }
}
