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


namespace advProj_ProjectManager
{

    public partial class Create_Project : Form
    {
        AdvProg_DatabaseContext context;
        AdvProjProject projectObject;


        public Create_Project()
        {
            InitializeComponent();
            context = new AdvProg_DatabaseContext();

            this.projectObject = new AdvProjProject();
        }

        public Create_Project(AdvProjProject retirvedProject)
        {
            InitializeComponent();


            // this is an edit - do some chnages to the page
            btn_CreateProject.Text = "Update Button";
            this.Text = "Update Project";

            context = new AdvProg_DatabaseContext();
            this.projectObject = retirvedProject;
        }

        private void Create_Project_Load(object sender, EventArgs e)
        {
            projectStartDate.Value = DateTime.Today.Date;
            projectEndDate.Value = DateTime.Today.Date;

            ddl_ProjectStatus.DataSource = context.AdvProjPStatuses.ToList();
            ddl_ProjectStatus.DisplayMember = "StatusName";
            ddl_ProjectStatus.ValueMember = "StatusId";
            ddl_ProjectStatus.SelectedItem = null;

            // if it is a passed project - populate data
            if (projectObject.ProjectId != 0)
            {
                txt_ProjectName.Text = projectObject.ProjectName;
                if (projectObject.StartDate != null)
                {
                    projectStartDate.Value = projectObject.StartDate.Value;
                }
                if (projectObject.EndDate != null)
                {
                    projectEndDate.Value = projectObject.EndDate.Value;
                }
                ddl_ProjectStatus.SelectedValue = projectObject.StatusId;
                txt_ProjectDescription.Text = projectObject.ProjectDescription;
            }
            else
            {
                // else if it is a create, disable the selction of a status other than create
                ddl_ProjectStatus.SelectedValue = 1;
                ddl_ProjectStatus.Enabled = false;
            }
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CreateProject_Click(object sender, EventArgs e)
        {
            string errors = "";

            if (txt_ProjectName.Text == "")
            {
                errors += "Please Input a name.\n";
            }

            if (ddl_ProjectStatus.SelectedValue == null)
            {
                errors += "Please Select a status.\n";
            }

            if (txt_ProjectDescription.Text == "")
            {
                errors += "Please Add a Project Description.\n";
            }

            // dates checks are canceled if it is an update
            if (projectObject.ProjectId == 0)
            {
                if (projectStartDate.Value < DateTime.Today.Date)
                {
                    errors += "Project Satrt Date Cannot be in the past.\n";
                } 
            }

            if (projectEndDate.Value < projectStartDate.Value)
            {
                errors += "Project End Date Cannot be before the start.\n";
            }

            if (errors == "")
            {
                projectObject.ProjectName = txt_ProjectName.Text;
                projectObject.StartDate = projectStartDate.Value.Date;
                projectObject.EndDate = projectEndDate.Value.Date;
                projectObject.StatusId = Convert.ToInt32(ddl_ProjectStatus.SelectedValue);
                projectObject.ProjectDescription = txt_ProjectDescription.Text;
                projectObject.ManagerId = Global.loggedUser.UserId;


                if (projectObject.ProjectId != 0)
                {
                    if (Convert.ToInt32(ddl_ProjectStatus.SelectedValue) == 5)
                    {
                        projectObject.FinishDate = DateTime.Now.Date;
                    }

                    // workaround to disable tracking check
                    AdvProg_DatabaseContext newContext = new AdvProg_DatabaseContext();
                    newContext.Update(projectObject);
                    newContext.SaveChanges();     

                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    projectObject.CreateDate = DateTime.Now.Date;

                    AdvProg_DatabaseContext newContext = new AdvProg_DatabaseContext();
                    newContext.Add(projectObject);
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
