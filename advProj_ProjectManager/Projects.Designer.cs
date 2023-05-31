namespace advProj_ProjectManager
{
    partial class Projects
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
            lbl_Project = new Label();
            dgv_Projects = new DataGridView();
            lbl_User = new Label();
            lbl_Projects = new Label();
            ddl_Users = new ComboBox();
            ddl_Projects = new ComboBox();
            btn_Filter = new Button();
            bt_Refresh = new Button();
            btn_CreateProject = new Button();
            btn_UpdateProject = new Button();
            btn_DeleteProject = new Button();
            btn_ViewTasks = new Button();
            btn_ViewProfile = new Button();
            btn_LogOut = new Button();
            btn_ViewLogs = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Projects).BeginInit();
            SuspendLayout();
            // 
            // lbl_Project
            // 
            lbl_Project.AutoSize = true;
            lbl_Project.Location = new Point(351, 27);
            lbl_Project.Name = "lbl_Project";
            lbl_Project.Size = new Size(49, 15);
            lbl_Project.TabIndex = 0;
            lbl_Project.Text = "Projects";
            // 
            // dgv_Projects
            // 
            dgv_Projects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Projects.Location = new Point(219, 65);
            dgv_Projects.Name = "dgv_Projects";
            dgv_Projects.RowTemplate.Height = 25;
            dgv_Projects.Size = new Size(546, 296);
            dgv_Projects.TabIndex = 1;
            // 
            // lbl_User
            // 
            lbl_User.AutoSize = true;
            lbl_User.Location = new Point(24, 85);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new Size(86, 15);
            lbl_User.TabIndex = 2;
            lbl_User.Text = "Filter by Users :";
            // 
            // lbl_Projects
            // 
            lbl_Projects.AutoSize = true;
            lbl_Projects.Location = new Point(24, 160);
            lbl_Projects.Name = "lbl_Projects";
            lbl_Projects.Size = new Size(94, 15);
            lbl_Projects.TabIndex = 3;
            lbl_Projects.Text = "Filter by Projects";
            // 
            // ddl_Users
            // 
            ddl_Users.FormattingEnabled = true;
            ddl_Users.Location = new Point(24, 112);
            ddl_Users.Name = "ddl_Users";
            ddl_Users.Size = new Size(121, 23);
            ddl_Users.TabIndex = 4;
            // 
            // ddl_Projects
            // 
            ddl_Projects.FormattingEnabled = true;
            ddl_Projects.Location = new Point(24, 192);
            ddl_Projects.Name = "ddl_Projects";
            ddl_Projects.Size = new Size(121, 23);
            ddl_Projects.TabIndex = 5;
            // 
            // btn_Filter
            // 
            btn_Filter.Location = new Point(24, 252);
            btn_Filter.Name = "btn_Filter";
            btn_Filter.Size = new Size(75, 23);
            btn_Filter.TabIndex = 6;
            btn_Filter.Text = "Filter";
            btn_Filter.UseVisualStyleBackColor = true;
            // 
            // bt_Refresh
            // 
            bt_Refresh.Location = new Point(24, 296);
            bt_Refresh.Name = "bt_Refresh";
            bt_Refresh.Size = new Size(75, 23);
            bt_Refresh.TabIndex = 7;
            bt_Refresh.Text = "Refresh";
            bt_Refresh.UseVisualStyleBackColor = true;
            // 
            // btn_CreateProject
            // 
            btn_CreateProject.Location = new Point(654, 395);
            btn_CreateProject.Name = "btn_CreateProject";
            btn_CreateProject.Size = new Size(111, 23);
            btn_CreateProject.TabIndex = 8;
            btn_CreateProject.Text = "Create Project";
            btn_CreateProject.UseVisualStyleBackColor = true;
            // 
            // btn_UpdateProject
            // 
            btn_UpdateProject.Location = new Point(548, 395);
            btn_UpdateProject.Name = "btn_UpdateProject";
            btn_UpdateProject.Size = new Size(93, 23);
            btn_UpdateProject.TabIndex = 9;
            btn_UpdateProject.Text = "Update Project";
            btn_UpdateProject.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteProject
            // 
            btn_DeleteProject.Location = new Point(445, 395);
            btn_DeleteProject.Name = "btn_DeleteProject";
            btn_DeleteProject.Size = new Size(97, 23);
            btn_DeleteProject.TabIndex = 10;
            btn_DeleteProject.Text = "Delete Project";
            btn_DeleteProject.UseVisualStyleBackColor = true;
            // 
            // btn_ViewTasks
            // 
            btn_ViewTasks.Location = new Point(341, 395);
            btn_ViewTasks.Name = "btn_ViewTasks";
            btn_ViewTasks.Size = new Size(86, 23);
            btn_ViewTasks.TabIndex = 11;
            btn_ViewTasks.Text = "View Tasks";
            btn_ViewTasks.UseVisualStyleBackColor = true;
            // 
            // btn_ViewProfile
            // 
            btn_ViewProfile.Location = new Point(20, 375);
            btn_ViewProfile.Name = "btn_ViewProfile";
            btn_ViewProfile.Size = new Size(98, 23);
            btn_ViewProfile.TabIndex = 12;
            btn_ViewProfile.Text = "View Profile";
            btn_ViewProfile.UseVisualStyleBackColor = true;
            // 
            // btn_LogOut
            // 
            btn_LogOut.Location = new Point(24, 404);
            btn_LogOut.Name = "btn_LogOut";
            btn_LogOut.Size = new Size(94, 22);
            btn_LogOut.TabIndex = 13;
            btn_LogOut.Text = "Log-Out";
            btn_LogOut.UseVisualStyleBackColor = true;
            // 
            // btn_ViewLogs
            // 
            btn_ViewLogs.Location = new Point(24, 27);
            btn_ViewLogs.Name = "btn_ViewLogs";
            btn_ViewLogs.Size = new Size(75, 23);
            btn_ViewLogs.TabIndex = 14;
            btn_ViewLogs.Text = "View Logs";
            btn_ViewLogs.UseVisualStyleBackColor = true;
            // 
            // Projects
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_ViewLogs);
            Controls.Add(btn_LogOut);
            Controls.Add(btn_ViewProfile);
            Controls.Add(btn_ViewTasks);
            Controls.Add(btn_DeleteProject);
            Controls.Add(btn_UpdateProject);
            Controls.Add(btn_CreateProject);
            Controls.Add(bt_Refresh);
            Controls.Add(btn_Filter);
            Controls.Add(ddl_Projects);
            Controls.Add(ddl_Users);
            Controls.Add(lbl_Projects);
            Controls.Add(lbl_User);
            Controls.Add(dgv_Projects);
            Controls.Add(lbl_Project);
            Name = "Projects";
            Text = "Projects";
            ((System.ComponentModel.ISupportInitialize)dgv_Projects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Project;
        private DataGridView dgv_Projects;
        private Label lbl_User;
        private Label lbl_Projects;
        private ComboBox ddl_Users;
        private ComboBox ddl_Projects;
        private Button btn_Filter;
        private Button bt_Refresh;
        private Button btn_CreateProject;
        private Button btn_UpdateProject;
        private Button btn_DeleteProject;
        private Button btn_ViewTasks;
        private Button btn_ViewProfile;
        private Button btn_LogOut;
        private Button btn_ViewLogs;
    }
}