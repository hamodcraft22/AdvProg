namespace advProj_ProjectManager
{
    partial class Create_Project
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
            lbl_CreateProject = new Label();
            lbl_ProjectName = new Label();
            lbl_ProjectStartDate = new Label();
            lbl_ProjectEndDate = new Label();
            lbl_ProjectStatus = new Label();
            lbl_ProjectDescription = new Label();
            txt_ProjectName = new TextBox();
            ddl_ProjectStatus = new ComboBox();
            projectStartDate = new DateTimePicker();
            projectEndDate = new DateTimePicker();
            txt_ProjectDescription = new RichTextBox();
            btn_CreateProject = new Button();
            btn_Return = new Button();
            SuspendLayout();
            // 
            // lbl_CreateProject
            // 
            lbl_CreateProject.AutoSize = true;
            lbl_CreateProject.Location = new Point(332, 38);
            lbl_CreateProject.Name = "lbl_CreateProject";
            lbl_CreateProject.Size = new Size(81, 15);
            lbl_CreateProject.TabIndex = 0;
            lbl_CreateProject.Text = "Create Project";
            // 
            // lbl_ProjectName
            // 
            lbl_ProjectName.AutoSize = true;
            lbl_ProjectName.Location = new Point(244, 101);
            lbl_ProjectName.Name = "lbl_ProjectName";
            lbl_ProjectName.Size = new Size(82, 15);
            lbl_ProjectName.TabIndex = 1;
            lbl_ProjectName.Text = "Project Name:";
            // 
            // lbl_ProjectStartDate
            // 
            lbl_ProjectStartDate.AutoSize = true;
            lbl_ProjectStartDate.Location = new Point(265, 145);
            lbl_ProjectStartDate.Name = "lbl_ProjectStartDate";
            lbl_ProjectStartDate.Size = new Size(61, 15);
            lbl_ProjectStartDate.TabIndex = 2;
            lbl_ProjectStartDate.Text = "Start Date:";
            // 
            // lbl_ProjectEndDate
            // 
            lbl_ProjectEndDate.AutoSize = true;
            lbl_ProjectEndDate.Location = new Point(269, 180);
            lbl_ProjectEndDate.Name = "lbl_ProjectEndDate";
            lbl_ProjectEndDate.Size = new Size(57, 15);
            lbl_ProjectEndDate.TabIndex = 3;
            lbl_ProjectEndDate.Text = "End Date:";
            // 
            // lbl_ProjectStatus
            // 
            lbl_ProjectStatus.AutoSize = true;
            lbl_ProjectStatus.Location = new Point(284, 213);
            lbl_ProjectStatus.Name = "lbl_ProjectStatus";
            lbl_ProjectStatus.Size = new Size(42, 15);
            lbl_ProjectStatus.TabIndex = 4;
            lbl_ProjectStatus.Text = "Status:";
            // 
            // lbl_ProjectDescription
            // 
            lbl_ProjectDescription.AutoSize = true;
            lbl_ProjectDescription.Location = new Point(216, 256);
            lbl_ProjectDescription.Name = "lbl_ProjectDescription";
            lbl_ProjectDescription.Size = new Size(110, 15);
            lbl_ProjectDescription.TabIndex = 5;
            lbl_ProjectDescription.Text = "Project Description:";
            // 
            // txt_ProjectName
            // 
            txt_ProjectName.Location = new Point(361, 98);
            txt_ProjectName.Name = "txt_ProjectName";
            txt_ProjectName.Size = new Size(200, 23);
            txt_ProjectName.TabIndex = 6;
            // 
            // ddl_ProjectStatus
            // 
            ddl_ProjectStatus.FormattingEnabled = true;
            ddl_ProjectStatus.Location = new Point(361, 210);
            ddl_ProjectStatus.Name = "ddl_ProjectStatus";
            ddl_ProjectStatus.Size = new Size(200, 23);
            ddl_ProjectStatus.TabIndex = 7;
            // 
            // projectStartDate
            // 
            projectStartDate.Location = new Point(361, 145);
            projectStartDate.Name = "projectStartDate";
            projectStartDate.Size = new Size(200, 23);
            projectStartDate.TabIndex = 8;
            // 
            // projectEndDate
            // 
            projectEndDate.Location = new Point(361, 174);
            projectEndDate.Name = "projectEndDate";
            projectEndDate.Size = new Size(200, 23);
            projectEndDate.TabIndex = 9;
            // 
            // txt_ProjectDescription
            // 
            txt_ProjectDescription.Location = new Point(361, 256);
            txt_ProjectDescription.Name = "txt_ProjectDescription";
            txt_ProjectDescription.Size = new Size(200, 96);
            txt_ProjectDescription.TabIndex = 10;
            txt_ProjectDescription.Text = "";
            // 
            // btn_CreateProject
            // 
            btn_CreateProject.Location = new Point(632, 383);
            btn_CreateProject.Name = "btn_CreateProject";
            btn_CreateProject.Size = new Size(98, 23);
            btn_CreateProject.TabIndex = 11;
            btn_CreateProject.Text = "Create Project";
            btn_CreateProject.UseVisualStyleBackColor = true;
            // 
            // btn_Return
            // 
            btn_Return.Location = new Point(143, 383);
            btn_Return.Name = "btn_Return";
            btn_Return.Size = new Size(75, 23);
            btn_Return.TabIndex = 12;
            btn_Return.Text = "Return";
            btn_Return.UseVisualStyleBackColor = true;
            // 
            // Create_Project
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Return);
            Controls.Add(btn_CreateProject);
            Controls.Add(txt_ProjectDescription);
            Controls.Add(projectEndDate);
            Controls.Add(projectStartDate);
            Controls.Add(ddl_ProjectStatus);
            Controls.Add(txt_ProjectName);
            Controls.Add(lbl_ProjectDescription);
            Controls.Add(lbl_ProjectStatus);
            Controls.Add(lbl_ProjectEndDate);
            Controls.Add(lbl_ProjectStartDate);
            Controls.Add(lbl_ProjectName);
            Controls.Add(lbl_CreateProject);
            Name = "Create_Project";
            Text = "Create Project";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_CreateProject;
        private Label lbl_ProjectName;
        private Label lbl_ProjectStartDate;
        private Label lbl_ProjectEndDate;
        private Label lbl_ProjectStatus;
        private Label lbl_ProjectDescription;
        private TextBox txt_ProjectName;
        private ComboBox ddl_ProjectStatus;
        private DateTimePicker projectStartDate;
        private DateTimePicker projectEndDate;
        private RichTextBox txt_ProjectDescription;
        private Button btn_CreateProject;
        private Button btn_Return;
    }
}