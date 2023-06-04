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

        private void HomePage_Load(object sender, EventArgs e)
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

        private void btn_ManagedProjects_Click(object sender, EventArgs e)
        {
            // passing in false to show managed projects
            ProjectsView projectsView = new ProjectsView(this, false);
            projectsView.Show();
            this.Hide();
        }

        private void btn_AdminLogs_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowInfo showInfo = new ShowInfo(this);
            showInfo.Show();

        }

        private void btn_AssignedProjects_Click(object sender, EventArgs e)
        {
            // passing in true to show member projects
            ProjectsView projectsView = new ProjectsView(this, true);
            projectsView.Show();
            this.Hide();
        }
    }
}
