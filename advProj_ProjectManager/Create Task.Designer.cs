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
            btn_Return.Location = new Point(23, 428);
            btn_Return.Margin = new Padding(3, 4, 3, 4);
            btn_Return.Name = "btn_Return";
            btn_Return.Size = new Size(118, 48);
            btn_Return.TabIndex = 24;
            btn_Return.Text = "Return";
            btn_Return.UseVisualStyleBackColor = false;
            // 
            // txt_TaskDescription
            // 
            txt_TaskDescription.Location = new Point(190, 230);
            txt_TaskDescription.Margin = new Padding(3, 4, 3, 4);
            txt_TaskDescription.Name = "txt_TaskDescription";
            txt_TaskDescription.Size = new Size(243, 127);
            txt_TaskDescription.TabIndex = 22;
            txt_TaskDescription.Text = "";
            // 
            // taskEndDate
            // 
            taskEndDate.Location = new Point(190, 134);
            taskEndDate.Margin = new Padding(3, 4, 3, 4);
            taskEndDate.Name = "taskEndDate";
            taskEndDate.Size = new Size(243, 27);
            taskEndDate.TabIndex = 21;
            // 
            // taskStartDate
            // 
            taskStartDate.Location = new Point(190, 84);
            taskStartDate.Margin = new Padding(3, 4, 3, 4);
            taskStartDate.Name = "taskStartDate";
            taskStartDate.Size = new Size(243, 27);
            taskStartDate.TabIndex = 20;
            // 
            // ddl_TaskStatus
            // 
            ddl_TaskStatus.FormattingEnabled = true;
            ddl_TaskStatus.Location = new Point(190, 178);
            ddl_TaskStatus.Margin = new Padding(3, 4, 3, 4);
            ddl_TaskStatus.Name = "ddl_TaskStatus";
            ddl_TaskStatus.Size = new Size(243, 28);
            ddl_TaskStatus.TabIndex = 19;
            // 
            // txt_TaskName
            // 
            txt_TaskName.Location = new Point(190, 36);
            txt_TaskName.Margin = new Padding(3, 4, 3, 4);
            txt_TaskName.Name = "txt_TaskName";
            txt_TaskName.Size = new Size(243, 27);
            txt_TaskName.TabIndex = 18;
            // 
            // lbl_TaskDescription
            // 
            lbl_TaskDescription.AutoSize = true;
            lbl_TaskDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TaskDescription.Location = new Point(35, 230);
            lbl_TaskDescription.Name = "lbl_TaskDescription";
            lbl_TaskDescription.Size = new Size(124, 20);
            lbl_TaskDescription.TabIndex = 17;
            lbl_TaskDescription.Text = "Task Description:";
            // 
            // lbl_TaskStatus
            // 
            lbl_TaskStatus.AutoSize = true;
            lbl_TaskStatus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TaskStatus.Location = new Point(35, 178);
            lbl_TaskStatus.Name = "lbl_TaskStatus";
            lbl_TaskStatus.Size = new Size(54, 20);
            lbl_TaskStatus.TabIndex = 16;
            lbl_TaskStatus.Text = "Status:";
            // 
            // lbl_TaskEndDate
            // 
            lbl_TaskEndDate.AutoSize = true;
            lbl_TaskEndDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TaskEndDate.Location = new Point(35, 134);
            lbl_TaskEndDate.Name = "lbl_TaskEndDate";
            lbl_TaskEndDate.Size = new Size(75, 20);
            lbl_TaskEndDate.TabIndex = 15;
            lbl_TaskEndDate.Text = "End Date:";
            // 
            // lbl_TaskStartDate
            // 
            lbl_TaskStartDate.AutoSize = true;
            lbl_TaskStartDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TaskStartDate.Location = new Point(33, 84);
            lbl_TaskStartDate.Name = "lbl_TaskStartDate";
            lbl_TaskStartDate.Size = new Size(81, 20);
            lbl_TaskStartDate.TabIndex = 14;
            lbl_TaskStartDate.Text = "Start Date:";
            // 
            // lbl_TaskName
            // 
            lbl_TaskName.AutoSize = true;
            lbl_TaskName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TaskName.Location = new Point(34, 39);
            lbl_TaskName.Name = "lbl_TaskName";
            lbl_TaskName.Size = new Size(87, 20);
            lbl_TaskName.TabIndex = 13;
            lbl_TaskName.Text = "Task Name:";
            // 
            // lbl_CreateTask
            // 
            lbl_CreateTask.AutoSize = true;
            lbl_CreateTask.Location = new Point(417, 37);
            lbl_CreateTask.Name = "lbl_CreateTask";
            lbl_CreateTask.Size = new Size(0, 20);
            lbl_CreateTask.TabIndex = 25;
            // 
            // btn_CreateTask
            // 
            btn_CreateTask.BackColor = SystemColors.GradientActiveCaption;
            btn_CreateTask.Location = new Point(352, 428);
            btn_CreateTask.Margin = new Padding(3, 4, 3, 4);
            btn_CreateTask.Name = "btn_CreateTask";
            btn_CreateTask.Size = new Size(125, 48);
            btn_CreateTask.TabIndex = 26;
            btn_CreateTask.Text = "Create Task";
            btn_CreateTask.UseVisualStyleBackColor = false;
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
            groupBox1.Location = new Point(23, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(454, 391);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task Info";
            // 
            // CreateTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(500, 498);
            Controls.Add(groupBox1);
            Controls.Add(btn_CreateTask);
            Controls.Add(lbl_CreateTask);
            Controls.Add(btn_Return);
            Margin = new Padding(3, 4, 3, 4);
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