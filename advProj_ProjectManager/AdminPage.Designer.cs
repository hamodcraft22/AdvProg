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
            lbl_LogSource = new Label();
            lbl_LogUser = new Label();
            ddl_LogSource = new ComboBox();
            ddl_LogUser = new ComboBox();
            btn_FilterLogs = new Button();
            btn_RefreshLogs = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            comboBox3 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Logs).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dgv_Logs
            // 
            dgv_Logs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Logs.Location = new Point(25, 31);
            dgv_Logs.Margin = new Padding(3, 4, 3, 4);
            dgv_Logs.Name = "dgv_Logs";
            dgv_Logs.RowHeadersWidth = 51;
            dgv_Logs.RowTemplate.Height = 25;
            dgv_Logs.Size = new Size(357, 268);
            dgv_Logs.TabIndex = 1;
            // 
            // btn_Return
            // 
            btn_Return.BackColor = SystemColors.GradientActiveCaption;
            btn_Return.Location = new Point(30, 559);
            btn_Return.Margin = new Padding(3, 4, 3, 4);
            btn_Return.Name = "btn_Return";
            btn_Return.Size = new Size(103, 46);
            btn_Return.TabIndex = 41;
            btn_Return.Text = "Return";
            btn_Return.UseVisualStyleBackColor = false;
            // 
            // lbl_LogSource
            // 
            lbl_LogSource.AutoSize = true;
            lbl_LogSource.Location = new Point(25, 330);
            lbl_LogSource.Name = "lbl_LogSource";
            lbl_LogSource.Size = new Size(83, 20);
            lbl_LogSource.TabIndex = 44;
            lbl_LogSource.Text = "Log Source";
            // 
            // lbl_LogUser
            // 
            lbl_LogUser.AutoSize = true;
            lbl_LogUser.Location = new Point(25, 377);
            lbl_LogUser.Name = "lbl_LogUser";
            lbl_LogUser.Size = new Size(67, 20);
            lbl_LogUser.TabIndex = 46;
            lbl_LogUser.Text = "Log User";
            // 
            // ddl_LogSource
            // 
            ddl_LogSource.FormattingEnabled = true;
            ddl_LogSource.Location = new Point(131, 327);
            ddl_LogSource.Margin = new Padding(3, 4, 3, 4);
            ddl_LogSource.Name = "ddl_LogSource";
            ddl_LogSource.Size = new Size(251, 28);
            ddl_LogSource.TabIndex = 47;
            ddl_LogSource.SelectedIndexChanged += ddl_LogSource_SelectedIndexChanged;
            // 
            // ddl_LogUser
            // 
            ddl_LogUser.FormattingEnabled = true;
            ddl_LogUser.Location = new Point(131, 374);
            ddl_LogUser.Margin = new Padding(3, 4, 3, 4);
            ddl_LogUser.Name = "ddl_LogUser";
            ddl_LogUser.Size = new Size(251, 28);
            ddl_LogUser.TabIndex = 48;
            // 
            // btn_FilterLogs
            // 
            btn_FilterLogs.Location = new Point(25, 464);
            btn_FilterLogs.Margin = new Padding(3, 4, 3, 4);
            btn_FilterLogs.Name = "btn_FilterLogs";
            btn_FilterLogs.Size = new Size(110, 41);
            btn_FilterLogs.TabIndex = 49;
            btn_FilterLogs.Text = "Filter Logs";
            btn_FilterLogs.UseVisualStyleBackColor = true;
            // 
            // btn_RefreshLogs
            // 
            btn_RefreshLogs.Location = new Point(272, 464);
            btn_RefreshLogs.Margin = new Padding(3, 4, 3, 4);
            btn_RefreshLogs.Name = "btn_RefreshLogs";
            btn_RefreshLogs.Size = new Size(110, 41);
            btn_RefreshLogs.TabIndex = 50;
            btn_RefreshLogs.Text = "Refresh Logs";
            btn_RefreshLogs.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_Logs);
            groupBox1.Controls.Add(lbl_LogSource);
            groupBox1.Controls.Add(ddl_LogSource);
            groupBox1.Controls.Add(lbl_LogUser);
            groupBox1.Controls.Add(ddl_LogUser);
            groupBox1.Controls.Add(btn_FilterLogs);
            groupBox1.Controls.Add(btn_RefreshLogs);
            groupBox1.Location = new Point(25, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(406, 522);
            groupBox1.TabIndex = 58;
            groupBox1.TabStop = false;
            groupBox1.Text = "View Logs";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(475, 17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(406, 521);
            groupBox2.TabIndex = 59;
            groupBox2.TabStop = false;
            groupBox2.Text = "View Audits";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(25, 31);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(357, 268);
            dataGridView2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 330);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 44;
            label1.Text = "Audit Source";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(131, 327);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(251, 28);
            comboBox1.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 377);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 46;
            label2.Text = "Source Type";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(131, 374);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(251, 28);
            comboBox2.TabIndex = 48;
            // 
            // button1
            // 
            button1.Location = new Point(25, 463);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(110, 41);
            button1.TabIndex = 49;
            button1.Text = "Filter Audits";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(257, 463);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(125, 41);
            button2.TabIndex = 50;
            button2.Text = "Refresh Audits";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 421);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 51;
            label3.Text = "Audit User";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(131, 418);
            comboBox3.Margin = new Padding(3, 4, 3, 4);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(251, 28);
            comboBox3.TabIndex = 52;
            // 
            // ShowInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(914, 629);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btn_Return);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ShowInfo";
            Text = "Show Information";
            ((System.ComponentModel.ISupportInitialize)dgv_Logs).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgv_Logs;
        private Button btn_Return;
        private Label lbl_LogSource;
        private Label lbl_LogUser;
        private ComboBox ddl_LogSource;
        private ComboBox ddl_LogUser;
        private Button btn_FilterLogs;
        private Button btn_RefreshLogs;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private DataGridView dataGridView2;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private ComboBox comboBox2;
        private Button button1;
        private Button button2;
        private ComboBox comboBox3;
    }
}