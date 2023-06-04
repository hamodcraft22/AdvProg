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
        AdvProjTask taskObject;
        int projectID;

        public CreateTask(int projectID)
        {
            InitializeComponent();
            context = new AdvProg_DatabaseContext();
            taskObject = new AdvProjTask();
            this.projectID = projectID;
        }

        public CreateTask(AdvProjTask Passedtask)
        {
            InitializeComponent();
            context = new AdvProg_DatabaseContext();

            this.taskObject = Passedtask;
            this.projectID = (int)Passedtask.ProjectId;

            // chnaging to update page
            btn_CreateTask.Text = "Update Button";
            this.Text = "Update task";
        }

        private void CreateTask_Load(object sender, EventArgs e)
        {
            taskStartDate.Value = DateTime.Today.Date;
            taskEndDate.Value = DateTime.Today.Date;

            ddl_TaskStatus.DataSource = context.AdvProjPStatuses.ToList();
            ddl_TaskStatus.DisplayMember = "StatusName";
            ddl_TaskStatus.ValueMember = "StatusId";
            ddl_TaskStatus.SelectedItem = null;

            // if an object is passed, populate data
            if (taskObject.TaskId != 0)
            {
                txt_TaskName.Text = taskObject.TaskName;
                if (taskObject.StartDate != null)
                {
                    taskStartDate.Value = taskObject.StartDate.Value;
                }
                if (taskObject.EndDate != null)
                {
                    taskEndDate.Value = taskObject.EndDate.Value;
                }
                ddl_TaskStatus.SelectedValue = taskObject.StatusId;
                txt_TaskDescription.Text = taskObject.TaskDescription;
            }
            else
            {
                // else if it is a create, disable the selction of a status other than create
                ddl_TaskStatus.SelectedValue = 1;
                ddl_TaskStatus.Enabled = false;
            }
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CreateTask_Click(object sender, EventArgs e)
        {
            string errors = "";

            if (txt_TaskName.Text == "")
            {
                errors += "Please Input a name.\n";
            }

            if (ddl_TaskStatus.SelectedValue == null)
            {
                errors += "Please Select a status.\n";
            }

            if (txt_TaskDescription.Text == "")
            {
                errors += "Please Add a Tsk Description.\n";
            }

            // dates checks are canceled if it is an update
            if (taskObject.TaskId == 0)
            {
                if (taskStartDate.Value < DateTime.Today.Date)
                {
                    errors += "Tsak Satrt Date Cannot be in the past.\n";
                }
            }

            if (taskEndDate.Value < taskStartDate.Value)
            {
                errors += "Task End Date Cannot be before the start.\n";
            }


            if (errors == "")
            {
                taskObject.TaskName = txt_TaskDescription.Text;
                taskObject.StartDate = taskStartDate.Value.Date;
                taskObject.EndDate = taskEndDate.Value.Date;
                taskObject.StatusId = Convert.ToInt32(ddl_TaskStatus.SelectedValue);
                taskObject.TaskDescription = txt_TaskDescription.Text;
                taskObject.ProjectId = projectID;

                if (taskObject.TaskId != 0)
                {
                    if (Convert.ToInt32(ddl_TaskStatus.SelectedValue) == 5)
                    {
                        taskObject.FinishDate = DateTime.Now.Date;
                    }

                    // workaround to disable tracking check
                    AdvProg_DatabaseContext newContext = new AdvProg_DatabaseContext();

                    newContext.Update(taskObject);
                    newContext.SaveChanges();

                    this.Close();
                    this.DialogResult = DialogResult.OK;

                }
                else
                {
                    taskObject.CreateDate = DateTime.Now.Date;

                    AdvProg_DatabaseContext newContext = new AdvProg_DatabaseContext();
                    newContext.Add(taskObject);
                    newContext.SaveChanges();

                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show(errors);
            }

        }

    }
}
