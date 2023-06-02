namespace advProj_ProjectManager
{
    partial class ViewTask
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
            lbl_TaskInfo = new Label();
            lbl_Comment = new Label();
            lbl_User = new Label();
            dgv_Comments = new DataGridView();
            dgv_User = new DataGridView();
            lbl_SearchComments = new Label();
            lbl_FilterUsers = new Label();
            txt_SearchComment = new TextBox();
            btn_SearchComment = new Button();
            btn_FilterUsers = new Button();
            ddl_FilterUsers = new ComboBox();
            btn_AddComment = new Button();
            btn_DeleteComment = new Button();
            btn_Return = new Button();
            bt_Refresh = new Button();
           =
            
            btn_DeleteUser = new Button();
            btn_AddUser = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Comments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_User).BeginInit();
            SuspendLayout();
            // 
            // lbl_TaskInfo
            // 
            lbl_TaskInfo.AutoSize = true;
            lbl_TaskInfo.Location = new Point(313, 37);
            lbl_TaskInfo.Name = "lbl_TaskInfo";
            lbl_TaskInfo.Size = new Size(95, 15);
            lbl_TaskInfo.TabIndex = 0;
            lbl_TaskInfo.Text = "Task Information";
            // 
            // lbl_Comment
            // 
            lbl_Comment.AutoSize = true;
            lbl_Comment.Location = new Point(189, 82);
            lbl_Comment.Name = "lbl_Comment";
            lbl_Comment.Size = new Size(66, 15);
            lbl_Comment.TabIndex = 1;
            lbl_Comment.Text = "Comments";
            // 
            // lbl_User
            // 
            lbl_User.AutoSize = true;
            lbl_User.Location = new Point(529, 82);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new Size(30, 15);
            lbl_User.TabIndex = 2;
            lbl_User.Text = "User";
            // 
            // dgv_Comments
            // 
            dgv_Comments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Comments.Location = new Point(147, 118);
            dgv_Comments.Name = "dgv_Comments";
            dgv_Comments.RowTemplate.Height = 25;
            dgv_Comments.Size = new Size(240, 260);
            dgv_Comments.TabIndex = 3;
            // 
            // dgv_User
            // 
            dgv_User.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_User.Location = new Point(409, 118);
            dgv_User.Name = "dgv_User";
            dgv_User.RowTemplate.Height = 25;
            dgv_User.Size = new Size(267, 260);
            dgv_User.TabIndex = 4;
            // 
            // lbl_SearchComments
            // 
            lbl_SearchComments.AutoSize = true;
            lbl_SearchComments.Location = new Point(12, 118);
            lbl_SearchComments.Name = "lbl_SearchComments";
            lbl_SearchComments.Size = new Size(127, 15);
            lbl_SearchComments.TabIndex = 5;
            lbl_SearchComments.Text = "Search For Comments:";
            // 
            // lbl_FilterUsers
            // 
            lbl_FilterUsers.AutoSize = true;
            lbl_FilterUsers.Location = new Point(29, 266);
            lbl_FilterUsers.Name = "lbl_FilterUsers";
            lbl_FilterUsers.Size = new Size(83, 15);
            lbl_FilterUsers.TabIndex = 6;
            lbl_FilterUsers.Text = "Filter by Users:";
            // 
            // txt_SearchComment
            // 
            txt_SearchComment.Location = new Point(10, 150);
            txt_SearchComment.Name = "txt_SearchComment";
            txt_SearchComment.Size = new Size(129, 23);
            txt_SearchComment.TabIndex = 7;
            // 
            // btn_SearchComment
            // 
            btn_SearchComment.Location = new Point(21, 179);
            btn_SearchComment.Name = "btn_SearchComment";
            btn_SearchComment.Size = new Size(108, 23);
            btn_SearchComment.TabIndex = 8;
            btn_SearchComment.Text = "Search Comment";
            btn_SearchComment.UseVisualStyleBackColor = true;
            // 
            // btn_FilterUsers
            // 
            btn_FilterUsers.Location = new Point(29, 346);
            btn_FilterUsers.Name = "btn_FilterUsers";
            btn_FilterUsers.Size = new Size(75, 23);
            btn_FilterUsers.TabIndex = 9;
            btn_FilterUsers.Text = "Filter Users";
            btn_FilterUsers.UseVisualStyleBackColor = true;
            // 
            // ddl_FilterUsers
            // 
            ddl_FilterUsers.FormattingEnabled = true;
            ddl_FilterUsers.Location = new Point(7, 303);
            ddl_FilterUsers.Name = "ddl_FilterUsers";
            ddl_FilterUsers.Size = new Size(121, 23);
            ddl_FilterUsers.TabIndex = 10;
            // 
            // btn_AddComment
            // 
            btn_AddComment.Location = new Point(148, 404);
            btn_AddComment.Name = "btn_AddComment";
            btn_AddComment.Size = new Size(107, 23);
            btn_AddComment.TabIndex = 11;
            btn_AddComment.Text = "Add Comment";
            btn_AddComment.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteComment
            // 
            btn_DeleteComment.Location = new Point(278, 404);
            btn_DeleteComment.Name = "btn_DeleteComment";
            btn_DeleteComment.Size = new Size(109, 23);
            btn_DeleteComment.TabIndex = 12;
            btn_DeleteComment.Text = "Delete Comment";
            btn_DeleteComment.UseVisualStyleBackColor = true;
            // 
            // btn_Return
            // 
            btn_Return.Location = new Point(14, 404);
            btn_Return.Name = "btn_Return";
            btn_Return.Size = new Size(90, 23);
            btn_Return.TabIndex = 66;
            btn_Return.Text = "Return";
            btn_Return.UseVisualStyleBackColor = true;
            // 
            // bt_Refresh
            // 
            bt_Refresh.Location = new Point(601, 404);
            bt_Refresh.Name = "bt_Refresh";
            bt_Refresh.Size = new Size(75, 23);
            bt_Refresh.TabIndex = 67;
            bt_Refresh.Text = "Refresh";
            bt_Refresh.UseVisualStyleBackColor = true;
            // 
            // ddl_SelectUser
            // 
            this.ddl_SelectUser.FormattingEnabled = true;
            this.ddl_SelectUser.Location = new Point(690, 164);
            this.ddl_SelectUser.Name = "ddl_SelectUser";
            this.ddl_SelectUser.Size = new Size(98, 23);
            this.ddl_SelectUser.TabIndex = 70;
            // 
            // lbl_SelectUser
            // 
            lbl_SelectUser.AutoSize = true;
            lbl_SelectUser.Location = new Point(706, 134);
            lbl_SelectUser.Name = "lbl_SelectUser";
            lbl_SelectUser.Size = new Size(67, 15);
            lbl_SelectUser.TabIndex = 68;
            lbl_SelectUser.Text = "Select User:";
            // 
            // btn_DeleteUser
            // 
            btn_DeleteUser.Location = new Point(469, 404);
            btn_DeleteUser.Name = "btn_DeleteUser";
            btn_DeleteUser.Size = new Size(109, 23);
            btn_DeleteUser.TabIndex = 72;
            btn_DeleteUser.Text = "Delete User";
            btn_DeleteUser.UseVisualStyleBackColor = true;
            // 
            // btn_AddUser
            // 
            btn_AddUser.Location = new Point(698, 205);
            btn_AddUser.Name = "btn_AddUser";
            btn_AddUser.Size = new Size(90, 23);
            btn_AddUser.TabIndex = 71;
            btn_AddUser.Text = "Add User";
            btn_AddUser.UseVisualStyleBackColor = true;
            // 
            // ViewTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_DeleteUser);
            Controls.Add(btn_AddUser);
            Controls.Add(this.ddl_SelectUser);
            Controls.Add(lbl_SelectUser);
            Controls.Add(bt_Refresh);
            Controls.Add(btn_Return);
            Controls.Add(btn_DeleteComment);
            Controls.Add(btn_AddComment);
            Controls.Add(ddl_FilterUsers);
            Controls.Add(btn_FilterUsers);
            Controls.Add(btn_SearchComment);
            Controls.Add(txt_SearchComment);
            Controls.Add(lbl_FilterUsers);
            Controls.Add(lbl_SearchComments);
            Controls.Add(dgv_User);
            Controls.Add(dgv_Comments);
            Controls.Add(lbl_User);
            Controls.Add(lbl_Comment);
            Controls.Add(lbl_TaskInfo);
            Name = "ViewTask";
            Text = "View Task";
            ((System.ComponentModel.ISupportInitialize)dgv_Comments).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_User).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_TaskInfo;
        private Label lbl_Comment;
        private Label lbl_User;
        private DataGridView dgv_Comments;
        private DataGridView dgv_User;
        private Label lbl_SearchComments;
        private Label lbl_FilterUsers;
        private TextBox txt_SearchComment;
        private Button btn_SearchComment;
        private Button btn_FilterUsers;
        private ComboBox ddl_FilterUsers;
        private Button btn_AddComment;
        private Button btn_DeleteComment;
        private Button btn_Return;
        private Button bt_Refresh;
        private ComboBox ddl_FilterUser;
        private Button btn_FilterUser;
        private Label lbl_SelectUser;
        private Button btn_DeleteUser;
        private Button btn_AddUser;
    }
}