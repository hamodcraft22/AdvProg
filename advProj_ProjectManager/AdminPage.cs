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
    public partial class ShowInfo : Form
    {
        AdvProg_DatabaseContext context;
        HomePage homePage;
        public ShowInfo()
        {
            InitializeComponent();
            context = new AdvProg_DatabaseContext();
        }
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

        private void ShowInfo_Load(object sender, EventArgs e)
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

        public void RefreshLog()
        {
            dgv_Logs.DataSource = null;

            var logsToShow = context.AdvProjLogs.AsQueryable();
            try
            {
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
                MessageBox.Show("Error " + ex);
            }
        }

        private void btn_FilterLogs_Click(object sender, EventArgs e)
        {
            if (ddl_LogUser == null)
            {
                MessageBox.Show("Select values to filter");
            }
            RefreshLog();
        }

        private void btn_RefreshLogs_Click(object sender, EventArgs e)
        {
            ddl_LogUser.SelectedItem = null;
            RefreshLog();
        }

        private void RefreshAudits()
        {
            dgv_Audits.DataSource = null;

            var auditsToShow = context.AdvProjAudits.AsQueryable();
            try
            {
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
                MessageBox.Show("Error " + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ddlAduitUser == null)
            {
                MessageBox.Show("Select values to filter");
            }
            RefreshAudits();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ddlAduitUser.SelectedItem = null;
            RefreshAudits();
        }
    }
}
