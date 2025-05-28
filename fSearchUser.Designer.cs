namespace HTQLCN
{
    partial class fSearchUser
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
            BtnSearchUser = new Button();
            TbUsernameSearch = new TextBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnSearchUser
            // 
            BtnSearchUser.Font = new Font("Segoe UI", 12F);
            BtnSearchUser.Image = Properties.Resources.search;
            BtnSearchUser.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSearchUser.Location = new Point(305, 128);
            BtnSearchUser.Name = "BtnSearchUser";
            BtnSearchUser.Padding = new Padding(20, 0, 0, 0);
            BtnSearchUser.Size = new Size(318, 74);
            BtnSearchUser.TabIndex = 0;
            BtnSearchUser.Tag = "";
            BtnSearchUser.Text = "Tìm kiếm";
            BtnSearchUser.TextAlign = ContentAlignment.MiddleLeft;
            BtnSearchUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSearchUser.UseVisualStyleBackColor = true;
            BtnSearchUser.Click += BtnSearchUser_Click;
            // 
            // TbUsernameSearch
            // 
            TbUsernameSearch.Font = new Font("Segoe UI", 12F);
            TbUsernameSearch.Location = new Point(3, 30);
            TbUsernameSearch.MaxLength = 50;
            TbUsernameSearch.Name = "TbUsernameSearch";
            TbUsernameSearch.PlaceholderText = "Nhập tên đăng nhập";
            TbUsernameSearch.Size = new Size(898, 71);
            TbUsernameSearch.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnSearchUser);
            panel1.Controls.Add(TbUsernameSearch);
            panel1.Location = new Point(46, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(907, 223);
            panel1.TabIndex = 2;
            // 
            // fSearchUser
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 247);
            Controls.Add(panel1);
            Name = "fSearchUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form tìm kiếm người dùng";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSearchUser;
        private TextBox TbUsernameSearch;
        private Panel panel1;
    }
}