using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace ConsoleApp;


public class AppDbContext : DbContext
{
    public DbSet<Bind> Bind { get; set; }
    public DbSet<Item> Item { get; set; }
    public DbSet<LineData> LineData { get; set; }
    public DbSet<Line> Line { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost;Database=BindTest;User Id=sa;Password=123456;TrustServerCertificate=True;");
    }
    
}