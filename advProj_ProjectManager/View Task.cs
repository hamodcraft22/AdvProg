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
        AdvProjTask task;
        public ViewTask()
        {
            InitializeComponent();
            context = new AdvProg_DatabaseContext();
        }
        public ViewTask(AdvProjTask task, ProjectView projectView)
        {
            InitializeComponent();
            context = new AdvProg_DatabaseContext();
            this.task = task;
            this.projectsView = projectView;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.projectsView.Show();

        }

        private void ViewTask_Load(object sender, EventArgs e)
        {
            ddl_Users.DataSource = context.AdvProjUsers.ToList();
            ddl_Users.DisplayMember = "FullName";
            ddl_Users.ValueMember = "UserId";
            ddl_Users.SelectedItem = null;
            RefreshUsers();
            RefreshComments();
        }
        public void RefreshUsers()
        {
            dgv_Users.DataSource = null;

            var usersToShow = context.AdvProjUsers.Where(u => context.AdvProjUserTasks.Where(ut => ut.TaskId == this.task.TaskId).Select(ut => ut.UserId).Contains(u.UserId)).AsQueryable();


            try
            {
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
                MessageBox.Show("Error " + ex);
            }

        }

        public void RefreshComments()
        {
            dgv_Comments.DataSource = null;
            var commentToShow = context.AdvProjComments.Where(x => x.TaskId == this.task.TaskId).AsQueryable();

            try
            {
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
                    FullName = o.User.FullName,
                    TaskName = o.Task.TaskName,
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            if (txtUsers.Text == "")
            {
                MessageBox.Show("Enter Text To Search");
            }
            RefreshUsers();
        }

        private void btnSearchComments_Click(object sender, EventArgs e)
        {
            if (txtComments.Text == "")
            {
                MessageBox.Show("Enter Text To Search");
            }
            RefreshComments();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (ddl_Users.SelectedValue != null)
                {
                    var userIds = context.AdvProjUserTasks.Where(x => x.TaskId == this.task.TaskId);
                    if (userIds.Contains(ddl_Users.SelectedValue))
                    {
                        MessageBox.Show("User eis already assigned");

                    }
                    else
                    {
                        AdvProjUserTask userTask = new AdvProjUserTask();
                        userTask.UserId = Convert.ToInt32(ddl_Users.SelectedValue.ToString());
                        userTask.TaskId = this.task.TaskId;
                        context.Add(userTask);
                        context.SaveChanges();
                        RefreshComments();
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
                MessageBox.Show("Error " + ex);
            }
        }

        private void btnDeletedComment_Click(object sender, EventArgs e)
        {
            int cell = Convert.ToInt32(dgv_Comments.SelectedCells[0].OwningRow.Cells[0].Value);

            AdvProjComment comment = context.AdvProjComments.Single(x => x.CommentId == cell);
            if (MessageBox.Show("Do u want to delete " + comment.CommentTitle + "?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context.Remove(comment);
                context.RemoveRange(comment);
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

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            try
            {
                AdvProjComment comment = new AdvProjComment();
                if (txtTitle.Text != "")
                {
                    comment.CommentTitle = txtTitle.Text;
                    if (txtBody.Text != "")
                    {
                        comment.CommentBody = txtBody.Text;
                        comment.CommentDate = DateTime.Now;
                        comment.User = Global.loggedUser;
                        comment.TaskId = this.task.TaskId;
                        comment.ResponseId = 2;
                        context.Add(comment);
                        context.SaveChanges();
                        MessageBox.Show("Successfully Successfully");
                        RefreshComments();
                        RefreshUsers();
                    }
                    else
                    {
                        MessageBox.Show("Enter a Body");
                    }
                }
                else
                {
                    MessageBox.Show("Enter a Title");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void btnEditComment_Click(object sender, EventArgs e)
        {
            int cell = Convert.ToInt32(dgv_Comments.SelectedCells[0].OwningRow.Cells[0].Value);

            AdvProjComment comment = context.AdvProjComments.Single(x => x.CommentId == cell);
            try
            {
                txtTitle.Text = comment.CommentTitle;
                txtBody.Text = comment.CommentBody;
                if (txtTitle.Text != "")
                {
                    comment.CommentTitle = txtTitle.Text;
                    if (txtComments.Text != "")
                    {
                        comment.CommentBody = txtBody.Text;
                        comment.TaskId = this.task.TaskId;
                        context.Update(comment);
                        context.SaveChanges();
                        RefreshComments();
                        RefreshUsers();
                    }
                    else
                    {
                       if (txtTitle.Text != "")
                {
                    comment.CommentTitle = txtTitle.Text;
                    if (txtComments.Text != "")
                    {
                        comment.CommentBody = txtBody.Text;
                        
                        context.Update(comment);
                        context.SaveChanges();
                       MessageBox.Show("Updated Successfully");
                       RefreshComments();
                        RefreshUsers();
                                
                            }
                    else
                    {
                        MessageBox.Show("Enter a Body");
                    }
                }
                else
                {
                    MessageBox.Show("Enter a Title");
                }
                    }
                }
                else
                {
                    MessageBox.Show("Enter a Title");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
    }
}
