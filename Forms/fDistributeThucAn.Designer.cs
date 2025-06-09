namespace GiaoDien.Forms
{
    partial class fDistributeThucAn
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
            lblTenThucAn = new Label();
            lblSoLuong = new Label();
            comboBoxChuong = new ComboBox();
            numericSoLuong = new NumericUpDown();
            btnXacNhan = new Button();
            lblDonVi = new Label();
            ((System.ComponentModel.ISupportInitialize)numericSoLuong).BeginInit();
            SuspendLayout();
            // 
            // lblTenThucAn
            // 
            lblTenThucAn.AutoSize = true;
            lblTenThucAn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenThucAn.Location = new Point(200, 26);
            lblTenThucAn.Margin = new Padding(6, 0, 6, 0);
            lblTenThucAn.Name = "lblTenThucAn";
            lblTenThucAn.Size = new Size(153, 65);
            lblTenThucAn.TabIndex = 0;
            lblTenThucAn.Text = "Tên: ...";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoLuong.Location = new Point(200, 101);
            lblSoLuong.Margin = new Padding(6, 0, 6, 0);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(269, 65);
            lblSoLuong.TabIndex = 1;
            lblSoLuong.Text = "Hiện còn: ...";
            // 
            // comboBoxChuong
            // 
            comboBoxChuong.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxChuong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxChuong.FormattingEnabled = true;
            comboBoxChuong.Location = new Point(200, 181);
            comboBoxChuong.Margin = new Padding(6);
            comboBoxChuong.Name = "comboBoxChuong";
            comboBoxChuong.Size = new Size(296, 73);
            comboBoxChuong.TabIndex = 2;
            // 
            // numericSoLuong
            // 
            numericSoLuong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericSoLuong.Location = new Point(200, 292);
            numericSoLuong.Margin = new Padding(12);
            numericSoLuong.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericSoLuong.Name = "numericSoLuong";
            numericSoLuong.Size = new Size(296, 71);
            numericSoLuong.TabIndex = 3;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXacNhan.Location = new Point(200, 420);
            btnXacNhan.Margin = new Padding(6);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(296, 92);
            btnXacNhan.TabIndex = 5;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // lblDonVi
            // 
            lblDonVi.AutoSize = true;
            lblDonVi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDonVi.Location = new Point(551, 294);
            lblDonVi.Margin = new Padding(6, 0, 6, 0);
            lblDonVi.Name = "lblDonVi";
            lblDonVi.Size = new Size(166, 65);
            lblDonVi.TabIndex = 4;
            lblDonVi.Text = "Đơn vị";
            // 
            // fDistributeThucAn
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 576);
            Controls.Add(btnXacNhan);
            Controls.Add(lblDonVi);
            Controls.Add(numericSoLuong);
            Controls.Add(comboBoxChuong);
            Controls.Add(lblSoLuong);
            Controls.Add(lblTenThucAn);
            Margin = new Padding(6);
            Name = "fDistributeThucAn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phân phối thức ăn";
            ((System.ComponentModel.ISupportInitialize)numericSoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTenThucAn;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.ComboBox comboBoxChuong;
        private System.Windows.Forms.NumericUpDown numericSoLuong;
        private System.Windows.Forms.Label lblDonVi;
        private System.Windows.Forms.Button btnXacNhan;
    }
}
