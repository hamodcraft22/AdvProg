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
            lbl_NumberOfProjects.Text = context.AdvProjProjects.Where(x => x.ManagerId == Global.loggedUser.UserId).Count().ToString();
            lbl_NumOfTasks.Text = context.AdvProjUserTasks.Where(x => x.UserId == Global.loggedUser.UserId).Count().ToString();
            lbl_NumberOfOverDueTasks.Text = context.AdvProjTasks.Where(x => x.FinishDate > x.EndDate || (x.FinishDate == null && x.EndDate > DateTime.Today.Date)).Count().ToString();
            lblNumberOfCompleteProject.Text = context.AdvProjProjects.Where(x => x.StatusId == '5' && x.ManagerId == Global.loggedUser.UserId).Count().ToString();
            lblNumberOfCompletedTasks.Text = context.AdvProjTasks.Where(x => x.StatusId == '5').Count().ToString();
            btn_AdminLogs.Visible = false;
            if (Global.isAdmin)
            {
                btn_AdminLogs.Visible = true;
            }
        }

        private void lbl_HomePage_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Project_Click(object sender, EventArgs e)
        {

        }

        private void lbl_NumberOfProjects_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void btn_ManagedProjects_Click(object sender, EventArgs e)
        {
            ProjectsView projectsView = new ProjectsView(this);
            projectsView.Show();
            this.Hide();
        }

        private void btn_AdminLogs_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowInfo showInfo = new ShowInfo(this);
            showInfo.Show();

        }
    }
}
