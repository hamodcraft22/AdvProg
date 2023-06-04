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
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_ProjectName
            // 
            lbl_ProjectName.AutoSize = true;
            lbl_ProjectName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ProjectName.Location = new Point(18, 34);
            lbl_ProjectName.Name = "lbl_ProjectName";
            lbl_ProjectName.Size = new Size(82, 15);
            lbl_ProjectName.TabIndex = 1;
            lbl_ProjectName.Text = "Project Name:";
            // 
            // lbl_ProjectStartDate
            // 
            lbl_ProjectStartDate.AutoSize = true;
            lbl_ProjectStartDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ProjectStartDate.Location = new Point(18, 72);
            lbl_ProjectStartDate.Name = "lbl_ProjectStartDate";
            lbl_ProjectStartDate.Size = new Size(63, 15);
            lbl_ProjectStartDate.TabIndex = 2;
            lbl_ProjectStartDate.Text = "Start Date:";
            // 
            // lbl_ProjectEndDate
            // 
            lbl_ProjectEndDate.AutoSize = true;
            lbl_ProjectEndDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ProjectEndDate.Location = new Point(18, 110);
            lbl_ProjectEndDate.Name = "lbl_ProjectEndDate";
            lbl_ProjectEndDate.Size = new Size(58, 15);
            lbl_ProjectEndDate.TabIndex = 3;
            lbl_ProjectEndDate.Text = "End Date:";
            // 
            // lbl_ProjectStatus
            // 
            lbl_ProjectStatus.AutoSize = true;
            lbl_ProjectStatus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ProjectStatus.Location = new Point(18, 152);
            lbl_ProjectStatus.Name = "lbl_ProjectStatus";
            lbl_ProjectStatus.Size = new Size(43, 15);
            lbl_ProjectStatus.TabIndex = 4;
            lbl_ProjectStatus.Text = "Status:";
            // 
            // lbl_ProjectDescription
            // 
            lbl_ProjectDescription.AutoSize = true;
            lbl_ProjectDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ProjectDescription.Location = new Point(18, 191);
            lbl_ProjectDescription.Name = "lbl_ProjectDescription";
            lbl_ProjectDescription.Size = new Size(111, 15);
            lbl_ProjectDescription.TabIndex = 5;
            lbl_ProjectDescription.Text = "Project Description:";
            // 
            // txt_ProjectName
            // 
            txt_ProjectName.Location = new Point(162, 28);
            txt_ProjectName.Name = "txt_ProjectName";
            txt_ProjectName.Size = new Size(217, 23);
            txt_ProjectName.TabIndex = 6;
            // 
            // ddl_ProjectStatus
            // 
            ddl_ProjectStatus.FormattingEnabled = true;
            ddl_ProjectStatus.Location = new Point(162, 146);
            ddl_ProjectStatus.Name = "ddl_ProjectStatus";
            ddl_ProjectStatus.Size = new Size(217, 23);
            ddl_ProjectStatus.TabIndex = 7;
            // 
            // projectStartDate
            // 
            projectStartDate.Location = new Point(162, 67);
            projectStartDate.Name = "projectStartDate";
            projectStartDate.Size = new Size(217, 23);
            projectStartDate.TabIndex = 8;
            // 
            // projectEndDate
            // 
            projectEndDate.Location = new Point(162, 106);
            projectEndDate.Name = "projectEndDate";
            projectEndDate.Size = new Size(217, 23);
            projectEndDate.TabIndex = 9;
            // 
            // txt_ProjectDescription
            // 
            txt_ProjectDescription.Location = new Point(162, 191);
            txt_ProjectDescription.Name = "txt_ProjectDescription";
            txt_ProjectDescription.Size = new Size(215, 102);
            txt_ProjectDescription.TabIndex = 10;
            txt_ProjectDescription.Text = "";
            // 
            // btn_CreateProject
            // 
            btn_CreateProject.BackColor = SystemColors.GradientActiveCaption;
            btn_CreateProject.Location = new Point(297, 341);
            btn_CreateProject.Name = "btn_CreateProject";
            btn_CreateProject.Size = new Size(121, 38);
            btn_CreateProject.TabIndex = 11;
            btn_CreateProject.Text = "Create Project";
            btn_CreateProject.UseVisualStyleBackColor = false;
            btn_CreateProject.Click += btn_CreateProject_Click;
            // 
            // btn_Return
            // 
            btn_Return.BackColor = SystemColors.GradientActiveCaption;
            btn_Return.Location = new Point(20, 341);
            btn_Return.Name = "btn_Return";
            btn_Return.Size = new Size(117, 38);
            btn_Return.TabIndex = 12;
            btn_Return.Text = "Return";
            btn_Return.UseVisualStyleBackColor = false;
            btn_Return.Click += btn_Return_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_ProjectName);
            groupBox1.Controls.Add(txt_ProjectName);
            groupBox1.Controls.Add(lbl_ProjectStartDate);
            groupBox1.Controls.Add(txt_ProjectDescription);
            groupBox1.Controls.Add(projectStartDate);
            groupBox1.Controls.Add(lbl_ProjectDescription);
            groupBox1.Controls.Add(ddl_ProjectStatus);
            groupBox1.Controls.Add(projectEndDate);
            groupBox1.Controls.Add(lbl_ProjectEndDate);
            groupBox1.Controls.Add(lbl_ProjectStatus);
            groupBox1.Location = new Point(20, 19);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(397, 309);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Project Info";
            // 
            // Create_Project
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(443, 396);
            Controls.Add(groupBox1);
            Controls.Add(btn_Return);
            Controls.Add(btn_CreateProject);
            Name = "Create_Project";
            Text = "Create Project";
            Load += Create_Project_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
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
        private GroupBox groupBox1;
    }
}