namespace GiaoDien.Forms
{
    partial class fAddLS
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnConfirmAddLS = new Button();
            btnCancelAddLS = new Button();
            lblLoai = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label(); // Tình trạng
            label9 = new Label(); // Ghi chú
            dateTimePickerAddLS = new DateTimePicker();
            comboBoxGioiTinhLS = new ComboBox();
            tbLoaiLS = new TextBox();
            tbGiongLS = new TextBox();
            tbCanNangLS = new TextBox();
            tbIDVatNuoiLS = new TextBox();
            cbChuongLS = new ComboBox();
            cbTinhTrangSucKhoe = new ComboBox();
            tbGhiChu = new TextBox();
            dateTimePickerAddLS.Format = DateTimePickerFormat.Custom;
            dateTimePickerAddLS.CustomFormat = "dd/MM/yyyy";


            SuspendLayout();

            // 
            // btnConfirmAddLS
            // 
            btnConfirmAddLS.Anchor = AnchorStyles.None;
            btnConfirmAddLS.Font = new Font("Segoe UI", 12F);
            btnConfirmAddLS.Location = new Point(222, 620);
            btnConfirmAddLS.Name = "btnConfirmAddLS";
            btnConfirmAddLS.Size = new Size(302, 96);
            btnConfirmAddLS.TabIndex = 8;
            btnConfirmAddLS.Text = "Xác nhận";
            btnConfirmAddLS.UseVisualStyleBackColor = true;
            btnConfirmAddLS.Click += btnConfirmAddLS_Click;

            // 
            // btnCancelAddLS
            // 
            btnCancelAddLS.Anchor = AnchorStyles.None;
            btnCancelAddLS.Font = new Font("Segoe UI", 12F);
            btnCancelAddLS.Location = new Point(717, 620);
            btnCancelAddLS.Name = "btnCancelAddLS";
            btnCancelAddLS.Size = new Size(302, 96);
            btnCancelAddLS.TabIndex = 9;
            btnCancelAddLS.Text = "Hủy";
            btnCancelAddLS.UseVisualStyleBackColor = true;
            btnCancelAddLS.Click += btnCancelAddLS_Click;

            // Các label cũ
            lblLoai.AutoSize = label2.AutoSize = label3.AutoSize = label4.AutoSize =
            label5.AutoSize = label6.AutoSize = label7.AutoSize = true;
            lblLoai.Font = label2.Font = label3.Font = label4.Font = label5.Font = label6.Font = label7.Font = new Font("Segoe UI", 12F);

            lblLoai.Location = new Point(17, 34);
            lblLoai.Name = "lblLoai";
            lblLoai.Size = new Size(115, 65);
            lblLoai.Text = "Loại";  
            lblLoai.AutoSize = true;    

            label2.Location = new Point(17, 154);
            label2.Name = "label2";
            label2.Size = new Size(209, 65);
            label2.Text = "Giới tính";
            label2.AutoSize = true;

            label3.Location = new Point(17, 278);
            label3.Name = "label3";
            label3.Size = new Size(236, 65);
            label3.Text = "Tên giống";
            label3.AutoSize = true;

            label4.Location = new Point(17, 402);
            label4.Name = "label4";
            label4.Size = new Size(238, 65);
            label4.Text = "Ngày sinh";
            label4.AutoSize = true;

            label5.Location = new Point(663, 34);
            label5.Name = "label5";
            label5.Size = new Size(228, 65);
            label5.Text = "Cân nặng";
            label5.AutoSize = true;

            label6.Location = new Point(663, 154);
            label6.Name = "label6";
            label6.Size = new Size(258, 65);
            label6.Text = "ID vật nuôi";
            label6.AutoSize = true;
            //label6.Click += label6_Click;

            label7.Location = new Point(663, 278);
            label7.Name = "label7";
            label7.Size = new Size(272, 65);
            label7.Text = "Tên chuồng";
            label7.AutoSize = true;

            // Tình trạng sức khỏe
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(663, 402);
            label8.Name = "label8";
            label8.Size = new Size(305, 65);
            label8.Text = "Tình trạng";
            label8.AutoSize = true;

            cbTinhTrangSucKhoe.Anchor = AnchorStyles.None;
            cbTinhTrangSucKhoe.Font = new Font("Segoe UI", 12F);
            cbTinhTrangSucKhoe.Location = new Point(941, 402);
            cbTinhTrangSucKhoe.Name = "cbTinhTrangSucKhoe";
            cbTinhTrangSucKhoe.Size = new Size(300, 73);

            // Ghi chú
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(17, 520);
            label9.Name = "label9";
            label9.Size = new Size(157, 65);
            label9.Text = "Ghi chú";
            label9.AutoSize = true;

            tbGhiChu.Anchor = AnchorStyles.None;
            tbGhiChu.Font = new Font("Segoe UI", 12F);
            tbGhiChu.Location = new Point(261, 520);
            tbGhiChu.Name = "tbGhiChu";
            tbGhiChu.Size = new Size(980, 71);

            // Các control nhập liệu
            dateTimePickerAddLS.Location = new Point(261, 396);
            dateTimePickerAddLS.Font = new Font("Segoe UI", 12F);
            dateTimePickerAddLS.Size = new Size(375, 71);

            comboBoxGioiTinhLS.Font = new Font("Segoe UI", 12F);
            comboBoxGioiTinhLS.Items.AddRange(new object[] { "Đực", "Cái" });
            comboBoxGioiTinhLS.Location = new Point(261, 154);
            comboBoxGioiTinhLS.Size = new Size(300, 73);

            tbLoaiLS.Location = new Point(261, 34);
            tbLoaiLS.Font = new Font("Segoe UI", 12F);
            tbLoaiLS.Size = new Size(300, 71);
            tbLoaiLS.TextChanged += tbLoaiLS_TextChanged;

            tbGiongLS.Location = new Point(261, 278);
            tbGiongLS.Font = new Font("Segoe UI", 12F);
            tbGiongLS.Size = new Size(300, 71);

            tbCanNangLS.Location = new Point(941, 31);
            tbCanNangLS.Font = new Font("Segoe UI", 12F);
            tbCanNangLS.Size = new Size(300, 71);

            tbIDVatNuoiLS.Location = new Point(941, 156);
            tbIDVatNuoiLS.Font = new Font("Segoe UI", 12F);
            tbIDVatNuoiLS.Size = new Size(300, 71);

            cbChuongLS.Location = new Point(941, 278);
            cbChuongLS.Font = new Font("Segoe UI", 12F);
            cbChuongLS.Size = new Size(300, 71);

            // Form setup
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 750);
            Controls.Add(cbChuongLS);
            Controls.Add(tbIDVatNuoiLS);
            Controls.Add(tbCanNangLS);
            Controls.Add(tbGiongLS);
            Controls.Add(tbLoaiLS);
            Controls.Add(comboBoxGioiTinhLS);
            Controls.Add(dateTimePickerAddLS);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblLoai);
            Controls.Add(btnCancelAddLS);
            Controls.Add(btnConfirmAddLS);
            Controls.Add(label8);
            Controls.Add(cbTinhTrangSucKhoe);
            Controls.Add(label9);
            Controls.Add(tbGhiChu);
            Name = "fAddLS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form thêm vật nuôi";
            Load += fAddLS_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmAddLS;
        private Button btnCancelAddLS;
        private Label lblLoai;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private DateTimePicker dateTimePickerAddLS;
        private ComboBox comboBoxGioiTinhLS;
        private TextBox tbLoaiLS;
        private TextBox tbGiongLS;
        private TextBox tbCanNangLS;
        private TextBox tbIDVatNuoiLS;
        private ComboBox cbChuongLS;
        private ComboBox cbTinhTrangSucKhoe;
        private TextBox tbGhiChu;
    }
}
