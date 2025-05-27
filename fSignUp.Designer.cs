namespace HTQLCN
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
            comboBoxGioiTinhSignUp = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tBtenDangNhapSignUp = new TextBox();
            tBMatKhauSignUp = new TextBox();
            tBEmailSignUp = new TextBox();
            tBTypeSignUp = new TextBox();
            tBHoTenSignUp = new TextBox();
            BtnSaveSignUp = new Button();
            BtnCancelSignUp = new Button();
            tBDisplayNameSignUp = new TextBox();
            label3 = new Label();
            dateTimePickerSignUp = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            tBCCCDSignUp = new TextBox();
            tBDiaChiSignUp = new TextBox();
            label11 = new Label();
            tBIDSignUp = new TextBox();
            SuspendLayout();
            // 
            // comboBoxGioiTinhSignUp
            // 
            comboBoxGioiTinhSignUp.FormattingEnabled = true;
            comboBoxGioiTinhSignUp.Items.AddRange(new object[] { "Nam", "Nữ" });
            comboBoxGioiTinhSignUp.Location = new Point(292, 442);
            comboBoxGioiTinhSignUp.Name = "comboBoxGioiTinhSignUp";
            comboBoxGioiTinhSignUp.Size = new Size(588, 56);
            comboBoxGioiTinhSignUp.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 31);
            label1.Name = "label1";
            label1.Size = new Size(253, 48);
            label1.TabIndex = 17;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 109);
            label2.Name = "label2";
            label2.Size = new Size(203, 48);
            label2.TabIndex = 18;
            label2.Text = "Tên hiển thị";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 272);
            label4.Name = "label4";
            label4.Size = new Size(105, 48);
            label4.TabIndex = 20;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 189);
            label5.Name = "label5";
            label5.Size = new Size(168, 48);
            label5.TabIndex = 21;
            label5.Text = "Mật khẩu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 848);
            label6.Name = "label6";
            label6.Size = new Size(241, 48);
            label6.TabIndex = 22;
            label6.Text = "Loại tài khoản";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 356);
            label7.Name = "label7";
            label7.Size = new Size(128, 48);
            label7.TabIndex = 23;
            label7.Text = "Họ tên";
            // 
            // tBtenDangNhapSignUp
            // 
            tBtenDangNhapSignUp.Location = new Point(292, 31);
            tBtenDangNhapSignUp.Name = "tBtenDangNhapSignUp";
            tBtenDangNhapSignUp.Size = new Size(588, 55);
            tBtenDangNhapSignUp.TabIndex = 1;
            // 
            // tBMatKhauSignUp
            // 
            tBMatKhauSignUp.Location = new Point(292, 189);
            tBMatKhauSignUp.Name = "tBMatKhauSignUp";
            tBMatKhauSignUp.Size = new Size(588, 55);
            tBMatKhauSignUp.TabIndex = 3;
            // 
            // tBEmailSignUp
            // 
            tBEmailSignUp.Location = new Point(292, 272);
            tBEmailSignUp.Name = "tBEmailSignUp";
            tBEmailSignUp.Size = new Size(588, 55);
            tBEmailSignUp.TabIndex = 4;
            // 
            // tBTypeSignUp
            // 
            tBTypeSignUp.Location = new Point(292, 848);
            tBTypeSignUp.Name = "tBTypeSignUp";
            tBTypeSignUp.ReadOnly = true;
            tBTypeSignUp.Size = new Size(588, 55);
            tBTypeSignUp.TabIndex = 27;
            // 
            // tBHoTenSignUp
            // 
            tBHoTenSignUp.Location = new Point(292, 356);
            tBHoTenSignUp.Name = "tBHoTenSignUp";
            tBHoTenSignUp.Size = new Size(588, 55);
            tBHoTenSignUp.TabIndex = 5;
            tBHoTenSignUp.TextChanged += textBox6_TextChanged;
            // 
            // BtnSaveSignUp
            // 
            BtnSaveSignUp.Location = new Point(119, 919);
            BtnSaveSignUp.Name = "BtnSaveSignUp";
            BtnSaveSignUp.Size = new Size(225, 69);
            BtnSaveSignUp.TabIndex = 10;
            BtnSaveSignUp.Text = "Xác nhận";
            BtnSaveSignUp.UseVisualStyleBackColor = true;
            BtnSaveSignUp.Click += BtnSaveSignUp_Click;
            // 
            // BtnCancelSignUp
            // 
            BtnCancelSignUp.Location = new Point(550, 919);
            BtnCancelSignUp.Name = "BtnCancelSignUp";
            BtnCancelSignUp.Size = new Size(225, 69);
            BtnCancelSignUp.TabIndex = 11;
            BtnCancelSignUp.Text = "Hủy";
            BtnCancelSignUp.UseVisualStyleBackColor = true;
            BtnCancelSignUp.Click += BtnCancelSignUp_Click;
            // 
            // tBDisplayNameSignUp
            // 
            tBDisplayNameSignUp.Location = new Point(292, 109);
            tBDisplayNameSignUp.Name = "tBDisplayNameSignUp";
            tBDisplayNameSignUp.Size = new Size(588, 55);
            tBDisplayNameSignUp.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 442);
            label3.Name = "label3";
            label3.Size = new Size(156, 48);
            label3.TabIndex = 33;
            label3.Text = "Giới tính";
            // 
            // dateTimePickerSignUp
            // 
            dateTimePickerSignUp.Location = new Point(292, 524);
            dateTimePickerSignUp.Name = "dateTimePickerSignUp";
            dateTimePickerSignUp.Size = new Size(588, 55);
            dateTimePickerSignUp.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 524);
            label8.Name = "label8";
            label8.Size = new Size(177, 48);
            label8.TabIndex = 35;
            label8.Text = "Ngày sinh";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 685);
            label9.Name = "label9";
            label9.Size = new Size(128, 48);
            label9.TabIndex = 39;
            label9.Text = "Địa chỉ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(32, 601);
            label10.Name = "label10";
            label10.Size = new Size(109, 48);
            label10.TabIndex = 37;
            label10.Text = "CCCD";
            // 
            // tBCCCDSignUp
            // 
            tBCCCDSignUp.Location = new Point(292, 601);
            tBCCCDSignUp.Name = "tBCCCDSignUp";
            tBCCCDSignUp.Size = new Size(588, 55);
            tBCCCDSignUp.TabIndex = 8;
            // 
            // tBDiaChiSignUp
            // 
            tBDiaChiSignUp.Location = new Point(292, 685);
            tBDiaChiSignUp.Name = "tBDiaChiSignUp";
            tBDiaChiSignUp.Size = new Size(588, 55);
            tBDiaChiSignUp.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(32, 763);
            label11.Name = "label11";
            label11.Size = new Size(250, 48);
            label11.TabIndex = 41;
            label11.Text = "ID người dùng";
            // 
            // tBIDSignUp
            // 
            tBIDSignUp.Location = new Point(292, 763);
            tBIDSignUp.Name = "tBIDSignUp";
            tBIDSignUp.ReadOnly = true;
            tBIDSignUp.Size = new Size(588, 55);
            tBIDSignUp.TabIndex = 42;
            // 
            // fSignUp
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 1016);
            Controls.Add(tBTypeSignUp);
            Controls.Add(tBIDSignUp);
            Controls.Add(label11);
            Controls.Add(tBDiaChiSignUp);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(tBCCCDSignUp);
            Controls.Add(label8);
            Controls.Add(dateTimePickerSignUp);
            Controls.Add(label3);
            Controls.Add(tBDisplayNameSignUp);
            Controls.Add(comboBoxGioiTinhSignUp);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(tBtenDangNhapSignUp);
            Controls.Add(tBMatKhauSignUp);
            Controls.Add(tBEmailSignUp);
            Controls.Add(tBHoTenSignUp);
            Controls.Add(BtnSaveSignUp);
            Controls.Add(BtnCancelSignUp);
            Name = "fSignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form đăng ký";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxGioiTinhSignUp;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tBtenDangNhapSignUp;
        private TextBox tBMatKhauSignUp;
        private TextBox tBEmailSignUp;
        private TextBox tBTypeSignUp;
        private TextBox tBHoTenSignUp;
        private Button BtnSaveSignUp;
        private Button BtnCancelSignUp;
        private TextBox tBDisplayNameSignUp;
        private Label label3;
        private DateTimePicker dateTimePickerSignUp;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox tBCCCDSignUp;
        private TextBox tBDiaChiSignUp;
        private Label label11;
        private TextBox tBIDSignUp;
    }
}