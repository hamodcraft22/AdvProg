using advProj_BusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace advProj_ProjectManager
{
    public partial class CreateTask : Form
    {
        AdvProg_DatabaseContext context;
        ProjectView projectView;
        AdvProjTask task;
        public CreateTask()
        {
            context = new AdvProg_DatabaseContext();
            InitializeComponent();
        }

        public CreateTask(ProjectView projectView)
        {
            context = new AdvProg_DatabaseContext();
            InitializeComponent();
            this.projectView = projectView;
        }

        public CreateTask(ProjectView projectView, AdvProjTask task)
        {
            context = new AdvProg_DatabaseContext();
            InitializeComponent();
            this.projectView = projectView;
            this.task = task;
            btn_CreateTask.Text = "Update Button";
            this.Text = "Update task";
        }

        private void lbl_Login_Click(object sender, EventArgs e)
        {

        }

        private void CreateTask_Load(object sender, EventArgs e)
        {
            taskStartDate.Value = DateTime.Today.Date;
            taskEndDate.Value = DateTime.Today.Date;

            ddl_TaskStatus.DataSource = context.AdvProjPStatuses.ToList();
            ddl_TaskStatus.DisplayMember = "StatusName";
            ddl_TaskStatus.ValueMember = "StatusId";
            ddl_TaskStatus.SelectedItem = null;
            if (task != null)
            {
                try
                {
                    txt_TaskName.Text = this.task.TaskName;
                    taskStartDate.Value = this.task.StartDate.Value;
                    taskEndDate.Value = this.task.EndDate.Value;
                    ddl_TaskStatus.SelectedValue = this.task.StatusId;
                    txt_TaskDescription.Text = this.task.TaskDescription;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }

            }
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.projectView.Refresh();
            this.projectView.Show();
        }

        private void btn_CreateTask_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_TaskDescription.Text != "")
                {
                    task.TaskName = txt_TaskDescription.Text;
                    if (taskStartDate.Value.Date >= DateTime.Today.Date)
                    {
                        task.StartDate = taskStartDate.Value.Date;
                        if (taskEndDate.Value.Date >= DateTime.Today.Date)
                        {
                            task.EndDate = taskEndDate.Value.Date;
                            if (ddl_TaskStatus.SelectedValue != null)
                            {
                                task.StatusId = Convert.ToInt32(ddl_TaskStatus.SelectedValue);
                                if (txt_TaskDescription.Text != "")
                                {
                                    task.TaskDescription = txt_TaskDescription.Text;
                                    task.ProjectId = this.task.ProjectId;

                                    if (this.task.ProjectId != null)
                                    {
                                        context.Update(this.task);
                                        context.SaveChanges();
                                        MessageBox.Show("Task updated Successfully");
                                        this.Hide();
                                        this.projectView.Refresh();
                                        this.projectView.Show();

                                    }
                                    else
                                    {
                                        context.Add(this.task);
                                        context.SaveChanges();
                                        MessageBox.Show("Task created Successfully");
                                        Refresh();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Enter a project Description");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Select a status");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid start date");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid start date");
                    }
                }
                else
                {
                    MessageBox.Show("Enter a Task Name");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
        public void Refresh()
        {
            ddl_TaskStatus.SelectedItem = null;
            taskStartDate.Value = DateTime.Today.Date;
            taskEndDate.Value = DateTime.Today.Date;
            txt_TaskDescription.Text = "";
            txt_TaskName.Text = "";
        }
    }
}
