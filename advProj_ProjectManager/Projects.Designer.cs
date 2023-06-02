namespace advProj_ProjectManager
{
    partial class ProjectsView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_ProjectsView = new Label();
            dgv_ProjectsView = new DataGridView();
            lbl_User = new Label();
            lbl_ProjectStartDate = new Label();
            ddl_Users = new ComboBox();
            btn_Filter = new Button();
            bt_Refresh = new Button();
            btn_CreateProject = new Button();
            btn_UpdateProject = new Button();
            btn_DeleteProject = new Button();
            btn_ViewProject = new Button();
            lbl_SearchProject = new Label();
            btn_SearchProject = new Button();
            txt_SearchProject = new TextBox();
            lbl_ProjectStatus = new Label();
            ddl_ProjectStatus = new ComboBox();
            btn_Return = new Button();
            ddl_ProjectStartDate = new DateTimePicker();
            groupBox1 = new GroupBox();
            lbl_CompletedProjects = new Label();
            lbl_AssignedProjects = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_ProjectsView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_ProjectsView
            // 
            lbl_ProjectsView.AutoSize = true;
            lbl_ProjectsView.Location = new Point(400, 55);
            lbl_ProjectsView.Name = "lbl_ProjectsView";
            lbl_ProjectsView.Size = new Size(0, 20);
            lbl_ProjectsView.TabIndex = 0;
            // 
            // dgv_ProjectsView
            // 
            dgv_ProjectsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ProjectsView.Location = new Point(255, 94);
            dgv_ProjectsView.Margin = new Padding(3, 4, 3, 4);
            dgv_ProjectsView.Name = "dgv_ProjectsView";
            dgv_ProjectsView.RowHeadersWidth = 51;
            dgv_ProjectsView.RowTemplate.Height = 25;
            dgv_ProjectsView.Size = new Size(867, 470);
            dgv_ProjectsView.TabIndex = 1;
            // 
            // lbl_User
            // 
            lbl_User.AutoSize = true;
            lbl_User.Location = new Point(11, 30);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new Size(108, 20);
            lbl_User.TabIndex = 2;
            lbl_User.Text = "Filter by Users :";
            // 
            // lbl_ProjectStartDate
            // 
            lbl_ProjectStartDate.AutoSize = true;
            lbl_ProjectStartDate.Location = new Point(280, 30);
            lbl_ProjectStartDate.Name = "lbl_ProjectStartDate";
            lbl_ProjectStartDate.Size = new Size(132, 20);
            lbl_ProjectStartDate.TabIndex = 3;
            lbl_ProjectStartDate.Text = "Filter by StartDate:";
            // 
            // ddl_Users
            // 
            ddl_Users.FormattingEnabled = true;
            ddl_Users.Location = new Point(125, 25);
            ddl_Users.Margin = new Padding(3, 4, 3, 4);
            ddl_Users.Name = "ddl_Users";
            ddl_Users.Size = new Size(138, 28);
            ddl_Users.TabIndex = 4;
            ddl_Users.SelectedIndexChanged += ddl_Users_SelectedIndexChanged;
            // 
            // btn_Filter
            // 
            btn_Filter.BackColor = SystemColors.GradientActiveCaption;
            btn_Filter.Location = new Point(917, 18);
            btn_Filter.Margin = new Padding(3, 4, 3, 4);
            btn_Filter.Name = "btn_Filter";
            btn_Filter.Size = new Size(86, 38);
            btn_Filter.TabIndex = 6;
            btn_Filter.Text = "Filter";
            btn_Filter.UseVisualStyleBackColor = false;
            // 
            // bt_Refresh
            // 
            bt_Refresh.BackColor = SystemColors.GradientActiveCaption;
            bt_Refresh.Location = new Point(1012, 18);
            bt_Refresh.Margin = new Padding(3, 4, 3, 4);
            bt_Refresh.Name = "bt_Refresh";
            bt_Refresh.Size = new Size(86, 38);
            bt_Refresh.TabIndex = 7;
            bt_Refresh.Text = "Refresh";
            bt_Refresh.UseVisualStyleBackColor = false;
            // 
            // btn_CreateProject
            // 
            btn_CreateProject.BackColor = SystemColors.GradientActiveCaption;
            btn_CreateProject.Location = new Point(995, 582);
            btn_CreateProject.Margin = new Padding(3, 4, 3, 4);
            btn_CreateProject.Name = "btn_CreateProject";
            btn_CreateProject.Size = new Size(127, 52);
            btn_CreateProject.TabIndex = 8;
            btn_CreateProject.Text = "Create Project";
            btn_CreateProject.UseVisualStyleBackColor = false;
            // 
            // btn_UpdateProject
            // 
            btn_UpdateProject.BackColor = SystemColors.GradientActiveCaption;
            btn_UpdateProject.Location = new Point(849, 582);
            btn_UpdateProject.Margin = new Padding(3, 4, 3, 4);
            btn_UpdateProject.Name = "btn_UpdateProject";
            btn_UpdateProject.Size = new Size(130, 52);
            btn_UpdateProject.TabIndex = 9;
            btn_UpdateProject.Text = "Update Project";
            btn_UpdateProject.UseVisualStyleBackColor = false;
            // 
            // btn_DeleteProject
            // 
            btn_DeleteProject.BackColor = Color.IndianRed;
            btn_DeleteProject.Location = new Point(582, 582);
            btn_DeleteProject.Margin = new Padding(3, 4, 3, 4);
            btn_DeleteProject.Name = "btn_DeleteProject";
            btn_DeleteProject.Size = new Size(116, 52);
            btn_DeleteProject.TabIndex = 10;
            btn_DeleteProject.Text = "Delete Project";
            btn_DeleteProject.UseVisualStyleBackColor = false;
            // 
            // btn_ViewProject
            // 
            btn_ViewProject.BackColor = SystemColors.GradientActiveCaption;
            btn_ViewProject.Location = new Point(716, 582);
            btn_ViewProject.Margin = new Padding(3, 4, 3, 4);
            btn_ViewProject.Name = "btn_ViewProject";
            btn_ViewProject.Size = new Size(114, 52);
            btn_ViewProject.TabIndex = 11;
            btn_ViewProject.Text = "View Project";
            btn_ViewProject.UseVisualStyleBackColor = false;
            // 
            // lbl_SearchProject
            // 
            lbl_SearchProject.AutoSize = true;
            lbl_SearchProject.Location = new Point(20, 112);
            lbl_SearchProject.Name = "lbl_SearchProject";
            lbl_SearchProject.Size = new Size(103, 20);
            lbl_SearchProject.TabIndex = 14;
            lbl_SearchProject.Text = "Search Project";
            // 
            // btn_SearchProject
            // 
            btn_SearchProject.BackColor = SystemColors.GradientActiveCaption;
            btn_SearchProject.Location = new Point(123, 182);
            btn_SearchProject.Margin = new Padding(3, 4, 3, 4);
            btn_SearchProject.Name = "btn_SearchProject";
            btn_SearchProject.Size = new Size(86, 31);
            btn_SearchProject.TabIndex = 15;
            btn_SearchProject.Text = "Search";
            btn_SearchProject.UseVisualStyleBackColor = false;
            // 
            // txt_SearchProject
            // 
            txt_SearchProject.Location = new Point(25, 144);
            txt_SearchProject.Margin = new Padding(3, 4, 3, 4);
            txt_SearchProject.Name = "txt_SearchProject";
            txt_SearchProject.Size = new Size(184, 27);
            txt_SearchProject.TabIndex = 16;
            // 
            // lbl_ProjectStatus
            // 
            lbl_ProjectStatus.AutoSize = true;
            lbl_ProjectStatus.Location = new Point(647, 30);
            lbl_ProjectStatus.Name = "lbl_ProjectStatus";
            lbl_ProjectStatus.Size = new Size(109, 20);
            lbl_ProjectStatus.TabIndex = 17;
            lbl_ProjectStatus.Text = "Filter by Status:";
            // 
            // ddl_ProjectStatus
            // 
            ddl_ProjectStatus.FormattingEnabled = true;
            ddl_ProjectStatus.Location = new Point(762, 26);
            ddl_ProjectStatus.Margin = new Padding(3, 4, 3, 4);
            ddl_ProjectStatus.Name = "ddl_ProjectStatus";
            ddl_ProjectStatus.Size = new Size(138, 28);
            ddl_ProjectStatus.TabIndex = 18;
            // 
            // btn_Return
            // 
            btn_Return.BackColor = SystemColors.GradientActiveCaption;
            btn_Return.Location = new Point(25, 582);
            btn_Return.Margin = new Padding(3, 4, 3, 4);
            btn_Return.Name = "btn_Return";
            btn_Return.Size = new Size(108, 52);
            btn_Return.TabIndex = 19;
            btn_Return.Text = "Return";
            btn_Return.UseVisualStyleBackColor = false;
            // 
            // ddl_ProjectStartDate
            // 
            ddl_ProjectStartDate.Location = new Point(416, 26);
            ddl_ProjectStartDate.Margin = new Padding(3, 4, 3, 4);
            ddl_ProjectStartDate.Name = "ddl_ProjectStartDate";
            ddl_ProjectStartDate.Size = new Size(212, 27);
            ddl_ProjectStartDate.TabIndex = 61;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_User);
            groupBox1.Controls.Add(ddl_ProjectStartDate);
            groupBox1.Controls.Add(ddl_Users);
            groupBox1.Controls.Add(lbl_ProjectStartDate);
            groupBox1.Controls.Add(lbl_ProjectStatus);
            groupBox1.Controls.Add(ddl_ProjectStatus);
            groupBox1.Controls.Add(btn_Filter);
            groupBox1.Controls.Add(bt_Refresh);
            groupBox1.Location = new Point(14, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1108, 67);
            groupBox1.TabIndex = 62;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filters";
            // 
            // lbl_CompletedProjects
            // 
            lbl_CompletedProjects.AutoSize = true;
            lbl_CompletedProjects.Location = new Point(47, 438);
            lbl_CompletedProjects.Name = "lbl_CompletedProjects";
            lbl_CompletedProjects.Size = new Size(0, 20);
            lbl_CompletedProjects.TabIndex = 54;
            // 
            // lbl_AssignedProjects
            // 
            lbl_AssignedProjects.AutoSize = true;
            lbl_AssignedProjects.Location = new Point(47, 475);
            lbl_AssignedProjects.Name = "lbl_AssignedProjects";
            lbl_AssignedProjects.Size = new Size(0, 20);
            lbl_AssignedProjects.TabIndex = 58;
            // 
            // ProjectsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1151, 653);
            Controls.Add(groupBox1);
            Controls.Add(lbl_AssignedProjects);
            Controls.Add(lbl_CompletedProjects);
            Controls.Add(btn_Return);
            Controls.Add(txt_SearchProject);
            Controls.Add(btn_SearchProject);
            Controls.Add(lbl_SearchProject);
            Controls.Add(btn_ViewProject);
            Controls.Add(btn_DeleteProject);
            Controls.Add(btn_UpdateProject);
            Controls.Add(btn_CreateProject);
            Controls.Add(dgv_ProjectsView);
            Controls.Add(lbl_ProjectsView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProjectsView";
            Text = "Projects View";
            Load += ProjectsView_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_ProjectsView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_ProjectsView;
        private DataGridView dgv_ProjectsView;
        private Label lbl_User;
        private Label lbl_ProjectStartDate;
        private ComboBox ddl_Users;
        private Button btn_Filter;
        private Button bt_Refresh;
        private Button btn_CreateProject;
        private Button btn_UpdateProject;
        private Button btn_DeleteProject;
        private Button btn_ViewProject;
        private Label lbl_SearchProject;
        private Button btn_SearchProject;
        private TextBox txt_SearchProject;
        private Label lbl_ProjectStatus;
        private ComboBox ddl_ProjectStatus;
        private Button btn_Return;
        private DateTimePicker ddl_ProjectStartDate;
        private GroupBox groupBox1;
        private Label lbl_CompletedProjects;
        private Label lbl_AssignedProjects;
    }
}