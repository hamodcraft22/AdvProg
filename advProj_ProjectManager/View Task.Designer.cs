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
            usersBox = new GroupBox();
            ddl_Users = new ComboBox();
            lblUsers = new Label();
            btnDeleteUser = new Button();
            btn_AddUser = new Button();
            dgv_Users = new DataGridView();
            btnSearchUser = new Button();
            txtUsers = new TextBox();
            lblSearchUseer = new Label();
            searchBox = new GroupBox();
            btnDeletedComment = new Button();
            btnEditComment = new Button();
            btnAddComment = new Button();
            txtBody = new RichTextBox();
            lblBody = new Label();
            txtTitle = new TextBox();
            lblTitle = new Label();
            dgv_Comments = new DataGridView();
            btnSearchComments = new Button();
            txtComments = new TextBox();
            lblSearchComments = new Label();
            btn_Return = new Button();
            usersBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Users).BeginInit();
            searchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Comments).BeginInit();
            SuspendLayout();
            // 
            // usersBox
            // 
            usersBox.Controls.Add(ddl_Users);
            usersBox.Controls.Add(lblUsers);
            usersBox.Controls.Add(btnDeleteUser);
            usersBox.Controls.Add(btn_AddUser);
            usersBox.Controls.Add(dgv_Users);
            usersBox.Controls.Add(btnSearchUser);
            usersBox.Controls.Add(txtUsers);
            usersBox.Controls.Add(lblSearchUseer);
            usersBox.Location = new Point(22, 12);
            usersBox.Name = "usersBox";
            usersBox.Size = new Size(375, 491);
            usersBox.TabIndex = 0;
            usersBox.TabStop = false;
            usersBox.Text = "Users";
            // 
            // ddl_Users
            // 
            ddl_Users.FormattingEnabled = true;
            ddl_Users.Location = new Point(56, 377);
            ddl_Users.Name = "ddl_Users";
            ddl_Users.Size = new Size(302, 23);
            ddl_Users.TabIndex = 81;
            // 
            // lblUsers
            // 
            lblUsers.AutoSize = true;
            lblUsers.Location = new Point(15, 380);
            lblUsers.Name = "lblUsers";
            lblUsers.Size = new Size(35, 15);
            lblUsers.TabIndex = 80;
            lblUsers.Text = "Users";
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.IndianRed;
            btnDeleteUser.Location = new Point(256, 421);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(102, 39);
            btnDeleteUser.TabIndex = 79;
            btnDeleteUser.Text = "Delete";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btn_AddUser
            // 
            btn_AddUser.BackColor = SystemColors.GradientActiveCaption;
            btn_AddUser.Location = new Point(15, 424);
            btn_AddUser.Name = "btn_AddUser";
            btn_AddUser.Size = new Size(103, 36);
            btn_AddUser.TabIndex = 25;
            btn_AddUser.Text = "Add";
            btn_AddUser.UseVisualStyleBackColor = false;
            btn_AddUser.Click += btn_AddUser_Click;
            // 
            // dgv_Users
            // 
            dgv_Users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Users.Location = new Point(26, 57);
            dgv_Users.Name = "dgv_Users";
            dgv_Users.RowTemplate.Height = 25;
            dgv_Users.Size = new Size(343, 300);
            dgv_Users.TabIndex = 3;
            // 
            // btnSearchUser
            // 
            btnSearchUser.Location = new Point(283, 28);
            btnSearchUser.Name = "btnSearchUser";
            btnSearchUser.Size = new Size(75, 23);
            btnSearchUser.TabIndex = 2;
            btnSearchUser.Text = "Search";
            btnSearchUser.UseVisualStyleBackColor = true;
            btnSearchUser.Click += btnSearchUser_Click;
            // 
            // txtUsers
            // 
            txtUsers.Location = new Point(54, 28);
            txtUsers.Name = "txtUsers";
            txtUsers.Size = new Size(223, 23);
            txtUsers.TabIndex = 1;
            // 
            // lblSearchUseer
            // 
            lblSearchUseer.AutoSize = true;
            lblSearchUseer.Location = new Point(6, 28);
            lblSearchUseer.Name = "lblSearchUseer";
            lblSearchUseer.Size = new Size(42, 15);
            lblSearchUseer.TabIndex = 0;
            lblSearchUseer.Text = "Search";
            // 
            // searchBox
            // 
            searchBox.Controls.Add(btnDeletedComment);
            searchBox.Controls.Add(btnEditComment);
            searchBox.Controls.Add(btnAddComment);
            searchBox.Controls.Add(txtBody);
            searchBox.Controls.Add(lblBody);
            searchBox.Controls.Add(txtTitle);
            searchBox.Controls.Add(lblTitle);
            searchBox.Controls.Add(dgv_Comments);
            searchBox.Controls.Add(btnSearchComments);
            searchBox.Controls.Add(txtComments);
            searchBox.Controls.Add(lblSearchComments);
            searchBox.Location = new Point(415, 12);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(373, 491);
            searchBox.TabIndex = 1;
            searchBox.TabStop = false;
            searchBox.Text = "Comments";
            // 
            // btnDeletedComment
            // 
            btnDeletedComment.BackColor = Color.IndianRed;
            btnDeletedComment.Location = new Point(256, 424);
            btnDeletedComment.Name = "btnDeletedComment";
            btnDeletedComment.Size = new Size(102, 39);
            btnDeletedComment.TabIndex = 79;
            btnDeletedComment.Text = "Delete";
            btnDeletedComment.UseVisualStyleBackColor = false;
            btnDeletedComment.Click += btnDeletedComment_Click;
            // 
            // btnEditComment
            // 
            btnEditComment.BackColor = SystemColors.GradientActiveCaption;
            btnEditComment.Location = new Point(137, 425);
            btnEditComment.Name = "btnEditComment";
            btnEditComment.Size = new Size(103, 36);
            btnEditComment.TabIndex = 26;
            btnEditComment.Text = "Edit";
            btnEditComment.UseVisualStyleBackColor = false;
            btnEditComment.Click += btnEditComment_Click;
            // 
            // btnAddComment
            // 
            btnAddComment.BackColor = SystemColors.GradientActiveCaption;
            btnAddComment.Location = new Point(19, 424);
            btnAddComment.Name = "btnAddComment";
            btnAddComment.Size = new Size(103, 36);
            btnAddComment.TabIndex = 25;
            btnAddComment.Text = "Add";
            btnAddComment.UseVisualStyleBackColor = false;
            btnAddComment.Click += btnAddComment_Click;
            // 
            // txtBody
            // 
            txtBody.Location = new Point(63, 320);
            txtBody.Name = "txtBody";
            txtBody.Size = new Size(295, 88);
            txtBody.TabIndex = 8;
            txtBody.Text = "";
            // 
            // lblBody
            // 
            lblBody.AutoSize = true;
            lblBody.Location = new Point(19, 320);
            lblBody.Name = "lblBody";
            lblBody.Size = new Size(34, 15);
            lblBody.TabIndex = 7;
            lblBody.Text = "Body";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(63, 291);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(295, 23);
            txtTitle.TabIndex = 6;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(19, 292);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(29, 15);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Title";
            // 
            // dgv_Comments
            // 
            dgv_Comments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Comments.Location = new Point(15, 57);
            dgv_Comments.Name = "dgv_Comments";
            dgv_Comments.RowTemplate.Height = 25;
            dgv_Comments.Size = new Size(343, 221);
            dgv_Comments.TabIndex = 4;
            // 
            // btnSearchComments
            // 
            btnSearchComments.Location = new Point(283, 27);
            btnSearchComments.Name = "btnSearchComments";
            btnSearchComments.Size = new Size(75, 23);
            btnSearchComments.TabIndex = 3;
            btnSearchComments.Text = "Search";
            btnSearchComments.UseVisualStyleBackColor = true;
            btnSearchComments.Click += btnSearchComments_Click;
            // 
            // txtComments
            // 
            txtComments.Location = new Point(54, 25);
            txtComments.Name = "txtComments";
            txtComments.Size = new Size(223, 23);
            txtComments.TabIndex = 2;
            // 
            // lblSearchComments
            // 
            lblSearchComments.AutoSize = true;
            lblSearchComments.Location = new Point(6, 28);
            lblSearchComments.Name = "lblSearchComments";
            lblSearchComments.Size = new Size(42, 15);
            lblSearchComments.TabIndex = 1;
            lblSearchComments.Text = "Search";
            // 
            // btn_Return
            // 
            btn_Return.BackColor = SystemColors.GradientActiveCaption;
            btn_Return.Location = new Point(22, 525);
            btn_Return.Name = "btn_Return";
            btn_Return.Size = new Size(94, 39);
            btn_Return.TabIndex = 76;
            btn_Return.Text = "Return";
            btn_Return.UseVisualStyleBackColor = false;
            btn_Return.Click += btn_Return_Click;
            // 
            // ViewTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 576);
            Controls.Add(btn_Return);
            Controls.Add(searchBox);
            Controls.Add(usersBox);
            Name = "ViewTask";
            Text = "ViewTask";
            Load += ViewTask_Load;
            usersBox.ResumeLayout(false);
            usersBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Users).EndInit();
            searchBox.ResumeLayout(false);
            searchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Comments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox usersBox;
        private DataGridView dgv_Users;
        private Button btnSearchUser;
        private TextBox txtUsers;
        private Label lblSearchUseer;
        private GroupBox searchBox;
        private RichTextBox txtBody;
        private Label lblBody;
        private TextBox txtTitle;
        private Label lblTitle;
        private DataGridView dgv_Comments;
        private Button btnSearchComments;
        private TextBox txtComments;
        private Label lblSearchComments;
        private Button btn_AddUser;
        private Button btnEditComment;
        private Button btnAddComment;
        private Button btnDeleteUser;
        private Button btnDeletedComment;
        private Button btn_Return;
        private ComboBox ddl_Users;
        private Label lblUsers;
    }
}