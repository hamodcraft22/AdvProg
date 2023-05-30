using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace advProj_BusinessObjects
{ 

public class AdvProg_IdentityContext : IdentityDbContext<AdvProg_ApplicationUser>
{
        DbSet<AdvProg_ApplicationUser> ApplicationUsers { get; set; }

        public AdvProg_IdentityContext()
        {

        }
        public AdvProg_IdentityContext(DbContextOptions<AdvProg_IdentityContext> options)
            : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=momacompany.asuscomm.com,62145;Database=AdvProg_Database;User Id=zift;Password=zift");
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

}
}