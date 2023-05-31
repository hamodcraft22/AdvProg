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
            lbl_ProjectView = new Label();
            dgv_Tasks = new DataGridView();
            btn_Filter = new Button();
            bt_Refresh = new Button();
            btn_CreateTask = new Button();
            btn_UpdateTask = new Button();
            btn_DeleteTask = new Button();
            btn_ViewTask = new Button();
            btn_Return = new Button();
            lbl_SearchTask = new Label();
            btn_SearchTask = new Button();
            txt_SearchTask = new TextBox();
            ddl_TaskStartDate = new DateTimePicker();
            ddl_TaskStatus = new ComboBox();
            lbl_TaskStatus = new Label();
            lbl_TaskStartDate = new Label();
            lbl_CompletedTasks = new Label();
            lbl_NumberOfCompletedTasks = new Label();
            lbl_OverDueTasks = new Label();
            lbl_NumberOfOverDueTasks = new Label();
            lbl_Tasks = new Label();
            lbl_NumberOfTasks = new Label();
            ddl_Users = new ComboBox();
            lbl_User = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Tasks).BeginInit();
            SuspendLayout();
            // 
            // lbl_ProjectView
            // 
            lbl_ProjectView.AutoSize = true;
            lbl_ProjectView.Location = new Point(409, 9);
            lbl_ProjectView.Name = "lbl_ProjectView";
            lbl_ProjectView.Size = new Size(72, 15);
            lbl_ProjectView.TabIndex = 0;
            lbl_ProjectView.Text = "Project View";
            // 
            // dgv_Tasks
            // 
            dgv_Tasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Tasks.Location = new Point(225, 68);
            dgv_Tasks.Name = "dgv_Tasks";
            dgv_Tasks.RowTemplate.Height = 25;
            dgv_Tasks.Size = new Size(546, 296);
            dgv_Tasks.TabIndex = 14;
            // 
            // btn_Filter
            // 
            btn_Filter.Location = new Point(7, 341);
            btn_Filter.Name = "btn_Filter";
            btn_Filter.Size = new Size(75, 23);
            btn_Filter.TabIndex = 19;
            btn_Filter.Text = "Filter";
            btn_Filter.UseVisualStyleBackColor = true;
            // 
            // bt_Refresh
            // 
            bt_Refresh.Location = new Point(111, 341);
            bt_Refresh.Name = "bt_Refresh";
            bt_Refresh.Size = new Size(75, 23);
            bt_Refresh.TabIndex = 20;
            bt_Refresh.Text = "Refresh";
            bt_Refresh.UseVisualStyleBackColor = true;
            // 
            // btn_CreateTask
            // 
            btn_CreateTask.Location = new Point(660, 398);
            btn_CreateTask.Name = "btn_CreateTask";
            btn_CreateTask.Size = new Size(111, 23);
            btn_CreateTask.TabIndex = 21;
            btn_CreateTask.Text = "Create Task";
            btn_CreateTask.UseVisualStyleBackColor = true;
            // 
            // btn_UpdateTask
            // 
            btn_UpdateTask.Location = new Point(561, 398);
            btn_UpdateTask.Name = "btn_UpdateTask";
            btn_UpdateTask.Size = new Size(93, 23);
            btn_UpdateTask.TabIndex = 22;
            btn_UpdateTask.Text = "Update Task";
            btn_UpdateTask.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteTask
            // 
            btn_DeleteTask.Location = new Point(451, 398);
            btn_DeleteTask.Name = "btn_DeleteTask";
            btn_DeleteTask.Size = new Size(97, 23);
            btn_DeleteTask.TabIndex = 23;
            btn_DeleteTask.Text = "Delete Task";
            btn_DeleteTask.UseVisualStyleBackColor = true;
            // 
            // btn_ViewTask
            // 
            btn_ViewTask.Location = new Point(309, 398);
            btn_ViewTask.Name = "btn_ViewTask";
            btn_ViewTask.Size = new Size(124, 23);
            btn_ViewTask.TabIndex = 24;
            btn_ViewTask.Text = "View Task";
            btn_ViewTask.UseVisualStyleBackColor = true;
            // 
            // btn_Return
            // 
            btn_Return.Location = new Point(55, 398);
            btn_Return.Name = "btn_Return";
            btn_Return.Size = new Size(90, 23);
            btn_Return.TabIndex = 27;
            btn_Return.Text = "Return";
            btn_Return.UseVisualStyleBackColor = true;
            // 
            // lbl_SearchTask
            // 
            lbl_SearchTask.AutoSize = true;
            lbl_SearchTask.Location = new Point(12, 68);
            lbl_SearchTask.Name = "lbl_SearchTask";
            lbl_SearchTask.Size = new Size(70, 15);
            lbl_SearchTask.TabIndex = 28;
            lbl_SearchTask.Text = "Search Task:";
            // 
            // btn_SearchTask
            // 
            btn_SearchTask.Location = new Point(121, 99);
            btn_SearchTask.Name = "btn_SearchTask";
            btn_SearchTask.Size = new Size(75, 23);
            btn_SearchTask.TabIndex = 29;
            btn_SearchTask.Text = "Search Task";
            btn_SearchTask.UseVisualStyleBackColor = true;
            // 
            // txt_SearchTask
            // 
            txt_SearchTask.Location = new Point(15, 99);
            txt_SearchTask.Name = "txt_SearchTask";
            txt_SearchTask.Size = new Size(100, 23);
            txt_SearchTask.TabIndex = 30;
            // 
            // ddl_TaskStartDate
            // 
            ddl_TaskStartDate.Location = new Point(15, 231);
            ddl_TaskStartDate.Name = "ddl_TaskStartDate";
            ddl_TaskStartDate.Size = new Size(186, 23);
            ddl_TaskStartDate.TabIndex = 65;
            // 
            // ddl_TaskStatus
            // 
            ddl_TaskStatus.FormattingEnabled = true;
            ddl_TaskStatus.Location = new Point(16, 301);
            ddl_TaskStatus.Name = "ddl_TaskStatus";
            ddl_TaskStatus.Size = new Size(185, 23);
            ddl_TaskStatus.TabIndex = 64;
            // 
            // lbl_TaskStatus
            // 
            lbl_TaskStatus.AutoSize = true;
            lbl_TaskStatus.Location = new Point(15, 270);
            lbl_TaskStatus.Name = "lbl_TaskStatus";
            lbl_TaskStatus.Size = new Size(87, 15);
            lbl_TaskStatus.TabIndex = 63;
            lbl_TaskStatus.Text = "Filter by Status:";
            // 
            // lbl_TaskStartDate
            // 
            lbl_TaskStartDate.AutoSize = true;
            lbl_TaskStartDate.Location = new Point(12, 213);
            lbl_TaskStartDate.Name = "lbl_TaskStartDate";
            lbl_TaskStartDate.Size = new Size(103, 15);
            lbl_TaskStartDate.TabIndex = 62;
            lbl_TaskStartDate.Text = "Filter by StartDate:";
            // 
            // lbl_CompletedTasks
            // 
            lbl_CompletedTasks.AutoSize = true;
            lbl_CompletedTasks.Location = new Point(543, 50);
            lbl_CompletedTasks.Name = "lbl_CompletedTasks";
            lbl_CompletedTasks.Size = new Size(99, 15);
            lbl_CompletedTasks.TabIndex = 66;
            lbl_CompletedTasks.Text = "Completed Tasks:";
            // 
            // lbl_NumberOfCompletedTasks
            // 
            lbl_NumberOfCompletedTasks.AutoSize = true;
            lbl_NumberOfCompletedTasks.Location = new Point(648, 50);
            lbl_NumberOfCompletedTasks.Name = "lbl_NumberOfCompletedTasks";
            lbl_NumberOfCompletedTasks.Size = new Size(13, 15);
            lbl_NumberOfCompletedTasks.TabIndex = 67;
            lbl_NumberOfCompletedTasks.Text = "0";
            // 
            // lbl_OverDueTasks
            // 
            lbl_OverDueTasks.AutoSize = true;
            lbl_OverDueTasks.Location = new Point(409, 50);
            lbl_OverDueTasks.Name = "lbl_OverDueTasks";
            lbl_OverDueTasks.Size = new Size(83, 15);
            lbl_OverDueTasks.TabIndex = 68;
            lbl_OverDueTasks.Text = "OverDueTasks:";
            // 
            // lbl_NumberOfOverDueTasks
            // 
            lbl_NumberOfOverDueTasks.AutoSize = true;
            lbl_NumberOfOverDueTasks.Location = new Point(513, 50);
            lbl_NumberOfOverDueTasks.Name = "lbl_NumberOfOverDueTasks";
            lbl_NumberOfOverDueTasks.Size = new Size(13, 15);
            lbl_NumberOfOverDueTasks.TabIndex = 69;
            lbl_NumberOfOverDueTasks.Text = "0";
            // 
            // lbl_Tasks
            // 
            lbl_Tasks.AutoSize = true;
            lbl_Tasks.Location = new Point(266, 50);
            lbl_Tasks.Name = "lbl_Tasks";
            lbl_Tasks.Size = new Size(98, 15);
            lbl_Tasks.TabIndex = 70;
            lbl_Tasks.Text = "Number of Tasks:";
            // 
            // lbl_NumberOfTasks
            // 
            lbl_NumberOfTasks.AutoSize = true;
            lbl_NumberOfTasks.Location = new Point(370, 50);
            lbl_NumberOfTasks.Name = "lbl_NumberOfTasks";
            lbl_NumberOfTasks.Size = new Size(13, 15);
            lbl_NumberOfTasks.TabIndex = 71;
            lbl_NumberOfTasks.Text = "0";
            // 
            // ddl_Users
            // 
            ddl_Users.FormattingEnabled = true;
            ddl_Users.Location = new Point(15, 174);
            ddl_Users.Name = "ddl_Users";
            ddl_Users.Size = new Size(186, 23);
            ddl_Users.TabIndex = 73;
            // 
            // lbl_User
            // 
            lbl_User.AutoSize = true;
            lbl_User.Location = new Point(16, 143);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new Size(86, 15);
            lbl_User.TabIndex = 72;
            lbl_User.Text = "Filter by Users :";
            // 
            // ProjectView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ddl_Users);
            Controls.Add(lbl_User);
            Controls.Add(lbl_NumberOfTasks);
            Controls.Add(lbl_Tasks);
            Controls.Add(lbl_NumberOfOverDueTasks);
            Controls.Add(lbl_OverDueTasks);
            Controls.Add(lbl_NumberOfCompletedTasks);
            Controls.Add(lbl_CompletedTasks);
            Controls.Add(ddl_TaskStartDate);
            Controls.Add(ddl_TaskStatus);
            Controls.Add(lbl_TaskStatus);
            Controls.Add(lbl_TaskStartDate);
            Controls.Add(txt_SearchTask);
            Controls.Add(btn_SearchTask);
            Controls.Add(lbl_SearchTask);
            Controls.Add(btn_Return);
            Controls.Add(btn_ViewTask);
            Controls.Add(btn_DeleteTask);
            Controls.Add(btn_UpdateTask);
            Controls.Add(btn_CreateTask);
            Controls.Add(bt_Refresh);
            Controls.Add(btn_Filter);
            Controls.Add(dgv_Tasks);
            Controls.Add(lbl_ProjectView);
            Name = "ProjectView";
            Text = "ProjectView";
            ((System.ComponentModel.ISupportInitialize)dgv_Tasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_ProjectView;
        private DataGridView dgv_Tasks;
        private Button btn_Filter;
        private Button bt_Refresh;
        private Button btn_CreateTask;
        private Button btn_UpdateTask;
        private Button btn_DeleteTask;
        private Button btn_ViewTask;
        private Button btn_Return;
        private Label lbl_SearchTask;
        private Button btn_SearchTask;
        private TextBox txt_SearchTask;
        private DateTimePicker ddl_TaskStartDate;
        private ComboBox ddl_TaskStatus;
        private Label lbl_TaskStatus;
        private Label lbl_TaskStartDate;
        private Label lbl_CompletedTasks;
        private Label lbl_NumberOfCompletedTasks;
        private Label lbl_OverDueTasks;
        private Label lbl_NumberOfOverDueTasks;
        private Label lbl_Tasks;
        private Label lbl_NumberOfTasks;
        private ComboBox ddl_Users;
        private Label lbl_User;
    }
}