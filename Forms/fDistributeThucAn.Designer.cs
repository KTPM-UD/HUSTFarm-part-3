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
            this.lblTenThucAn = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.comboBoxChuong = new System.Windows.Forms.ComboBox();
            this.numericSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.lblDonVi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenThucAn
            // 
            this.lblTenThucAn.AutoSize = true;
            this.lblTenThucAn.Location = new System.Drawing.Point(100, 30);
            this.lblTenThucAn.Name = "lblTenThucAn";
            this.lblTenThucAn.Size = new System.Drawing.Size(100, 25);
            this.lblTenThucAn.TabIndex = 0;
            this.lblTenThucAn.Text = "Tên: ...";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(100, 70);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(120, 25);
            this.lblSoLuong.TabIndex = 1;
            this.lblSoLuong.Text = "Hiện còn: ...";
            // 
            // comboBoxChuong
            // 
            this.comboBoxChuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChuong.FormattingEnabled = true;
            this.comboBoxChuong.Location = new System.Drawing.Point(100, 110);
            this.comboBoxChuong.Name = "comboBoxChuong";
            this.comboBoxChuong.Size = new System.Drawing.Size(150, 33);
            this.comboBoxChuong.TabIndex = 2;
            // 
            // numericSoLuong
            // 
            this.numericSoLuong.Location = new System.Drawing.Point(100, 160);
            this.numericSoLuong.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numericSoLuong.Name = "numericSoLuong";
            this.numericSoLuong.Size = new System.Drawing.Size(150, 31);
            this.numericSoLuong.TabIndex = 3;
            // 
            // lblDonVi
            // 
            this.lblDonVi.AutoSize = true;
            this.lblDonVi.Location = new System.Drawing.Point(270, 160);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(63, 25);
            this.lblDonVi.TabIndex = 4;
            this.lblDonVi.Text = "Đơn vị";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(100, 210);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(150, 40);
            this.btnXacNhan.TabIndex = 5;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // fDistributeThucAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.lblDonVi);
            this.Controls.Add(this.numericSoLuong);
            this.Controls.Add(this.comboBoxChuong);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblTenThucAn);
            this.Name = "fDistributeThucAn";
            this.Text = "Phân phối thức ăn";
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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
