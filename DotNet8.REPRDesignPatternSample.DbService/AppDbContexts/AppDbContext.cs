using Microsoft.EntityFrameworkCore;

namespace DotNet8.REPRDesignPatternSample.DbService.AppDbContexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options)
        : base(options) { }

    public DbSet<Tbl_Blog> Blogs { get; set; }
}
