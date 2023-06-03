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
            lbl_username = new Label();
            lbl_Password = new Label();
            txt_Username = new TextBox();
            txt_Password = new TextBox();
            btn_Login = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_Login
            // 
            lbl_Login.AutoSize = true;
            lbl_Login.BackColor = Color.Transparent;
            lbl_Login.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Login.Location = new Point(515, 118);
            lbl_Login.Margin = new Padding(5, 0, 5, 0);
            lbl_Login.Name = "lbl_Login";
            lbl_Login.Size = new Size(413, 71);
            lbl_Login.TabIndex = 0;
            lbl_Login.Text = "Welcome Back! ";
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.BackColor = Color.Transparent;
            lbl_username.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_username.Location = new Point(473, 435);
            lbl_username.Margin = new Padding(5, 0, 5, 0);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(124, 32);
            lbl_username.TabIndex = 1;
            lbl_username.Text = "Username";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.BackColor = Color.Transparent;
            lbl_Password.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Password.Location = new Point(481, 506);
            lbl_Password.Margin = new Padding(5, 0, 5, 0);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(115, 32);
            lbl_Password.TabIndex = 2;
            lbl_Password.Text = "Password";
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(619, 430);
            txt_Username.Margin = new Padding(5, 6, 5, 6);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(300, 39);
            txt_Username.TabIndex = 3;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(619, 501);
            txt_Password.Margin = new Padding(5, 6, 5, 6);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(300, 39);
            txt_Password.TabIndex = 4;
            // 
            // btn_Login
            // 
            btn_Login.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Login.Location = new Point(619, 656);
            btn_Login.Margin = new Padding(5, 6, 5, 6);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(219, 64);
            btn_Login.TabIndex = 5;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.abstract_line_wave_linear_gradient_background_modern_colorful_wavy_line_abstract_background_vector;
            pictureBox1.Location = new Point(-16, -8);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1565, 1024);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(520, 208);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(422, 50);
            label1.TabIndex = 7;
            label1.Text = "Log in into your account";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1485, 960);
            Controls.Add(label1);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_username);
            Controls.Add(lbl_Login);
            Controls.Add(txt_Username);
            Controls.Add(txt_Password);
            Controls.Add(btn_Login);
            Controls.Add(pictureBox1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Login";
            Text = "Log-In";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Login;
        private Label lbl_username;
        private Label lbl_Password;
        private TextBox txt_Username;
        private TextBox txt_Password;
        private Button btn_Login;
        private PictureBox pictureBox1;
        private Label label1;
    }
}