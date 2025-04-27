using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
public class CommerceContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
          
            optionsBuilder.UseSqlServer("Server=ANWARUL;Database=TightlyCoupledCode;User Id=sa;Password=sa123;TrustServerCertificate=True;");
        }
    }
}
