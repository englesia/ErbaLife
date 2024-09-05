using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // DbSet'ler buraya eklenir
    public DbSet<ApplicationUser> AspNetUsers { get; set; }
}
