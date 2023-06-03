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
    public partial class ProjectsView : Form
    {
        public ProjectsView()
        {
            InitializeComponent();
        }

        private void lbl_NumberOfManagedProjects_Click(object sender, EventArgs e)
        {

        }

        private void ddl_Users_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProjectsView_Load(object sender, EventArgs e)
        {
            ddl_Users.DataSource = new List<string>();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }
    }
}
