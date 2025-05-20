using Loosly_Domain.Models;
using Microsoft.EntityFrameworkCore;
namespace Loosely_DAL;
public class CommerceContext : DbContext
{
    private string _connectionString;
    public CommerceContext(string connectionString)
    {
        if (string.IsNullOrWhiteSpace(connectionString))
        {
            throw new ArgumentException("Connectionstring should not be empty.", "connectionString");
        }

        _connectionString = connectionString;
    }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString); // Updated to use the private _connectionString field  
    }
}