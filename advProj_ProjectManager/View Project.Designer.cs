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
            btn_SearchTask = new Button();
            txt_SearchTask = new TextBox();
            lbl_User = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            ddl_ProjectStartDate = new DateTimePicker();
            ddl_Users = new ComboBox();
            lbl_ProjectStartDate = new Label();
            lbl_ProjectStatus = new Label();
            ddl_ProjectStatus = new ComboBox();
            btn_Filter = new Button();
            btn_Refresh = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dgv_Tasks).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_Tasks
            // 
            dgv_Tasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Tasks.Location = new Point(205, 71);
            dgv_Tasks.Name = "dgv_Tasks";
            dgv_Tasks.RowHeadersWidth = 51;
            dgv_Tasks.RowTemplate.Height = 25;
            dgv_Tasks.Size = new Size(777, 339);
            dgv_Tasks.TabIndex = 14;
            // 
            // lbl_SearchTask
            // 
            lbl_SearchTask.AutoSize = true;
            lbl_SearchTask.Location = new Point(22, 82);
            lbl_SearchTask.Name = "lbl_SearchTask";
            lbl_SearchTask.Size = new Size(67, 15);
            lbl_SearchTask.TabIndex = 28;
            lbl_SearchTask.Text = "Search Task";
            // 
            // btn_SearchTask
            // 
            btn_SearchTask.Location = new Point(108, 135);
            btn_SearchTask.Name = "btn_SearchTask";
            btn_SearchTask.Size = new Size(75, 23);
            btn_SearchTask.TabIndex = 29;
            btn_SearchTask.Text = "Search Task";
            btn_SearchTask.UseVisualStyleBackColor = true;
            btn_SearchTask.Click += btn_SearchTask_Click;
            // 
            // txt_SearchTask
            // 
            txt_SearchTask.Location = new Point(22, 105);
            txt_SearchTask.Name = "txt_SearchTask";
            txt_SearchTask.Size = new Size(162, 23);
            txt_SearchTask.TabIndex = 30;
            // 
            // lbl_User
            // 
            lbl_User.AutoSize = true;
            lbl_User.Location = new Point(16, 143);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new Size(0, 15);
            lbl_User.TabIndex = 72;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ddl_ProjectStartDate);
            groupBox1.Controls.Add(ddl_Users);
            groupBox1.Controls.Add(lbl_ProjectStartDate);
            groupBox1.Controls.Add(lbl_ProjectStatus);
            groupBox1.Controls.Add(ddl_ProjectStatus);
            groupBox1.Controls.Add(btn_Filter);
            groupBox1.Controls.Add(btn_Refresh);
            groupBox1.Location = new Point(12, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(970, 50);
            groupBox1.TabIndex = 74;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filters";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 22);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 2;
            label1.Text = "Filter by Users :";
            // 
            // ddl_ProjectStartDate
            // 
            ddl_ProjectStartDate.Location = new Point(364, 20);
            ddl_ProjectStartDate.Name = "ddl_ProjectStartDate";
            ddl_ProjectStartDate.Size = new Size(186, 23);
            ddl_ProjectStartDate.TabIndex = 61;
            // 
            // ddl_Users
            // 
            ddl_Users.FormattingEnabled = true;
            ddl_Users.Location = new Point(109, 19);
            ddl_Users.Name = "ddl_Users";
            ddl_Users.Size = new Size(121, 23);
            ddl_Users.TabIndex = 4;
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
            // btn_Refresh
            // 
            btn_Refresh.BackColor = SystemColors.GradientActiveCaption;
            btn_Refresh.Location = new Point(886, 14);
            btn_Refresh.Name = "btn_Refresh";
            btn_Refresh.Size = new Size(75, 28);
            btn_Refresh.TabIndex = 7;
            btn_Refresh.Text = "Refresh";
            btn_Refresh.UseVisualStyleBackColor = false;
            btn_Refresh.Click += btn_Refresh_Click;
            // 
            // btn_Return
            // 
            btn_Return.BackColor = SystemColors.GradientActiveCaption;
            btn_Return.Location = new Point(22, 426);
            btn_Return.Name = "btn_Return";
            btn_Return.Size = new Size(94, 39);
            btn_Return.TabIndex = 75;
            btn_Return.Text = "Return";
            btn_Return.UseVisualStyleBackColor = false;
            btn_Return.Click += button3_Click;
            // 
            // btn_ViewProject
            // 
            btn_ViewProject.BackColor = SystemColors.GradientActiveCaption;
            btn_ViewProject.Location = new Point(626, 426);
            btn_ViewProject.Name = "btn_ViewProject";
            btn_ViewProject.Size = new Size(100, 39);
            btn_ViewProject.TabIndex = 79;
            btn_ViewProject.Text = "View Task";
            btn_ViewProject.UseVisualStyleBackColor = false;
            btn_ViewProject.Click += btn_ViewProject_Click;
            // 
            // btn_DeleteProject
            // 
            btn_DeleteProject.BackColor = Color.IndianRed;
            btn_DeleteProject.Location = new Point(509, 426);
            btn_DeleteProject.Name = "btn_DeleteProject";
            btn_DeleteProject.Size = new Size(102, 39);
            btn_DeleteProject.TabIndex = 78;
            btn_DeleteProject.Text = "Delete Task";
            btn_DeleteProject.UseVisualStyleBackColor = false;
            btn_DeleteProject.Click += btn_DeleteProject_Click;
            // 
            // btn_UpdateProject
            // 
            btn_UpdateProject.BackColor = SystemColors.GradientActiveCaption;
            btn_UpdateProject.Location = new Point(743, 426);
            btn_UpdateProject.Name = "btn_UpdateProject";
            btn_UpdateProject.Size = new Size(114, 39);
            btn_UpdateProject.TabIndex = 77;
            btn_UpdateProject.Text = "Update Task";
            btn_UpdateProject.UseVisualStyleBackColor = false;
            btn_UpdateProject.Click += btn_UpdateProject_Click;
            // 
            // btn_CreateProject
            // 
            btn_CreateProject.BackColor = SystemColors.GradientActiveCaption;
            btn_CreateProject.Location = new Point(871, 426);
            btn_CreateProject.Name = "btn_CreateProject";
            btn_CreateProject.Size = new Size(111, 39);
            btn_CreateProject.TabIndex = 76;
            btn_CreateProject.Text = "Create Task";
            btn_CreateProject.UseVisualStyleBackColor = false;
            btn_CreateProject.Click += btn_CreateProject_Click;
            // 
            // lbl_AssignedProjects
            // 
            lbl_AssignedProjects.AutoSize = true;
            lbl_AssignedProjects.Location = new Point(30, 356);
            lbl_AssignedProjects.Name = "lbl_AssignedProjects";
            lbl_AssignedProjects.Size = new Size(0, 15);
            lbl_AssignedProjects.TabIndex = 81;
            // 
            // lbl_CompletedProjects
            // 
            lbl_CompletedProjects.AutoSize = true;
            lbl_CompletedProjects.Location = new Point(30, 328);
            lbl_CompletedProjects.Name = "lbl_CompletedProjects";
            lbl_CompletedProjects.Size = new Size(0, 15);
            lbl_CompletedProjects.TabIndex = 80;
            // 
            // lblOverDueTasks
            // 
            lblOverDueTasks.AutoSize = true;
            lblOverDueTasks.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblOverDueTasks.Location = new Point(48, 229);
            lblOverDueTasks.Name = "lblOverDueTasks";
            lblOverDueTasks.Size = new Size(97, 19);
            lblOverDueTasks.TabIndex = 82;
            lblOverDueTasks.Text = "Overdue Tasks";
            // 
            // lblCompletedTasks
            // 
            lblCompletedTasks.AutoSize = true;
            lblCompletedTasks.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblCompletedTasks.Location = new Point(39, 300);
            lblCompletedTasks.Name = "lblCompletedTasks";
            lblCompletedTasks.Size = new Size(111, 19);
            lblCompletedTasks.TabIndex = 83;
            lblCompletedTasks.Text = "Completed Tasks";
            lblCompletedTasks.Click += label3_Click;
            // 
            // lblNumberOfOverDueTasks
            // 
            lblNumberOfOverDueTasks.AutoSize = true;
            lblNumberOfOverDueTasks.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumberOfOverDueTasks.Location = new Point(81, 246);
            lblNumberOfOverDueTasks.Name = "lblNumberOfOverDueTasks";
            lblNumberOfOverDueTasks.Size = new Size(23, 25);
            lblNumberOfOverDueTasks.TabIndex = 84;
            lblNumberOfOverDueTasks.Text = "0";
            // 
            // lblNumberOfCompletedTasks
            // 
            lblNumberOfCompletedTasks.AutoSize = true;
            lblNumberOfCompletedTasks.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumberOfCompletedTasks.Location = new Point(81, 326);
            lblNumberOfCompletedTasks.Name = "lblNumberOfCompletedTasks";
            lblNumberOfCompletedTasks.Size = new Size(23, 25);
            lblNumberOfCompletedTasks.TabIndex = 85;
            lblNumberOfCompletedTasks.Text = "0";
            // 
            // ProjectView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1007, 478);
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
            Controls.Add(txt_SearchTask);
            Controls.Add(btn_SearchTask);
            Controls.Add(lbl_SearchTask);
            Controls.Add(dgv_Tasks);
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
        private Button btn_SearchTask;
        private TextBox txt_SearchTask;
        private Label lbl_User;
        private GroupBox groupBox1;
        private Label label1;
        private DateTimePicker ddl_ProjectStartDate;
        private ComboBox ddl_Users;
        private Label lbl_ProjectStartDate;
        private Label lbl_ProjectStatus;
        private ComboBox ddl_ProjectStatus;
        private Button btn_Filter;
        private Button btn_Refresh;
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
    }
}