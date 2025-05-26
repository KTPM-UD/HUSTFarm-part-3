namespace HTQLCN
{
    partial class fTableManager
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
            tbKho = new TabPage();
            tbFood = new TabPage();
            tbUserManage = new TabPage();
            dtgvAccount = new DataGridView();
            panel5 = new Panel();
            BtnSearch1 = new Button();
            btnDetails1 = new Button();
            BtnRefresh1 = new Button();
            btnUpdate1 = new Button();
            btnDelete1 = new Button();
            btnAdd1 = new Button();
            tbFarm = new TabPage();
            dtgvLivestock = new DataGridView();
            panel1 = new Panel();
            btnSearch = new Button();
            btnDetails = new Button();
            btnRefresh = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            panel2 = new Panel();
            tbMainScreen = new TabPage();
            tBID = new TextBox();
            label6 = new Label();
            tBTotalMain = new TextBox();
            tBTypeMain = new TextBox();
            tBUsernameMain = new TextBox();
            btnSignOut = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tcQLCN = new TabControl();
            tbUserManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            panel5.SuspendLayout();
            tbFarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvLivestock).BeginInit();
            panel1.SuspendLayout();
            tbMainScreen.SuspendLayout();
            tcQLCN.SuspendLayout();
            SuspendLayout();
            // 
            // tbKho
            // 
            tbKho.Location = new Point(12, 82);
            tbKho.Name = "tbKho";
            tbKho.Padding = new Padding(3);
            tbKho.Size = new Size(2378, 1300);
            tbKho.TabIndex = 4;
            tbKho.Text = "Quản lý kho";
            tbKho.UseVisualStyleBackColor = true;
            // 
            // tbFood
            // 
            tbFood.Location = new Point(12, 82);
            tbFood.Name = "tbFood";
            tbFood.Padding = new Padding(3);
            tbFood.Size = new Size(2378, 1300);
            tbFood.TabIndex = 3;
            tbFood.Text = "Quản lý thức ăn";
            tbFood.UseVisualStyleBackColor = true;
            // 
            // tbUserManage
            // 
            tbUserManage.Controls.Add(dtgvAccount);
            tbUserManage.Controls.Add(panel5);
            tbUserManage.Location = new Point(12, 82);
            tbUserManage.Name = "tbUserManage";
            tbUserManage.Padding = new Padding(3);
            tbUserManage.Size = new Size(2378, 1300);
            tbUserManage.TabIndex = 2;
            tbUserManage.Text = "Quản lý người dùng";
            tbUserManage.UseVisualStyleBackColor = true;
            // 
            // dtgvAccount
            // 
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(7, 127);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.RowHeadersWidth = 123;
            dtgvAccount.Size = new Size(2373, 1156);
            dtgvAccount.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(BtnSearch1);
            panel5.Controls.Add(btnDetails1);
            panel5.Controls.Add(BtnRefresh1);
            panel5.Controls.Add(btnUpdate1);
            panel5.Controls.Add(btnDelete1);
            panel5.Controls.Add(btnAdd1);
            panel5.Location = new Point(7, 6);
            panel5.Name = "panel5";
            panel5.Size = new Size(2371, 115);
            panel5.TabIndex = 1;
            // 
            // BtnSearch1
            // 
            BtnSearch1.Location = new Point(1505, 19);
            BtnSearch1.Name = "BtnSearch1";
            BtnSearch1.Size = new Size(274, 69);
            BtnSearch1.TabIndex = 5;
            BtnSearch1.Text = "Tìm kiếm";
            BtnSearch1.UseVisualStyleBackColor = true;
            BtnSearch1.Click += BtnSearch1_Click;
            // 
            // btnDetails1
            // 
            btnDetails1.Location = new Point(1177, 19);
            btnDetails1.Name = "btnDetails1";
            btnDetails1.Size = new Size(274, 69);
            btnDetails1.TabIndex = 4;
            btnDetails1.Text = "Xem chi tiết";
            btnDetails1.UseVisualStyleBackColor = true;
            // 
            // BtnRefresh1
            // 
            BtnRefresh1.Location = new Point(847, 19);
            BtnRefresh1.Name = "BtnRefresh1";
            BtnRefresh1.Size = new Size(270, 69);
            BtnRefresh1.TabIndex = 3;
            BtnRefresh1.Text = "Làm mới";
            BtnRefresh1.UseVisualStyleBackColor = true;
            BtnRefresh1.Click += BtnRefresh1_Click;
            // 
            // btnUpdate1
            // 
            btnUpdate1.Location = new Point(581, 19);
            btnUpdate1.Name = "btnUpdate1";
            btnUpdate1.Size = new Size(207, 69);
            btnUpdate1.TabIndex = 2;
            btnUpdate1.Text = "Sửa";
            btnUpdate1.UseVisualStyleBackColor = true;
            // 
            // btnDelete1
            // 
            btnDelete1.Location = new Point(319, 19);
            btnDelete1.Name = "btnDelete1";
            btnDelete1.Size = new Size(207, 69);
            btnDelete1.TabIndex = 1;
            btnDelete1.Text = "Xóa";
            btnDelete1.UseVisualStyleBackColor = true;
            // 
            // btnAdd1
            // 
            btnAdd1.Location = new Point(61, 19);
            btnAdd1.Name = "btnAdd1";
            btnAdd1.Size = new Size(207, 69);
            btnAdd1.TabIndex = 0;
            btnAdd1.Text = "Thêm";
            btnAdd1.UseVisualStyleBackColor = true;
            btnAdd1.Click += button12_Click;
            // 
            // tbFarm
            // 
            tbFarm.Controls.Add(dtgvLivestock);
            tbFarm.Controls.Add(panel1);
            tbFarm.Controls.Add(panel2);
            tbFarm.Location = new Point(12, 82);
            tbFarm.Name = "tbFarm";
            tbFarm.Padding = new Padding(3);
            tbFarm.Size = new Size(2378, 1300);
            tbFarm.TabIndex = 1;
            tbFarm.Text = "Quản lý vật nuôi";
            tbFarm.UseVisualStyleBackColor = true;
            // 
            // dtgvLivestock
            // 
            dtgvLivestock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvLivestock.Location = new Point(6, 128);
            dtgvLivestock.Name = "dtgvLivestock";
            dtgvLivestock.RowHeadersWidth = 123;
            dtgvLivestock.Size = new Size(2373, 1156);
            dtgvLivestock.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnDetails);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(4, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(2371, 115);
            panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1478, 19);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(274, 69);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += button6_Click;
            // 
            // btnDetails
            // 
            btnDetails.Location = new Point(1150, 19);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(274, 69);
            btnDetails.TabIndex = 4;
            btnDetails.Text = "Xem chi tiết";
            btnDetails.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(828, 19);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(270, 69);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += button4_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(317, 19);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(207, 69);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(568, 19);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(207, 69);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += button2_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(59, 19);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(207, 69);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(6, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(2353, 1169);
            panel2.TabIndex = 1;
            // 
            // tbMainScreen
            // 
            tbMainScreen.Controls.Add(tBID);
            tbMainScreen.Controls.Add(label6);
            tbMainScreen.Controls.Add(tBTotalMain);
            tbMainScreen.Controls.Add(tBTypeMain);
            tbMainScreen.Controls.Add(tBUsernameMain);
            tbMainScreen.Controls.Add(btnSignOut);
            tbMainScreen.Controls.Add(label5);
            tbMainScreen.Controls.Add(label4);
            tbMainScreen.Controls.Add(label3);
            tbMainScreen.Controls.Add(label2);
            tbMainScreen.Controls.Add(label1);
            tbMainScreen.Location = new Point(12, 82);
            tbMainScreen.Name = "tbMainScreen";
            tbMainScreen.Padding = new Padding(3);
            tbMainScreen.Size = new Size(2378, 1300);
            tbMainScreen.TabIndex = 0;
            tbMainScreen.Text = "Màn hình chính";
            tbMainScreen.UseVisualStyleBackColor = true;
            // 
            // tBID
            // 
            tBID.Font = new Font("Segoe UI", 14F);
            tBID.Location = new Point(777, 370);
            tBID.Name = "tBID";
            tBID.ReadOnly = true;
            tBID.Size = new Size(458, 82);
            tBID.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(201, 378);
            label6.Name = "label6";
            label6.Size = new Size(98, 74);
            label6.TabIndex = 4;
            label6.Text = "ID:";
            // 
            // tBTotalMain
            // 
            tBTotalMain.Font = new Font("Segoe UI", 14F);
            tBTotalMain.Location = new Point(777, 736);
            tBTotalMain.Name = "tBTotalMain";
            tBTotalMain.ReadOnly = true;
            tBTotalMain.Size = new Size(458, 82);
            tBTotalMain.TabIndex = 10;
            // 
            // tBTypeMain
            // 
            tBTypeMain.Font = new Font("Segoe UI", 14F);
            tBTypeMain.Location = new Point(777, 554);
            tBTypeMain.Name = "tBTypeMain";
            tBTypeMain.ReadOnly = true;
            tBTypeMain.Size = new Size(458, 82);
            tBTypeMain.TabIndex = 9;
            // 
            // tBUsernameMain
            // 
            tBUsernameMain.Font = new Font("Segoe UI", 14F);
            tBUsernameMain.Location = new Point(777, 179);
            tBUsernameMain.Name = "tBUsernameMain";
            tBUsernameMain.ReadOnly = true;
            tBUsernameMain.Size = new Size(458, 82);
            tBUsernameMain.TabIndex = 7;
            // 
            // btnSignOut
            // 
            btnSignOut.Location = new Point(246, 885);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(353, 119);
            btnSignOut.TabIndex = 11;
            btnSignOut.Text = "Đăng xuất";
            btnSignOut.UseVisualStyleBackColor = true;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(201, 562);
            label5.Name = "label5";
            label5.Size = new Size(203, 74);
            label5.TabIndex = 5;
            label5.Text = "Vai trò:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(201, 187);
            label4.Name = "label4";
            label4.Size = new Size(410, 74);
            label4.TabIndex = 3;
            label4.Text = "Tên đăng nhập:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(626, 39);
            label3.Name = "label3";
            label3.Size = new Size(1140, 86);
            label3.TabIndex = 2;
            label3.Text = "Hệ thống quản lý chăn nuôi HUSTFarm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(527, 139);
            label2.Name = "label2";
            label2.Size = new Size(0, 48);
            label2.TabIndex = 1;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(201, 744);
            label1.Name = "label1";
            label1.Size = new Size(458, 74);
            label1.TabIndex = 6;
            label1.Text = "Tổng số vật nuôi:";
            label1.Click += label1_Click;
            // 
            // tcQLCN
            // 
            tcQLCN.Controls.Add(tbMainScreen);
            tcQLCN.Controls.Add(tbFarm);
            tcQLCN.Controls.Add(tbUserManage);
            tcQLCN.Controls.Add(tbFood);
            tcQLCN.Controls.Add(tbKho);
            tcQLCN.ItemSize = new Size(257, 70);
            tcQLCN.Location = new Point(16, 17);
            tcQLCN.Name = "tcQLCN";
            tcQLCN.Padding = new Point(60, 3);
            tcQLCN.SelectedIndex = 0;
            tcQLCN.Size = new Size(2402, 1394);
            tcQLCN.TabIndex = 0;
            // 
            // fTableManager
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2430, 1423);
            Controls.Add(tcQLCN);
            Name = "fTableManager";
            Text = "Hệ thống quản lý chăn nuôi HUSTFarm";
            Load += fTableManager_Load;
            tbUserManage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            panel5.ResumeLayout(false);
            tbFarm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvLivestock).EndInit();
            panel1.ResumeLayout(false);
            tbMainScreen.ResumeLayout(false);
            tbMainScreen.PerformLayout();
            tcQLCN.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TabPage tbKho;
        private TabPage tbFood;
        private TabPage tbUserManage;
        private DataGridView dtgvAccount;
        private Panel panel5;
        private Button BtnSearch1;
        private Button btnDetails1;
        private Button BtnRefresh1;
        private Button btnUpdate1;
        private Button btnDelete1;
        private Button btnAdd1;
        private TabPage tbFarm;
        private DataGridView dtgvLivestock;
        private Panel panel1;
        private Button btnSearch;
        private Button btnDetails;
        private Button btnRefresh;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private Panel panel2;
        private TabPage tbMainScreen;
        private Label label2;
        private Label label1;
        private TabControl tcQLCN;
        private Label label4;
        private Label label3;
        private Label label5;
        private Button btnSignOut;
        private TextBox tBTotalMain;
        private TextBox tBTypeMain;
        private TextBox tBUsernameMain;
        private TextBox tBID;
        private Label label6;
    }
}