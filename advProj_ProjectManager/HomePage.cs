using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using advProj_BusinessObjects;
using advProj_BusinessObjects.GlobalClass;

namespace advProj_ProjectManager
{
    public partial class HomePage : Form
    {
        AdvProg_DatabaseContext context;
        public HomePage()
        {
            InitializeComponent();
            context = new AdvProg_DatabaseContext();
        }

        /// >Loads the home page and displays various statistics.
 
        private void HomePage_Load(object sender, EventArgs e)
        {
            try
            {
                lbl_User.Text = Global.loggedUser.FullName;

                // loading statts - home stats, not specific to user
                lbl_NumberOfProjects.Text = context.AdvProjProjects.Count().ToString();
                lbl_NumOfTasks.Text = context.AdvProjUserTasks.Count().ToString();
                lbl_NumberOfOverDueTasks.Text = context.AdvProjTasks.Where(x => x.FinishDate > x.EndDate || (x.FinishDate == DateTime.MinValue.Date && x.EndDate > DateTime.Today.Date)).Count().ToString();
                lblNumberOfCompleteProject.Text = context.AdvProjProjects.Where(x => x.StatusId == '5').Count().ToString();
                lblNumberOfCompletedTasks.Text = context.AdvProjTasks.Where(x => x.StatusId == '5').Count().ToString();

                // hifing the log button unless its an admin
                btn_AdminLogs.Visible = false;
                if (Global.isAdmin)
                {
                    btn_AdminLogs.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }

        }

        //Handles the click event of the "Managed Projects" button.
        private void btn_ManagedProjects_Click(object sender, EventArgs e)
        {
            // passing in false to show managed projects
            ProjectsView projectsView = new ProjectsView(this, false);
            projectsView.Show();
            this.Hide();
        }

        ///Hides the current form and shows the ShowInfo form.

        private void btn_AdminLogs_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowInfo showInfo = new ShowInfo(this);
            showInfo.Show();

        }

        /// Displays the assigned projects view.
        private void btn_AssignedProjects_Click(object sender, EventArgs e)
        {
            // passing in true to show member projects
            ProjectsView projectsView = new ProjectsView(this, true);
            projectsView.Show();
            this.Hide();
        }
    }
}
