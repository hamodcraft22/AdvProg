using advProj_BusinessObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AdvProg_DatabaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Defultconnection")));

builder.Services.AddDbContext<AdvProg_IdentityContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Defultconnection")));

builder.Services.AddDefaultIdentity<AdvProg_ApplicationUser>(config => config.SignIn.RequireConfirmedEmail = false).AddRoles<IdentityRole>().AddEntityFrameworkStores<AdvProg_IdentityContext>();

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


// custome routes for tasks - behind projects (enforcing the valid forms)
app.MapControllerRoute(
    name: "Task",
    pattern: "AdvProjTasks/{id}",
    defaults: new { controller = "AdvProjTasks", action = "Index" });

app.MapControllerRoute(
    name: "TaskDetails",
    pattern: "AdvProjTasks/Details/{id}/{tid}",
    defaults: new { controller = "AdvProjTasks", action = "Details" });

app.MapControllerRoute(
    name: "TaskDetails",
    pattern: "AdvProjTasks/Edit/{id}/{tid}",
    defaults: new { controller = "AdvProjTasks", action = "Edit" });

app.MapControllerRoute(
    name: "TaskDetails",
    pattern: "AdvProjTasks/Create/{id}/{tid}",
    defaults: new { controller = "AdvProjTasks", action = "Create" });

app.MapControllerRoute(
    name: "TaskDetails",
    pattern: "AdvProjTasks/Delete/{id}/{tid}",
    defaults: new { controller = "AdvProjTasks", action = "Delete" });



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
