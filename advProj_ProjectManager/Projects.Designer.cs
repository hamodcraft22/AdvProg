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
            ddl_Users = new ComboBox();
            btn_Filter = new Button();
            bt_Clear = new Button();
            btn_CreateProject = new Button();
            btn_UpdateProject = new Button();
            btn_DeleteProject = new Button();
            btn_ViewProject = new Button();
            lbl_SearchProject = new Label();
            txt_SearchProject = new TextBox();
            lbl_ProjectStatus = new Label();
            ddl_ProjectStatus = new ComboBox();
            btn_Return = new Button();
            groupBox1 = new GroupBox();
            lbl_CompletedProjects = new Label();
            lbl_AssignedProjects = new Label();
            lblNumberOfCompletedProjects = new Label();
            lblNumberofOverDueProjects = new Label();
            lblCompletedProjects = new Label();
            lblOverDueProjects = new Label();
            lblNumberofProjects = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_ProjectsView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_ProjectsView
            // 
            lbl_ProjectsView.AutoSize = true;
            lbl_ProjectsView.Location = new Point(650, 87);
            lbl_ProjectsView.Margin = new Padding(6, 0, 6, 0);
            lbl_ProjectsView.Name = "lbl_ProjectsView";
            lbl_ProjectsView.Size = new Size(0, 32);
            lbl_ProjectsView.TabIndex = 0;
            // 
            // dgv_ProjectsView
            // 
            dgv_ProjectsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ProjectsView.Location = new Point(414, 149);
            dgv_ProjectsView.Margin = new Padding(6);
            dgv_ProjectsView.Name = "dgv_ProjectsView";
            dgv_ProjectsView.RowHeadersWidth = 51;
            dgv_ProjectsView.RowTemplate.Height = 25;
            dgv_ProjectsView.Size = new Size(1410, 751);
            dgv_ProjectsView.TabIndex = 1;
            // 
            // lbl_User
            // 
            lbl_User.AutoSize = true;
            lbl_User.Location = new Point(612, 47);
            lbl_User.Margin = new Padding(6, 0, 6, 0);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new Size(176, 32);
            lbl_User.TabIndex = 2;
            lbl_User.Text = "Filter by Users :";
            // 
            // ddl_Users
            // 
            ddl_Users.FormattingEnabled = true;
            ddl_Users.Location = new Point(801, 44);
            ddl_Users.Margin = new Padding(6);
            ddl_Users.Name = "ddl_Users";
            ddl_Users.Size = new Size(221, 40);
            ddl_Users.TabIndex = 4;
            // 
            // btn_Filter
            // 
            btn_Filter.BackColor = SystemColors.GradientActiveCaption;
            btn_Filter.Location = new Point(1489, 30);
            btn_Filter.Margin = new Padding(6);
            btn_Filter.Name = "btn_Filter";
            btn_Filter.Size = new Size(139, 60);
            btn_Filter.TabIndex = 6;
            btn_Filter.Text = "Filter";
            btn_Filter.UseVisualStyleBackColor = false;
            btn_Filter.Click += btn_Filter_Click;
            // 
            // bt_Clear
            // 
            bt_Clear.BackColor = SystemColors.GradientActiveCaption;
            bt_Clear.Location = new Point(1645, 30);
            bt_Clear.Margin = new Padding(6);
            bt_Clear.Name = "bt_Clear";
            bt_Clear.Size = new Size(139, 60);
            bt_Clear.TabIndex = 7;
            bt_Clear.Text = "Clear";
            bt_Clear.UseVisualStyleBackColor = false;
            bt_Clear.Click += bt_Clear_Click;
            // 
            // btn_CreateProject
            // 
            btn_CreateProject.BackColor = SystemColors.GradientActiveCaption;
            btn_CreateProject.Location = new Point(1162, 930);
            btn_CreateProject.Margin = new Padding(6);
            btn_CreateProject.Name = "btn_CreateProject";
            btn_CreateProject.Size = new Size(206, 83);
            btn_CreateProject.TabIndex = 8;
            btn_CreateProject.Text = "Create Project";
            btn_CreateProject.UseVisualStyleBackColor = false;
            btn_CreateProject.Click += btn_CreateProject_Click;
            // 
            // btn_UpdateProject
            // 
            btn_UpdateProject.BackColor = SystemColors.GradientActiveCaption;
            btn_UpdateProject.Location = new Point(1398, 930);
            btn_UpdateProject.Margin = new Padding(6);
            btn_UpdateProject.Name = "btn_UpdateProject";
            btn_UpdateProject.Size = new Size(212, 83);
            btn_UpdateProject.TabIndex = 9;
            btn_UpdateProject.Text = "Update Project";
            btn_UpdateProject.UseVisualStyleBackColor = false;
            btn_UpdateProject.Click += btn_UpdateProject_Click;
            // 
            // btn_DeleteProject
            // 
            btn_DeleteProject.BackColor = Color.IndianRed;
            btn_DeleteProject.Location = new Point(945, 930);
            btn_DeleteProject.Margin = new Padding(6);
            btn_DeleteProject.Name = "btn_DeleteProject";
            btn_DeleteProject.Size = new Size(189, 83);
            btn_DeleteProject.TabIndex = 10;
            btn_DeleteProject.Text = "Delete Project";
            btn_DeleteProject.UseVisualStyleBackColor = false;
            btn_DeleteProject.Click += btn_DeleteProject_Click;
            // 
            // btn_ViewProject
            // 
            btn_ViewProject.BackColor = SystemColors.GradientActiveCaption;
            btn_ViewProject.Location = new Point(1638, 930);
            btn_ViewProject.Margin = new Padding(6);
            btn_ViewProject.Name = "btn_ViewProject";
            btn_ViewProject.Size = new Size(186, 83);
            btn_ViewProject.TabIndex = 11;
            btn_ViewProject.Text = "View Project";
            btn_ViewProject.UseVisualStyleBackColor = false;
            btn_ViewProject.Click += btn_ViewProject_Click;
            // 
            // lbl_SearchProject
            // 
            lbl_SearchProject.AutoSize = true;
            lbl_SearchProject.Location = new Point(87, 47);
            lbl_SearchProject.Margin = new Padding(6, 0, 6, 0);
            lbl_SearchProject.Name = "lbl_SearchProject";
            lbl_SearchProject.Size = new Size(165, 32);
            lbl_SearchProject.TabIndex = 14;
            lbl_SearchProject.Text = "Search Project";
            // 
            // txt_SearchProject
            // 
            txt_SearchProject.Location = new Point(279, 42);
            txt_SearchProject.Margin = new Padding(6);
            txt_SearchProject.Name = "txt_SearchProject";
            txt_SearchProject.Size = new Size(297, 39);
            txt_SearchProject.TabIndex = 16;
            // 
            // lbl_ProjectStatus
            // 
            lbl_ProjectStatus.AutoSize = true;
            lbl_ProjectStatus.Location = new Point(1051, 47);
            lbl_ProjectStatus.Margin = new Padding(6, 0, 6, 0);
            lbl_ProjectStatus.Name = "lbl_ProjectStatus";
            lbl_ProjectStatus.Size = new Size(176, 32);
            lbl_ProjectStatus.TabIndex = 17;
            lbl_ProjectStatus.Text = "Filter by Status:";
            // 
            // ddl_ProjectStatus
            // 
            ddl_ProjectStatus.FormattingEnabled = true;
            ddl_ProjectStatus.Location = new Point(1239, 43);
            ddl_ProjectStatus.Margin = new Padding(6);
            ddl_ProjectStatus.Name = "ddl_ProjectStatus";
            ddl_ProjectStatus.Size = new Size(221, 40);
            ddl_ProjectStatus.TabIndex = 18;
            // 
            // btn_Return
            // 
            btn_Return.BackColor = SystemColors.GradientActiveCaption;
            btn_Return.Location = new Point(41, 930);
            btn_Return.Margin = new Padding(6);
            btn_Return.Name = "btn_Return";
            btn_Return.Size = new Size(175, 83);
            btn_Return.TabIndex = 19;
            btn_Return.Text = "Return";
            btn_Return.UseVisualStyleBackColor = false;
            btn_Return.Click += btn_Return_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_User);
            groupBox1.Controls.Add(ddl_Users);
            groupBox1.Controls.Add(lbl_ProjectStatus);
            groupBox1.Controls.Add(ddl_ProjectStatus);
            groupBox1.Controls.Add(btn_Filter);
            groupBox1.Controls.Add(bt_Clear);
            groupBox1.Controls.Add(txt_SearchProject);
            groupBox1.Controls.Add(lbl_SearchProject);
            groupBox1.Location = new Point(22, 13);
            groupBox1.Margin = new Padding(6, 4, 6, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 4, 6, 4);
            groupBox1.Size = new Size(1801, 107);
            groupBox1.TabIndex = 62;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filters";
            // 
            // lbl_CompletedProjects
            // 
            lbl_CompletedProjects.AutoSize = true;
            lbl_CompletedProjects.Location = new Point(76, 700);
            lbl_CompletedProjects.Margin = new Padding(6, 0, 6, 0);
            lbl_CompletedProjects.Name = "lbl_CompletedProjects";
            lbl_CompletedProjects.Size = new Size(0, 32);
            lbl_CompletedProjects.TabIndex = 54;
            // 
            // lbl_AssignedProjects
            // 
            lbl_AssignedProjects.AutoSize = true;
            lbl_AssignedProjects.Location = new Point(76, 759);
            lbl_AssignedProjects.Margin = new Padding(6, 0, 6, 0);
            lbl_AssignedProjects.Name = "lbl_AssignedProjects";
            lbl_AssignedProjects.Size = new Size(0, 32);
            lbl_AssignedProjects.TabIndex = 58;
            // 
            // lblNumberOfCompletedProjects
            // 
            lblNumberOfCompletedProjects.AutoSize = true;
            lblNumberOfCompletedProjects.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumberOfCompletedProjects.Location = new Point(174, 732);
            lblNumberOfCompletedProjects.Margin = new Padding(6, 0, 6, 0);
            lblNumberOfCompletedProjects.Name = "lblNumberOfCompletedProjects";
            lblNumberOfCompletedProjects.Size = new Size(43, 50);
            lblNumberOfCompletedProjects.TabIndex = 91;
            lblNumberOfCompletedProjects.Text = "0";
            // 
            // lblNumberofOverDueProjects
            // 
            lblNumberofOverDueProjects.AutoSize = true;
            lblNumberofOverDueProjects.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumberofOverDueProjects.Location = new Point(172, 542);
            lblNumberofOverDueProjects.Margin = new Padding(6, 0, 6, 0);
            lblNumberofOverDueProjects.Name = "lblNumberofOverDueProjects";
            lblNumberofOverDueProjects.Size = new Size(43, 50);
            lblNumberofOverDueProjects.TabIndex = 90;
            lblNumberofOverDueProjects.Text = "0";
            // 
            // lblCompletedProjects
            // 
            lblCompletedProjects.AutoSize = true;
            lblCompletedProjects.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblCompletedProjects.Location = new Point(71, 674);
            lblCompletedProjects.Margin = new Padding(6, 0, 6, 0);
            lblCompletedProjects.Name = "lblCompletedProjects";
            lblCompletedProjects.Size = new Size(258, 38);
            lblCompletedProjects.TabIndex = 89;
            lblCompletedProjects.Text = "Completed Projects";
            // 
            // lblOverDueProjects
            // 
            lblOverDueProjects.AutoSize = true;
            lblOverDueProjects.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblOverDueProjects.Location = new Point(86, 477);
            lblOverDueProjects.Margin = new Padding(6, 0, 6, 0);
            lblOverDueProjects.Name = "lblOverDueProjects";
            lblOverDueProjects.Size = new Size(229, 38);
            lblOverDueProjects.TabIndex = 88;
            lblOverDueProjects.Text = "Overdue Projects";
            // 
            // lblNumberofProjects
            // 
            lblNumberofProjects.AutoSize = true;
            lblNumberofProjects.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumberofProjects.Location = new Point(178, 331);
            lblNumberofProjects.Margin = new Padding(6, 0, 6, 0);
            lblNumberofProjects.Name = "lblNumberofProjects";
            lblNumberofProjects.Size = new Size(43, 50);
            lblNumberofProjects.TabIndex = 93;
            lblNumberofProjects.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(111, 265);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(166, 38);
            label3.TabIndex = 92;
            label3.Text = "No. Projects";
            // 
            // ProjectsView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1870, 1045);
            Controls.Add(lblNumberofProjects);
            Controls.Add(label3);
            Controls.Add(lblNumberOfCompletedProjects);
            Controls.Add(lblNumberofOverDueProjects);
            Controls.Add(lblCompletedProjects);
            Controls.Add(lblOverDueProjects);
            Controls.Add(groupBox1);
            Controls.Add(lbl_AssignedProjects);
            Controls.Add(lbl_CompletedProjects);
            Controls.Add(btn_Return);
            Controls.Add(btn_ViewProject);
            Controls.Add(btn_DeleteProject);
            Controls.Add(btn_UpdateProject);
            Controls.Add(btn_CreateProject);
            Controls.Add(dgv_ProjectsView);
            Controls.Add(lbl_ProjectsView);
            Margin = new Padding(6);
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
        private ComboBox ddl_Users;
        private Button btn_Filter;
        private Button bt_Clear;
        private Button btn_CreateProject;
        private Button btn_UpdateProject;
        private Button btn_DeleteProject;
        private Button btn_ViewProject;
        private Label lbl_SearchProject;
        private TextBox txt_SearchProject;
        private Label lbl_ProjectStatus;
        private ComboBox ddl_ProjectStatus;
        private Button btn_Return;
        private GroupBox groupBox1;
        private Label lbl_CompletedProjects;
        private Label lbl_AssignedProjects;
        private Label lblNumberOfCompletedProjects;
        private Label lblNumberofOverDueProjects;
        private Label lblCompletedProjects;
        private Label lblOverDueProjects;
        private Label lblNumberofProjects;
        private Label label3;
    }
}