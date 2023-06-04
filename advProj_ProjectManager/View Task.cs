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
    public partial class ViewTask : Form
    {
        AdvProg_DatabaseContext context;
        ProjectView projectsView;
        AdvProjTask taskObject;
        bool isMember;

        /// Initializes a new instance of the ViewTask class.
        public ViewTask(AdvProjTask task, ProjectView projectView, bool isMember)
        {
            InitializeComponent();
            context = new AdvProg_DatabaseContext();

            this.taskObject = task;
            this.projectsView = projectView;
            this.isMember = isMember;
        }

        /// Closes the current form and shows the projects view.

        private void btn_Return_Click(object sender, EventArgs e)
        {
            projectsView.Show();
            this.Close();
        }

        /// Loads the view task form.

        private void ViewTask_Load(object sender, EventArgs e)
        {
            try
            {
                ddl_Users.DataSource = context.AdvProjUsers.ToList();
                ddl_Users.DisplayMember = "FullName";
                ddl_Users.ValueMember = "UserId";
                ddl_Users.SelectedItem = null;

                //disable elements for member 
                if (isMember)
                {
                    btnDeleteUser.Visible = false;
                    btn_AddUser.Visible = false;
                    ddl_Users.Visible = false;
                }

                RefreshUsers();
                RefreshComments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }

        }

        /// Refreshes the list of users displayed in the DataGridView.

        /// The list of users displayed is filtered to only show users who are assigned to the current task.
        /// If a search term is entered in the txtUsers TextBox, the list is further filtered to only show users whose full name matches the search term.

        public void RefreshUsers()
        {
            try
            {
                dgv_Users.DataSource = null;

                // get all users for this task - many to many situation
                var usersToShow = context.AdvProjUsers.Where(u => context.AdvProjUserTasks.Where(ut => ut.TaskId == taskObject.TaskId).Select(ut => ut.UserId).Contains(u.UserId)).AsQueryable();

                // filter by Fullname
                if (txtUsers.Text != "")
                {
                    usersToShow = usersToShow.Where(x => x.FullName == txtUsers.Text);
                }

                dgv_Users.DataSource = usersToShow.Select(o => new
                {
                    UserID = o.UserId,
                    FullName = o.FullName
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }

        }


        /// The method retrieves the comments from the database that correspond to the current task object.
        /// If the text box txtComments is not empty, it filters the comments by the comment title.
        /// The DataGridView dgv_Comments is then populated with the CommentID, CommentTitle, CommentBody, CommentDate, and FullName of the user who created the comment.
        /// If an exception occurs, a message box is displayed and a log is added to the LogsAudits table in the database.

        public void RefreshComments()
        {
            try
            {
                dgv_Comments.DataSource = null;

                var commentToShow = context.AdvProjComments.Where(x => x.TaskId == taskObject.TaskId).AsQueryable();

                // filter by title
                if (txtComments.Text != "")
                {
                    commentToShow = commentToShow.Where(x => x.CommentTitle == txtComments.Text);
                }

                dgv_Comments.DataSource = commentToShow.Select(o => new
                {
                    CommentID = o.CommentId,
                    CommentTitle = o.CommentTitle,
                    CommentBody = o.CommentBody,
                    CommentDate = o.CommentDate,
                    FullName = o.User.FullName
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }

        }

        /// Handles the click event of the search user button.

        /// If the text box is empty, a message box is displayed prompting the user to enter text to search.
        /// Otherwise, the list of users is refreshed.
        /// If an exception is thrown, a message box is displayed and the error is logged.
  
        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsers.Text == "")
                {
                    MessageBox.Show("Enter Text To Search");
                }
                else
                {
                    RefreshUsers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }


        }

        /// Searches for comments based on the text entered in the text box.
        
        private void btnSearchComments_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtComments.Text == "")
                {
                    MessageBox.Show("Enter Text To Search");
                }
                else
                {
                    RefreshComments();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }


        }

        /// Deletes a user from a task

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                int cell = Convert.ToInt32(dgv_Users.SelectedCells[0].OwningRow.Cells[0].Value);

                AdvProjUserTask userTask = context.AdvProjUserTasks.Single(x => x.UserId == cell && x.TaskId == taskObject.TaskId);

                if (MessageBox.Show("Are you sure you want to remove the user ?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    AdvProg_DatabaseContext newContext = new AdvProg_DatabaseContext();
                    newContext.Remove(userTask);
                    newContext.SaveChanges();

                    LogsAudits.addAudit("Forms", "Delete", "UserTask", userTask.ToString(), null ,userTask.UserTaskId, Global.loggedUser.UserId);

                    MessageBox.Show("Removed Successfully");
                    RefreshUsers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }
        }

        ///Adds a user to a task

        /// This method retrieves the selected user from a dropdown list and checks if the user is already assigned to the task.
        /// If the user is not assigned to the task, a new AdvProjUserTask object is created and added to the database.
        /// The method also logs the creation of the user task and refreshes the list of users assigned to the task.


        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (ddl_Users.SelectedValue != null)
                {
                    // check if user is already in task
                    var userIds = context.AdvProjUserTasks.Where(x => x.TaskId == taskObject.TaskId).Select(a => a.UserId).ToList();

                    if (userIds.Contains(Convert.ToInt32(ddl_Users.SelectedValue.ToString())))
                    {
                        MessageBox.Show("User eis already assigned");
                    }
                    else
                    {
                        AdvProjUserTask userTask = new AdvProjUserTask();

                        userTask.UserId = Convert.ToInt32(ddl_Users.SelectedValue.ToString());
                        userTask.TaskId = taskObject.TaskId;

                        AdvProg_DatabaseContext newContext = new AdvProg_DatabaseContext();
                        newContext.Add(userTask);
                        newContext.SaveChanges();

                        LogsAudits.addAudit("Forms", "Create", "UserTask", null, userTask.ToString(), userTask.UserTaskId, Global.loggedUser.UserId);

                        RefreshUsers();
                    }
                }
                else
                {
                    MessageBox.Show("Choose a User");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }

        }

        /// Deletes a comment from the database.

        /// If the user is not an admin and did not create the comment, the comment will not be deleted.


        private void btnDeletedComment_Click(object sender, EventArgs e)
        {
            try
            {
                int cell = Convert.ToInt32(dgv_Comments.SelectedCells[0].OwningRow.Cells[0].Value);

                AdvProjComment comment = context.AdvProjComments.Single(x => x.CommentId == cell);

                if (comment.UserId == Global.loggedUser.UserId || Global.isAdmin)
                {
                    if (MessageBox.Show("Are you sure you want to delete " + comment.CommentTitle + " ?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // wrokaround 
                        AdvProg_DatabaseContext newContext = new AdvProg_DatabaseContext();

                        newContext.Remove(comment);
                        newContext.SaveChanges();

                        LogsAudits.addAudit("Forms", "Delete", "Comment", comment.ToString(), null, comment.CommentId, Global.loggedUser.UserId);

                        MessageBox.Show("Deleted Successfully");
                        RefreshComments();
                    }
                }
                else
                {
                    MessageBox.Show("You cant delete a comment thats not your's");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }


        }

        ///Adds a comment to the database.

        /// This method validates the input fields for the comment title and body. If both fields are not empty, a new comment object is created and added to the database. 
        /// The comment object is then logged in the audit trail and the comments section is refreshed.

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            try
            {
                string errors = "";

                if (txtTitle.Text == "")
                {
                    errors += "Please input a title \n";
                }

                if (txtBody.Text == "")
                {
                    errors += "Please input a Body \n";
                }

                if (errors == "")
                {
                    AdvProjComment comment = new AdvProjComment();

                    comment.CommentTitle = txtTitle.Text;
                    comment.CommentBody = txtBody.Text;
                    comment.CommentDate = DateTime.Now;
                    comment.UserId = Global.loggedUser.UserId;
                    comment.TaskId = taskObject.TaskId;
                    comment.ResponseId = 2;

                    // wrokaround 
                    AdvProg_DatabaseContext newContext = new AdvProg_DatabaseContext();
                    newContext.Add(comment);
                    newContext.SaveChanges();

                    LogsAudits.addAudit("Forms", "Create", "Comment", null, comment.ToString(), comment.CommentId, Global.loggedUser.UserId);

                    clearCom();

                    MessageBox.Show("Successfully Added Comment");
                    RefreshComments();
                }
                else
                {
                    MessageBox.Show(errors);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }

        }

        /// This method retrieves the selected comment from the database and checks if the logged user is the owner of the comment.
        /// If the user is the owner, it validates the input fields and updates the comment in the database.
        /// If the input fields are invalid, it displays an error message.
        /// If the user is not the owner, it displays a message indicating that the comment cannot be edited.
        /// If an error occurs, it displays a message indicating that there has been an error and logs the exception.
        private void btnEditComment_Click(object sender, EventArgs e)
        {
            try
            {
                int cell = Convert.ToInt32(dgv_Comments.SelectedCells[0].OwningRow.Cells[0].Value);

                AdvProjComment comment = context.AdvProjComments.Single(x => x.CommentId == cell);

                if (comment.UserId == Global.loggedUser.UserId)
                {
                    string errors = "";

                    if (txtTitle.Text == "")
                    {
                        errors += "Please input a title \n";
                    }

                    if (txtBody.Text == "")
                    {
                        errors += "Please input a Body \n";
                    }


                    if (errors == "")
                    {
                        comment.CommentTitle = txtTitle.Text;
                        comment.CommentBody = txtBody.Text;

                        // new context to workaround detached state
                        AdvProg_DatabaseContext newContext = new AdvProg_DatabaseContext();

                        newContext.Update(comment);
                        newContext.SaveChanges();

                        MessageBox.Show("Comment Update Done");

                        clearCom();

                        RefreshComments();
                    }
                    else
                    {
                        MessageBox.Show(errors);
                    }
                }
                else
                {
                    MessageBox.Show("You cant edit a comment thats not your's");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }


        }

        ///Clears the content of the communication form.

        /// This method clears the text of the body and title fields of the communication form.
        /// If an exception occurs, a message box is displayed and the error is logged.
        
        private void clearCom()
        {
            try
            {
                txtBody.Text = "";
                txtTitle.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }

        }

        /// Handles the double-click event of the comments DataGridView.
   
        /// This method retrieves the selected comment from the DataGridView and displays its title and body in the corresponding text boxes.
        
        private void dgv_Comments_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int cell = Convert.ToInt32(dgv_Comments.SelectedCells[0].OwningRow.Cells[0].Value);
                AdvProjComment comment = context.AdvProjComments.Single(x => x.CommentId == cell);

                txtTitle.Text = comment.CommentTitle;
                txtBody.Text = comment.CommentBody;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }
        }

        ///Clears the communication.

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clearCom();
        }
    }
}
