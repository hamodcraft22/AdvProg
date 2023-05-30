using advProj_BusinessObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AdvProg_DatabaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Defultconnection")));

builder.Services.AddDbContext<AdvProg_IdentityContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Defultconnection")));

builder.Services.AddDefaultIdentity<AdvProg_ApplicationUser>().AddEntityFrameworkStores<AdvProg_IdentityContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
