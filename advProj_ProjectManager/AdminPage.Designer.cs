namespace advProj_ProjectManager
{
    partial class View_Logs
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
            btn_ViewProfile = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Logs).BeginInit();
            SuspendLayout();
            // 
            // lbl_Logs
            // 
            lbl_Logs.AutoSize = true;
            lbl_Logs.Location = new Point(338, 23);
            lbl_Logs.Name = "lbl_Logs";
            lbl_Logs.Size = new Size(60, 15);
            lbl_Logs.TabIndex = 0;
            lbl_Logs.Text = "View Logs";
            // 
            // dgv_Logs
            // 
            dgv_Logs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Logs.Location = new Point(73, 63);
            dgv_Logs.Name = "dgv_Logs";
            dgv_Logs.RowTemplate.Height = 25;
            dgv_Logs.Size = new Size(652, 309);
            dgv_Logs.TabIndex = 1;
            // 
            // btn_Return
            // 
            btn_Return.Location = new Point(169, 397);
            btn_Return.Name = "btn_Return";
            btn_Return.Size = new Size(90, 23);
            btn_Return.TabIndex = 41;
            btn_Return.Text = "Return";
            btn_Return.UseVisualStyleBackColor = true;
            // 
            // btn_ViewProfile
            // 
            btn_ViewProfile.Location = new Point(73, 397);
            btn_ViewProfile.Name = "btn_ViewProfile";
            btn_ViewProfile.Size = new Size(90, 23);
            btn_ViewProfile.TabIndex = 40;
            btn_ViewProfile.Text = "View Profile";
            btn_ViewProfile.UseVisualStyleBackColor = true;
            // 
            // View_Logs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Return);
            Controls.Add(btn_ViewProfile);
            Controls.Add(dgv_Logs);
            Controls.Add(lbl_Logs);
            Name = "View_Logs";
            Text = "View Logs Page";
            ((System.ComponentModel.ISupportInitialize)dgv_Logs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Logs;
        private DataGridView dgv_Logs;
        private Button btn_Return;
        private Button btn_ViewProfile;
    }
}