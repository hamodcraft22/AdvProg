using advProj_BusinessObjects;
using advProj_BusinessObjects.GlobalClass;
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

        
        /// This constructor is used when updating an existing task. It sets the form's title to "Update task" and the text of the
        /// button to "Update Button". It also initializes the form's context and sets the taskObject and projectID fields.
        /// 
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

        /// Loads the form for creating a new task or editing an existing one
 
        private void CreateTask_Load(object sender, EventArgs e)
        {
            try {
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
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }
        }

        /// Closes the current form.
      
        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        /// This method validates the user input and displays an error message if any of the required fields are missing or invalid.
        /// If the task object already exists in the database, it updates the existing record. Otherwise, it creates a new record.
        
        
        private void btn_CreateTask_Click(object sender, EventArgs e)
        {
            try {
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
                    taskObject.TaskName = txt_TaskName.Text;
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

                        //var oldTask = context.AdvProjTasks.Find(taskObject.TaskId);

                        // workaround to disable tracking check
                        AdvProg_DatabaseContext newContext = new AdvProg_DatabaseContext();

                        newContext.Update(taskObject);
                        newContext.SaveChanges();

                        //LogsAudits.addAudit("Forms", "Update", "Task", oldTask.ToString(), taskObject.ToString(), taskObject.TaskId, Global.loggedUser.UserId);

                        this.Close();
                        this.DialogResult = DialogResult.OK;

                    }
                    else
                    {
                        taskObject.CreateDate = DateTime.Now.Date;

                        AdvProg_DatabaseContext newContext = new AdvProg_DatabaseContext();
                        newContext.Add(taskObject);
                        newContext.SaveChanges();

                        LogsAudits.addAudit("Forms", "Create", "Task", null, taskObject.ToString(), taskObject.TaskId, Global.loggedUser.UserId);


                        this.Close();
                        this.DialogResult = DialogResult.OK;
                    }
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

    }
}
