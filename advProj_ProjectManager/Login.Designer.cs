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
            lbl_Login.Location = new Point(317, 74);
            lbl_Login.Name = "lbl_Login";
            lbl_Login.Size = new Size(264, 46);
            lbl_Login.TabIndex = 0;
            lbl_Login.Text = "Welcome Back! ";
            lbl_Login.Click += lbl_Login_Click;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.BackColor = Color.Transparent;
            lbl_Email.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Email.Location = new Point(317, 272);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(52, 20);
            lbl_Email.TabIndex = 1;
            lbl_Email.Text = "E-mail";
            lbl_Email.Click += lbl_Email_Click;
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.BackColor = Color.Transparent;
            lbl_Password.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Password.Location = new Point(296, 316);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(73, 20);
            lbl_Password.TabIndex = 2;
            lbl_Password.Text = "Password";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(381, 269);
            txt_Email.Margin = new Padding(3, 4, 3, 4);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(186, 27);
            txt_Email.TabIndex = 3;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(381, 313);
            txt_Password.Margin = new Padding(3, 4, 3, 4);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(186, 27);
            txt_Password.TabIndex = 4;
            // 
            // btn_Login
            // 
            btn_Login.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Login.Location = new Point(381, 410);
            btn_Login.Margin = new Padding(3, 4, 3, 4);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(135, 40);
            btn_Login.TabIndex = 5;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.abstract_line_wave_linear_gradient_background_modern_colorful_wavy_line_abstract_background_vector;
            pictureBox1.Location = new Point(-10, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(963, 640);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(320, 130);
            label1.Name = "label1";
            label1.Size = new Size(261, 31);
            label1.TabIndex = 7;
            label1.Text = "Log in into your account";
            label1.Click += label1_Click_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_Login);
            Controls.Add(txt_Email);
            Controls.Add(txt_Password);
            Controls.Add(btn_Login);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Log-In";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Label label1;
    }
}