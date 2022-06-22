using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RazorIdentity.Areas.Identity.Data;
using RazorIdentity.Models;

namespace RazorIdentity.Areas.Identity.Data;

public class RazorIdentityContextDb : IdentityDbContext<RazorIdentityUser>
{
    public RazorIdentityContextDb(DbContextOptions<RazorIdentityContextDb> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    public DbSet<RazorIdentity.Models.Movie>? Movie { get; set; }
}
