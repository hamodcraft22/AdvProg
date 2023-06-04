namespace advProj_ProjectManager
{
    partial class ProjectView
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
            dgv_Tasks = new DataGridView();
            lbl_SearchTask = new Label();
            txt_SearchTask = new TextBox();
            lbl_User = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            ddl_Users = new ComboBox();
            lbl_ProjectStatus = new Label();
            ddl_ProjectStatus = new ComboBox();
            btn_Filter = new Button();
            btn_Clear = new Button();
            btn_Return = new Button();
            btn_ViewProject = new Button();
            btn_DeleteProject = new Button();
            btn_UpdateProject = new Button();
            btn_CreateProject = new Button();
            lbl_AssignedProjects = new Label();
            lbl_CompletedProjects = new Label();
            lblOverDueTasks = new Label();
            lblCompletedTasks = new Label();
            lblNumberOfOverDueTasks = new Label();
            lblNumberOfCompletedTasks = new Label();
            lblNumberOfTask = new Label();
            lbl_NoOfTasks = new Label();
            lblPrcntCmplt = new Label();
            lbl_cmpltPrcnt = new Label();
            btn_ShowAll = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Tasks).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_Tasks
            // 
            dgv_Tasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Tasks.Location = new Point(381, 151);
            dgv_Tasks.Margin = new Padding(6);
            dgv_Tasks.Name = "dgv_Tasks";
            dgv_Tasks.RowHeadersWidth = 51;
            dgv_Tasks.RowTemplate.Height = 25;
            dgv_Tasks.Size = new Size(1443, 723);
            dgv_Tasks.TabIndex = 14;
            // 
            // lbl_SearchTask
            // 
            lbl_SearchTask.AutoSize = true;
            lbl_SearchTask.Location = new Point(106, 50);
            lbl_SearchTask.Margin = new Padding(6, 0, 6, 0);
            lbl_SearchTask.Name = "lbl_SearchTask";
            lbl_SearchTask.Size = new Size(136, 32);
            lbl_SearchTask.TabIndex = 28;
            lbl_SearchTask.Text = "Search Task";
            // 
            // txt_SearchTask
            // 
            txt_SearchTask.Location = new Point(251, 48);
            txt_SearchTask.Margin = new Padding(6);
            txt_SearchTask.Name = "txt_SearchTask";
            txt_SearchTask.Size = new Size(297, 39);
            txt_SearchTask.TabIndex = 30;
            // 
            // lbl_User
            // 
            lbl_User.AutoSize = true;
            lbl_User.Location = new Point(30, 305);
            lbl_User.Margin = new Padding(6, 0, 6, 0);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new Size(0, 32);
            lbl_User.TabIndex = 72;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ddl_Users);
            groupBox1.Controls.Add(lbl_ProjectStatus);
            groupBox1.Controls.Add(ddl_ProjectStatus);
            groupBox1.Controls.Add(btn_Filter);
            groupBox1.Controls.Add(btn_Clear);
            groupBox1.Controls.Add(lbl_SearchTask);
            groupBox1.Controls.Add(txt_SearchTask);
            groupBox1.Location = new Point(22, 19);
            groupBox1.Margin = new Padding(6, 4, 6, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 4, 6, 4);
            groupBox1.Size = new Size(1801, 107);
            groupBox1.TabIndex = 74;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filters";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(592, 51);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 32);
            label1.TabIndex = 2;
            label1.Text = "Filter by Users :";
            // 
            // ddl_Users
            // 
            ddl_Users.FormattingEnabled = true;
            ddl_Users.Location = new Point(775, 45);
            ddl_Users.Margin = new Padding(6);
            ddl_Users.Name = "ddl_Users";
            ddl_Users.Size = new Size(221, 40);
            ddl_Users.TabIndex = 4;
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
            // btn_Clear
            // 
            btn_Clear.BackColor = SystemColors.GradientActiveCaption;
            btn_Clear.Location = new Point(1645, 30);
            btn_Clear.Margin = new Padding(6);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(139, 60);
            btn_Clear.TabIndex = 7;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = false;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // btn_Return
            // 
            btn_Return.BackColor = SystemColors.GradientActiveCaption;
            btn_Return.Location = new Point(41, 909);
            btn_Return.Margin = new Padding(6);
            btn_Return.Name = "btn_Return";
            btn_Return.Size = new Size(175, 83);
            btn_Return.TabIndex = 75;
            btn_Return.Text = "Return";
            btn_Return.UseVisualStyleBackColor = false;
            btn_Return.Click += btn_Return_Click;
            // 
            // btn_ViewProject
            // 
            btn_ViewProject.BackColor = SystemColors.GradientActiveCaption;
            btn_ViewProject.Location = new Point(1637, 909);
            btn_ViewProject.Margin = new Padding(6);
            btn_ViewProject.Name = "btn_ViewProject";
            btn_ViewProject.Size = new Size(186, 83);
            btn_ViewProject.TabIndex = 79;
            btn_ViewProject.Text = "View Task";
            btn_ViewProject.UseVisualStyleBackColor = false;
            btn_ViewProject.Click += btn_ViewProject_Click;
            // 
            // btn_DeleteProject
            // 
            btn_DeleteProject.BackColor = Color.IndianRed;
            btn_DeleteProject.Location = new Point(945, 909);
            btn_DeleteProject.Margin = new Padding(6);
            btn_DeleteProject.Name = "btn_DeleteProject";
            btn_DeleteProject.Size = new Size(189, 83);
            btn_DeleteProject.TabIndex = 78;
            btn_DeleteProject.Text = "Delete Task";
            btn_DeleteProject.UseVisualStyleBackColor = false;
            btn_DeleteProject.Click += btn_DeleteProject_Click;
            // 
            // btn_UpdateProject
            // 
            btn_UpdateProject.BackColor = SystemColors.GradientActiveCaption;
            btn_UpdateProject.Location = new Point(1400, 909);
            btn_UpdateProject.Margin = new Padding(6);
            btn_UpdateProject.Name = "btn_UpdateProject";
            btn_UpdateProject.Size = new Size(212, 83);
            btn_UpdateProject.TabIndex = 77;
            btn_UpdateProject.Text = "Update Task";
            btn_UpdateProject.UseVisualStyleBackColor = false;
            btn_UpdateProject.Click += btn_UpdateProject_Click;
            // 
            // btn_CreateProject
            // 
            btn_CreateProject.BackColor = SystemColors.GradientActiveCaption;
            btn_CreateProject.Location = new Point(1163, 909);
            btn_CreateProject.Margin = new Padding(6);
            btn_CreateProject.Name = "btn_CreateProject";
            btn_CreateProject.Size = new Size(206, 83);
            btn_CreateProject.TabIndex = 76;
            btn_CreateProject.Text = "Create Task";
            btn_CreateProject.UseVisualStyleBackColor = false;
            btn_CreateProject.Click += btn_CreateProject_Click;
            // 
            // lbl_AssignedProjects
            // 
            lbl_AssignedProjects.AutoSize = true;
            lbl_AssignedProjects.Location = new Point(56, 759);
            lbl_AssignedProjects.Margin = new Padding(6, 0, 6, 0);
            lbl_AssignedProjects.Name = "lbl_AssignedProjects";
            lbl_AssignedProjects.Size = new Size(0, 32);
            lbl_AssignedProjects.TabIndex = 81;
            // 
            // lbl_CompletedProjects
            // 
            lbl_CompletedProjects.AutoSize = true;
            lbl_CompletedProjects.Location = new Point(56, 700);
            lbl_CompletedProjects.Margin = new Padding(6, 0, 6, 0);
            lbl_CompletedProjects.Name = "lbl_CompletedProjects";
            lbl_CompletedProjects.Size = new Size(0, 32);
            lbl_CompletedProjects.TabIndex = 80;
            // 
            // lblOverDueTasks
            // 
            lblOverDueTasks.AutoSize = true;
            lblOverDueTasks.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblOverDueTasks.Location = new Point(85, 390);
            lblOverDueTasks.Margin = new Padding(6, 0, 6, 0);
            lblOverDueTasks.Name = "lblOverDueTasks";
            lblOverDueTasks.Size = new Size(195, 38);
            lblOverDueTasks.TabIndex = 82;
            lblOverDueTasks.Text = "Overdue Tasks";
            // 
            // lblCompletedTasks
            // 
            lblCompletedTasks.AutoSize = true;
            lblCompletedTasks.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblCompletedTasks.Location = new Point(72, 571);
            lblCompletedTasks.Margin = new Padding(6, 0, 6, 0);
            lblCompletedTasks.Name = "lblCompletedTasks";
            lblCompletedTasks.Size = new Size(224, 38);
            lblCompletedTasks.TabIndex = 83;
            lblCompletedTasks.Text = "Completed Tasks";
            // 
            // lblNumberOfOverDueTasks
            // 
            lblNumberOfOverDueTasks.AutoSize = true;
            lblNumberOfOverDueTasks.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumberOfOverDueTasks.Location = new Point(146, 426);
            lblNumberOfOverDueTasks.Margin = new Padding(6, 0, 6, 0);
            lblNumberOfOverDueTasks.Name = "lblNumberOfOverDueTasks";
            lblNumberOfOverDueTasks.Size = new Size(43, 50);
            lblNumberOfOverDueTasks.TabIndex = 84;
            lblNumberOfOverDueTasks.Text = "0";
            // 
            // lblNumberOfCompletedTasks
            // 
            lblNumberOfCompletedTasks.AutoSize = true;
            lblNumberOfCompletedTasks.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumberOfCompletedTasks.Location = new Point(150, 626);
            lblNumberOfCompletedTasks.Margin = new Padding(6, 0, 6, 0);
            lblNumberOfCompletedTasks.Name = "lblNumberOfCompletedTasks";
            lblNumberOfCompletedTasks.Size = new Size(43, 50);
            lblNumberOfCompletedTasks.TabIndex = 85;
            lblNumberOfCompletedTasks.Text = "0";
            // 
            // lblNumberOfTask
            // 
            lblNumberOfTask.AutoSize = true;
            lblNumberOfTask.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumberOfTask.Location = new Point(146, 237);
            lblNumberOfTask.Margin = new Padding(6, 0, 6, 0);
            lblNumberOfTask.Name = "lblNumberOfTask";
            lblNumberOfTask.Size = new Size(43, 50);
            lblNumberOfTask.TabIndex = 87;
            lblNumberOfTask.Text = "0";
            // 
            // lbl_NoOfTasks
            // 
            lbl_NoOfTasks.AutoSize = true;
            lbl_NoOfTasks.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_NoOfTasks.Location = new Point(104, 201);
            lbl_NoOfTasks.Margin = new Padding(6, 0, 6, 0);
            lbl_NoOfTasks.Name = "lbl_NoOfTasks";
            lbl_NoOfTasks.Size = new Size(132, 38);
            lbl_NoOfTasks.TabIndex = 86;
            lbl_NoOfTasks.Text = "No. Tasks";
            // 
            // lblPrcntCmplt
            // 
            lblPrcntCmplt.AutoSize = true;
            lblPrcntCmplt.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrcntCmplt.Location = new Point(150, 810);
            lblPrcntCmplt.Margin = new Padding(6, 0, 6, 0);
            lblPrcntCmplt.Name = "lblPrcntCmplt";
            lblPrcntCmplt.Size = new Size(43, 50);
            lblPrcntCmplt.TabIndex = 89;
            lblPrcntCmplt.Text = "0";
            // 
            // lbl_cmpltPrcnt
            // 
            lbl_cmpltPrcnt.AutoSize = true;
            lbl_cmpltPrcnt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_cmpltPrcnt.Location = new Point(72, 755);
            lbl_cmpltPrcnt.Margin = new Padding(6, 0, 6, 0);
            lbl_cmpltPrcnt.Name = "lbl_cmpltPrcnt";
            lbl_cmpltPrcnt.Size = new Size(255, 38);
            lbl_cmpltPrcnt.TabIndex = 88;
            lbl_cmpltPrcnt.Text = "Completed Tasks %";
            // 
            // btn_ShowAll
            // 
            btn_ShowAll.BackColor = SystemColors.GradientActiveCaption;
            btn_ShowAll.Location = new Point(241, 909);
            btn_ShowAll.Margin = new Padding(6);
            btn_ShowAll.Name = "btn_ShowAll";
            btn_ShowAll.Size = new Size(212, 83);
            btn_ShowAll.TabIndex = 90;
            btn_ShowAll.Text = "Show All Tasks";
            btn_ShowAll.UseVisualStyleBackColor = false;
            btn_ShowAll.Click += btn_ShowAll_Click;
            // 
            // ProjectView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1870, 1020);
            Controls.Add(btn_ShowAll);
            Controls.Add(lblPrcntCmplt);
            Controls.Add(lbl_cmpltPrcnt);
            Controls.Add(lblNumberOfTask);
            Controls.Add(lbl_NoOfTasks);
            Controls.Add(lblNumberOfCompletedTasks);
            Controls.Add(lblNumberOfOverDueTasks);
            Controls.Add(lblCompletedTasks);
            Controls.Add(lblOverDueTasks);
            Controls.Add(lbl_AssignedProjects);
            Controls.Add(lbl_CompletedProjects);
            Controls.Add(btn_ViewProject);
            Controls.Add(btn_DeleteProject);
            Controls.Add(btn_UpdateProject);
            Controls.Add(btn_CreateProject);
            Controls.Add(btn_Return);
            Controls.Add(groupBox1);
            Controls.Add(lbl_User);
            Controls.Add(dgv_Tasks);
            Margin = new Padding(6);
            Name = "ProjectView";
            Text = "Task View";
            Load += ProjectView_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Tasks).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgv_Tasks;
        private Label lbl_SearchTask;
        private TextBox txt_SearchTask;
        private Label lbl_User;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox ddl_Users;
        private Label lbl_ProjectStatus;
        private ComboBox ddl_ProjectStatus;
        private Button btn_Filter;
        private Button btn_Clear;
        private Button btn_Return;
        private Button btn_ViewProject;
        private Button btn_DeleteProject;
        private Button btn_UpdateProject;
        private Button btn_CreateProject;
        private Label lbl_AssignedProjects;
        private Label lbl_CompletedProjects;
        private Label lblOverDueTasks;
        private Label lblCompletedTasks;
        private Label lblNumberOfOverDueTasks;
        private Label lblNumberOfCompletedTasks;
        private Label lblNumberOfTask;
        private Label lbl_NoOfTasks;
        private Label lblPrcntCmplt;
        private Label lbl_cmpltPrcnt;
        private Button btn_ShowAll;
    }
}