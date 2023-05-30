using advProj_BusinessObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace advProj_ProjectManager
{
    public partial class Form1 : Form
    {
        private IServiceProvider? serviceProvider;

        AdvProg_DatabaseContext dbContext;
        AdvProg_IdentityContext identityContext;

        public Form1()
        {
            InitializeComponent();
            dbContext = new AdvProg_DatabaseContext();
            identityContext = new AdvProg_IdentityContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbContext.AdvProjProjects.ToList();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var signInResults = await VerifyUserNamePassword(username.Text, password.Text);
            if (signInResults == true)
            {
                MessageBox.Show("OK.");
            }
            else
            {
                MessageBox.Show("Error. The username or password are not correct");
            }
        }

        public async Task<bool> VerifyUserNamePassword(string userName, string password)
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();

            var userManager = serviceProvider.GetRequiredService<UserManager<AdvProg_ApplicationUser>>();

            var founduser = await userManager.FindByEmailAsync(username.Text);

            if (founduser != null)
            {
                var passCheck = await userManager.CheckPasswordAsync(founduser, password) == true;

                if (passCheck)
                {
                    MessageBox.Show(founduser.Id);
                }
                return passCheck;
            }
            return false;
        }

        private void ConfigureServices(IServiceCollection services)
        {

            services.AddEntityFrameworkSqlServer()
                .AddDbContext<AdvProg_IdentityContext>();

            // Register UserManager & RoleManager
            services.AddIdentity<AdvProg_ApplicationUser, IdentityRole>()
               .AddEntityFrameworkStores<AdvProg_IdentityContext>()
               .AddDefaultTokenProviders();

            // UserManager & RoleManager require logging and HttpContext dependencies
            services.AddLogging();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }
    }
}