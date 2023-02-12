using CyberSafe.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CyberSafe.Areas.Identity.Data;

public class CyberSafeDBContext : IdentityDbContext<CyberSafeUser>
{
    public CyberSafeDBContext(DbContextOptions<CyberSafeDBContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new CyberSafeUserIdentityConfiguration());
    }
}

public class CyberSafeUserIdentityConfiguration : IEntityTypeConfiguration<CyberSafeUser>
{
    public void Configure(EntityTypeBuilder<CyberSafeUser> builder)
    {
        builder.Property(u => u.FirstName).HasMaxLength(255);
        builder.Property(u => u.LastName).HasMaxLength(255);
    }
}