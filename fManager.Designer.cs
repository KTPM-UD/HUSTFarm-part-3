namespace GiaoDien
{
    partial class fManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            button3 = new Button();
            btnSignUp = new Button();
            btnLogin = new Button();
            BtnWareHouse = new Button();
            BtnFood = new Button();
            BtnUsers = new Button();
            BtnLiveStock = new Button();
            panelLogo = new Panel();
            label2 = new Label();
            label1 = new Label();
            panelTitleBar = new Panel();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            lblTitle = new Label();
            btnCloseChildForm = new Button();
            panelDesktopPane = new Panel();
            tbTotalLSHome = new TextBox();
            tbTypeHome = new TextBox();
            tbIDHome = new TextBox();
            tbTenDangNhapHome = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            panelDesktopPane.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(btnSignUp);
            panelMenu.Controls.Add(btnLogin);
            panelMenu.Controls.Add(BtnWareHouse);
            panelMenu.Controls.Add(BtnFood);
            panelMenu.Controls.Add(BtnUsers);
            panelMenu.Controls.Add(BtnLiveStock);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(575, 1532);
            panelMenu.TabIndex = 0;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Bottom;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F);
            button3.ForeColor = Color.Gainsboro;
            button3.Image = Properties.Resources.logout_90dp;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 1352);
            button3.Name = "button3";
            button3.Padding = new Padding(16, 0, 0, 0);
            button3.Size = new Size(575, 180);
            button3.TabIndex = 99;
            button3.Text = "Thoát";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.Dock = DockStyle.Top;
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Segoe UI", 10F);
            btnSignUp.ForeColor = Color.Gainsboro;
            btnSignUp.Image = Properties.Resources.person_add_90dp;
            btnSignUp.ImageAlign = ContentAlignment.MiddleLeft;
            btnSignUp.Location = new Point(0, 1140);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Padding = new Padding(16, 0, 0, 0);
            btnSignUp.Size = new Size(575, 180);
            btnSignUp.TabIndex = 98;
            btnSignUp.Text = "Đăng ký";
            btnSignUp.TextAlign = ContentAlignment.MiddleLeft;
            btnSignUp.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += button2_Click;
            // 
            // btnLogin
            // 
            btnLogin.Dock = DockStyle.Top;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F);
            btnLogin.ForeColor = Color.Gainsboro;
            btnLogin.Image = Properties.Resources.login_90dp;
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(0, 960);
            btnLogin.Name = "btnLogin";
            btnLogin.Padding = new Padding(16, 0, 0, 0);
            btnLogin.Size = new Size(575, 180);
            btnLogin.TabIndex = 97;
            btnLogin.Text = "Đăng nhập";
            btnLogin.TextAlign = ContentAlignment.MiddleLeft;
            btnLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // BtnWareHouse
            // 
            BtnWareHouse.Dock = DockStyle.Top;
            BtnWareHouse.FlatAppearance.BorderSize = 0;
            BtnWareHouse.FlatStyle = FlatStyle.Flat;
            BtnWareHouse.Font = new Font("Segoe UI", 10F);
            BtnWareHouse.ForeColor = Color.Gainsboro;
            BtnWareHouse.Image = Properties.Resources.warehouse_90dp;
            BtnWareHouse.ImageAlign = ContentAlignment.MiddleLeft;
            BtnWareHouse.Location = new Point(0, 780);
            BtnWareHouse.Name = "BtnWareHouse";
            BtnWareHouse.Padding = new Padding(16, 0, 0, 0);
            BtnWareHouse.Size = new Size(575, 180);
            BtnWareHouse.TabIndex = 104;
            BtnWareHouse.Text = "Quản lý kho và chuồng";
            BtnWareHouse.TextAlign = ContentAlignment.MiddleLeft;
            BtnWareHouse.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnWareHouse.UseVisualStyleBackColor = true;
            BtnWareHouse.Click += button4_Click;
            // 
            // BtnFood
            // 
            BtnFood.Dock = DockStyle.Top;
            BtnFood.FlatAppearance.BorderSize = 0;
            BtnFood.FlatStyle = FlatStyle.Flat;
            BtnFood.Font = new Font("Segoe UI", 10F);
            BtnFood.ForeColor = Color.Gainsboro;
            BtnFood.Image = Properties.Resources.pet_supplies_90dp;
            BtnFood.ImageAlign = ContentAlignment.MiddleLeft;
            BtnFood.Location = new Point(0, 600);
            BtnFood.Name = "BtnFood";
            BtnFood.Padding = new Padding(16, 0, 0, 0);
            BtnFood.Size = new Size(575, 180);
            BtnFood.TabIndex = 103;
            BtnFood.Text = "Quản lý thực phẩm";
            BtnFood.TextAlign = ContentAlignment.MiddleLeft;
            BtnFood.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnFood.UseVisualStyleBackColor = true;
            BtnFood.Click += BtnFood_Click;
            // 
            // BtnUsers
            // 
            BtnUsers.Dock = DockStyle.Top;
            BtnUsers.FlatAppearance.BorderSize = 0;
            BtnUsers.FlatStyle = FlatStyle.Flat;
            BtnUsers.Font = new Font("Segoe UI", 10F);
            BtnUsers.ForeColor = Color.Gainsboro;
            BtnUsers.Image = Properties.Resources.groups_90dp;
            BtnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            BtnUsers.Location = new Point(0, 420);
            BtnUsers.Name = "BtnUsers";
            BtnUsers.Padding = new Padding(16, 0, 0, 0);
            BtnUsers.Size = new Size(575, 180);
            BtnUsers.TabIndex = 102;
            BtnUsers.Text = "Quản lý người dùng";
            BtnUsers.TextAlign = ContentAlignment.MiddleLeft;
            BtnUsers.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnUsers.UseVisualStyleBackColor = true;
            BtnUsers.Click += BtnUsers_Click;
            // 
            // BtnLiveStock
            // 
            BtnLiveStock.Dock = DockStyle.Top;
            BtnLiveStock.FlatAppearance.BorderSize = 0;
            BtnLiveStock.FlatStyle = FlatStyle.Flat;
            BtnLiveStock.Font = new Font("Segoe UI", 10F);
            BtnLiveStock.ForeColor = Color.Gainsboro;
            BtnLiveStock.Image = Properties.Resources.pets_90dp;
            BtnLiveStock.ImageAlign = ContentAlignment.MiddleLeft;
            BtnLiveStock.Location = new Point(0, 240);
            BtnLiveStock.Name = "BtnLiveStock";
            BtnLiveStock.Padding = new Padding(16, 0, 0, 0);
            BtnLiveStock.Size = new Size(575, 180);
            BtnLiveStock.TabIndex = 101;
            BtnLiveStock.Text = "Quản lý vật nuôi";
            BtnLiveStock.TextAlign = ContentAlignment.MiddleLeft;
            BtnLiveStock.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnLiveStock.UseVisualStyleBackColor = true;
            BtnLiveStock.Click += BtnLiveStock_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(label2);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(575, 240);
            panelLogo.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(7, 8);
            label2.Name = "label2";
            label2.Size = new Size(0, 65);
            label2.TabIndex = 1;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(82, 77);
            label1.Name = "label1";
            label1.Size = new Size(398, 96);
            label1.TabIndex = 100;
            label1.Text = "HUSTFarm";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Controls.Add(btnCloseChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(575, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1995, 240);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.Paint += panelTitleBar_Paint;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Image = Properties.Resources.check;
            btnMinimize.Location = new Point(1710, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(90, 90);
            btnMinimize.TabIndex = 120;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Image = Properties.Resources.crop_16_9_90dp;
            btnMaximize.Location = new Point(1806, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(90, 90);
            btnMaximize.TabIndex = 121;
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.disabled_by_default_90dp;
            btnClose.Location = new Point(1902, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(90, 90);
            btnClose.TabIndex = 122;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += button1_Click_1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(591, 96);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(475, 72);
            lblTitle.TabIndex = 124;
            lblTitle.Text = "Màn hình chính";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += label2_Click;
            lblTitle.MouseDown += lblTitle_MouseDown;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.Dock = DockStyle.Left;
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.Image = Properties.Resources.close_90dp;
            btnCloseChildForm.Location = new Point(0, 0);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(240, 240);
            btnCloseChildForm.TabIndex = 123;
            btnCloseChildForm.UseVisualStyleBackColor = true;
            btnCloseChildForm.Click += btnCloseChildForm_Click;
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Controls.Add(tbTotalLSHome);
            panelDesktopPane.Controls.Add(tbTypeHome);
            panelDesktopPane.Controls.Add(tbIDHome);
            panelDesktopPane.Controls.Add(tbTenDangNhapHome);
            panelDesktopPane.Controls.Add(label7);
            panelDesktopPane.Controls.Add(label6);
            panelDesktopPane.Controls.Add(label5);
            panelDesktopPane.Controls.Add(label4);
            panelDesktopPane.Controls.Add(label3);
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(575, 240);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(1995, 1292);
            panelDesktopPane.TabIndex = 2;
            // 
            // tbTotalLSHome
            // 
            tbTotalLSHome.Anchor = AnchorStyles.None;
            tbTotalLSHome.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTotalLSHome.Location = new Point(995, 898);
            tbTotalLSHome.Name = "tbTotalLSHome";
            tbTotalLSHome.ReadOnly = true;
            tbTotalLSHome.Size = new Size(636, 93);
            tbTotalLSHome.TabIndex = 8;
            // 
            // tbTypeHome
            // 
            tbTypeHome.Anchor = AnchorStyles.None;
            tbTypeHome.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTypeHome.Location = new Point(995, 718);
            tbTypeHome.Name = "tbTypeHome";
            tbTypeHome.ReadOnly = true;
            tbTypeHome.Size = new Size(636, 93);
            tbTypeHome.TabIndex = 7;
            // 
            // tbIDHome
            // 
            tbIDHome.Anchor = AnchorStyles.None;
            tbIDHome.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbIDHome.Location = new Point(995, 540);
            tbIDHome.Name = "tbIDHome";
            tbIDHome.ReadOnly = true;
            tbIDHome.Size = new Size(636, 93);
            tbIDHome.TabIndex = 6;
            tbIDHome.TextChanged += tbIDHome_TextChanged;
            // 
            // tbTenDangNhapHome
            // 
            tbTenDangNhapHome.Anchor = AnchorStyles.None;
            tbTenDangNhapHome.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTenDangNhapHome.Location = new Point(995, 358);
            tbTenDangNhapHome.Name = "tbTenDangNhapHome";
            tbTenDangNhapHome.ReadOnly = true;
            tbTenDangNhapHome.Size = new Size(636, 93);
            tbTenDangNhapHome.TabIndex = 5;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(404, 358);
            label7.Name = "label7";
            label7.Size = new Size(472, 86);
            label7.TabIndex = 4;
            label7.Text = "Tên đăng nhập:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(404, 538);
            label6.Name = "label6";
            label6.Size = new Size(113, 86);
            label6.TabIndex = 3;
            label6.Text = "ID:";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(404, 898);
            label5.Name = "label5";
            label5.Size = new Size(528, 86);
            label5.TabIndex = 2;
            label5.Text = "Tổng số vật nuôi:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(404, 718);
            label4.Name = "label4";
            label4.Size = new Size(235, 86);
            label4.TabIndex = 1;
            label4.Text = "Vai trò:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(432, 66);
            label3.Name = "label3";
            label3.Size = new Size(1140, 86);
            label3.TabIndex = 0;
            label3.Text = "Hệ thống quản lý chăn nuôi HUSTFarm";
            // 
            // fManager
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2570, 1532);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            MinimumSize = new Size(2300, 1300);
            Name = "fManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Hệ thống quản lý chăn nuôi HUSTFarm";
            FormClosing += fManager_FormClosing;
            Load += fManager_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelDesktopPane.ResumeLayout(false);
            panelDesktopPane.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button BtnWareHouse;
        private Button BtnFood;
        private Button BtnUsers;
        private Button BtnLiveStock;
        private Label label1;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Panel panelDesktopPane;
        private Button btnCloseChildForm;
        private Button btnClose;
        private Button btnMinimize;
        private Button btnMaximize;
        private Label label2;
        private Button btnSignUp;
        private Button btnLogin;
        private Button button3;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox tbTotalLSHome;
        private TextBox tbTypeHome;
        private TextBox tbIDHome;
        private TextBox tbTenDangNhapHome;
    }
}
