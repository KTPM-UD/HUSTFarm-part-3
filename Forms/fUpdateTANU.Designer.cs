using System.Windows.Forms;

namespace GiaoDien.Forms
{
    partial class fUpdateTANU
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
            cbLoai = new ComboBox();
            dtpHanSuDung = new DateTimePicker();
            btnXacNhan = new Button();
            btnHuy = new Button();
            tbSoLuong = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cbDonVi = new ComboBox();
            tbTen = new TextBox();
            cbMaKho = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(30, 36);
            label1.Name = "label1";
            label1.Size = new Size(100, 65);
            label1.TabIndex = 0;
            label1.Text = "Tên";
            // 
            // cbLoai
            // 
            cbLoai.Font = new Font("Segoe UI", 12F);
            cbLoai.FormattingEnabled = true;
            cbLoai.Items.AddRange(new object[] { "Thức ăn", "Nước uống", "Thuốc" });
            cbLoai.Location = new Point(278, 132);
            cbLoai.Name = "cbLoai";
            cbLoai.Size = new Size(610, 73);
            cbLoai.TabIndex = 1;
            cbLoai.SelectedIndexChanged += cbLoai_SelectedIndexChanged;
            // 
            // dtpHanSuDung
            // 
            dtpHanSuDung.Font = new Font("Segoe UI", 12F);
            dtpHanSuDung.Format = DateTimePickerFormat.Custom;
            dtpHanSuDung.CustomFormat = "dd/MM/yyyy";
            dtpHanSuDung.Location = new Point(333, 439);
            dtpHanSuDung.Name = "dtpHanSuDung";
            dtpHanSuDung.Size = new Size(555, 71);
            dtpHanSuDung.TabIndex = 2;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Font = new Font("Segoe UI", 12F);
            btnXacNhan.Location = new Point(148, 599);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(276, 96);
            btnXacNhan.TabIndex = 3;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Segoe UI", 12F);
            btnHuy.Location = new Point(504, 599);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(276, 96);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // tbSoLuong
            // 
            tbSoLuong.Font = new Font("Segoe UI", 12F);
            tbSoLuong.Location = new Point(278, 235);
            tbSoLuong.Name = "tbSoLuong";
            tbSoLuong.Size = new Size(220, 71);
            tbSoLuong.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(30, 135);
            label2.Name = "label2";
            label2.Size = new Size(115, 65);
            label2.TabIndex = 6;
            label2.Text = "Loại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(30, 238);
            label3.Name = "label3";
            label3.Size = new Size(219, 65);
            label3.TabIndex = 7;
            label3.Text = "Số lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(30, 336);
            label4.Name = "label4";
            label4.Size = new Size(187, 65);
            label4.TabIndex = 8;
            label4.Text = "Mã kho";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(30, 439);
            label5.Name = "label5";
            label5.Size = new Size(297, 65);
            label5.TabIndex = 9;
            label5.Text = "Hạn sử dụng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(504, 241);
            label6.Name = "label6";
            label6.Size = new Size(166, 65);
            label6.TabIndex = 10;
            label6.Text = "Đơn vị";
            // 
            // cbDonVi
            // 
            cbDonVi.Font = new Font("Segoe UI", 12F);
            cbDonVi.FormattingEnabled = true;
            cbDonVi.Items.AddRange(new object[] { "kg", "lít" });
            cbDonVi.Location = new Point(674, 238);
            cbDonVi.Name = "cbDonVi";
            cbDonVi.Size = new Size(214, 73);
            cbDonVi.TabIndex = 11;
            // 
            // tbTen
            // 
            tbTen.Font = new Font("Segoe UI", 12F);
            tbTen.Location = new Point(278, 30);
            tbTen.Name = "tbTen";
            tbTen.Size = new Size(610, 71);
            tbTen.TabIndex = 12;
            // 
            // cbMaKho
            // 
            cbMaKho.Font = new Font("Segoe UI", 12F);
            cbMaKho.FormattingEnabled = true;
            cbMaKho.Items.AddRange(new object[] { "1", "2", "3" });
            cbMaKho.Location = new Point(278, 336);
            cbMaKho.Name = "cbMaKho";
            cbMaKho.Size = new Size(610, 73);
            cbMaKho.TabIndex = 13;
            // 
            // fUpdateTANU
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 722);
            Controls.Add(cbMaKho);
            Controls.Add(tbTen);
            Controls.Add(cbDonVi);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbSoLuong);
            Controls.Add(btnHuy);
            Controls.Add(btnXacNhan);
            Controls.Add(dtpHanSuDung);
            Controls.Add(cbLoai);
            Controls.Add(label1);
            Name = "fUpdateTANU";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cập nhật thức ăn / nước uống";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbLoai;
        private DateTimePicker dtpHanSuDung;
        private Button btnXacNhan;
        private Button btnHuy;
        private TextBox tbSoLuong;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cbDonVi;
        private TextBox tbTen;
        private ComboBox cbMaKho;
    }
}