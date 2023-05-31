namespace advProj_ProjectManager
{
    partial class Profile
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
            lbl_Profile = new Label();
            lbl_UserName = new Label();
            lbl_Email = new Label();
            lbl_Password = new Label();
            txt_UserName = new TextBox();
            txt_Email = new TextBox();
            txt_Password = new TextBox();
            btn_Return = new Button();
            btn_Update = new Button();
            SuspendLayout();
            // 
            // lbl_Profile
            // 
            lbl_Profile.AutoSize = true;
            lbl_Profile.Location = new Point(329, 66);
            lbl_Profile.Name = "lbl_Profile";
            lbl_Profile.Size = new Size(67, 15);
            lbl_Profile.TabIndex = 0;
            lbl_Profile.Text = "User Profile";
            // 
            // lbl_UserName
            // 
            lbl_UserName.AutoSize = true;
            lbl_UserName.Location = new Point(248, 146);
            lbl_UserName.Name = "lbl_UserName";
            lbl_UserName.Size = new Size(106, 15);
            lbl_UserName.TabIndex = 1;
            lbl_UserName.Text = "Change UserName";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new Point(274, 187);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(80, 15);
            lbl_Email.TabIndex = 2;
            lbl_Email.Text = "Change Email";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Location = new Point(253, 220);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(101, 15);
            lbl_Password.TabIndex = 3;
            lbl_Password.Text = "Change Password";
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(386, 143);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(100, 23);
            txt_UserName.TabIndex = 4;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(386, 184);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(100, 23);
            txt_Email.TabIndex = 5;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(386, 220);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(100, 23);
            txt_Password.TabIndex = 6;
            // 
            // btn_Return
            // 
            btn_Return.Location = new Point(253, 294);
            btn_Return.Name = "btn_Return";
            btn_Return.Size = new Size(75, 23);
            btn_Return.TabIndex = 7;
            btn_Return.Text = "Return";
            btn_Return.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(442, 294);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(103, 23);
            btn_Update.TabIndex = 8;
            btn_Update.Text = "Update User";
            btn_Update.UseVisualStyleBackColor = true;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Update);
            Controls.Add(btn_Return);
            Controls.Add(txt_Password);
            Controls.Add(txt_Email);
            Controls.Add(txt_UserName);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_UserName);
            Controls.Add(lbl_Profile);
            Name = "Profile";
            Text = "Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Profile;
        private Label lbl_UserName;
        private Label lbl_Email;
        private Label lbl_Password;
        private TextBox txt_UserName;
        private TextBox txt_Email;
        private TextBox txt_Password;
        private Button btn_Return;
        private Button btn_Update;
    }
}