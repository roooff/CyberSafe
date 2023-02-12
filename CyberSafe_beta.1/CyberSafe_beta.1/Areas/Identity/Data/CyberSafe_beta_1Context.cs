using CyberSafe_beta._1.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CyberSafe_beta._1.Data;

public class CyberSafe_beta_1Context : IdentityDbContext<CyberSafe_beta_1User>
{
    public CyberSafe_beta_1Context(DbContextOptions<CyberSafe_beta_1Context> options)
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
}
