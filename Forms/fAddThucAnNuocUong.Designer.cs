namespace GiaoDien.Forms
{
    partial class fAddThucAnNuocUong
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
            cbDonVi = new ComboBox();
            cbLoai = new ComboBox();
            cbMaKho = new ComboBox();
            dtpHanSuDung = new DateTimePicker();
            tbTen = new TextBox();
            tbSoLuong = new TextBox();
            button1 = new Button();
            button2 = new Button();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(30, 135);
            label2.Name = "label2";
            label2.Size = new Size(115, 65);
            label2.TabIndex = 1;
            label2.Text = "Loại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(30, 238);
            label3.Name = "label3";
            label3.Size = new Size(219, 65);
            label3.TabIndex = 2;
            label3.Text = "Số lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(30, 446);
            label4.Name = "label4";
            label4.Size = new Size(297, 65);
            label4.TabIndex = 3;
            label4.Text = "Hạn sử dụng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(30, 337);
            label5.Name = "label5";
            label5.Size = new Size(187, 65);
            label5.TabIndex = 4;
            label5.Text = "Mã kho";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(513, 238);
            label6.Name = "label6";
            label6.Size = new Size(166, 65);
            label6.TabIndex = 5;
            label6.Text = "Đơn vị";
            // 
            // cbDonVi
            // 
            cbDonVi.Font = new Font("Segoe UI", 12F);
            cbDonVi.FormattingEnabled = true;
            cbDonVi.Items.AddRange(new object[] { "kg", "lít" });
            cbDonVi.Location = new Point(685, 230);
            cbDonVi.Name = "cbDonVi";
            cbDonVi.Size = new Size(203, 73);
            cbDonVi.TabIndex = 6;
            // 
            // cbLoai
            // 
            cbLoai.Font = new Font("Segoe UI", 12F);
            cbLoai.FormattingEnabled = true;
            cbLoai.Items.AddRange(new object[] { "Thức ăn", "Nước uống", "Thuốc" });
            cbLoai.Location = new Point(278, 132);
            cbLoai.Name = "cbLoai";
            cbLoai.Size = new Size(610, 73);
            cbLoai.TabIndex = 7;
            cbLoai.SelectedIndexChanged += cbLoai_SelectedIndexChanged_1;
            // 
            // cbMaKho
            // 
            cbMaKho.Font = new Font("Segoe UI", 12F);
            cbMaKho.FormattingEnabled = true;
            cbMaKho.Items.AddRange(new object[] { "1", "2", "3" });
            cbMaKho.Location = new Point(278, 337);
            cbMaKho.Name = "cbMaKho";
            cbMaKho.Size = new Size(610, 73);
            cbMaKho.TabIndex = 8;
            // 
            // dtpHanSuDung
            // 
            dtpHanSuDung.Font = new Font("Segoe UI", 12F);
            dtpHanSuDung.Format = DateTimePickerFormat.Custom;
            dtpHanSuDung.CustomFormat = "dd/MM/yyyy";
            dtpHanSuDung.Location = new Point(343, 446);
            dtpHanSuDung.Name = "dtpHanSuDung";
            dtpHanSuDung.Size = new Size(545, 71);
            dtpHanSuDung.TabIndex = 9;
            // 
            // tbTen
            // 
            tbTen.Font = new Font("Segoe UI", 12F);
            tbTen.Location = new Point(278, 30);
            tbTen.Name = "tbTen";
            tbTen.Size = new Size(610, 71);
            tbTen.TabIndex = 10;
            // 
            // tbSoLuong
            // 
            tbSoLuong.Font = new Font("Segoe UI", 12F);
            tbSoLuong.Location = new Point(278, 232);
            tbSoLuong.Name = "tbSoLuong";
            tbSoLuong.Size = new Size(230, 71);
            tbSoLuong.TabIndex = 11;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(148, 599);
            button1.Name = "button1";
            button1.Size = new Size(276, 96);
            button1.TabIndex = 12;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(491, 599);
            button2.Name = "button2";
            button2.Size = new Size(276, 96);
            button2.TabIndex = 13;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // fAddThucAnNuocUong
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(927, 735);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbSoLuong);
            Controls.Add(tbTen);
            Controls.Add(dtpHanSuDung);
            Controls.Add(cbMaKho);
            Controls.Add(cbLoai);
            Controls.Add(cbDonVi);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fAddThucAnNuocUong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm thức ăn / nước uống";
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
        private ComboBox cbDonVi;
        private ComboBox cbLoai;
        private ComboBox cbMaKho;
        private DateTimePicker dtpHanSuDung;
        private TextBox tbTen;
        private TextBox tbSoLuong;
        private Button button1;
        private Button button2;
    }
}