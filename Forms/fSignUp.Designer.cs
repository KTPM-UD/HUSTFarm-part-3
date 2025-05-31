namespace GiaoDien.Forms
{
    partial class fSignUp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            BtnConfirmSignUp = new Button();
            tBIDSignUp = new TextBox();
            dateTimePickerSignUp = new DateTimePicker();
            tBTypeSignUp = new TextBox();
            tbDiaChiSignUp = new TextBox();
            tbCCCDSignUp = new TextBox();
            tbHoTenSignUp = new TextBox();
            tbEmailSignUp = new TextBox();
            tbMatKhauSignUp = new TextBox();
            tbTenHienThiSignUp = new TextBox();
            tbTenDangNhapSignUp = new TextBox();
            comboBoxGioiTinhSignUp = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(179, 204);
            label1.Name = "label1";
            label1.Size = new Size(339, 65);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(179, 324);
            label2.Name = "label2";
            label2.Size = new Size(272, 65);
            label2.TabIndex = 1;
            label2.Text = "Tên hiển thị";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(179, 444);
            label3.Name = "label3";
            label3.Size = new Size(226, 65);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(186, 563);
            label4.Name = "label4";
            label4.Size = new Size(141, 65);
            label4.TabIndex = 3;
            label4.Text = "Email";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(186, 683);
            label5.Name = "label5";
            label5.Size = new Size(171, 65);
            label5.TabIndex = 4;
            label5.Text = "Họ tên";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(1010, 204);
            label6.Name = "label6";
            label6.Size = new Size(209, 65);
            label6.TabIndex = 5;
            label6.Text = "Giới tính";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(186, 803);
            label7.Name = "label7";
            label7.Size = new Size(238, 65);
            label7.TabIndex = 6;
            label7.Text = "Ngày sinh";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(1010, 324);
            label8.Name = "label8";
            label8.Size = new Size(150, 65);
            label8.TabIndex = 7;
            label8.Text = "CCCD";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(1010, 444);
            label9.Name = "label9";
            label9.Size = new Size(172, 65);
            label9.TabIndex = 8;
            label9.Text = "Địa chỉ";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(1010, 563);
            label10.Name = "label10";
            label10.Size = new Size(335, 65);
            label10.TabIndex = 9;
            label10.Text = "ID người dùng";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(1010, 683);
            label11.Name = "label11";
            label11.Size = new Size(323, 65);
            label11.TabIndex = 10;
            label11.Text = "Loại tài khoản";
            // 
            // BtnConfirmSignUp
            // 
            BtnConfirmSignUp.Anchor = AnchorStyles.None;
            BtnConfirmSignUp.FlatStyle = FlatStyle.Flat;
            BtnConfirmSignUp.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnConfirmSignUp.Location = new Point(699, 959);
            BtnConfirmSignUp.Name = "BtnConfirmSignUp";
            BtnConfirmSignUp.Size = new Size(531, 113);
            BtnConfirmSignUp.TabIndex = 8;
            BtnConfirmSignUp.Text = "Xác nhận đăng ký";
            BtnConfirmSignUp.UseVisualStyleBackColor = true;
            BtnConfirmSignUp.Click += BtnConfirmSignUp_Click;
            // 
            // tBIDSignUp
            // 
            tBIDSignUp.Anchor = AnchorStyles.None;
            tBIDSignUp.Font = new Font("Segoe UI", 12F);
            tBIDSignUp.Location = new Point(1358, 560);
            tBIDSignUp.Name = "tBIDSignUp";
            tBIDSignUp.ReadOnly = true;
            tBIDSignUp.Size = new Size(439, 71);
            tBIDSignUp.TabIndex = 12;
            // 
            // dateTimePickerSignUp
            // 
            dateTimePickerSignUp.Anchor = AnchorStyles.None;
            dateTimePickerSignUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerSignUp.Location = new Point(524, 803);
            dateTimePickerSignUp.Name = "dateTimePickerSignUp";
            dateTimePickerSignUp.Size = new Size(750, 71);
            dateTimePickerSignUp.TabIndex = 13;
            // 
            // tBTypeSignUp
            // 
            tBTypeSignUp.Anchor = AnchorStyles.None;
            tBTypeSignUp.Font = new Font("Segoe UI", 12F);
            tBTypeSignUp.Location = new Point(1358, 683);
            tBTypeSignUp.Name = "tBTypeSignUp";
            tBTypeSignUp.ReadOnly = true;
            tBTypeSignUp.Size = new Size(439, 71);
            tBTypeSignUp.TabIndex = 14;
            // 
            // tbDiaChiSignUp
            // 
            tbDiaChiSignUp.Anchor = AnchorStyles.None;
            tbDiaChiSignUp.Font = new Font("Segoe UI", 12F);
            tbDiaChiSignUp.Location = new Point(1358, 444);
            tbDiaChiSignUp.Name = "tbDiaChiSignUp";
            tbDiaChiSignUp.Size = new Size(439, 71);
            tbDiaChiSignUp.TabIndex = 7;
            // 
            // tbCCCDSignUp
            // 
            tbCCCDSignUp.Anchor = AnchorStyles.None;
            tbCCCDSignUp.Font = new Font("Segoe UI", 12F);
            tbCCCDSignUp.Location = new Point(1358, 321);
            tbCCCDSignUp.MaxLength = 12;
            tbCCCDSignUp.Name = "tbCCCDSignUp";
            tbCCCDSignUp.Size = new Size(439, 71);
            tbCCCDSignUp.TabIndex = 6;
            // 
            // tbHoTenSignUp
            // 
            tbHoTenSignUp.Anchor = AnchorStyles.None;
            tbHoTenSignUp.Font = new Font("Segoe UI", 12F);
            tbHoTenSignUp.Location = new Point(524, 684);
            tbHoTenSignUp.Name = "tbHoTenSignUp";
            tbHoTenSignUp.Size = new Size(437, 71);
            tbHoTenSignUp.TabIndex = 4;
            // 
            // tbEmailSignUp
            // 
            tbEmailSignUp.Anchor = AnchorStyles.None;
            tbEmailSignUp.Font = new Font("Segoe UI", 12F);
            tbEmailSignUp.Location = new Point(524, 564);
            tbEmailSignUp.Name = "tbEmailSignUp";
            tbEmailSignUp.Size = new Size(437, 71);
            tbEmailSignUp.TabIndex = 3;
            // 
            // tbMatKhauSignUp
            // 
            tbMatKhauSignUp.Anchor = AnchorStyles.None;
            tbMatKhauSignUp.Font = new Font("Segoe UI", 12F);
            tbMatKhauSignUp.Location = new Point(524, 438);
            tbMatKhauSignUp.Name = "tbMatKhauSignUp";
            tbMatKhauSignUp.Size = new Size(437, 71);
            tbMatKhauSignUp.TabIndex = 2;
            // 
            // tbTenHienThiSignUp
            // 
            tbTenHienThiSignUp.Anchor = AnchorStyles.None;
            tbTenHienThiSignUp.Font = new Font("Segoe UI", 12F);
            tbTenHienThiSignUp.Location = new Point(524, 329);
            tbTenHienThiSignUp.Name = "tbTenHienThiSignUp";
            tbTenHienThiSignUp.Size = new Size(437, 71);
            tbTenHienThiSignUp.TabIndex = 1;
            // 
            // tbTenDangNhapSignUp
            // 
            tbTenDangNhapSignUp.Anchor = AnchorStyles.None;
            tbTenDangNhapSignUp.Font = new Font("Segoe UI", 12F);
            tbTenDangNhapSignUp.Location = new Point(524, 204);
            tbTenDangNhapSignUp.Name = "tbTenDangNhapSignUp";
            tbTenDangNhapSignUp.Size = new Size(437, 71);
            tbTenDangNhapSignUp.TabIndex = 0;
            // 
            // comboBoxGioiTinhSignUp
            // 
            comboBoxGioiTinhSignUp.Anchor = AnchorStyles.None;
            comboBoxGioiTinhSignUp.Font = new Font("Segoe UI", 12F);
            comboBoxGioiTinhSignUp.FormattingEnabled = true;
            comboBoxGioiTinhSignUp.Items.AddRange(new object[] { "Nam", "Nữ" });
            comboBoxGioiTinhSignUp.Location = new Point(1358, 204);
            comboBoxGioiTinhSignUp.Name = "comboBoxGioiTinhSignUp";
            comboBoxGioiTinhSignUp.Size = new Size(437, 73);
            comboBoxGioiTinhSignUp.TabIndex = 5;
            // 
            // fSignUp
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1959, 1189);
            Controls.Add(comboBoxGioiTinhSignUp);
            Controls.Add(tbTenDangNhapSignUp);
            Controls.Add(tbTenHienThiSignUp);
            Controls.Add(tbMatKhauSignUp);
            Controls.Add(tbEmailSignUp);
            Controls.Add(tbHoTenSignUp);
            Controls.Add(tbCCCDSignUp);
            Controls.Add(tbDiaChiSignUp);
            Controls.Add(tBTypeSignUp);
            Controls.Add(dateTimePickerSignUp);
            Controls.Add(tBIDSignUp);
            Controls.Add(BtnConfirmSignUp);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fSignUp";
            Text = "Đăng ký";
            Load += fSignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button BtnConfirmSignUp;
        private TextBox tBIDSignUp;
        private DateTimePicker dateTimePickerSignUp;
        private TextBox tBTypeSignUp;
        private TextBox tbDiaChiSignUp;
        private TextBox tbCCCDSignUp;
        private TextBox tbHoTenSignUp;
        private TextBox tbEmailSignUp;
        private TextBox tbMatKhauSignUp;
        private TextBox tbTenHienThiSignUp;
        private TextBox tbTenDangNhapSignUp;
        private ComboBox comboBoxGioiTinhSignUp;
    }
}