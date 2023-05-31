namespace advProj_ProjectManager
{
    partial class Update_Projects
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
            btn_ProjectUpdate = new Button();
            txt_ProjectDescription = new RichTextBox();
            projectEndDate = new DateTimePicker();
            ProjectstartDate = new DateTimePicker();
            ddl_ProjectStatus = new ComboBox();
            txt_ProjectName = new TextBox();
            lbl_ProjectDescription = new Label();
            lbl_ProjectStatus = new Label();
            lbl_ProjectEndDate = new Label();
            lbl_ProjectStartDate = new Label();
            lbl_ProjectName = new Label();
            lbl_UpdateProject = new Label();
            SuspendLayout();
            // 
            // btn_Return
            // 
            btn_Return.Location = new Point(118, 386);
            btn_Return.Name = "btn_Return";
            btn_Return.Size = new Size(75, 23);
            btn_Return.TabIndex = 25;
            btn_Return.Text = "Return";
            btn_Return.UseVisualStyleBackColor = true;
            // 
            // btn_ProjectUpdate
            // 
            btn_ProjectUpdate.Location = new Point(607, 386);
            btn_ProjectUpdate.Name = "btn_ProjectUpdate";
            btn_ProjectUpdate.Size = new Size(102, 23);
            btn_ProjectUpdate.TabIndex = 24;
            btn_ProjectUpdate.Text = "Update Project";
            btn_ProjectUpdate.UseVisualStyleBackColor = true;
            // 
            // txt_ProjectDescription
            // 
            txt_ProjectDescription.Location = new Point(336, 259);
            txt_ProjectDescription.Name = "txt_ProjectDescription";
            txt_ProjectDescription.Size = new Size(200, 96);
            txt_ProjectDescription.TabIndex = 23;
            txt_ProjectDescription.Text = "";
            // 
            // projectEndDate
            // 
            projectEndDate.Location = new Point(336, 177);
            projectEndDate.Name = "projectEndDate";
            projectEndDate.Size = new Size(200, 23);
            projectEndDate.TabIndex = 22;
            // 
            // ProjectstartDate
            // 
            ProjectstartDate.Location = new Point(336, 148);
            ProjectstartDate.Name = "ProjectstartDate";
            ProjectstartDate.Size = new Size(200, 23);
            ProjectstartDate.TabIndex = 21;
            // 
            // ddl_ProjectStatus
            // 
            ddl_ProjectStatus.FormattingEnabled = true;
            ddl_ProjectStatus.Location = new Point(336, 213);
            ddl_ProjectStatus.Name = "ddl_ProjectStatus";
            ddl_ProjectStatus.Size = new Size(200, 23);
            ddl_ProjectStatus.TabIndex = 20;
            // 
            // txt_ProjectName
            // 
            txt_ProjectName.Location = new Point(336, 101);
            txt_ProjectName.Name = "txt_ProjectName";
            txt_ProjectName.Size = new Size(200, 23);
            txt_ProjectName.TabIndex = 19;
            // 
            // lbl_ProjectDescription
            // 
            lbl_ProjectDescription.AutoSize = true;
            lbl_ProjectDescription.Location = new Point(191, 259);
            lbl_ProjectDescription.Name = "lbl_ProjectDescription";
            lbl_ProjectDescription.Size = new Size(110, 15);
            lbl_ProjectDescription.TabIndex = 18;
            lbl_ProjectDescription.Text = "Project Description:";
            // 
            // lbl_ProjectStatus
            // 
            lbl_ProjectStatus.AutoSize = true;
            lbl_ProjectStatus.Location = new Point(259, 216);
            lbl_ProjectStatus.Name = "lbl_ProjectStatus";
            lbl_ProjectStatus.Size = new Size(42, 15);
            lbl_ProjectStatus.TabIndex = 17;
            lbl_ProjectStatus.Text = "Status:";
            // 
            // lbl_ProjectEndDate
            // 
            lbl_ProjectEndDate.AutoSize = true;
            lbl_ProjectEndDate.Location = new Point(244, 183);
            lbl_ProjectEndDate.Name = "lbl_ProjectEndDate";
            lbl_ProjectEndDate.Size = new Size(57, 15);
            lbl_ProjectEndDate.TabIndex = 16;
            lbl_ProjectEndDate.Text = "End Date:";
            // 
            // lbl_ProjectStartDate
            // 
            lbl_ProjectStartDate.AutoSize = true;
            lbl_ProjectStartDate.Location = new Point(240, 148);
            lbl_ProjectStartDate.Name = "lbl_ProjectStartDate";
            lbl_ProjectStartDate.Size = new Size(61, 15);
            lbl_ProjectStartDate.TabIndex = 15;
            lbl_ProjectStartDate.Text = "Start Date:";
            // 
            // lbl_ProjectName
            // 
            lbl_ProjectName.AutoSize = true;
            lbl_ProjectName.Location = new Point(219, 104);
            lbl_ProjectName.Name = "lbl_ProjectName";
            lbl_ProjectName.Size = new Size(82, 15);
            lbl_ProjectName.TabIndex = 14;
            lbl_ProjectName.Text = "Project Name:";
            // 
            // lbl_UpdateProject
            // 
            lbl_UpdateProject.AutoSize = true;
            lbl_UpdateProject.Location = new Point(307, 41);
            lbl_UpdateProject.Name = "lbl_UpdateProject";
            lbl_UpdateProject.Size = new Size(85, 15);
            lbl_UpdateProject.TabIndex = 13;
            lbl_UpdateProject.Text = "Update Project";
            // 
            // Update_Projects
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Return);
            Controls.Add(btn_ProjectUpdate);
            Controls.Add(txt_ProjectDescription);
            Controls.Add(projectEndDate);
            Controls.Add(ProjectstartDate);
            Controls.Add(ddl_ProjectStatus);
            Controls.Add(txt_ProjectName);
            Controls.Add(lbl_ProjectDescription);
            Controls.Add(lbl_ProjectStatus);
            Controls.Add(lbl_ProjectEndDate);
            Controls.Add(lbl_ProjectStartDate);
            Controls.Add(lbl_ProjectName);
            Controls.Add(lbl_UpdateProject);
            Name = "Update_Projects";
            Text = "Update Projects";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Return;
        private Button btn_ProjectUpdate;
        private RichTextBox txt_ProjectDescription;
        private DateTimePicker projectEndDate;
        private DateTimePicker ProjectstartDate;
        private ComboBox ddl_ProjectStatus;
        private TextBox txt_ProjectName;
        private Label lbl_ProjectDescription;
        private Label lbl_ProjectStatus;
        private Label lbl_ProjectEndDate;
        private Label lbl_ProjectStartDate;
        private Label lbl_ProjectName;
        private Label lbl_UpdateProject;
    }
}