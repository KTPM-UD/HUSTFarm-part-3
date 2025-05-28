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
            BtnWareHouse = new Button();
            BtnFood = new Button();
            BtnUsers = new Button();
            BtnLiveStock = new Button();
            BtnMainHome = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            panelTitleBar = new Panel();
            lblTitle = new Label();
            panelDesktopPane = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(BtnWareHouse);
            panelMenu.Controls.Add(BtnFood);
            panelMenu.Controls.Add(BtnUsers);
            panelMenu.Controls.Add(BtnLiveStock);
            panelMenu.Controls.Add(BtnMainHome);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(551, 1142);
            panelMenu.TabIndex = 0;
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
            BtnWareHouse.Location = new Point(0, 960);
            BtnWareHouse.Name = "BtnWareHouse";
            BtnWareHouse.Padding = new Padding(12, 0, 0, 0);
            BtnWareHouse.Size = new Size(551, 180);
            BtnWareHouse.TabIndex = 5;
            BtnWareHouse.Text = "Quản lý kho";
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
            BtnFood.Location = new Point(0, 780);
            BtnFood.Name = "BtnFood";
            BtnFood.Padding = new Padding(12, 0, 0, 0);
            BtnFood.Size = new Size(551, 180);
            BtnFood.TabIndex = 4;
            BtnFood.Text = "Quản lý thức ăn";
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
            BtnUsers.Location = new Point(0, 600);
            BtnUsers.Name = "BtnUsers";
            BtnUsers.Padding = new Padding(12, 0, 0, 0);
            BtnUsers.Size = new Size(551, 180);
            BtnUsers.TabIndex = 3;
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
            BtnLiveStock.Location = new Point(0, 420);
            BtnLiveStock.Name = "BtnLiveStock";
            BtnLiveStock.Padding = new Padding(12, 0, 0, 0);
            BtnLiveStock.Size = new Size(551, 180);
            BtnLiveStock.TabIndex = 2;
            BtnLiveStock.Text = "Quản lý vật nuôi";
            BtnLiveStock.TextAlign = ContentAlignment.MiddleLeft;
            BtnLiveStock.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnLiveStock.UseVisualStyleBackColor = true;
            BtnLiveStock.Click += BtnLiveStock_Click;
            // 
            // BtnMainHome
            // 
            BtnMainHome.Dock = DockStyle.Top;
            BtnMainHome.FlatAppearance.BorderSize = 0;
            BtnMainHome.FlatStyle = FlatStyle.Flat;
            BtnMainHome.Font = new Font("Segoe UI", 10F);
            BtnMainHome.ForeColor = Color.Gainsboro;
            BtnMainHome.Image = Properties.Resources.home_90dp;
            BtnMainHome.ImageAlign = ContentAlignment.MiddleLeft;
            BtnMainHome.Location = new Point(0, 240);
            BtnMainHome.Name = "BtnMainHome";
            BtnMainHome.Padding = new Padding(12, 0, 0, 0);
            BtnMainHome.Size = new Size(551, 180);
            BtnMainHome.TabIndex = 1;
            BtnMainHome.Text = "Màn hình chính";
            BtnMainHome.TextAlign = ContentAlignment.MiddleLeft;
            BtnMainHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnMainHome.UseVisualStyleBackColor = true;
            BtnMainHome.Click += BtnMainHome_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(551, 240);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(32, 76);
            label1.Name = "label1";
            label1.Size = new Size(249, 65);
            label1.TabIndex = 0;
            label1.Text = "HUSTFarm";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(551, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1722, 240);
            panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(769, 76);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(222, 72);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            lblTitle.Click += label2_Click;
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(551, 240);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(1722, 902);
            panelDesktopPane.TabIndex = 2;
            // 
            // fManager
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2273, 1142);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "fManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Hệ thống quản lý chăn nuôi HUSTFarm";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button BtnMainHome;
        private Button BtnWareHouse;
        private Button BtnFood;
        private Button BtnUsers;
        private Button BtnLiveStock;
        private Label label1;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Panel panelDesktopPane;
    }
}
