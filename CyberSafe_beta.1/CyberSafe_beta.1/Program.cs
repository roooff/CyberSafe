using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using CyberSafe_beta._1.Data;
using CyberSafe_beta._1.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("CyberSafe_beta_1ContextConnection") ?? throw new InvalidOperationException("Connection string 'CyberSafe_beta_1ContextConnection' not found.");

builder.Services.AddDbContext<CyberSafe_beta_1Context>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<CyberSafe_beta_1User>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<CyberSafe_beta_1Context>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication(); ;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();