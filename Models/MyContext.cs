using Microsoft.EntityFrameworkCore;
namespace oneToMany.Models
{
  public class MyContext : DbContext
  {
    public MyContext(DbContextOptions options) : base(options) { }
    public DbSet<Artist> Artists { get; set; }
    public DbSet<Song> Songs { get; set; }
  }
}