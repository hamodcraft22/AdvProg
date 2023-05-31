namespace advProj_ProjectManager
{
    partial class Project_Dashboard
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
            lbl_ProjectDashboard = new Label();
            btn_Return = new Button();
            lbl_PendingTasks = new Label();
            lbl_NumberOfPendingTasks = new Label();
            lbl_CompletedTasks = new Label();
            lbl_NumberOfCompletedTasks = new Label();
            lbl_OverDueTasks = new Label();
            lbl_NumberOfOverDueTasks = new Label();
            lbl_NumberTasks = new Label();
            lbl_NumberOfTasks = new Label();
            lbl_Project = new Label();
            lbl_ProjectName = new Label();
            SuspendLayout();
            // 
            // lbl_ProjectDashboard
            // 
            lbl_ProjectDashboard.AutoSize = true;
            lbl_ProjectDashboard.Location = new Point(338, 50);
            lbl_ProjectDashboard.Name = "lbl_ProjectDashboard";
            lbl_ProjectDashboard.Size = new Size(104, 15);
            lbl_ProjectDashboard.TabIndex = 0;
            lbl_ProjectDashboard.Text = "Project Dashboard";
            // 
            // btn_Return
            // 
            btn_Return.Location = new Point(338, 330);
            btn_Return.Name = "btn_Return";
            btn_Return.Size = new Size(90, 23);
            btn_Return.TabIndex = 28;
            btn_Return.Text = "Return";
            btn_Return.UseVisualStyleBackColor = true;
            // 
            // lbl_PendingTasks
            // 
            lbl_PendingTasks.AutoSize = true;
            lbl_PendingTasks.Location = new Point(262, 133);
            lbl_PendingTasks.Name = "lbl_PendingTasks";
            lbl_PendingTasks.Size = new Size(84, 15);
            lbl_PendingTasks.TabIndex = 29;
            lbl_PendingTasks.Text = "Pending Tasks:";
            // 
            // lbl_NumberOfPendingTasks
            // 
            lbl_NumberOfPendingTasks.AutoSize = true;
            lbl_NumberOfPendingTasks.Location = new Point(438, 133);
            lbl_NumberOfPendingTasks.Name = "lbl_NumberOfPendingTasks";
            lbl_NumberOfPendingTasks.Size = new Size(142, 15);
            lbl_NumberOfPendingTasks.TabIndex = 30;
            lbl_NumberOfPendingTasks.Text = "Number of Pending Tasks";
            // 
            // lbl_CompletedTasks
            // 
            lbl_CompletedTasks.AutoSize = true;
            lbl_CompletedTasks.Location = new Point(248, 173);
            lbl_CompletedTasks.Name = "lbl_CompletedTasks";
            lbl_CompletedTasks.Size = new Size(99, 15);
            lbl_CompletedTasks.TabIndex = 31;
            lbl_CompletedTasks.Text = "Completed Tasks:";
            // 
            // lbl_NumberOfCompletedTasks
            // 
            lbl_NumberOfCompletedTasks.AutoSize = true;
            lbl_NumberOfCompletedTasks.Location = new Point(438, 173);
            lbl_NumberOfCompletedTasks.Name = "lbl_NumberOfCompletedTasks";
            lbl_NumberOfCompletedTasks.Size = new Size(157, 15);
            lbl_NumberOfCompletedTasks.TabIndex = 32;
            lbl_NumberOfCompletedTasks.Text = "Number of Completed Tasks";
            // 
            // lbl_OverDueTasks
            // 
            lbl_OverDueTasks.AutoSize = true;
            lbl_OverDueTasks.Location = new Point(263, 223);
            lbl_OverDueTasks.Name = "lbl_OverDueTasks";
            lbl_OverDueTasks.Size = new Size(83, 15);
            lbl_OverDueTasks.TabIndex = 33;
            lbl_OverDueTasks.Text = "OverDueTasks:";
            // 
            // lbl_NumberOfOverDueTasks
            // 
            lbl_NumberOfOverDueTasks.AutoSize = true;
            lbl_NumberOfOverDueTasks.Location = new Point(438, 223);
            lbl_NumberOfOverDueTasks.Name = "lbl_NumberOfOverDueTasks";
            lbl_NumberOfOverDueTasks.Size = new Size(144, 15);
            lbl_NumberOfOverDueTasks.TabIndex = 34;
            lbl_NumberOfOverDueTasks.Text = "Number of OverDue Tasks";
            // 
            // lbl_NumberTasks
            // 
            lbl_NumberTasks.AutoSize = true;
            lbl_NumberTasks.Location = new Point(248, 275);
            lbl_NumberTasks.Name = "lbl_NumberTasks";
            lbl_NumberTasks.Size = new Size(98, 15);
            lbl_NumberTasks.TabIndex = 35;
            lbl_NumberTasks.Text = "Number of Tasks:";
            // 
            // lbl_NumberOfTasks
            // 
            lbl_NumberOfTasks.AutoSize = true;
            lbl_NumberOfTasks.Location = new Point(438, 284);
            lbl_NumberOfTasks.Name = "lbl_NumberOfTasks";
            lbl_NumberOfTasks.Size = new Size(95, 15);
            lbl_NumberOfTasks.TabIndex = 36;
            lbl_NumberOfTasks.Text = "Number of Tasks";
            // 
            // lbl_Project
            // 
            lbl_Project.AutoSize = true;
            lbl_Project.Location = new Point(263, 101);
            lbl_Project.Name = "lbl_Project";
            lbl_Project.Size = new Size(82, 15);
            lbl_Project.TabIndex = 37;
            lbl_Project.Text = "Project Name:";
            // 
            // lbl_ProjectName
            // 
            lbl_ProjectName.AutoSize = true;
            lbl_ProjectName.Location = new Point(438, 101);
            lbl_ProjectName.Name = "lbl_ProjectName";
            lbl_ProjectName.Size = new Size(79, 15);
            lbl_ProjectName.TabIndex = 38;
            lbl_ProjectName.Text = "Project Name";
            // 
            // Project_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_ProjectName);
            Controls.Add(lbl_Project);
            Controls.Add(lbl_NumberOfTasks);
            Controls.Add(lbl_NumberTasks);
            Controls.Add(lbl_NumberOfOverDueTasks);
            Controls.Add(lbl_OverDueTasks);
            Controls.Add(lbl_NumberOfCompletedTasks);
            Controls.Add(lbl_CompletedTasks);
            Controls.Add(lbl_NumberOfPendingTasks);
            Controls.Add(lbl_PendingTasks);
            Controls.Add(btn_Return);
            Controls.Add(lbl_ProjectDashboard);
            Name = "Project_Dashboard";
            Text = "Project Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_ProjectDashboard;
        private Button btn_Return;
        private Label lbl_PendingTasks;
        private Label lbl_NumberOfPendingTasks;
        private Label lbl_CompletedTasks;
        private Label lbl_NumberOfCompletedTasks;
        private Label lbl_OverDueTasks;
        private Label lbl_NumberOfOverDueTasks;
        private Label lbl_NumberTasks;
        private Label lbl_NumberOfTasks;
        private Label lbl_Project;
        private Label lbl_ProjectName;
    }
}