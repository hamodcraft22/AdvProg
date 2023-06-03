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
    public partial class ProjectView : Form
    {
        AdvProg_DatabaseContext context;
        ProjectsView projectsView;
        AdvProjProject project;
        public ProjectView()
        {
            InitializeComponent();
            context = new AdvProg_DatabaseContext();
        }

        public ProjectView(ProjectsView projectsView, AdvProjProject project)
        {
            InitializeComponent();
            context = new AdvProg_DatabaseContext();
            this.projectsView = projectsView;
            this.project = project;
        }

        private void ProjectView_Load(object sender, EventArgs e)
        {
            ddl_Users.DataSource = context.AdvProjUsers.ToList();
            ddl_Users.DisplayMember = "FullName";
            ddl_Users.ValueMember = "userId";
            ddl_Users.SelectedItem = null;

            ddl_ProjectStatus.DataSource = context.AdvProjPStatuses.ToList();
            ddl_ProjectStatus.DisplayMember = "StatusName";
            ddl_ProjectStatus.ValueMember = "StatusId";
            ddl_ProjectStatus.SelectedItem = null;
            lblNumberOfOverDueTasks.Text = context.AdvProjTasks.Where(x => x.FinishDate > x.EndDate || (x.FinishDate == null && x.EndDate > DateTime.Today.Date)).Count().ToString();
            lblNumberOfCompletedTasks.Text = context.AdvProjTasks.Where(x => x.StatusId == '5').Count().ToString();

            Refresh();
        }

        public void Refresh()
        {
            dgv_Tasks.DataSource = null;

            var tasksToShow = context.AdvProjTasks.Where(x => x.ProjectId == this.project.ProjectId).AsQueryable();

            try
            {
                if (txt_SearchTask.Text != "")
                {
                    tasksToShow = tasksToShow.Where(x => x.TaskName == txt_SearchTask.Text);
                }
                else if (ddl_Users.SelectedValue != null)
                {
                    var userTaksIds = context.AdvProjUserTasks.Where(a => a.UserId == Global.loggedUser.UserId).Select(b => b.TaskId);
                    tasksToShow = tasksToShow.Where(a => userTaksIds.Contains(a.TaskId));
                }
                else if (ddl_ProjectStatus.SelectedValue != null)
                {
                    tasksToShow = tasksToShow.Where(x => x.StatusId.ToString() == ddl_ProjectStatus.SelectedValue.ToString());
                }

                dgv_Tasks.DataSource = tasksToShow.Select(o => new
                {
                    TaskId = o.TaskId,
                    TaskName = o.TaskName,
                    TaskDescription = o.TaskDescription,
                    StartDate = o.StartDate,
                    EndDate = o.EndDate,
                    ProjectName = o.Project.ProjectName,
                    Status = o.Status.StatusName

                }).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btn_SearchTask_Click(object sender, EventArgs e)
        {
            if (txt_SearchTask.Text == "")
            {
                MessageBox.Show("Enter Text To Search");
            }
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.projectsView.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            if (ddl_Users.SelectedValue == null && ddl_ProjectStatus.SelectedValue == null)
            {
                MessageBox.Show("Select values to filters");
            }
            Refresh();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            txt_SearchTask.Text = "";
            ddl_ProjectStatus.SelectedItem = null;
            ddl_Users.SelectedItem = null;
            Refresh();
        }

        private void btn_DeleteProject_Click(object sender, EventArgs e)
        {
            int cell = Convert.ToInt32(dgv_Tasks.SelectedCells[0].OwningRow.Cells[0].Value);

            AdvProjTask Task = context.AdvProjTasks.Single(x => x.TaskId == cell);
            if (MessageBox.Show("Do u want to delete " + Task.TaskName + "?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context.Remove(Task);
                context.RemoveRange(Task);
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
            CreateTask createTask = new CreateTask(this);
            createTask.Show();
        }

        private void btn_UpdateProject_Click(object sender, EventArgs e)
        {
            int cell = Convert.ToInt32(dgv_Tasks.SelectedCells[0].OwningRow.Cells[0].Value);
            AdvProjTask Task = context.AdvProjTasks.Single(x => x.TaskId == cell);
            this.Hide();
            CreateTask createTask = new CreateTask(this, Task);
            createTask.Show();
        }

        private void btn_ViewProject_Click(object sender, EventArgs e)
        {
            int cell = Convert.ToInt32(dgv_Tasks.SelectedCells[0].OwningRow.Cells[0].Value);
            AdvProjTask Task = context.AdvProjTasks.Single(x => x.TaskId == cell);
            this.Hide();
            ViewTask viewTask = new ViewTask(Task, this);
            viewTask.Show();
        }
    }
}
