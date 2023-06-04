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
using Microsoft.EntityFrameworkCore;

namespace advProj_ProjectManager
{
    public partial class ProjectView : Form
    {
        /// Initializes a new instance of the ProjectView class.
        
        
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

        
        /// Populates the dropdown lists for users and project statuses from the database.
        /// Hides the create and delete project buttons if the user is a member, or the show all projects button if the user is not.
        /// Calls the RefreshData method to populate the project list.
        
        private void ProjectView_Load(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }

        }

        
        /// This method retrieves the tasks associated with the current project and displays them in the DataGridView.
        /// If the user is a member and not authorized to view all tasks, only the tasks assigned to them will be displayed.
        /// The method also calculates and displays the number of tasks, completed tasks, overdue tasks, and the percentage of completed tasks.
       
        public void RefreshData()
        {
            try
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
                double countOfOvrd = tasksToShow.Where(x => x.FinishDate > x.EndDate || (x.FinishDate == DateTime.MinValue.Date && x.EndDate < DateTime.Today.Date)).Count();


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
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }

        }

        /// Filters the data based on the selected values.
       
        private void btn_Filter_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }

        }

  
        /// This method retrieves the ID of the selected task from the DataGridView, then uses it to retrieve the corresponding
        /// AdvProjTask object from the database. If the user confirms the deletion, the task is removed from the database and
        /// an audit log is created. If an exception occurs, an error message is displayed and a log is created.
       
        private void btn_DeleteProject_Click(object sender, EventArgs e)
        {
            try
            {
                int TaskID = Convert.ToInt32(dgv_Tasks.SelectedCells[0].OwningRow.Cells[0].Value);

                AdvProjTask Task = context.AdvProjTasks.Single(x => x.TaskId == TaskID);

                if (MessageBox.Show("Are you sure you want to delete " + Task.TaskName + " ?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    context.Remove(Task);
                    context.SaveChanges();
                    LogsAudits.addAudit("Forms", "Delete", "Task", Task.ToString(), null, Task.TaskId, Global.loggedUser.UserId);


                    MessageBox.Show("Deleted Successfully");
                    RefreshData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }

        }

        /// Handles the click event of the Create Project button.
        
        private void btn_CreateProject_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }

        }

      
        /// This method retrieves the ID of the selected task from the data grid view, and uses it to retrieve the corresponding task object from the context.
        /// It then creates a new instance of the CreateTask form, passing the retrieved task object as a parameter.
        /// The form is displayed as a dialog box, and if the user clicks the "OK" button, the task is updated and the data is refreshed.
        /// If an exception occurs, an error message is displayed and a log entry is added
        private void btn_UpdateProject_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }
        }

       //Handles the click event of the "View Project" button
        
        private void btn_ViewProject_Click(object sender, EventArgs e)
        {
            try
            {
                int TaskID = Convert.ToInt32(dgv_Tasks.SelectedCells[0].OwningRow.Cells[0].Value);
                AdvProjTask TaskToPass = context.AdvProjTasks.Single(x => x.TaskId == TaskID);


                ViewTask viewTask = new ViewTask(TaskToPass, this, isMember);
                this.Hide();
                viewTask.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }
        }

        //Handles the click event of the "Show All" button
   
        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }
        }

        /// >Clears the search task text box, project status drop-down list, and users drop-down list. Then refreshes the data.
        
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            try
            {
                txt_SearchTask.Text = "";
                ddl_ProjectStatus.SelectedItem = null;
                ddl_Users.SelectedItem = null;

                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }
        }

        /// Closes the current form and shows the projects view.
 
        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.projectsView.Show();
            this.Close();
        }
    }
}
