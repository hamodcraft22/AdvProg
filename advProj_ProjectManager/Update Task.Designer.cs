namespace advProj_ProjectManager
{
    partial class Update_Task
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
            btn_UpdateTask = new Button();
            lbl_UpdateTask = new Label();
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
            SuspendLayout();
            // 
            // btn_UpdateTask
            // 
            btn_UpdateTask.Location = new Point(613, 378);
            btn_UpdateTask.Name = "btn_UpdateTask";
            btn_UpdateTask.Size = new Size(97, 23);
            btn_UpdateTask.TabIndex = 39;
            btn_UpdateTask.Text = "Update Task";
            btn_UpdateTask.UseVisualStyleBackColor = true;
            // 
            // lbl_UpdateTask
            // 
            lbl_UpdateTask.AutoSize = true;
            lbl_UpdateTask.Location = new Point(360, 50);
            lbl_UpdateTask.Name = "lbl_UpdateTask";
            lbl_UpdateTask.Size = new Size(70, 15);
            lbl_UpdateTask.TabIndex = 38;
            lbl_UpdateTask.Text = "Update Task";
            // 
            // btn_Return
            // 
            btn_Return.Location = new Point(113, 378);
            btn_Return.Name = "btn_Return";
            btn_Return.Size = new Size(75, 23);
            btn_Return.TabIndex = 37;
            btn_Return.Text = "Return";
            btn_Return.UseVisualStyleBackColor = true;
            // 
            // txt_TaskDescription
            // 
            txt_TaskDescription.Location = new Point(331, 251);
            txt_TaskDescription.Name = "txt_TaskDescription";
            txt_TaskDescription.Size = new Size(200, 96);
            txt_TaskDescription.TabIndex = 36;
            txt_TaskDescription.Text = "";
            // 
            // taskEndDate
            // 
            taskEndDate.Location = new Point(331, 169);
            taskEndDate.Name = "taskEndDate";
            taskEndDate.Size = new Size(200, 23);
            taskEndDate.TabIndex = 35;
            // 
            // taskStartDate
            // 
            taskStartDate.Location = new Point(331, 140);
            taskStartDate.Name = "taskStartDate";
            taskStartDate.Size = new Size(200, 23);
            taskStartDate.TabIndex = 34;
            // 
            // ddl_TaskStatus
            // 
            ddl_TaskStatus.FormattingEnabled = true;
            ddl_TaskStatus.Location = new Point(331, 205);
            ddl_TaskStatus.Name = "ddl_TaskStatus";
            ddl_TaskStatus.Size = new Size(200, 23);
            ddl_TaskStatus.TabIndex = 33;
            // 
            // txt_TaskName
            // 
            txt_TaskName.Location = new Point(331, 93);
            txt_TaskName.Name = "txt_TaskName";
            txt_TaskName.Size = new Size(200, 23);
            txt_TaskName.TabIndex = 32;
            // 
            // lbl_TaskDescription
            // 
            lbl_TaskDescription.AutoSize = true;
            lbl_TaskDescription.Location = new Point(186, 251);
            lbl_TaskDescription.Name = "lbl_TaskDescription";
            lbl_TaskDescription.Size = new Size(95, 15);
            lbl_TaskDescription.TabIndex = 31;
            lbl_TaskDescription.Text = "Task Description:";
            // 
            // lbl_TaskStatus
            // 
            lbl_TaskStatus.AutoSize = true;
            lbl_TaskStatus.Location = new Point(254, 208);
            lbl_TaskStatus.Name = "lbl_TaskStatus";
            lbl_TaskStatus.Size = new Size(42, 15);
            lbl_TaskStatus.TabIndex = 30;
            lbl_TaskStatus.Text = "Status:";
            // 
            // lbl_TaskEndDate
            // 
            lbl_TaskEndDate.AutoSize = true;
            lbl_TaskEndDate.Location = new Point(239, 175);
            lbl_TaskEndDate.Name = "lbl_TaskEndDate";
            lbl_TaskEndDate.Size = new Size(57, 15);
            lbl_TaskEndDate.TabIndex = 29;
            lbl_TaskEndDate.Text = "End Date:";
            // 
            // lbl_TaskStartDate
            // 
            lbl_TaskStartDate.AutoSize = true;
            lbl_TaskStartDate.Location = new Point(235, 140);
            lbl_TaskStartDate.Name = "lbl_TaskStartDate";
            lbl_TaskStartDate.Size = new Size(61, 15);
            lbl_TaskStartDate.TabIndex = 28;
            lbl_TaskStartDate.Text = "Start Date:";
            // 
            // lbl_TaskName
            // 
            lbl_TaskName.AutoSize = true;
            lbl_TaskName.Location = new Point(214, 96);
            lbl_TaskName.Name = "lbl_TaskName";
            lbl_TaskName.Size = new Size(67, 15);
            lbl_TaskName.TabIndex = 27;
            lbl_TaskName.Text = "Task Name:";
            // 
            // Update_Task
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_UpdateTask);
            Controls.Add(lbl_UpdateTask);
            Controls.Add(btn_Return);
            Controls.Add(txt_TaskDescription);
            Controls.Add(taskEndDate);
            Controls.Add(taskStartDate);
            Controls.Add(ddl_TaskStatus);
            Controls.Add(txt_TaskName);
            Controls.Add(lbl_TaskDescription);
            Controls.Add(lbl_TaskStatus);
            Controls.Add(lbl_TaskEndDate);
            Controls.Add(lbl_TaskStartDate);
            Controls.Add(lbl_TaskName);
            Name = "Update_Task";
            Text = "Update Task";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_UpdateTask;
        private Label lbl_UpdateTask;
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
    }
}