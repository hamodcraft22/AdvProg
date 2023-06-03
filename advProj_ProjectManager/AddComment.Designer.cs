namespace advProj_ProjectManager
{
    partial class AddComment
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
            lbl_AddComment = new Label();
            lbl_CommentTitle = new Label();
            lbl_CommentBody = new Label();
            txt_CommentTitle = new TextBox();
            richTextBox1 = new RichTextBox();
            btn_AddComment = new Button();
            groupBox1 = new GroupBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_AddComment
            // 
            lbl_AddComment.AutoSize = true;
            lbl_AddComment.Location = new Point(454, 60);
            lbl_AddComment.Name = "lbl_AddComment";
            lbl_AddComment.Size = new Size(0, 20);
            lbl_AddComment.TabIndex = 0;
            // 
            // lbl_CommentTitle
            // 
            lbl_CommentTitle.AutoSize = true;
            lbl_CommentTitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_CommentTitle.Location = new Point(27, 59);
            lbl_CommentTitle.Name = "lbl_CommentTitle";
            lbl_CommentTitle.Size = new Size(112, 20);
            lbl_CommentTitle.TabIndex = 1;
            lbl_CommentTitle.Text = "Comment Title:";
            // 
            // lbl_CommentBody
            // 
            lbl_CommentBody.AutoSize = true;
            lbl_CommentBody.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_CommentBody.Location = new Point(27, 108);
            lbl_CommentBody.Name = "lbl_CommentBody";
            lbl_CommentBody.Size = new Size(118, 20);
            lbl_CommentBody.TabIndex = 2;
            lbl_CommentBody.Text = "Comment Body:";
            // 
            // txt_CommentTitle
            // 
            txt_CommentTitle.Location = new Point(167, 52);
            txt_CommentTitle.Margin = new Padding(3, 4, 3, 4);
            txt_CommentTitle.Name = "txt_CommentTitle";
            txt_CommentTitle.Size = new Size(259, 27);
            txt_CommentTitle.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(167, 108);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(259, 279);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // btn_AddComment
            // 
            btn_AddComment.BackColor = SystemColors.GradientActiveCaption;
            btn_AddComment.Location = new Point(339, 450);
            btn_AddComment.Margin = new Padding(3, 4, 3, 4);
            btn_AddComment.Name = "btn_AddComment";
            btn_AddComment.Size = new Size(139, 49);
            btn_AddComment.TabIndex = 5;
            btn_AddComment.Text = "Add Comment";
            btn_AddComment.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_CommentTitle);
            groupBox1.Controls.Add(txt_CommentTitle);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(lbl_CommentBody);
            groupBox1.Location = new Point(28, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(450, 416);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Comment Info";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(28, 450);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(139, 49);
            button1.TabIndex = 7;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            // 
            // AddComment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(513, 521);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(btn_AddComment);
            Controls.Add(lbl_AddComment);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddComment";
            Text = "Add Comment";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_AddComment;
        private Label lbl_CommentTitle;
        private Label lbl_CommentBody;
        private TextBox txt_CommentTitle;
        private RichTextBox richTextBox1;
        private Button btn_AddComment;
        private GroupBox groupBox1;
        private Button button1;
    }
}