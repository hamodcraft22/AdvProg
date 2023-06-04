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
using Microsoft.EntityFrameworkCore;

namespace advProj_ProjectManager
{
    public partial class ProjectsView : Form
    {
        AdvProg_DatabaseContext context;
        HomePage homePage;
        bool isMember;

        public ProjectsView(HomePage homePage, bool isMember)
        {
            InitializeComponent();
            context = new AdvProg_DatabaseContext();
            this.homePage = homePage;
            this.isMember = isMember;
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

            // hiding the elemnts which a member shouldnt touch
            if (isMember)
            {
                btn_CreateProject.Visible = false;
                btn_DeleteProject.Visible = false;
                btn_UpdateProject.Visible = false;
            }

            RefreshData();
        }

        public void RefreshData()
        {
            dgv_ProjectsView.DataSource = null;

            var projectsToShow = context.AdvProjProjects.Include(a => a.Status).Include(b => b.Manager).AsQueryable();

            // check if is member of view or not
            if (isMember)
            {
                // part to check if member and only show those results
                var userTaskIds = context.AdvProjUserTasks.Where(x => x.UserId == Global.loggedUser.UserId).Select(a => a.TaskId);
                var userProjectIds = context.AdvProjTasks.Where(x => userTaskIds.Contains(x.TaskId)).Select(a => a.ProjectId);
                projectsToShow = projectsToShow.Where(a => userTaskIds.Contains(a.ProjectId));
            }
            else
            {
                // show only the ones where the logged user is the manager
                projectsToShow = projectsToShow.Where(a => a.ManagerId == Global.loggedUser.UserId);
            }

            // statistics
            lblNumberofProjects.Text = projectsToShow.Count().ToString();
            lblNumberOfCompletedProjects.Text = projectsToShow.Where(x => x.StatusId == '5').Count().ToString();
            lblNumberofOverDueProjects.Text = projectsToShow.Where(x => x.FinishDate > x.EndDate || (x.FinishDate == DateTime.MinValue.Date && x.EndDate > DateTime.Today.Date)).Count().ToString();

            if (txt_SearchProject.Text != "")
            {
                projectsToShow = projectsToShow.Where(x => x.ProjectName == txt_SearchProject.Text);
            }

            if (ddl_Users.SelectedValue != null)
            {
                projectsToShow = projectsToShow.Where(x => x.ManagerId == Convert.ToInt32(ddl_Users.SelectedValue.ToString()));
            }

            if (ddl_ProjectStatus.SelectedValue != null)
            {
                projectsToShow = projectsToShow.Where(x => x.StatusId == Convert.ToInt32(ddl_ProjectStatus.SelectedValue.ToString()));
            }

            dgv_ProjectsView.DataSource = projectsToShow.Select(o => new
            {
                ProjectId = o.ProjectId,
                ProjectName = o.ProjectName,
                ProjectDescription = o.ProjectDescription,
                StartDate = o.StartDate,
                EndDate = o.EndDate,
                CreateDate = o.CreateDate,
                FinishDate = o.FinishDate,
                Status = o.Status.StatusName,
                Manager = o.Manager.FullName
            }).ToList();


        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            if (ddl_Users.SelectedValue == null && ddl_ProjectStatus.SelectedValue == null && txt_SearchProject.Text == "")
            {
                MessageBox.Show("Please add a filter");
            }
            else
            {
                RefreshData();
            }
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.homePage.Show();
            this.Close();
        }

        private void btn_DeleteProject_Click(object sender, EventArgs e)
        {
            int projectID = Convert.ToInt32(dgv_ProjectsView.SelectedCells[0].OwningRow.Cells[0].Value);

            AdvProjProject advProj = context.AdvProjProjects.Single(o => o.ProjectId == projectID);

            if (MessageBox.Show("Are you sure you want to delete " + advProj.ProjectName + " ?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context.AdvProjProjects.Remove(advProj);
                context.AdvProjProjects.RemoveRange(advProj);
                context.SaveChanges();

                MessageBox.Show("Deleted Successfully");
                RefreshData();
            }

        }

        private void btn_CreateProject_Click(object sender, EventArgs e)
        {
            Create_Project create_Project = new Create_Project();
            create_Project.ShowDialog();

            if (create_Project.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Project Created Successfully");

                RefreshData();
            }
        }

        private void btn_UpdateProject_Click(object sender, EventArgs e)
        {
            int projectID = Convert.ToInt32(dgv_ProjectsView.SelectedCells[0].OwningRow.Cells[0].Value);
            AdvProjProject RetrivedProj = context.AdvProjProjects.Single(o => o.ProjectId == projectID);


            Create_Project edit_Project = new Create_Project(RetrivedProj);
            edit_Project.ShowDialog();

            if (edit_Project.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Project updated Successfully");

                RefreshData();
            }
        }

        private void btn_ViewProject_Click(object sender, EventArgs e)
        {
            int projectID = Convert.ToInt32(dgv_ProjectsView.SelectedCells[0].OwningRow.Cells[0].Value);

            AdvProjProject advProj = context.AdvProjProjects.Single(o => o.ProjectId == projectID);
            ProjectView projectView = new ProjectView(this, advProj, isMember);

            this.Hide();
            projectView.Show();
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            txt_SearchProject.Text = "";
            ddl_ProjectStatus.SelectedItem = null;
            ddl_Users.SelectedItem = null;

            RefreshData();
        }
    }
}
