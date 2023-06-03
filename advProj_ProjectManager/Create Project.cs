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
        ProjectsView projectsView;
        AdvProjProject project;


        public Create_Project(ProjectsView projectsView)
        {
            context = new AdvProg_DatabaseContext();
            InitializeComponent();
            this.projectsView = projectsView;
            this.project = new AdvProjProject();
        }

        public Create_Project(ProjectsView projectsView, AdvProjProject project)
        {
            context = new AdvProg_DatabaseContext();
            InitializeComponent();
            this.projectsView = projectsView;
            this.project = project;
            btn_CreateProject.Text = "Update Button";
            this.Text = "Update Project";
        }

        private void Create_Project_Load(object sender, EventArgs e)
        {
            projectStartDate.Value = DateTime.Today.Date;
            projectEndDate.Value = DateTime.Today.Date;

            ddl_ProjectStatus.DataSource = context.AdvProjPStatuses.ToList();
            ddl_ProjectStatus.DisplayMember = "StatusName";
            ddl_ProjectStatus.ValueMember = "StatusId";
            ddl_ProjectStatus.SelectedItem = null;
            if (this.project != null)
            {
                try
                {
                    txt_ProjectName.Text = this.project.ProjectName;
                    projectStartDate.Value = this.project.StartDate.Value;
                    projectEndDate.Value = this.project.EndDate.Value;
                    ddl_ProjectStatus.SelectedValue = this.project.StatusId;
                    txt_ProjectDescription.Text = this.project.ProjectDescription;
                }catch(Exception ex)
                {
                    MessageBox.Show("Error "+ex);
                }
                
            }
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.projectsView.Refresh();
            this.projectsView.Show();

        }

        private void btn_CreateProject_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ProjectName.Text != "")
                {
                    project.ProjectName = txt_ProjectName.Text;
                    if (projectStartDate.Value.Date >= DateTime.Today.Date)
                    {
                        project.StartDate = projectStartDate.Value.Date;
                        if (projectEndDate.Value.Date >= DateTime.Today.Date)
                        {
                            project.EndDate = projectEndDate.Value.Date;
                            if (ddl_ProjectStatus.SelectedValue != null)
                            {
                                project.StatusId = Convert.ToInt32(ddl_ProjectStatus.SelectedValue);
                                if (txt_ProjectDescription.Text != "")
                                {
                                    project.ProjectDescription = txt_ProjectDescription.Text;
                                    project.ManagerId = Global.loggedUser.UserId;

                                    if (this.project.ProjectId != null)
                                    {
                                        context.Update(this.project);
                                        context.SaveChanges();
                                        MessageBox.Show("Project updated Successfully");
                                        this.Hide();
                                        this.projectsView.Refresh();
                                        this.projectsView.Show();

                                    }
                                    else
                                    {
                                        context.Add(this.project);
                                        context.SaveChanges();
                                        MessageBox.Show("Project created Successfully");
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
                    MessageBox.Show("Enter a project Name");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
        public void Refresh()
        {
            ddl_ProjectStatus.SelectedItem = null;
            projectStartDate.Value = DateTime.Today.Date;
            projectEndDate.Value = DateTime.Today.Date;
            txt_ProjectDescription.Text = "";
            txt_ProjectName.Text = "";


        }
    }
}
