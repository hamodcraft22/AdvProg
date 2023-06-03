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
            comboBox1 = new ComboBox();
            lbl_ProjectStartDate = new Label();
            lbl_ProjectStatus = new Label();
            ddl_ProjectStatus = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btn_ViewProject = new Button();
            btn_DeleteProject = new Button();
            btn_UpdateProject = new Button();
            btn_CreateProject = new Button();
            lbl_AssignedProjects = new Label();
            lbl_CompletedProjects = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Tasks).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_Tasks
            // 
            dgv_Tasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Tasks.Location = new Point(234, 95);
            dgv_Tasks.Margin = new Padding(3, 4, 3, 4);
            dgv_Tasks.Name = "dgv_Tasks";
            dgv_Tasks.RowHeadersWidth = 51;
            dgv_Tasks.RowTemplate.Height = 25;
            dgv_Tasks.Size = new Size(888, 452);
            dgv_Tasks.TabIndex = 14;
            // 
            // lbl_SearchTask
            // 
            lbl_SearchTask.AutoSize = true;
            lbl_SearchTask.Location = new Point(25, 109);
            lbl_SearchTask.Name = "lbl_SearchTask";
            lbl_SearchTask.Size = new Size(84, 20);
            lbl_SearchTask.TabIndex = 28;
            lbl_SearchTask.Text = "Search Task";
            // 
            // btn_SearchTask
            // 
            btn_SearchTask.Location = new Point(123, 180);
            btn_SearchTask.Margin = new Padding(3, 4, 3, 4);
            btn_SearchTask.Name = "btn_SearchTask";
            btn_SearchTask.Size = new Size(86, 31);
            btn_SearchTask.TabIndex = 29;
            btn_SearchTask.Text = "Search Task";
            btn_SearchTask.UseVisualStyleBackColor = true;
            // 
            // txt_SearchTask
            // 
            txt_SearchTask.Location = new Point(25, 140);
            txt_SearchTask.Margin = new Padding(3, 4, 3, 4);
            txt_SearchTask.Name = "txt_SearchTask";
            txt_SearchTask.Size = new Size(184, 27);
            txt_SearchTask.TabIndex = 30;
            // 
            // lbl_User
            // 
            lbl_User.AutoSize = true;
            lbl_User.Location = new Point(18, 191);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new Size(0, 20);
            lbl_User.TabIndex = 72;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ddl_ProjectStartDate);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(lbl_ProjectStartDate);
            groupBox1.Controls.Add(lbl_ProjectStatus);
            groupBox1.Controls.Add(ddl_ProjectStatus);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(14, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1108, 67);
            groupBox1.TabIndex = 74;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filters";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 30);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 2;
            label1.Text = "Filter by Users :";
            // 
            // ddl_ProjectStartDate
            // 
            ddl_ProjectStartDate.Location = new Point(416, 26);
            ddl_ProjectStartDate.Margin = new Padding(3, 4, 3, 4);
            ddl_ProjectStartDate.Name = "ddl_ProjectStartDate";
            ddl_ProjectStartDate.Size = new Size(212, 27);
            ddl_ProjectStartDate.TabIndex = 61;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(125, 25);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 4;
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
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(917, 18);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 38);
            button1.TabIndex = 6;
            button1.Text = "Filter";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Location = new Point(1012, 18);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 38);
            button2.TabIndex = 7;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.Location = new Point(25, 568);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(108, 52);
            button3.TabIndex = 75;
            button3.Text = "Return";
            button3.UseVisualStyleBackColor = false;
            // 
            // btn_ViewProject
            // 
            btn_ViewProject.BackColor = SystemColors.GradientActiveCaption;
            btn_ViewProject.Location = new Point(716, 568);
            btn_ViewProject.Margin = new Padding(3, 4, 3, 4);
            btn_ViewProject.Name = "btn_ViewProject";
            btn_ViewProject.Size = new Size(114, 52);
            btn_ViewProject.TabIndex = 79;
            btn_ViewProject.Text = "View Task";
            btn_ViewProject.UseVisualStyleBackColor = false;
            // 
            // btn_DeleteProject
            // 
            btn_DeleteProject.BackColor = Color.IndianRed;
            btn_DeleteProject.Location = new Point(582, 568);
            btn_DeleteProject.Margin = new Padding(3, 4, 3, 4);
            btn_DeleteProject.Name = "btn_DeleteProject";
            btn_DeleteProject.Size = new Size(116, 52);
            btn_DeleteProject.TabIndex = 78;
            btn_DeleteProject.Text = "Delete Task";
            btn_DeleteProject.UseVisualStyleBackColor = false;
            // 
            // btn_UpdateProject
            // 
            btn_UpdateProject.BackColor = SystemColors.GradientActiveCaption;
            btn_UpdateProject.Location = new Point(849, 568);
            btn_UpdateProject.Margin = new Padding(3, 4, 3, 4);
            btn_UpdateProject.Name = "btn_UpdateProject";
            btn_UpdateProject.Size = new Size(130, 52);
            btn_UpdateProject.TabIndex = 77;
            btn_UpdateProject.Text = "Update Task";
            btn_UpdateProject.UseVisualStyleBackColor = false;
            // 
            // btn_CreateProject
            // 
            btn_CreateProject.BackColor = SystemColors.GradientActiveCaption;
            btn_CreateProject.Location = new Point(995, 568);
            btn_CreateProject.Margin = new Padding(3, 4, 3, 4);
            btn_CreateProject.Name = "btn_CreateProject";
            btn_CreateProject.Size = new Size(127, 52);
            btn_CreateProject.TabIndex = 76;
            btn_CreateProject.Text = "Create Task";
            btn_CreateProject.UseVisualStyleBackColor = false;
            // 
            // lbl_AssignedProjects
            // 
            lbl_AssignedProjects.AutoSize = true;
            lbl_AssignedProjects.Location = new Point(34, 475);
            lbl_AssignedProjects.Name = "lbl_AssignedProjects";
            lbl_AssignedProjects.Size = new Size(0, 20);
            lbl_AssignedProjects.TabIndex = 81;
            // 
            // lbl_CompletedProjects
            // 
            lbl_CompletedProjects.AutoSize = true;
            lbl_CompletedProjects.Location = new Point(34, 438);
            lbl_CompletedProjects.Name = "lbl_CompletedProjects";
            lbl_CompletedProjects.Size = new Size(0, 20);
            lbl_CompletedProjects.TabIndex = 80;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(55, 305);
            label2.Name = "label2";
            label2.Size = new Size(118, 23);
            label2.TabIndex = 82;
            label2.Text = "Overdue Tasks";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(45, 400);
            label3.Name = "label3";
            label3.Size = new Size(137, 23);
            label3.TabIndex = 83;
            label3.Text = "Completed Tasks";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(93, 328);
            label4.Name = "label4";
            label4.Size = new Size(27, 31);
            label4.TabIndex = 84;
            label4.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(93, 434);
            label5.Name = "label5";
            label5.Size = new Size(27, 31);
            label5.TabIndex = 85;
            label5.Text = "0";
            // 
            // ProjectView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1151, 637);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl_AssignedProjects);
            Controls.Add(lbl_CompletedProjects);
            Controls.Add(btn_ViewProject);
            Controls.Add(btn_DeleteProject);
            Controls.Add(btn_UpdateProject);
            Controls.Add(btn_CreateProject);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(lbl_User);
            Controls.Add(txt_SearchTask);
            Controls.Add(btn_SearchTask);
            Controls.Add(lbl_SearchTask);
            Controls.Add(dgv_Tasks);
            Margin = new Padding(3, 4, 3, 4);
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
        private ComboBox comboBox1;
        private Label lbl_ProjectStartDate;
        private Label lbl_ProjectStatus;
        private ComboBox ddl_ProjectStatus;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btn_ViewProject;
        private Button btn_DeleteProject;
        private Button btn_UpdateProject;
        private Button btn_CreateProject;
        private Label lbl_AssignedProjects;
        private Label lbl_CompletedProjects;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}