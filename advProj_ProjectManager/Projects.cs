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
    public partial class ProjectsView : Form
    {
        /// Initializes a new instance of the ProjectsView class.
        
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


        /// Loads the ProjectsView form.
        
        private void ProjectsView_Load(object sender, EventArgs e)
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

                // hiding the elemnts which a member shouldnt touch
                if (isMember)
                {
                    btn_CreateProject.Visible = false;
                    btn_DeleteProject.Visible = false;
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

        
        /// This method retrieves the projects to be displayed in the view based on the user's role and filters applied.
        /// It then updates the labels displaying the number of projects, completed projects, and overdue projects.
        /// Finally, it populates the DataGridView with the retrieved projects.
       
        public void RefreshData()
        {
            try
            {
                dgv_ProjectsView.DataSource = null;

                var projectsToShow = context.AdvProjProjects.Include(a => a.Status).Include(b => b.Manager).AsQueryable();

                // check if is member of view or not
                if (isMember)
                {
                    // part to check if member and only show those results
                    var userTaskIds = context.AdvProjUserTasks.Where(x => x.UserId == Global.loggedUser.UserId).Select(a => a.TaskId);
                    var userProjectIds = context.AdvProjTasks.Where(x => userTaskIds.Contains(x.TaskId)).Select(a => a.ProjectId);
                    projectsToShow = projectsToShow.Where(a => userProjectIds.Contains(a.ProjectId));
                }
                else
                {
                    // show only the ones where the logged user is the manager
                    projectsToShow = projectsToShow.Where(a => a.ManagerId == Global.loggedUser.UserId);
                }

                // statistics
                lblNumberofProjects.Text = projectsToShow.Count().ToString();
                lblNumberOfCompletedProjects.Text = projectsToShow.Where(x => x.StatusId == '5').Count().ToString();
                lblNumberofOverDueProjects.Text = projectsToShow.Where(x => x.FinishDate > x.EndDate || (x.FinishDate == DateTime.MinValue.Date && x.EndDate < DateTime.Today.Date)).Count().ToString();

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
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }
        }

        
        /// If no filter is selected, a message box is displayed to prompt the user to add a filter.
        /// Otherwise, the data is refreshed based on the selected filter.
        /// If an exception occurs, a message box is displayed to inform the user and the error is logged.
        
        private void btn_Filter_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }

        }

        /// Closes the current form and shows the home page.
        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.homePage.Show();
            this.Close();
        }

        /// Deletes a project from the database and logs the action
     
        private void btn_DeleteProject_Click(object sender, EventArgs e)
        {
            try
            {
                int projectID = Convert.ToInt32(dgv_ProjectsView.SelectedCells[0].OwningRow.Cells[0].Value);

                AdvProjProject advProj = context.AdvProjProjects.Single(o => o.ProjectId == projectID);

                if (MessageBox.Show("Are you sure you want to delete " + advProj.ProjectName + " ?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    context.AdvProjProjects.Remove(advProj);
                    context.AdvProjProjects.RemoveRange(advProj);
                    context.SaveChanges();

                    LogsAudits.addAudit("Forms", "Delete", "Project", advProj.ToString(), null, advProj.ProjectId, Global.loggedUser.UserId);

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
                Create_Project create_Project = new Create_Project();
                create_Project.ShowDialog();

                if (create_Project.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Project Created Successfully");

                    RefreshData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }
        }

        
        /// This method retrieves the ID of the selected project from the data grid view, retrieves the corresponding project from the database,
        /// opens a form to edit the project, and refreshes the data grid view if the project was successfully updated.
        /// If an error occurs, a message box is displayed and the error is logged.
        
        private void btn_UpdateProject_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }
        }

        /// Handles the click event of the "View Project" button.
        private void btn_ViewProject_Click(object sender, EventArgs e)
        {
            try
            {
                int projectID = Convert.ToInt32(dgv_ProjectsView.SelectedCells[0].OwningRow.Cells[0].Value);

                AdvProjProject advProj = context.AdvProjProjects.Single(o => o.ProjectId == projectID);
                ProjectView projectView = new ProjectView(this, advProj, isMember);

                this.Hide();
                projectView.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }

        }

  
        /// This method clears the text in the search field, the selected item in the project status dropdown, and the selected item in the users dropdown.
        /// It then refreshes the data displayed in the form.

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            try
            {
                txt_SearchProject.Text = "";
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
    }
}
