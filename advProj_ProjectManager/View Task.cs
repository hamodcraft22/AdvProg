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
    public partial class ViewTask : Form
    {
        AdvProg_DatabaseContext context;
        ProjectView projectsView;
        AdvProjTask taskObject;
        bool isMember;

        public ViewTask(AdvProjTask task, ProjectView projectView, bool isMember)
        {
            InitializeComponent();
            context = new AdvProg_DatabaseContext();

            this.taskObject = task;
            this.projectsView = projectView;
            this.isMember = isMember;
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            projectsView.Show();
            this.Close();
        }

        private void ViewTask_Load(object sender, EventArgs e)
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

        public void RefreshUsers()
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

        public void RefreshComments()
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

        private void btnSearchUser_Click(object sender, EventArgs e)
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

        private void btnSearchComments_Click(object sender, EventArgs e)
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

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            int cell = Convert.ToInt32(dgv_Users.SelectedCells[0].OwningRow.Cells[0].Value);

            AdvProjUserTask userTask = context.AdvProjUserTasks.Single(x => x.UserId == cell && x.TaskId == taskObject.TaskId);

            if (MessageBox.Show("Are you sure you want to remove the user ?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                AdvProg_DatabaseContext newContext = new AdvProg_DatabaseContext();
                newContext.Remove(userTask);
                newContext.SaveChanges();

                MessageBox.Show("Removed Successfully");
                RefreshUsers();
            }
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
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

                    RefreshUsers();
                }
            }
            else
            {
                MessageBox.Show("Choose a User");
            }
        }

        private void btnDeletedComment_Click(object sender, EventArgs e)
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

                    MessageBox.Show("Deleted Successfully");
                    RefreshComments();
                }
            }
            else
            {
                MessageBox.Show("You cant delete a comment thats not your's");
            }

        }

        private void btnAddComment_Click(object sender, EventArgs e)
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

                clearCom();

                MessageBox.Show("Successfully Added Comment");
                RefreshComments();
            }
            else
            {
                MessageBox.Show(errors);
            }
        }

        private void btnEditComment_Click(object sender, EventArgs e)
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

        private void clearCom()
        {
            txtBody.Text = "";
            txtTitle.Text = "";
        }

        private void dgv_Comments_DoubleClick(object sender, EventArgs e)
        {
            int cell = Convert.ToInt32(dgv_Comments.SelectedCells[0].OwningRow.Cells[0].Value);
            AdvProjComment comment = context.AdvProjComments.Single(x => x.CommentId == cell);

            txtTitle.Text = comment.CommentTitle;
            txtBody.Text = comment.CommentBody;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clearCom();
        }
    }
}
