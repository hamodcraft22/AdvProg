namespace advProj_ProjectManager
{
    partial class CreateTask
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
            btn_Return = new Button();
            txt_TaskDescription = new RichTextBox();
            taskEndDate = new DateTimePicker();
            taskStartDate = new DateTimePicker();
            ddl_TaskStatus = new ComboBox();
            txt_TaskName = new TextBox();
            lbl_TaskDescription = new Label();
            lbl_TaskStatus = new Label();
            lbl_TaskEndDate = new Label();
            lbl_TaskStartDate = new Label();
            lbl_TaskName = new Label();
            lbl_CreateTask = new Label();
            btn_CreateTask = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Return
            // 
            btn_Return.BackColor = SystemColors.GradientActiveCaption;
            btn_Return.Location = new Point(20, 321);
            btn_Return.Name = "btn_Return";
            btn_Return.Size = new Size(103, 36);
            btn_Return.TabIndex = 24;
            btn_Return.Text = "Return";
            btn_Return.UseVisualStyleBackColor = false;
            btn_Return.Click += btn_Return_Click;
            // 
            // txt_TaskDescription
            // 
            txt_TaskDescription.Location = new Point(166, 172);
            txt_TaskDescription.Name = "txt_TaskDescription";
            txt_TaskDescription.Size = new Size(213, 96);
            txt_TaskDescription.TabIndex = 22;
            txt_TaskDescription.Text = "";
            // 
            // taskEndDate
            // 
            taskEndDate.Location = new Point(166, 100);
            taskEndDate.Name = "taskEndDate";
            taskEndDate.Size = new Size(213, 23);
            taskEndDate.TabIndex = 21;
            // 
            // taskStartDate
            // 
            taskStartDate.Location = new Point(166, 63);
            taskStartDate.Name = "taskStartDate";
            taskStartDate.Size = new Size(213, 23);
            taskStartDate.TabIndex = 20;
            // 
            // ddl_TaskStatus
            // 
            ddl_TaskStatus.FormattingEnabled = true;
            ddl_TaskStatus.Location = new Point(166, 134);
            ddl_TaskStatus.Name = "ddl_TaskStatus";
            ddl_TaskStatus.Size = new Size(213, 23);
            ddl_TaskStatus.TabIndex = 19;
            // 
            // txt_TaskName
            // 
            txt_TaskName.Location = new Point(166, 27);
            txt_TaskName.Name = "txt_TaskName";
            txt_TaskName.Size = new Size(213, 23);
            txt_TaskName.TabIndex = 18;
            // 
            // lbl_TaskDescription
            // 
            lbl_TaskDescription.AutoSize = true;
            lbl_TaskDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TaskDescription.Location = new Point(31, 172);
            lbl_TaskDescription.Name = "lbl_TaskDescription";
            lbl_TaskDescription.Size = new Size(97, 15);
            lbl_TaskDescription.TabIndex = 17;
            lbl_TaskDescription.Text = "Task Description:";
            // 
            // lbl_TaskStatus
            // 
            lbl_TaskStatus.AutoSize = true;
            lbl_TaskStatus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TaskStatus.Location = new Point(31, 134);
            lbl_TaskStatus.Name = "lbl_TaskStatus";
            lbl_TaskStatus.Size = new Size(43, 15);
            lbl_TaskStatus.TabIndex = 16;
            lbl_TaskStatus.Text = "Status:";
            // 
            // lbl_TaskEndDate
            // 
            lbl_TaskEndDate.AutoSize = true;
            lbl_TaskEndDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TaskEndDate.Location = new Point(31, 100);
            lbl_TaskEndDate.Name = "lbl_TaskEndDate";
            lbl_TaskEndDate.Size = new Size(58, 15);
            lbl_TaskEndDate.TabIndex = 15;
            lbl_TaskEndDate.Text = "End Date:";
            // 
            // lbl_TaskStartDate
            // 
            lbl_TaskStartDate.AutoSize = true;
            lbl_TaskStartDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TaskStartDate.Location = new Point(29, 63);
            lbl_TaskStartDate.Name = "lbl_TaskStartDate";
            lbl_TaskStartDate.Size = new Size(63, 15);
            lbl_TaskStartDate.TabIndex = 14;
            lbl_TaskStartDate.Text = "Start Date:";
            // 
            // lbl_TaskName
            // 
            lbl_TaskName.AutoSize = true;
            lbl_TaskName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TaskName.Location = new Point(30, 29);
            lbl_TaskName.Name = "lbl_TaskName";
            lbl_TaskName.Size = new Size(68, 15);
            lbl_TaskName.TabIndex = 13;
            lbl_TaskName.Text = "Task Name:";
            // 
            // lbl_CreateTask
            // 
            lbl_CreateTask.AutoSize = true;
            lbl_CreateTask.Location = new Point(365, 28);
            lbl_CreateTask.Name = "lbl_CreateTask";
            lbl_CreateTask.Size = new Size(0, 15);
            lbl_CreateTask.TabIndex = 25;
            // 
            // btn_CreateTask
            // 
            btn_CreateTask.BackColor = SystemColors.GradientActiveCaption;
            btn_CreateTask.Location = new Point(308, 321);
            btn_CreateTask.Name = "btn_CreateTask";
            btn_CreateTask.Size = new Size(109, 36);
            btn_CreateTask.TabIndex = 26;
            btn_CreateTask.Text = "Create Task";
            btn_CreateTask.UseVisualStyleBackColor = false;
            btn_CreateTask.Click += btn_CreateTask_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_TaskName);
            groupBox1.Controls.Add(txt_TaskName);
            groupBox1.Controls.Add(lbl_TaskStartDate);
            groupBox1.Controls.Add(taskStartDate);
            groupBox1.Controls.Add(txt_TaskDescription);
            groupBox1.Controls.Add(lbl_TaskEndDate);
            groupBox1.Controls.Add(lbl_TaskDescription);
            groupBox1.Controls.Add(ddl_TaskStatus);
            groupBox1.Controls.Add(taskEndDate);
            groupBox1.Controls.Add(lbl_TaskStatus);
            groupBox1.Location = new Point(20, 15);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(397, 293);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task Info";
            // 
            // CreateTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(438, 374);
            Controls.Add(groupBox1);
            Controls.Add(btn_CreateTask);
            Controls.Add(lbl_CreateTask);
            Controls.Add(btn_Return);
            Name = "CreateTask";
            Text = "Create Task";
            Load += CreateTask_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Return;
        private RichTextBox txt_TaskDescription;
        private DateTimePicker taskEndDate;
        private DateTimePicker taskStartDate;
        private ComboBox ddl_TaskStatus;
        private TextBox txt_TaskName;
        private Label lbl_TaskDescription;
        private Label lbl_TaskStatus;
        private Label lbl_TaskEndDate;
        private Label lbl_TaskStartDate;
        private Label lbl_TaskName;
        private Label lbl_CreateTask;
        private Button btn_CreateTask;
        private GroupBox groupBox1;
    }
}