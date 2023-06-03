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
    public partial class ProjectsView : Form
    {
        AdvProg_DatabaseContext context;
        HomePage homePage;
        public ProjectsView()
        {
            context = new AdvProg_DatabaseContext();
            InitializeComponent();
        }
        public ProjectsView(HomePage homePage)
        {
            context = new AdvProg_DatabaseContext();
            InitializeComponent();
            this.homePage = homePage;
        }


        private void ddl_Users_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProjectsView_Load(object sender, EventArgs e)
        {
            ddl_Users.DataSource = context.AdvProjUsers.ToList();
            ddl_Users.DisplayMember = "FullName";
            ddl_Users.ValueMember = "userId";
            ddl_Users.SelectedItem = null;

            ddl_ProjectStatus.DataSource = context.AdvProjPStatuses.ToList();
            ddl_ProjectStatus.DisplayMember = "StatusName";
            ddl_ProjectStatus.ValueMember = "StatusId";
            ddl_ProjectStatus.SelectedItem = null;

            lblNumberOfCompletedProjects.Text = context.AdvProjProjects.Where(x => x.StatusId == '5' && x.ManagerId == Global.loggedUser.UserId).Count().ToString();
            lblNumberofOverDueProjects.Text = context.AdvProjProjects.Where(x => x.FinishDate > x.EndDate || (x.FinishDate == null && x.EndDate > DateTime.Today.Date) && x.ManagerId == Global.loggedUser.UserId).Count().ToString();

            Refresh();
        }

        public void Refresh()
        {
            dgv_ProjectsView.DataSource = null;

            var projectsToShow = context.AdvProjProjects.AsQueryable();

            try
            {
                if (txt_SearchProject.Text != "")
                {
                    projectsToShow = projectsToShow.Where(x => x.ProjectName == txt_SearchProject.Text);
                }
                else if (ddl_Users.SelectedValue != null)
                {
                    projectsToShow = projectsToShow.Where(x => x.ManagerId.ToString() == ddl_Users.SelectedValue.ToString());
                }
                else if (ddl_ProjectStatus.SelectedValue != null)
                {
                    projectsToShow = projectsToShow.Where(x => x.StatusId.ToString() == ddl_ProjectStatus.SelectedValue.ToString());
                }

                dgv_ProjectsView.DataSource = projectsToShow.Select(o => new
                {
                    ProjectId = o.ProjectId,
                    ProjectName = o.ProjectName,
                    ProjectDescription = o.ProjectDescription,
                    StartDate = o.StartDate,
                    FinishDate = o.FinishDate,
                    Status = o.Status.StatusName,
                    Manager = o.Manager.FullName
                }).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
        public void Reset()
        {
            txt_SearchProject.Text = "";
            ddl_ProjectStatus.SelectedItem = null;
            ddl_Users.SelectedItem = null;
            Refresh();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            if (ddl_Users.SelectedValue == null && ddl_ProjectStatus.SelectedValue == null)
            {
                MessageBox.Show("Select values to filter");
            }
            Refresh();
        }

        private void bt_Refresh_Click(object sender, EventArgs e)
        {

            Reset();
        }

        private void btn_SearchProject_Click(object sender, EventArgs e)
        {
            if (txt_SearchProject.Text == "")
            {
                MessageBox.Show("Enter Text To Search");
            }
            Refresh();
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.homePage.Show();
        }

        private void btn_DeleteProject_Click(object sender, EventArgs e)
        {
            int cell = Convert.ToInt32(dgv_ProjectsView.SelectedCells[0].OwningRow.Cells[0].Value);
          
            AdvProjProject advProj = context.AdvProjProjects.Single(o => o.ProjectId == cell);
           if (MessageBox.Show("Do u want to delete " + advProj.ProjectName + "?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context.AdvProjProjects.Remove(advProj);
                context.AdvProjProjects.RemoveRange(advProj);
                context.SaveChanges();
                MessageBox.Show("Deleted Successfully");
                Refresh();
            }
            else
            {
                MessageBox.Show("Failed To delete");
                Refresh();
            }
              
           
        }

        private void btn_CreateProject_Click(object sender, EventArgs e)
        {
            this.Hide();
            Create_Project create_Project = new Create_Project(this);
            create_Project.Show();
        }

        private void btn_UpdateProject_Click(object sender, EventArgs e)
        {
            int cell = Convert.ToInt32(dgv_ProjectsView.SelectedCells[0].OwningRow.Cells[0].Value);
            
            AdvProjProject advProj = context.AdvProjProjects.Single(o => o.ProjectId == cell);
            this.Hide();
            Create_Project create_Project = new Create_Project(this, advProj);
            create_Project.Show();
            
     
        }

        private void btn_ViewProject_Click(object sender, EventArgs e)
        {
            int cell = Convert.ToInt32(dgv_ProjectsView.SelectedCells[0].OwningRow.Cells[0].Value);
            
            AdvProjProject advProj = context.AdvProjProjects.Single(o => o.ProjectId == cell);
            ProjectView projectView = new ProjectView(this, advProj);
            this.Hide();
            projectView.Show();
            
}
    }
}
