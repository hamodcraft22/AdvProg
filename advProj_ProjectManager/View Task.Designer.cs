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
            btn_Clear = new Button();
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
            usersBox.Location = new Point(41, 26);
            usersBox.Margin = new Padding(6);
            usersBox.Name = "usersBox";
            usersBox.Padding = new Padding(6);
            usersBox.Size = new Size(696, 1047);
            usersBox.TabIndex = 0;
            usersBox.TabStop = false;
            usersBox.Text = "Users";
            // 
            // ddl_Users
            // 
            ddl_Users.FormattingEnabled = true;
            ddl_Users.Location = new Point(104, 804);
            ddl_Users.Margin = new Padding(6);
            ddl_Users.Name = "ddl_Users";
            ddl_Users.Size = new Size(557, 40);
            ddl_Users.TabIndex = 81;
            // 
            // lblUsers
            // 
            lblUsers.AutoSize = true;
            lblUsers.Location = new Point(28, 811);
            lblUsers.Margin = new Padding(6, 0, 6, 0);
            lblUsers.Name = "lblUsers";
            lblUsers.Size = new Size(71, 32);
            lblUsers.TabIndex = 80;
            lblUsers.Text = "Users";
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.IndianRed;
            btnDeleteUser.Location = new Point(475, 898);
            btnDeleteUser.Margin = new Padding(6);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(189, 83);
            btnDeleteUser.TabIndex = 79;
            btnDeleteUser.Text = "Delete";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btn_AddUser
            // 
            btn_AddUser.BackColor = SystemColors.GradientActiveCaption;
            btn_AddUser.Location = new Point(28, 905);
            btn_AddUser.Margin = new Padding(6);
            btn_AddUser.Name = "btn_AddUser";
            btn_AddUser.Size = new Size(191, 77);
            btn_AddUser.TabIndex = 25;
            btn_AddUser.Text = "Add";
            btn_AddUser.UseVisualStyleBackColor = false;
            btn_AddUser.Click += btn_AddUser_Click;
            // 
            // dgv_Users
            // 
            dgv_Users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Users.Location = new Point(32, 122);
            dgv_Users.Margin = new Padding(6);
            dgv_Users.Name = "dgv_Users";
            dgv_Users.RowHeadersWidth = 82;
            dgv_Users.RowTemplate.Height = 25;
            dgv_Users.Size = new Size(637, 640);
            dgv_Users.TabIndex = 3;
            // 
            // btnSearchUser
            // 
            btnSearchUser.Location = new Point(526, 54);
            btnSearchUser.Margin = new Padding(6);
            btnSearchUser.Name = "btnSearchUser";
            btnSearchUser.Size = new Size(139, 49);
            btnSearchUser.TabIndex = 2;
            btnSearchUser.Text = "Search";
            btnSearchUser.UseVisualStyleBackColor = true;
            btnSearchUser.Click += btnSearchUser_Click;
            // 
            // txtUsers
            // 
            txtUsers.Location = new Point(100, 60);
            txtUsers.Margin = new Padding(6);
            txtUsers.Name = "txtUsers";
            txtUsers.Size = new Size(411, 39);
            txtUsers.TabIndex = 1;
            // 
            // lblSearchUseer
            // 
            lblSearchUseer.AutoSize = true;
            lblSearchUseer.Location = new Point(11, 60);
            lblSearchUseer.Margin = new Padding(6, 0, 6, 0);
            lblSearchUseer.Name = "lblSearchUseer";
            lblSearchUseer.Size = new Size(85, 32);
            lblSearchUseer.TabIndex = 0;
            lblSearchUseer.Text = "Search";
            // 
            // searchBox
            // 
            searchBox.Controls.Add(btn_Clear);
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
            searchBox.Location = new Point(771, 26);
            searchBox.Margin = new Padding(6);
            searchBox.Name = "searchBox";
            searchBox.Padding = new Padding(6);
            searchBox.Size = new Size(693, 1047);
            searchBox.TabIndex = 1;
            searchBox.TabStop = false;
            searchBox.Text = "Comments";
            // 
            // btnDeletedComment
            // 
            btnDeletedComment.BackColor = Color.IndianRed;
            btnDeletedComment.Location = new Point(475, 905);
            btnDeletedComment.Margin = new Padding(6);
            btnDeletedComment.Name = "btnDeletedComment";
            btnDeletedComment.Size = new Size(189, 83);
            btnDeletedComment.TabIndex = 79;
            btnDeletedComment.Text = "Delete";
            btnDeletedComment.UseVisualStyleBackColor = false;
            btnDeletedComment.Click += btnDeletedComment_Click;
            // 
            // btnEditComment
            // 
            btnEditComment.BackColor = SystemColors.GradientActiveCaption;
            btnEditComment.Location = new Point(254, 907);
            btnEditComment.Margin = new Padding(6);
            btnEditComment.Name = "btnEditComment";
            btnEditComment.Size = new Size(191, 77);
            btnEditComment.TabIndex = 26;
            btnEditComment.Text = "Edit";
            btnEditComment.UseVisualStyleBackColor = false;
            btnEditComment.Click += btnEditComment_Click;
            // 
            // btnAddComment
            // 
            btnAddComment.BackColor = SystemColors.GradientActiveCaption;
            btnAddComment.Location = new Point(35, 905);
            btnAddComment.Margin = new Padding(6);
            btnAddComment.Name = "btnAddComment";
            btnAddComment.Size = new Size(191, 77);
            btnAddComment.TabIndex = 25;
            btnAddComment.Text = "Add";
            btnAddComment.UseVisualStyleBackColor = false;
            btnAddComment.Click += btnAddComment_Click;
            // 
            // txtBody
            // 
            txtBody.Location = new Point(117, 683);
            txtBody.Margin = new Padding(6);
            txtBody.Name = "txtBody";
            txtBody.Size = new Size(544, 183);
            txtBody.TabIndex = 8;
            txtBody.Text = "";
            // 
            // lblBody
            // 
            lblBody.AutoSize = true;
            lblBody.Location = new Point(35, 683);
            lblBody.Margin = new Padding(6, 0, 6, 0);
            lblBody.Name = "lblBody";
            lblBody.Size = new Size(68, 32);
            lblBody.TabIndex = 7;
            lblBody.Text = "Body";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(117, 621);
            txtTitle.Margin = new Padding(6);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(544, 39);
            txtTitle.TabIndex = 6;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(35, 623);
            lblTitle.Margin = new Padding(6, 0, 6, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(60, 32);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Title";
            // 
            // dgv_Comments
            // 
            dgv_Comments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Comments.Location = new Point(28, 122);
            dgv_Comments.Margin = new Padding(6);
            dgv_Comments.Name = "dgv_Comments";
            dgv_Comments.RowHeadersWidth = 82;
            dgv_Comments.RowTemplate.Height = 25;
            dgv_Comments.Size = new Size(637, 471);
            dgv_Comments.TabIndex = 4;
            dgv_Comments.DoubleClick += dgv_Comments_DoubleClick;
            // 
            // btnSearchComments
            // 
            btnSearchComments.Location = new Point(526, 48);
            btnSearchComments.Margin = new Padding(6);
            btnSearchComments.Name = "btnSearchComments";
            btnSearchComments.Size = new Size(139, 49);
            btnSearchComments.TabIndex = 3;
            btnSearchComments.Text = "Search";
            btnSearchComments.UseVisualStyleBackColor = true;
            btnSearchComments.Click += btnSearchComments_Click;
            // 
            // txtComments
            // 
            txtComments.Location = new Point(100, 53);
            txtComments.Margin = new Padding(6);
            txtComments.Name = "txtComments";
            txtComments.Size = new Size(411, 39);
            txtComments.TabIndex = 2;
            // 
            // lblSearchComments
            // 
            lblSearchComments.AutoSize = true;
            lblSearchComments.Location = new Point(11, 60);
            lblSearchComments.Margin = new Padding(6, 0, 6, 0);
            lblSearchComments.Name = "lblSearchComments";
            lblSearchComments.Size = new Size(85, 32);
            lblSearchComments.TabIndex = 1;
            lblSearchComments.Text = "Search";
            // 
            // btn_Return
            // 
            btn_Return.BackColor = SystemColors.GradientActiveCaption;
            btn_Return.Location = new Point(41, 1120);
            btn_Return.Margin = new Padding(6);
            btn_Return.Name = "btn_Return";
            btn_Return.Size = new Size(175, 83);
            btn_Return.TabIndex = 76;
            btn_Return.Text = "Return";
            btn_Return.UseVisualStyleBackColor = false;
            btn_Return.Click += btn_Return_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.BackColor = SystemColors.GradientActiveCaption;
            btn_Clear.Location = new Point(37, 787);
            btn_Clear.Margin = new Padding(6);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(68, 77);
            btn_Clear.TabIndex = 80;
            btn_Clear.Text = "X";
            btn_Clear.UseVisualStyleBackColor = false;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // ViewTask
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 1229);
            Controls.Add(btn_Return);
            Controls.Add(searchBox);
            Controls.Add(usersBox);
            Margin = new Padding(6);
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
        private Button btn_Clear;
    }
}