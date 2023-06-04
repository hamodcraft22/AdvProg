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
        AdvProjProject projectObject;
        bool isMember;
        bool showAll;
        public ProjectView(ProjectsView projectsView, AdvProjProject project, bool isMember)
        {
            InitializeComponent();
            context = new AdvProg_DatabaseContext();

            this.projectsView = projectsView;
            this.projectObject = project;
            this.isMember = isMember;
            this.showAll = false;
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

            // hiding the elemnts which a member shouldnt touch or a manager
            if (isMember)
            {
                btn_CreateProject.Visible = false;
                btn_DeleteProject.Visible = false;
            }
            else
            {
                btn_ShowAll.Visible = false;
            }

            RefreshData();
        }

        public void RefreshData()
        {
            dgv_Tasks.DataSource = null;

            var tasksToShow = context.AdvProjTasks.Include(a => a.Project).Include(a => a.Status).Where(x => x.ProjectId == projectObject.ProjectId).AsQueryable();

            // check if member and show all parameters
            if (isMember && !showAll)
            {
                // show member tasks only!!
                var userTaskIds = context.AdvProjUserTasks.Where(x => x.UserId == Global.loggedUser.UserId).Select(a => a.TaskId);
                tasksToShow = tasksToShow.Where(a => userTaskIds.Contains(a.TaskId));
            }

            // loading and calculating statstics
            double countOfTasks = tasksToShow.Count();
            double countOfCmplt = tasksToShow.Where(x => x.StatusId == '5').Count();
            double countOfOvrd = tasksToShow.Where(x => x.FinishDate > x.EndDate || (x.FinishDate == DateTime.MinValue.Date && x.EndDate > DateTime.Today.Date)).Count();


            lblNumberOfTask.Text = ((int)countOfTasks).ToString();
            lblNumberOfOverDueTasks.Text = ((int)countOfOvrd).ToString();
            lblNumberOfCompletedTasks.Text = ((int)countOfCmplt).ToString();
            lblPrcntCmplt.Text = ((countOfCmplt / countOfTasks) * 100).ToString() + "%";


            if (txt_SearchTask.Text != "")
            {
                tasksToShow = tasksToShow.Where(x => x.TaskName == txt_SearchTask.Text);
            }

            if (ddl_Users.SelectedValue != null)
            {
                var userTaksIds = context.AdvProjUserTasks.Where(a => a.UserId == Global.loggedUser.UserId).Select(b => b.TaskId);
                tasksToShow = tasksToShow.Where(a => userTaksIds.Contains(a.TaskId));
            }

            if (ddl_ProjectStatus.SelectedValue != null)
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
                CreateDate = o.CreateDate,
                FinishDate = o.FinishDate,
                ProjectName = o.Project.ProjectName,
                Status = o.Status.StatusName

            }).ToList();
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            if (ddl_Users.SelectedValue == null && ddl_ProjectStatus.SelectedValue == null && txt_SearchTask.Text == "")
            {
                MessageBox.Show("Select values to filters");
            }
            else
            {
                RefreshData();
            }
        }

        private void btn_DeleteProject_Click(object sender, EventArgs e)
        {
            int TaskID = Convert.ToInt32(dgv_Tasks.SelectedCells[0].OwningRow.Cells[0].Value);

            AdvProjTask Task = context.AdvProjTasks.Single(x => x.TaskId == TaskID);

            if (MessageBox.Show("Are you sure you want to delete " + Task.TaskName + " ?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context.Remove(Task);
                context.SaveChanges();

                MessageBox.Show("Deleted Successfully");
                RefreshData();
            }
        }

        private void btn_CreateProject_Click(object sender, EventArgs e)
        {
            CreateTask createTask = new CreateTask(projectObject.ProjectId);
            createTask.ShowDialog();

            if (createTask.DialogResult == DialogResult.OK)
            {
                // notification and refresh
                MessageBox.Show("Task Created Successfully");
                RefreshData();
            }
        }

        private void btn_UpdateProject_Click(object sender, EventArgs e)
        {
            int TaskID = Convert.ToInt32(dgv_Tasks.SelectedCells[0].OwningRow.Cells[0].Value);
            AdvProjTask TaskToPass = context.AdvProjTasks.Single(x => x.TaskId == TaskID);

            CreateTask editTask = new CreateTask(TaskToPass);
            editTask.ShowDialog();

            if (editTask.DialogResult == DialogResult.OK)
            {
                // notification and refresh
                MessageBox.Show("Task Updated Successfully");
                RefreshData();
            }
        }

        private void btn_ViewProject_Click(object sender, EventArgs e)
        {
            int TaskID = Convert.ToInt32(dgv_Tasks.SelectedCells[0].OwningRow.Cells[0].Value);
            AdvProjTask TaskToPass = context.AdvProjTasks.Single(x => x.TaskId == TaskID);


            ViewTask viewTask = new ViewTask(TaskToPass, this, isMember);
            this.Hide();
            viewTask.Show();
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            if (showAll)
            {
                showAll = false;
                btn_ShowAll.Text = "Show All Tasks";
                btn_UpdateProject.Visible = true;
            }
            else
            {
                showAll = true;
                btn_ShowAll.Text = "Show My Tasks";
                btn_UpdateProject.Visible = false;
            }

            RefreshData();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_SearchTask.Text = "";
            ddl_ProjectStatus.SelectedItem = null;
            ddl_Users.SelectedItem = null;

            RefreshData();
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.projectsView.Show();
            this.Close();
        }
    }
}
