namespace advProj_ProjectManager
{
    partial class Login
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
            lbl_Login = new Label();
            lbl_Email = new Label();
            lbl_Password = new Label();
            txt_Email = new TextBox();
            txt_Password = new TextBox();
            btn_Login = new Button();
            SuspendLayout();
            // 
            // lbl_Login
            // 
            lbl_Login.AutoSize = true;
            lbl_Login.Location = new Point(333, 61);
            lbl_Login.Name = "lbl_Login";
            lbl_Login.Size = new Size(42, 15);
            lbl_Login.TabIndex = 0;
            lbl_Login.Text = "Log-In";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new Point(280, 160);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(36, 15);
            lbl_Email.TabIndex = 1;
            lbl_Email.Text = "Email";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Location = new Point(259, 205);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(57, 15);
            lbl_Password.TabIndex = 2;
            lbl_Password.Text = "Password";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(333, 157);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(100, 23);
            txt_Email.TabIndex = 3;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(333, 202);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(100, 23);
            txt_Password.TabIndex = 4;
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(315, 253);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(75, 23);
            btn_Login.TabIndex = 5;
            btn_Login.Text = "Log-In";
            btn_Login.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Login);
            Controls.Add(txt_Password);
            Controls.Add(txt_Email);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_Login);
            Name = "Login";
            Text = "Log-In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Login;
        private Label lbl_Email;
        private Label lbl_Password;
        private TextBox txt_Email;
        private TextBox txt_Password;
        private Button btn_Login;
    }
}