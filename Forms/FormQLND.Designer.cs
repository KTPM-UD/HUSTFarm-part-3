namespace GiaoDien.Forms
{
    partial class FormQLND
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
            dtgvAccount = new DataGridView();
            btnAddUser = new Button();
            btnDeleteUser = new Button();
            btnUpdateUser = new Button();
            btnSearchUser = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvAccount
            // 
            dtgvAccount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvAccount.BackgroundColor = SystemColors.Control;
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(0, 137);
            dtgvAccount.MaximumSize = new Size(99999, 99999);
            dtgvAccount.MinimumSize = new Size(1954, 1008);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.RowHeadersWidth = 123;
            dtgvAccount.Size = new Size(1959, 1052);
            dtgvAccount.TabIndex = 0;
            // 
            // btnAddUser
            // 
            btnAddUser.Anchor = AnchorStyles.None;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Segoe UI", 12F);
            btnAddUser.Location = new Point(262, 19);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(182, 86);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "Thêm";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Anchor = AnchorStyles.None;
            btnDeleteUser.FlatStyle = FlatStyle.Flat;
            btnDeleteUser.Font = new Font("Segoe UI", 12F);
            btnDeleteUser.Location = new Point(690, 19);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(138, 86);
            btnDeleteUser.TabIndex = 2;
            btnDeleteUser.Text = "Xóa";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.Anchor = AnchorStyles.None;
            btnUpdateUser.FlatStyle = FlatStyle.Flat;
            btnUpdateUser.Font = new Font("Segoe UI", 12F);
            btnUpdateUser.Location = new Point(1056, 19);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(135, 86);
            btnUpdateUser.TabIndex = 3;
            btnUpdateUser.Text = "Sửa";
            btnUpdateUser.UseVisualStyleBackColor = true;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // btnSearchUser
            // 
            btnSearchUser.Anchor = AnchorStyles.None;
            btnSearchUser.FlatStyle = FlatStyle.Flat;
            btnSearchUser.Font = new Font("Segoe UI", 12F);
            btnSearchUser.Location = new Point(1406, 19);
            btnSearchUser.Name = "btnSearchUser";
            btnSearchUser.Size = new Size(270, 86);
            btnSearchUser.TabIndex = 5;
            btnSearchUser.Text = "Tìm kiếm";
            btnSearchUser.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAddUser);
            panel1.Controls.Add(btnSearchUser);
            panel1.Controls.Add(btnDeleteUser);
            panel1.Controls.Add(btnUpdateUser);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1959, 131);
            panel1.TabIndex = 6;
            // 
            // FormQLND
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1959, 1189);
            Controls.Add(panel1);
            Controls.Add(dtgvAccount);
            Name = "FormQLND";
            Text = "Quản lý người dùng";
            Load += FormQLND_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvAccount;
        private Button btnAddUser;
        private Button btnDeleteUser;
        private Button btnUpdateUser;
        private Button btnSearchUser;
        private Panel panel1;
    }
}