using advProj_BusinessObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace advProj_ProjectManager
{
    public partial class Login : Form
    {
        // creating service provider for user manager
        private IServiceProvider serviceProvider;

        AdvProg_DatabaseContext dbContext;
        AdvProg_IdentityContext identityContext;

        public Login()
        {
            InitializeComponent();

            // initing the contexts
            dbContext = new AdvProg_DatabaseContext();
            identityContext = new AdvProg_IdentityContext();
        }

        private async void btn_Login_Click(object sender, EventArgs e)
        {
            var signInResults = await VerifyUserNamePassword(txt_Username.Text, txt_Password.Text);
            if (signInResults)
            {
                // ALI SATRT FROM HERE
                HomePage homePage = new HomePage();
                homePage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Credentales Invalid");
            }
        }


        // verify username function
        public async Task<bool> VerifyUserNamePassword(string userName, string password)
        {
            // configuring services
            var services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();

            // creating user manager
            var userManager = serviceProvider.GetRequiredService<UserManager<AdvProg_ApplicationUser>>();

            //getting the user via username
            var founduser = await userManager.FindByNameAsync(txt_Username.Text);

            // if user if found check password
            if (founduser != null)
            {
                var passCheck = await userManager.CheckPasswordAsync(founduser, password) == true;

                // if password is check check role
                if (passCheck)
                {
                    var userRole = await userManager.GetRolesAsync(founduser);

                    // adding user ID 
                    AdvProjUser logUser = new AdvProjUser();
                    logUser = dbContext.AdvProjUsers.Where(a => a.AspUserId == founduser.Id).FirstOrDefault();
                    Global.loggedUser = logUser;

                    // adding role to global class - if admin
                    if (userRole.FirstOrDefault() == "Admin")
                    {
                        Global.isAdmin = true;
                    }
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
