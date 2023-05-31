namespace advProj_ProjectManager
{
    partial class Tasks
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
            lbl_Tasks = new Label();
            btn_ViewProfile = new Button();
            dgv_Tasks = new DataGridView();
            lbl_User = new Label();
            ddl_Users = new ComboBox();
            ddl_Task = new ComboBox();
            btn_Filter = new Button();
            bt_Refresh = new Button();
            btn_CreateTask = new Button();
            btn_UpdateTask = new Button();
            btn_DeleteTask = new Button();
            btn_AssignedUsers = new Button();
            lbl_Task = new Label();
            btn_Return = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Tasks).BeginInit();
            SuspendLayout();
            // 
            // lbl_Tasks
            // 
            lbl_Tasks.AutoSize = true;
            lbl_Tasks.Location = new Point(347, 29);
            lbl_Tasks.Name = "lbl_Tasks";
            lbl_Tasks.Size = new Size(34, 15);
            lbl_Tasks.TabIndex = 0;
            lbl_Tasks.Text = "Tasks";
            // 
            // btn_ViewProfile
            // 
            btn_ViewProfile.Location = new Point(25, 398);
            btn_ViewProfile.Name = "btn_ViewProfile";
            btn_ViewProfile.Size = new Size(90, 23);
            btn_ViewProfile.TabIndex = 25;
            btn_ViewProfile.Text = "View Profile";
            btn_ViewProfile.UseVisualStyleBackColor = true;
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
            // lbl_User
            // 
            lbl_User.AutoSize = true;
            lbl_User.Location = new Point(30, 88);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new Size(86, 15);
            lbl_User.TabIndex = 15;
            lbl_User.Text = "Filter by Users :";
            // 
            // ddl_Users
            // 
            ddl_Users.FormattingEnabled = true;
            ddl_Users.Location = new Point(30, 115);
            ddl_Users.Name = "ddl_Users";
            ddl_Users.Size = new Size(121, 23);
            ddl_Users.TabIndex = 17;
            // 
            // ddl_Task
            // 
            ddl_Task.FormattingEnabled = true;
            ddl_Task.Location = new Point(30, 195);
            ddl_Task.Name = "ddl_Task";
            ddl_Task.Size = new Size(121, 23);
            ddl_Task.TabIndex = 18;
            // 
            // btn_Filter
            // 
            btn_Filter.Location = new Point(30, 255);
            btn_Filter.Name = "btn_Filter";
            btn_Filter.Size = new Size(75, 23);
            btn_Filter.TabIndex = 19;
            btn_Filter.Text = "Filter";
            btn_Filter.UseVisualStyleBackColor = true;
            // 
            // bt_Refresh
            // 
            bt_Refresh.Location = new Point(30, 299);
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
            // btn_AssignedUsers
            // 
            btn_AssignedUsers.Location = new Point(309, 398);
            btn_AssignedUsers.Name = "btn_AssignedUsers";
            btn_AssignedUsers.Size = new Size(124, 23);
            btn_AssignedUsers.TabIndex = 24;
            btn_AssignedUsers.Text = "View Assigned Users";
            btn_AssignedUsers.UseVisualStyleBackColor = true;
            // 
            // lbl_Task
            // 
            lbl_Task.AutoSize = true;
            lbl_Task.Location = new Point(41, 156);
            lbl_Task.Name = "lbl_Task";
            lbl_Task.Size = new Size(74, 15);
            lbl_Task.TabIndex = 26;
            lbl_Task.Text = "Filter by Task";
            // 
            // btn_Return
            // 
            btn_Return.Location = new Point(121, 398);
            btn_Return.Name = "btn_Return";
            btn_Return.Size = new Size(90, 23);
            btn_Return.TabIndex = 27;
            btn_Return.Text = "Return";
            btn_Return.UseVisualStyleBackColor = true;
            // 
            // Tasks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Return);
            Controls.Add(lbl_Task);
            Controls.Add(btn_ViewProfile);
            Controls.Add(btn_AssignedUsers);
            Controls.Add(btn_DeleteTask);
            Controls.Add(btn_UpdateTask);
            Controls.Add(btn_CreateTask);
            Controls.Add(bt_Refresh);
            Controls.Add(btn_Filter);
            Controls.Add(ddl_Task);
            Controls.Add(ddl_Users);
            Controls.Add(lbl_User);
            Controls.Add(dgv_Tasks);
            Controls.Add(lbl_Tasks);
            Name = "Tasks";
            Text = "Tasks";
            ((System.ComponentModel.ISupportInitialize)dgv_Tasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Tasks;
        private Button btn_ViewProfile;
        private DataGridView dgv_Tasks;
        private Label lbl_User;
        private ComboBox ddl_Users;
        private ComboBox ddl_Task;
        private Button btn_Filter;
        private Button bt_Refresh;
        private Button btn_CreateTask;
        private Button btn_UpdateTask;
        private Button btn_DeleteTask;
        private Button btn_AssignedUsers;
        private Label lbl_Task;
        private Button btn_Return;
    }
}