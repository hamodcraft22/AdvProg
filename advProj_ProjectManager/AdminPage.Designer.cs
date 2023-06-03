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
            dgv_Logs = new DataGridView();
            btn_Return = new Button();
            lbl_LogUser = new Label();
            ddl_LogUser = new ComboBox();
            btn_FilterLogs = new Button();
            btn_RefreshLogs = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ddlAduitUser = new ComboBox();
            label3 = new Label();
            dgv_Audits = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Logs).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Audits).BeginInit();
            SuspendLayout();
            // 
            // dgv_Logs
            // 
            dgv_Logs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Logs.Location = new Point(22, 23);
            dgv_Logs.Name = "dgv_Logs";
            dgv_Logs.RowHeadersWidth = 51;
            dgv_Logs.RowTemplate.Height = 25;
            dgv_Logs.Size = new Size(312, 201);
            dgv_Logs.TabIndex = 1;
            // 
            // btn_Return
            // 
            btn_Return.BackColor = SystemColors.GradientActiveCaption;
            btn_Return.Location = new Point(26, 419);
            btn_Return.Name = "btn_Return";
            btn_Return.Size = new Size(90, 34);
            btn_Return.TabIndex = 41;
            btn_Return.Text = "Return";
            btn_Return.UseVisualStyleBackColor = false;
            btn_Return.Click += btn_Return_Click;
            // 
            // lbl_LogUser
            // 
            lbl_LogUser.AutoSize = true;
            lbl_LogUser.Location = new Point(31, 243);
            lbl_LogUser.Name = "lbl_LogUser";
            lbl_LogUser.Size = new Size(53, 15);
            lbl_LogUser.TabIndex = 46;
            lbl_LogUser.Text = "Log User";
            // 
            // ddl_LogUser
            // 
            ddl_LogUser.FormattingEnabled = true;
            ddl_LogUser.Location = new Point(90, 240);
            ddl_LogUser.Name = "ddl_LogUser";
            ddl_LogUser.Size = new Size(220, 23);
            ddl_LogUser.TabIndex = 48;
            // 
            // btn_FilterLogs
            // 
            btn_FilterLogs.Location = new Point(22, 283);
            btn_FilterLogs.Name = "btn_FilterLogs";
            btn_FilterLogs.Size = new Size(96, 31);
            btn_FilterLogs.TabIndex = 49;
            btn_FilterLogs.Text = "Filter Logs";
            btn_FilterLogs.UseVisualStyleBackColor = true;
            btn_FilterLogs.Click += btn_FilterLogs_Click;
            // 
            // btn_RefreshLogs
            // 
            btn_RefreshLogs.Location = new Point(238, 283);
            btn_RefreshLogs.Name = "btn_RefreshLogs";
            btn_RefreshLogs.Size = new Size(96, 31);
            btn_RefreshLogs.TabIndex = 50;
            btn_RefreshLogs.Text = "Refresh Logs";
            btn_RefreshLogs.UseVisualStyleBackColor = true;
            btn_RefreshLogs.Click += btn_RefreshLogs_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_Logs);
            groupBox1.Controls.Add(lbl_LogUser);
            groupBox1.Controls.Add(ddl_LogUser);
            groupBox1.Controls.Add(btn_FilterLogs);
            groupBox1.Controls.Add(btn_RefreshLogs);
            groupBox1.Location = new Point(22, 12);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(355, 339);
            groupBox1.TabIndex = 58;
            groupBox1.TabStop = false;
            groupBox1.Text = "View Logs";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ddlAduitUser);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(dgv_Audits);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(416, 13);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(355, 338);
            groupBox2.TabIndex = 59;
            groupBox2.TabStop = false;
            groupBox2.Text = "View Audits";
            // 
            // ddlAduitUser
            // 
            ddlAduitUser.FormattingEnabled = true;
            ddlAduitUser.Location = new Point(114, 242);
            ddlAduitUser.Name = "ddlAduitUser";
            ddlAduitUser.Size = new Size(220, 23);
            ddlAduitUser.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 242);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 51;
            label3.Text = "Audit User";
            // 
            // dgv_Audits
            // 
            dgv_Audits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Audits.Location = new Point(22, 23);
            dgv_Audits.Name = "dgv_Audits";
            dgv_Audits.RowHeadersWidth = 51;
            dgv_Audits.RowTemplate.Height = 25;
            dgv_Audits.Size = new Size(312, 201);
            dgv_Audits.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(22, 282);
            button1.Name = "button1";
            button1.Size = new Size(96, 31);
            button1.TabIndex = 49;
            button1.Text = "Filter Audits";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(225, 282);
            button2.Name = "button2";
            button2.Size = new Size(109, 31);
            button2.TabIndex = 50;
            button2.Text = "Refresh Audits";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ShowInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 472);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btn_Return);
            Name = "ShowInfo";
            Text = "Show Information";
            Load += ShowInfo_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Logs).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Audits).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgv_Logs;
        private Button btn_Return;
        private Label lbl_LogUser;
        private ComboBox ddl_LogUser;
        private Button btn_FilterLogs;
        private Button btn_RefreshLogs;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private DataGridView dgv_Audits;
        private Button button1;
        private Button button2;
        private ComboBox ddlAduitUser;
    }
}