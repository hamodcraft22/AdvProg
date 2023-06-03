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
            lblNumberOfCompletedProjects = new Label();
            lblNumberofOverDueProjects = new Label();
            lblCompletedProjects = new Label();
            lblOverDueProjects = new Label();
            label1 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_ProjectsView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_ProjectsView
            // 
            lbl_ProjectsView.AutoSize = true;
            lbl_ProjectsView.Location = new Point(350, 41);
            lbl_ProjectsView.Name = "lbl_ProjectsView";
            lbl_ProjectsView.Size = new Size(0, 15);
            lbl_ProjectsView.TabIndex = 0;
            // 
            // dgv_ProjectsView
            // 
            dgv_ProjectsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ProjectsView.Location = new Point(223, 70);
            dgv_ProjectsView.Name = "dgv_ProjectsView";
            dgv_ProjectsView.RowHeadersWidth = 51;
            dgv_ProjectsView.RowTemplate.Height = 25;
            dgv_ProjectsView.Size = new Size(759, 352);
            dgv_ProjectsView.TabIndex = 1;
            // 
            // lbl_User
            // 
            lbl_User.AutoSize = true;
            lbl_User.Location = new Point(10, 22);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new Size(86, 15);
            lbl_User.TabIndex = 2;
            lbl_User.Text = "Filter by Users :";
            // 
            // lbl_ProjectStartDate
            // 
            lbl_ProjectStartDate.AutoSize = true;
            lbl_ProjectStartDate.Location = new Point(245, 22);
            lbl_ProjectStartDate.Name = "lbl_ProjectStartDate";
            lbl_ProjectStartDate.Size = new Size(103, 15);
            lbl_ProjectStartDate.TabIndex = 3;
            lbl_ProjectStartDate.Text = "Filter by StartDate:";
            // 
            // ddl_Users
            // 
            ddl_Users.FormattingEnabled = true;
            ddl_Users.Location = new Point(109, 19);
            ddl_Users.Name = "ddl_Users";
            ddl_Users.Size = new Size(121, 23);
            ddl_Users.TabIndex = 4;
            ddl_Users.SelectedIndexChanged += ddl_Users_SelectedIndexChanged;
            // 
            // btn_Filter
            // 
            btn_Filter.BackColor = SystemColors.GradientActiveCaption;
            btn_Filter.Location = new Point(802, 14);
            btn_Filter.Name = "btn_Filter";
            btn_Filter.Size = new Size(75, 28);
            btn_Filter.TabIndex = 6;
            btn_Filter.Text = "Filter";
            btn_Filter.UseVisualStyleBackColor = false;
            btn_Filter.Click += btn_Filter_Click;
            // 
            // bt_Refresh
            // 
            bt_Refresh.BackColor = SystemColors.GradientActiveCaption;
            bt_Refresh.Location = new Point(886, 14);
            bt_Refresh.Name = "bt_Refresh";
            bt_Refresh.Size = new Size(75, 28);
            bt_Refresh.TabIndex = 7;
            bt_Refresh.Text = "Refresh";
            bt_Refresh.UseVisualStyleBackColor = false;
            bt_Refresh.Click += bt_Refresh_Click;
            // 
            // btn_CreateProject
            // 
            btn_CreateProject.BackColor = SystemColors.GradientActiveCaption;
            btn_CreateProject.Location = new Point(871, 436);
            btn_CreateProject.Name = "btn_CreateProject";
            btn_CreateProject.Size = new Size(111, 39);
            btn_CreateProject.TabIndex = 8;
            btn_CreateProject.Text = "Create Project";
            btn_CreateProject.UseVisualStyleBackColor = false;
            btn_CreateProject.Click += btn_CreateProject_Click;
            // 
            // btn_UpdateProject
            // 
            btn_UpdateProject.BackColor = SystemColors.GradientActiveCaption;
            btn_UpdateProject.Location = new Point(743, 436);
            btn_UpdateProject.Name = "btn_UpdateProject";
            btn_UpdateProject.Size = new Size(114, 39);
            btn_UpdateProject.TabIndex = 9;
            btn_UpdateProject.Text = "Update Project";
            btn_UpdateProject.UseVisualStyleBackColor = false;
            btn_UpdateProject.Click += btn_UpdateProject_Click;
            // 
            // btn_DeleteProject
            // 
            btn_DeleteProject.BackColor = Color.IndianRed;
            btn_DeleteProject.Location = new Point(509, 436);
            btn_DeleteProject.Name = "btn_DeleteProject";
            btn_DeleteProject.Size = new Size(102, 39);
            btn_DeleteProject.TabIndex = 10;
            btn_DeleteProject.Text = "Delete Project";
            btn_DeleteProject.UseVisualStyleBackColor = false;
            btn_DeleteProject.Click += btn_DeleteProject_Click;
            // 
            // btn_ViewProject
            // 
            btn_ViewProject.BackColor = SystemColors.GradientActiveCaption;
            btn_ViewProject.Location = new Point(626, 436);
            btn_ViewProject.Name = "btn_ViewProject";
            btn_ViewProject.Size = new Size(100, 39);
            btn_ViewProject.TabIndex = 11;
            btn_ViewProject.Text = "View Project";
            btn_ViewProject.UseVisualStyleBackColor = false;
            btn_ViewProject.Click += btn_ViewProject_Click;
            // 
            // lbl_SearchProject
            // 
            lbl_SearchProject.AutoSize = true;
            lbl_SearchProject.Location = new Point(18, 84);
            lbl_SearchProject.Name = "lbl_SearchProject";
            lbl_SearchProject.Size = new Size(82, 15);
            lbl_SearchProject.TabIndex = 14;
            lbl_SearchProject.Text = "Search Project";
            // 
            // btn_SearchProject
            // 
            btn_SearchProject.BackColor = SystemColors.GradientActiveCaption;
            btn_SearchProject.Location = new Point(108, 136);
            btn_SearchProject.Name = "btn_SearchProject";
            btn_SearchProject.Size = new Size(75, 23);
            btn_SearchProject.TabIndex = 15;
            btn_SearchProject.Text = "Search";
            btn_SearchProject.UseVisualStyleBackColor = false;
            btn_SearchProject.Click += btn_SearchProject_Click;
            // 
            // txt_SearchProject
            // 
            txt_SearchProject.Location = new Point(22, 108);
            txt_SearchProject.Name = "txt_SearchProject";
            txt_SearchProject.Size = new Size(162, 23);
            txt_SearchProject.TabIndex = 16;
            // 
            // lbl_ProjectStatus
            // 
            lbl_ProjectStatus.AutoSize = true;
            lbl_ProjectStatus.Location = new Point(566, 22);
            lbl_ProjectStatus.Name = "lbl_ProjectStatus";
            lbl_ProjectStatus.Size = new Size(87, 15);
            lbl_ProjectStatus.TabIndex = 17;
            lbl_ProjectStatus.Text = "Filter by Status:";
            // 
            // ddl_ProjectStatus
            // 
            ddl_ProjectStatus.FormattingEnabled = true;
            ddl_ProjectStatus.Location = new Point(667, 20);
            ddl_ProjectStatus.Name = "ddl_ProjectStatus";
            ddl_ProjectStatus.Size = new Size(121, 23);
            ddl_ProjectStatus.TabIndex = 18;
            // 
            // btn_Return
            // 
            btn_Return.BackColor = SystemColors.GradientActiveCaption;
            btn_Return.Location = new Point(22, 436);
            btn_Return.Name = "btn_Return";
            btn_Return.Size = new Size(94, 39);
            btn_Return.TabIndex = 19;
            btn_Return.Text = "Return";
            btn_Return.UseVisualStyleBackColor = false;
            btn_Return.Click += btn_Return_Click;
            // 
            // ddl_ProjectStartDate
            // 
            ddl_ProjectStartDate.Location = new Point(364, 20);
            ddl_ProjectStartDate.Name = "ddl_ProjectStartDate";
            ddl_ProjectStartDate.Size = new Size(186, 23);
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
            groupBox1.Location = new Point(12, 6);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(970, 50);
            groupBox1.TabIndex = 62;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filters";
            // 
            // lbl_CompletedProjects
            // 
            lbl_CompletedProjects.AutoSize = true;
            lbl_CompletedProjects.Location = new Point(41, 328);
            lbl_CompletedProjects.Name = "lbl_CompletedProjects";
            lbl_CompletedProjects.Size = new Size(0, 15);
            lbl_CompletedProjects.TabIndex = 54;
            // 
            // lbl_AssignedProjects
            // 
            lbl_AssignedProjects.AutoSize = true;
            lbl_AssignedProjects.Location = new Point(41, 356);
            lbl_AssignedProjects.Name = "lbl_AssignedProjects";
            lbl_AssignedProjects.Size = new Size(0, 15);
            lbl_AssignedProjects.TabIndex = 58;
            // 
            // lblNumberOfCompletedProjects
            // 
            lblNumberOfCompletedProjects.AutoSize = true;
            lblNumberOfCompletedProjects.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumberOfCompletedProjects.Location = new Point(92, 338);
            lblNumberOfCompletedProjects.Name = "lblNumberOfCompletedProjects";
            lblNumberOfCompletedProjects.Size = new Size(23, 25);
            lblNumberOfCompletedProjects.TabIndex = 91;
            lblNumberOfCompletedProjects.Text = "0";
            lblNumberOfCompletedProjects.Click += label5_Click;
            // 
            // lblNumberofOverDueProjects
            // 
            lblNumberofOverDueProjects.AutoSize = true;
            lblNumberofOverDueProjects.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumberofOverDueProjects.Location = new Point(92, 262);
            lblNumberofOverDueProjects.Name = "lblNumberofOverDueProjects";
            lblNumberofOverDueProjects.Size = new Size(23, 25);
            lblNumberofOverDueProjects.TabIndex = 90;
            lblNumberofOverDueProjects.Text = "0";
            lblNumberofOverDueProjects.Click += label4_Click;
            // 
            // lblCompletedProjects
            // 
            lblCompletedProjects.AutoSize = true;
            lblCompletedProjects.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblCompletedProjects.Location = new Point(38, 316);
            lblCompletedProjects.Name = "lblCompletedProjects";
            lblCompletedProjects.Size = new Size(128, 19);
            lblCompletedProjects.TabIndex = 89;
            lblCompletedProjects.Text = "Completed Projects";
            lblCompletedProjects.Click += label3_Click;
            // 
            // lblOverDueProjects
            // 
            lblOverDueProjects.AutoSize = true;
            lblOverDueProjects.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblOverDueProjects.Location = new Point(45, 244);
            lblOverDueProjects.Name = "lblOverDueProjects";
            lblOverDueProjects.Size = new Size(114, 19);
            lblOverDueProjects.TabIndex = 88;
            lblOverDueProjects.Text = "Overdue Projects";
            lblOverDueProjects.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 372);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 87;
            label1.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 344);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 86;
            label6.Click += label6_Click;
            // 
            // ProjectsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1007, 490);
            Controls.Add(lblNumberOfCompletedProjects);
            Controls.Add(lblNumberofOverDueProjects);
            Controls.Add(lblCompletedProjects);
            Controls.Add(lblOverDueProjects);
            Controls.Add(label1);
            Controls.Add(label6);
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
        private Label lblNumberOfCompletedProjects;
        private Label lblNumberofOverDueProjects;
        private Label lblCompletedProjects;
        private Label lblOverDueProjects;
        private Label label1;
        private Label label6;
    }
}