namespace advProj_ProjectManager
{
    partial class ShowInfo
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
            lbl_Logs = new Label();
            dgv_Logs = new DataGridView();
            btn_Return = new Button();
            lbl_Audits = new Label();
            dataGridView1 = new DataGridView();
            lbl_LogSource = new Label();
            lbl_AuditSource = new Label();
            lbl_LogUser = new Label();
            ddl_LogSource = new ComboBox();
            ddl_LogUser = new ComboBox();
            btn_FilterLogs = new Button();
            btn_RefreshLogs = new Button();
            ddl_AuditSource = new ComboBox();
            lbl_SourceType = new Label();
            ddl_SourceType = new ComboBox();
            lbl_AuditUser = new Label();
            ddl_AuditUser = new ComboBox();
            btn_FilterAudits = new Button();
            btn_RefreshAudits = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Logs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl_Logs
            // 
            lbl_Logs.AutoSize = true;
            lbl_Logs.Location = new Point(73, 25);
            lbl_Logs.Name = "lbl_Logs";
            lbl_Logs.Size = new Size(60, 15);
            lbl_Logs.TabIndex = 0;
            lbl_Logs.Text = "View Logs";
            // 
            // dgv_Logs
            // 
            dgv_Logs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Logs.Location = new Point(12, 63);
            dgv_Logs.Name = "dgv_Logs";
            dgv_Logs.RowTemplate.Height = 25;
            dgv_Logs.Size = new Size(246, 309);
            dgv_Logs.TabIndex = 1;
            // 
            // btn_Return
            // 
            btn_Return.Location = new Point(73, 393);
            btn_Return.Name = "btn_Return";
            btn_Return.Size = new Size(90, 23);
            btn_Return.TabIndex = 41;
            btn_Return.Text = "Return";
            btn_Return.UseVisualStyleBackColor = true;
            // 
            // lbl_Audits
            // 
            lbl_Audits.AutoSize = true;
            lbl_Audits.Location = new Point(476, 25);
            lbl_Audits.Name = "lbl_Audits";
            lbl_Audits.Size = new Size(69, 15);
            lbl_Audits.TabIndex = 42;
            lbl_Audits.Text = "View Audits";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(392, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 309);
            dataGridView1.TabIndex = 43;
            // 
            // lbl_LogSource
            // 
            lbl_LogSource.AutoSize = true;
            lbl_LogSource.Location = new Point(289, 91);
            lbl_LogSource.Name = "lbl_LogSource";
            lbl_LogSource.Size = new Size(66, 15);
            lbl_LogSource.TabIndex = 44;
            lbl_LogSource.Text = "Log Source";
            // 
            // lbl_AuditSource
            // 
            lbl_AuditSource.AutoSize = true;
            lbl_AuditSource.Location = new Point(689, 91);
            lbl_AuditSource.Name = "lbl_AuditSource";
            lbl_AuditSource.Size = new Size(75, 15);
            lbl_AuditSource.TabIndex = 45;
            lbl_AuditSource.Text = "Audit Source";
            // 
            // lbl_LogUser
            // 
            lbl_LogUser.AutoSize = true;
            lbl_LogUser.Location = new Point(299, 167);
            lbl_LogUser.Name = "lbl_LogUser";
            lbl_LogUser.Size = new Size(53, 15);
            lbl_LogUser.TabIndex = 46;
            lbl_LogUser.Text = "Log User";
            // 
            // ddl_LogSource
            // 
            ddl_LogSource.FormattingEnabled = true;
            ddl_LogSource.Location = new Point(265, 120);
            ddl_LogSource.Name = "ddl_LogSource";
            ddl_LogSource.Size = new Size(121, 23);
            ddl_LogSource.TabIndex = 47;
            // 
            // ddl_LogUser
            // 
            ddl_LogUser.FormattingEnabled = true;
            ddl_LogUser.Location = new Point(265, 202);
            ddl_LogUser.Name = "ddl_LogUser";
            ddl_LogUser.Size = new Size(121, 23);
            ddl_LogUser.TabIndex = 48;
            // 
            // btn_FilterLogs
            // 
            btn_FilterLogs.Location = new Point(279, 247);
            btn_FilterLogs.Name = "btn_FilterLogs";
            btn_FilterLogs.Size = new Size(96, 23);
            btn_FilterLogs.TabIndex = 49;
            btn_FilterLogs.Text = "Filter Logs";
            btn_FilterLogs.UseVisualStyleBackColor = true;
            // 
            // btn_RefreshLogs
            // 
            btn_RefreshLogs.Location = new Point(279, 290);
            btn_RefreshLogs.Name = "btn_RefreshLogs";
            btn_RefreshLogs.Size = new Size(96, 23);
            btn_RefreshLogs.TabIndex = 50;
            btn_RefreshLogs.Text = "Refresh Logs";
            btn_RefreshLogs.UseVisualStyleBackColor = true;
            // 
            // ddl_AuditSource
            // 
            ddl_AuditSource.FormattingEnabled = true;
            ddl_AuditSource.Location = new Point(658, 120);
            ddl_AuditSource.Name = "ddl_AuditSource";
            ddl_AuditSource.Size = new Size(130, 23);
            ddl_AuditSource.TabIndex = 51;
            // 
            // lbl_SourceType
            // 
            lbl_SourceType.AutoSize = true;
            lbl_SourceType.Location = new Point(689, 167);
            lbl_SourceType.Name = "lbl_SourceType";
            lbl_SourceType.Size = new Size(70, 15);
            lbl_SourceType.TabIndex = 52;
            lbl_SourceType.Text = "Source Type";
            // 
            // ddl_SourceType
            // 
            ddl_SourceType.FormattingEnabled = true;
            ddl_SourceType.Location = new Point(658, 185);
            ddl_SourceType.Name = "ddl_SourceType";
            ddl_SourceType.Size = new Size(130, 23);
            ddl_SourceType.TabIndex = 53;
            // 
            // lbl_AuditUser
            // 
            lbl_AuditUser.AutoSize = true;
            lbl_AuditUser.Location = new Point(689, 230);
            lbl_AuditUser.Name = "lbl_AuditUser";
            lbl_AuditUser.Size = new Size(62, 15);
            lbl_AuditUser.TabIndex = 54;
            lbl_AuditUser.Text = "Audit User";
            // 
            // ddl_AuditUser
            // 
            ddl_AuditUser.FormattingEnabled = true;
            ddl_AuditUser.Location = new Point(658, 248);
            ddl_AuditUser.Name = "ddl_AuditUser";
            ddl_AuditUser.Size = new Size(121, 23);
            ddl_AuditUser.TabIndex = 55;
            // 
            // btn_FilterAudits
            // 
            btn_FilterAudits.Location = new Point(667, 290);
            btn_FilterAudits.Name = "btn_FilterAudits";
            btn_FilterAudits.Size = new Size(97, 23);
            btn_FilterAudits.TabIndex = 56;
            btn_FilterAudits.Text = "Filter Audits";
            btn_FilterAudits.UseVisualStyleBackColor = true;
            // 
            // btn_RefreshAudits
            // 
            btn_RefreshAudits.Location = new Point(672, 319);
            btn_RefreshAudits.Name = "btn_RefreshAudits";
            btn_RefreshAudits.Size = new Size(92, 23);
            btn_RefreshAudits.TabIndex = 57;
            btn_RefreshAudits.Text = "Refresh Audits";
            btn_RefreshAudits.UseVisualStyleBackColor = true;
            // 
            // ShowInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_RefreshAudits);
            Controls.Add(btn_FilterAudits);
            Controls.Add(ddl_AuditUser);
            Controls.Add(lbl_AuditUser);
            Controls.Add(ddl_SourceType);
            Controls.Add(lbl_SourceType);
            Controls.Add(ddl_AuditSource);
            Controls.Add(btn_RefreshLogs);
            Controls.Add(btn_FilterLogs);
            Controls.Add(ddl_LogUser);
            Controls.Add(ddl_LogSource);
            Controls.Add(lbl_LogUser);
            Controls.Add(lbl_AuditSource);
            Controls.Add(lbl_LogSource);
            Controls.Add(dataGridView1);
            Controls.Add(lbl_Audits);
            Controls.Add(btn_Return);
            Controls.Add(dgv_Logs);
            Controls.Add(lbl_Logs);
            Name = "ShowInfo";
            Text = "Show Information";
            ((System.ComponentModel.ISupportInitialize)dgv_Logs).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Logs;
        private DataGridView dgv_Logs;
        private Button btn_Return;
        private Label lbl_Audits;
        private DataGridView dataGridView1;
        private Label lbl_LogSource;
        private Label lbl_AuditSource;
        private Label lbl_LogUser;
        private ComboBox ddl_LogSource;
        private ComboBox ddl_LogUser;
        private Button btn_FilterLogs;
        private Button btn_RefreshLogs;
        private ComboBox ddl_AuditSource;
        private Label lbl_SourceType;
        private ComboBox ddl_SourceType;
        private Label lbl_AuditUser;
        private ComboBox ddl_AuditUser;
        private Button btn_FilterAudits;
        private Button btn_RefreshAudits;
    }
}