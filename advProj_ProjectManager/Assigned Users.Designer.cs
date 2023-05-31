namespace advProj_ProjectManager
{
    partial class Assigned_Users
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
            btn_ViewProfile = new Button();
            this.btn_UserDelete = new Button();
            btn_AssignUser = new Button();
            bt_Refresh = new Button();
            btn_Filter = new Button();
            ddl_Users = new ComboBox();
            lbl_User = new Label();
            dgv_Users = new DataGridView();
            lbl_Users = new Label();
            btn_Return = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Users).BeginInit();
            SuspendLayout();
            // 
            // btn_ViewProfile
            // 
            btn_ViewProfile.Location = new Point(24, 398);
            btn_ViewProfile.Name = "btn_ViewProfile";
            btn_ViewProfile.Size = new Size(90, 23);
            btn_ViewProfile.TabIndex = 38;
            btn_ViewProfile.Text = "View Profile";
            btn_ViewProfile.UseVisualStyleBackColor = true;
            // 
            // btn_UserDelete
            // 
            this.btn_UserDelete.Location = new Point(461, 398);
            this.btn_UserDelete.Name = "btn_UserDelete";
            this.btn_UserDelete.Size = new Size(97, 23);
            this.btn_UserDelete.TabIndex = 36;
            this.btn_UserDelete.Text = "Delete User";
            this.btn_UserDelete.UseVisualStyleBackColor = true;
            // 
            // btn_AssignUser
            // 
            btn_AssignUser.Location = new Point(624, 398);
            btn_AssignUser.Name = "btn_AssignUser";
            btn_AssignUser.Size = new Size(111, 23);
            btn_AssignUser.TabIndex = 34;
            btn_AssignUser.Text = "Assign User";
            btn_AssignUser.UseVisualStyleBackColor = true;
            // 
            // bt_Refresh
            // 
            bt_Refresh.Location = new Point(39, 237);
            bt_Refresh.Name = "bt_Refresh";
            bt_Refresh.Size = new Size(75, 23);
            bt_Refresh.TabIndex = 33;
            bt_Refresh.Text = "Refresh";
            bt_Refresh.UseVisualStyleBackColor = true;
            // 
            // btn_Filter
            // 
            btn_Filter.Location = new Point(39, 196);
            btn_Filter.Name = "btn_Filter";
            btn_Filter.Size = new Size(75, 23);
            btn_Filter.TabIndex = 32;
            btn_Filter.Text = "Filter";
            btn_Filter.UseVisualStyleBackColor = true;
            // 
            // ddl_Users
            // 
            ddl_Users.FormattingEnabled = true;
            ddl_Users.Location = new Point(30, 115);
            ddl_Users.Name = "ddl_Users";
            ddl_Users.Size = new Size(121, 23);
            ddl_Users.TabIndex = 30;
            // 
            // lbl_User
            // 
            lbl_User.AutoSize = true;
            lbl_User.Location = new Point(30, 88);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new Size(86, 15);
            lbl_User.TabIndex = 29;
            lbl_User.Text = "Filter by Users :";
            // 
            // dgv_Users
            // 
            dgv_Users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Users.Location = new Point(225, 68);
            dgv_Users.Name = "dgv_Users";
            dgv_Users.RowTemplate.Height = 25;
            dgv_Users.Size = new Size(546, 296);
            dgv_Users.TabIndex = 28;
            // 
            // lbl_Users
            // 
            lbl_Users.AutoSize = true;
            lbl_Users.Location = new Point(347, 29);
            lbl_Users.Name = "lbl_Users";
            lbl_Users.Size = new Size(35, 15);
            lbl_Users.TabIndex = 27;
            lbl_Users.Text = "Users";
            // 
            // btn_Return
            // 
            btn_Return.Location = new Point(120, 398);
            btn_Return.Name = "btn_Return";
            btn_Return.Size = new Size(90, 23);
            btn_Return.TabIndex = 39;
            btn_Return.Text = "Return";
            btn_Return.UseVisualStyleBackColor = true;
            // 
            // Assigned_Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Return);
            Controls.Add(btn_ViewProfile);
            Controls.Add(this.btn_UserDelete);
            Controls.Add(btn_AssignUser);
            Controls.Add(bt_Refresh);
            Controls.Add(btn_Filter);
            Controls.Add(ddl_Users);
            Controls.Add(lbl_User);
            Controls.Add(dgv_Users);
            Controls.Add(lbl_Users);
            Name = "Assigned_Users";
            Text = "Assigned Users";
            ((System.ComponentModel.ISupportInitialize)dgv_Users).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Task;
        private Button btn_ViewProfile;
        private Button btn_AssignedUsers;
        private Button btn_Delete;
        private Button btn_Update;
        private Button btn_AssignUser;
        private Button bt_Refresh;
        private Button btn_Filter;
        private ComboBox ddl_Task;
        private ComboBox ddl_Users;
        private Label lbl_User;
        private DataGridView dgv_Users;
        private Label lbl_Users;
        private Button btn_Return;
    }
}