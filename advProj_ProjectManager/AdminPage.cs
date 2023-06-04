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
    public partial class ShowInfo : Form
    {
        /// The database context used to interact with the database.
        
        AdvProg_DatabaseContext context;
        HomePage homePage;
        public ShowInfo()
        {
            InitializeComponent();
            context = new AdvProg_DatabaseContext();
        }
        /// Initializes a new instance of the ShowInfo class.
       
        public ShowInfo(HomePage homePage)
        {
            InitializeComponent();
            context = new AdvProg_DatabaseContext();
            this.homePage = homePage;
        }

        private void ddl_LogSource_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.homePage.Show();
        }


        /// This method sets the data source, display member, and value member for the dropdown lists.
        /// It also calls the RefreshLog and RefreshAudits methods to populate the log and audit tables.
        /// If an exception occurs, a message box is displayed and the error is logged.
        
        private void ShowInfo_Load(object sender, EventArgs e)
        {
            try
            {
                ddl_LogUser.DataSource = context.AdvProjUsers.ToList();
                ddl_LogUser.DisplayMember = "FullName";
                ddl_LogUser.ValueMember = "UserId";
                ddl_LogUser.SelectedItem = null;

                ddlAduitUser.DataSource = context.AdvProjUsers.ToList();
                ddlAduitUser.DisplayMember = "FullName";
                ddlAduitUser.ValueMember = "UserId";
                ddlAduitUser.SelectedItem = null;
                RefreshLog();
                RefreshAudits();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }
        }

        
        /// This method retrieves the latest logs from the database and displays them in the log view.
     
      
        public void RefreshLog()
        {
            try
            {
                dgv_Logs.DataSource = null;

                var logsToShow = context.AdvProjLogs.AsQueryable();

                if (ddl_LogUser.SelectedValue != null)
                {
                    logsToShow = logsToShow.Where(x => x.UserId.ToString() == ddl_LogUser.SelectedValue.ToString());
                }
                dgv_Logs.DataSource = logsToShow.Select(o => new
                {
                    LogId = o.LogId,
                    LogSource = o.LogSource,
                    ExceptionMag = o.ExceptionMsg,
                    Date = o.Date,
                    User = o.User.FullName

                }).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }


        }

        /// Filters the logs based on the selected user.
       
        /// If no user is selected, a message box will be displayed to prompt the user to select values to filter.
       
        private void btn_FilterLogs_Click(object sender, EventArgs e)
        {
            try
            {
                if (ddl_LogUser == null)
                {
                    MessageBox.Show("Select values to filter");
                }
                RefreshLog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }

        }

        ///Refreshes the log view.
        /// This method clears the selected user from the user dropdown list and refreshes the log view.
        /// If an exception occurs, a message box is displayed and the error is logged.
     
        private void btn_RefreshLogs_Click(object sender, EventArgs e)
        {
            try
            {
                ddl_LogUser.SelectedItem = null;
                RefreshLog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }

        }

        /// Refreshes the audits displayed in the DataGridView
        
        /// This method retrieves the audits from the database and filters them based on the selected user (if any).
        /// The resulting audits are then displayed in the DataGridView.
   
        private void RefreshAudits()
        {
            try
            {
                dgv_Audits.DataSource = null;

                var auditsToShow = context.AdvProjAudits.AsQueryable();

                if (ddlAduitUser.SelectedValue != null)
                {
                    auditsToShow = context.AdvProjAudits.Where(x => x.UserId.ToString() == ddlAduitUser.SelectedValue.ToString());
                }
                dgv_Audits.DataSource = auditsToShow.Select(o => new
                {
                    AuditId = o.AuditId,
                    AuditSource = o.AuditSource,
                    Type = o.ChnageType,
                    EntityName = o.EntityName,
                    oldValue = o.OldValue,
                    newValue = o.NewValue,
                    RecordId = o.RecordId,
                    User = o.User.FullName
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }
        }

        /// Handles the click event of a button to filter audit records.
    
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ddlAduitUser == null)
                {
                    MessageBox.Show("Select values to filter");
                }
                RefreshAudits();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }

        }

        ///Event handler for the click event of button2.
 
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ddlAduitUser.SelectedItem = null;
                RefreshAudits();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error, please contact your admin");
                LogsAudits.addLog("Forms", ex.Message.ToString(), Global.loggedUser.UserId);
            }
        }
    }
}
