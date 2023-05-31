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
            btn_LogOut = new Button();
            lbl_SearchProject = new Label();
            btn_SearchProject = new Button();
            txt_SearchProject = new TextBox();
            lbl_ProjectStatus = new Label();
            ddl_ProjectStatus = new ComboBox();
            btn_Return = new Button();
            lbl_AssignedProjects = new Label();
            lbl_ProgectsManaged = new Label();
            lbl_NumberofCompletedProjects = new Label();
            lbl_CompletedProjects = new Label();
            lbl_NumberOfProjects = new Label();
            lbl_Project = new Label();
            lbl_NumberOfManagedProjects = new Label();
            lbl_NumberOfAssignedProjects = new Label();
            ddl_ProjectStartDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgv_ProjectsView).BeginInit();
            SuspendLayout();
            // 
            // lbl_ProjectsView
            // 
            lbl_ProjectsView.AutoSize = true;
            lbl_ProjectsView.Location = new Point(350, 41);
            lbl_ProjectsView.Name = "lbl_ProjectsView";
            lbl_ProjectsView.Size = new Size(77, 15);
            lbl_ProjectsView.TabIndex = 0;
            lbl_ProjectsView.Text = "Projects View";
            // 
            // dgv_ProjectsView
            // 
            dgv_ProjectsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ProjectsView.Location = new Point(204, 66);
            dgv_ProjectsView.Name = "dgv_ProjectsView";
            dgv_ProjectsView.RowTemplate.Height = 25;
            dgv_ProjectsView.Size = new Size(546, 296);
            dgv_ProjectsView.TabIndex = 1;
            // 
            // lbl_User
            // 
            lbl_User.AutoSize = true;
            lbl_User.Location = new Point(12, 134);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new Size(86, 15);
            lbl_User.TabIndex = 2;
            lbl_User.Text = "Filter by Users :";
            // 
            // lbl_ProjectStartDate
            // 
            lbl_ProjectStartDate.AutoSize = true;
            lbl_ProjectStartDate.Location = new Point(6, 194);
            lbl_ProjectStartDate.Name = "lbl_ProjectStartDate";
            lbl_ProjectStartDate.Size = new Size(103, 15);
            lbl_ProjectStartDate.TabIndex = 3;
            lbl_ProjectStartDate.Text = "Filter by StartDate:";
            // 
            // ddl_Users
            // 
            ddl_Users.FormattingEnabled = true;
            ddl_Users.Location = new Point(6, 152);
            ddl_Users.Name = "ddl_Users";
            ddl_Users.Size = new Size(121, 23);
            ddl_Users.TabIndex = 4;
            // 
            // btn_Filter
            // 
            btn_Filter.Location = new Point(4, 350);
            btn_Filter.Name = "btn_Filter";
            btn_Filter.Size = new Size(75, 23);
            btn_Filter.TabIndex = 6;
            btn_Filter.Text = "Filter";
            btn_Filter.UseVisualStyleBackColor = true;
            // 
            // bt_Refresh
            // 
            bt_Refresh.Location = new Point(85, 350);
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
            // btn_ViewProject
            // 
            btn_ViewProject.Location = new Point(341, 395);
            btn_ViewProject.Name = "btn_ViewProject";
            btn_ViewProject.Size = new Size(86, 23);
            btn_ViewProject.TabIndex = 11;
            btn_ViewProject.Text = "View Project";
            btn_ViewProject.UseVisualStyleBackColor = true;
            // 
            // btn_LogOut
            // 
            btn_LogOut.Location = new Point(85, 396);
            btn_LogOut.Name = "btn_LogOut";
            btn_LogOut.Size = new Size(85, 22);
            btn_LogOut.TabIndex = 13;
            btn_LogOut.Text = "Log-Out";
            btn_LogOut.UseVisualStyleBackColor = true;
            // 
            // lbl_SearchProject
            // 
            lbl_SearchProject.AutoSize = true;
            lbl_SearchProject.Location = new Point(24, 41);
            lbl_SearchProject.Name = "lbl_SearchProject";
            lbl_SearchProject.Size = new Size(85, 15);
            lbl_SearchProject.TabIndex = 14;
            lbl_SearchProject.Text = "Search Project:";
            // 
            // btn_SearchProject
            // 
            btn_SearchProject.Location = new Point(115, 79);
            btn_SearchProject.Name = "btn_SearchProject";
            btn_SearchProject.Size = new Size(75, 23);
            btn_SearchProject.TabIndex = 15;
            btn_SearchProject.Text = "Search";
            btn_SearchProject.UseVisualStyleBackColor = true;
            // 
            // txt_SearchProject
            // 
            txt_SearchProject.Location = new Point(9, 79);
            txt_SearchProject.Name = "txt_SearchProject";
            txt_SearchProject.Size = new Size(100, 23);
            txt_SearchProject.TabIndex = 16;
            // 
            // lbl_ProjectStatus
            // 
            lbl_ProjectStatus.AutoSize = true;
            lbl_ProjectStatus.Location = new Point(6, 264);
            lbl_ProjectStatus.Name = "lbl_ProjectStatus";
            lbl_ProjectStatus.Size = new Size(87, 15);
            lbl_ProjectStatus.TabIndex = 17;
            lbl_ProjectStatus.Text = "Filter by Status:";
            // 
            // ddl_ProjectStatus
            // 
            ddl_ProjectStatus.FormattingEnabled = true;
            ddl_ProjectStatus.Location = new Point(4, 300);
            ddl_ProjectStatus.Name = "ddl_ProjectStatus";
            ddl_ProjectStatus.Size = new Size(121, 23);
            ddl_ProjectStatus.TabIndex = 18;
            // 
            // btn_Return
            // 
            btn_Return.Location = new Point(4, 395);
            btn_Return.Name = "btn_Return";
            btn_Return.Size = new Size(75, 23);
            btn_Return.TabIndex = 19;
            btn_Return.Text = "Return";
            btn_Return.UseVisualStyleBackColor = true;
            // 
            // lbl_AssignedProjects
            // 
            lbl_AssignedProjects.AutoSize = true;
            lbl_AssignedProjects.Location = new Point(382, 9);
            lbl_AssignedProjects.Name = "lbl_AssignedProjects";
            lbl_AssignedProjects.Size = new Size(100, 15);
            lbl_AssignedProjects.TabIndex = 58;
            lbl_AssignedProjects.Text = "Assigned Projects";
            // 
            // lbl_ProgectsManaged
            // 
            lbl_ProgectsManaged.AutoSize = true;
            lbl_ProgectsManaged.Location = new Point(182, 9);
            lbl_ProgectsManaged.Name = "lbl_ProgectsManaged";
            lbl_ProgectsManaged.Size = new Size(141, 15);
            lbl_ProgectsManaged.TabIndex = 56;
            lbl_ProgectsManaged.Text = "Projects Managed by Me:";
            // 
            // lbl_NumberofCompletedProjects
            // 
            lbl_NumberofCompletedProjects.AutoSize = true;
            lbl_NumberofCompletedProjects.Location = new Point(654, 9);
            lbl_NumberofCompletedProjects.Name = "lbl_NumberofCompletedProjects";
            lbl_NumberofCompletedProjects.Size = new Size(13, 15);
            lbl_NumberofCompletedProjects.TabIndex = 55;
            lbl_NumberofCompletedProjects.Text = "0";
            // 
            // lbl_CompletedProjects
            // 
            lbl_CompletedProjects.AutoSize = true;
            lbl_CompletedProjects.Location = new Point(527, 9);
            lbl_CompletedProjects.Name = "lbl_CompletedProjects";
            lbl_CompletedProjects.Size = new Size(114, 15);
            lbl_CompletedProjects.TabIndex = 54;
            lbl_CompletedProjects.Text = "Completed Projects:";
            // 
            // lbl_NumberOfProjects
            // 
            lbl_NumberOfProjects.AutoSize = true;
            lbl_NumberOfProjects.Location = new Point(147, 9);
            lbl_NumberOfProjects.Name = "lbl_NumberOfProjects";
            lbl_NumberOfProjects.Size = new Size(13, 15);
            lbl_NumberOfProjects.TabIndex = 53;
            lbl_NumberOfProjects.Text = "0";
            // 
            // lbl_Project
            // 
            lbl_Project.AutoSize = true;
            lbl_Project.Location = new Point(17, 9);
            lbl_Project.Name = "lbl_Project";
            lbl_Project.Size = new Size(113, 15);
            lbl_Project.TabIndex = 52;
            lbl_Project.Text = "Number of Projects:";
            // 
            // lbl_NumberOfManagedProjects
            // 
            lbl_NumberOfManagedProjects.AutoSize = true;
            lbl_NumberOfManagedProjects.Location = new Point(329, 9);
            lbl_NumberOfManagedProjects.Name = "lbl_NumberOfManagedProjects";
            lbl_NumberOfManagedProjects.Size = new Size(13, 15);
            lbl_NumberOfManagedProjects.TabIndex = 59;
            lbl_NumberOfManagedProjects.Text = "0";
            // 
            // lbl_NumberOfAssignedProjects
            // 
            lbl_NumberOfAssignedProjects.AutoSize = true;
            lbl_NumberOfAssignedProjects.Location = new Point(488, 9);
            lbl_NumberOfAssignedProjects.Name = "lbl_NumberOfAssignedProjects";
            lbl_NumberOfAssignedProjects.Size = new Size(13, 15);
            lbl_NumberOfAssignedProjects.TabIndex = 60;
            lbl_NumberOfAssignedProjects.Text = "0";
            // 
            // ddl_ProjectStartDate
            // 
            ddl_ProjectStartDate.Location = new Point(4, 212);
            ddl_ProjectStartDate.Name = "ddl_ProjectStartDate";
            ddl_ProjectStartDate.Size = new Size(186, 23);
            ddl_ProjectStartDate.TabIndex = 61;
            // 
            // ProjectsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ddl_ProjectStartDate);
            Controls.Add(lbl_NumberOfAssignedProjects);
            Controls.Add(lbl_NumberOfManagedProjects);
            Controls.Add(lbl_AssignedProjects);
            Controls.Add(lbl_ProgectsManaged);
            Controls.Add(lbl_NumberofCompletedProjects);
            Controls.Add(lbl_CompletedProjects);
            Controls.Add(lbl_NumberOfProjects);
            Controls.Add(lbl_Project);
            Controls.Add(btn_Return);
            Controls.Add(ddl_ProjectStatus);
            Controls.Add(lbl_ProjectStatus);
            Controls.Add(txt_SearchProject);
            Controls.Add(btn_SearchProject);
            Controls.Add(lbl_SearchProject);
            Controls.Add(btn_LogOut);
            Controls.Add(btn_ViewProject);
            Controls.Add(btn_DeleteProject);
            Controls.Add(btn_UpdateProject);
            Controls.Add(btn_CreateProject);
            Controls.Add(bt_Refresh);
            Controls.Add(btn_Filter);
            Controls.Add(ddl_Users);
            Controls.Add(lbl_ProjectStartDate);
            Controls.Add(lbl_User);
            Controls.Add(dgv_ProjectsView);
            Controls.Add(lbl_ProjectsView);
            Name = "ProjectsView";
            Text = "Projects View";
            ((System.ComponentModel.ISupportInitialize)dgv_ProjectsView).EndInit();
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
        private Button btn_LogOut;
        private Label lbl_SearchProject;
        private Button btn_SearchProject;
        private TextBox txt_SearchProject;
        private Label lbl_ProjectStatus;
        private ComboBox ddl_ProjectStatus;
        private Button btn_Return;
        private Label lbl_AssignedProjects;
        private Label lbl_ProgectsManaged;
        private Label lbl_NumberofCompletedProjects;
        private Label lbl_CompletedProjects;
        private Label lbl_NumberOfProjects;
        private Label lbl_Project;
        private Label lbl_NumberOfManagedProjects;
        private Label lbl_NumberOfAssignedProjects;
        private DateTimePicker ddl_ProjectStartDate;
    }
}