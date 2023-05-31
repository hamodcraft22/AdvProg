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
            SuspendLayout();
            // 
            // lbl_AddComment
            // 
            lbl_AddComment.AutoSize = true;
            lbl_AddComment.Location = new Point(397, 45);
            lbl_AddComment.Name = "lbl_AddComment";
            lbl_AddComment.Size = new Size(86, 15);
            lbl_AddComment.TabIndex = 0;
            lbl_AddComment.Text = "Add Comment";
            // 
            // lbl_CommentTitle
            // 
            lbl_CommentTitle.AutoSize = true;
            lbl_CommentTitle.Location = new Point(217, 105);
            lbl_CommentTitle.Name = "lbl_CommentTitle";
            lbl_CommentTitle.Size = new Size(89, 15);
            lbl_CommentTitle.TabIndex = 1;
            lbl_CommentTitle.Text = "Comment Title:";
            // 
            // lbl_CommentBody
            // 
            lbl_CommentBody.AutoSize = true;
            lbl_CommentBody.Location = new Point(217, 178);
            lbl_CommentBody.Name = "lbl_CommentBody";
            lbl_CommentBody.Size = new Size(94, 15);
            lbl_CommentBody.TabIndex = 2;
            lbl_CommentBody.Text = "Comment Body:";
            // 
            // txt_CommentTitle
            // 
            txt_CommentTitle.Location = new Point(331, 105);
            txt_CommentTitle.Name = "txt_CommentTitle";
            txt_CommentTitle.Size = new Size(227, 23);
            txt_CommentTitle.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(331, 175);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(227, 210);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // btn_AddComment
            // 
            btn_AddComment.Location = new Point(361, 401);
            btn_AddComment.Name = "btn_AddComment";
            btn_AddComment.Size = new Size(122, 23);
            btn_AddComment.TabIndex = 5;
            btn_AddComment.Text = "Add Comment";
            btn_AddComment.UseVisualStyleBackColor = true;
            // 
            // AddComment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_AddComment);
            Controls.Add(richTextBox1);
            Controls.Add(txt_CommentTitle);
            Controls.Add(lbl_CommentBody);
            Controls.Add(lbl_CommentTitle);
            Controls.Add(lbl_AddComment);
            Name = "AddComment";
            Text = "Add Comment";
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
    }
}