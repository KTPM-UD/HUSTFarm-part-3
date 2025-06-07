namespace GiaoDien.Forms
{
    partial class fUpdateThucAn
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTen = new System.Windows.Forms.Label();
            this.lblLoai = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblHanSuDung = new System.Windows.Forms.Label();
            this.lblMaKho = new System.Windows.Forms.Label();
            this.lblDonVi = new System.Windows.Forms.Label();

            this.tbTen = new System.Windows.Forms.TextBox();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.dtpHanSuDung = new System.Windows.Forms.DateTimePicker();
            this.cbMaKho = new System.Windows.Forms.ComboBox();
            this.cbDonVi = new System.Windows.Forms.ComboBox();

            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();

            this.SuspendLayout();

            int labelX = 20;
            int inputX = 150;
            int rowHeight = 25;
            int spacingY = 15;
            int rowY = 30;
            int totalInputWidth = 210;

            // lblTen
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTen.Location = new System.Drawing.Point(labelX, rowY);
            this.lblTen.Text = "Tên";

            // tbTen
            this.tbTen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbTen.Location = new System.Drawing.Point(inputX, rowY);
            this.tbTen.Size = new System.Drawing.Size(totalInputWidth, rowHeight);

            rowY += rowHeight + spacingY;

            // lblLoai
            this.lblLoai.AutoSize = true;
            this.lblLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLoai.Location = new System.Drawing.Point(labelX, rowY);
            this.lblLoai.Text = "Loại";

            // cbLoai
            this.cbLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLoai.Location = new System.Drawing.Point(inputX, rowY);
            this.cbLoai.Size = new System.Drawing.Size(totalInputWidth, rowHeight);

            rowY += rowHeight + spacingY;

            // lblSoLuong
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSoLuong.Location = new System.Drawing.Point(labelX, rowY);
            this.lblSoLuong.Text = "Số lượng";

            // tbSoLuong
            this.tbSoLuong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbSoLuong.Location = new System.Drawing.Point(inputX, rowY);
            this.tbSoLuong.Size = new System.Drawing.Size(100, rowHeight);

            // lblDonVi
            this.lblDonVi.AutoSize = true;
            this.lblDonVi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDonVi.Location = new System.Drawing.Point(inputX + 100, rowY + 5);
            this.lblDonVi.Text = "Đơn vị";

            // cbDonVi
            this.cbDonVi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDonVi.Location = new System.Drawing.Point(inputX + 160, rowY);
            this.cbDonVi.Size = new System.Drawing.Size(50, rowHeight);
            this.cbDonVi.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbDonVi.Items.AddRange(new object[] { "kg", "g", "lít", "ml", "bao", "chai", "viên", "túi", "thùng" });

            rowY += rowHeight + spacingY;

            // lblHanSuDung
            this.lblHanSuDung.AutoSize = true;
            this.lblHanSuDung.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHanSuDung.Location = new System.Drawing.Point(labelX, rowY);
            this.lblHanSuDung.Text = "Hạn sử dụng";

            // dtpHanSuDung
            this.dtpHanSuDung.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpHanSuDung.Location = new System.Drawing.Point(inputX, rowY);
            this.dtpHanSuDung.Size = new System.Drawing.Size(totalInputWidth, rowHeight);

            rowY += rowHeight + spacingY;

            // lblMaKho
            this.lblMaKho.AutoSize = true;
            this.lblMaKho.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaKho.Location = new System.Drawing.Point(labelX, rowY);
            this.lblMaKho.Text = "Mã kho";

            // cbMaKho
            this.cbMaKho.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMaKho.Location = new System.Drawing.Point(inputX, rowY);
            this.cbMaKho.Size = new System.Drawing.Size(totalInputWidth, rowHeight);

            rowY += rowHeight + spacingY + 10;

            // btnXacNhan
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnXacNhan.Location = new System.Drawing.Point(100, rowY);
            this.btnXacNhan.Size = new System.Drawing.Size(120, 40);
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);

            // btnHuy
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnHuy.Location = new System.Drawing.Point(270, rowY);
            this.btnHuy.Size = new System.Drawing.Size(120, 40);
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            // fUpdateThucAn
            this.ClientSize = new System.Drawing.Size(420, rowY + 60);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblLoai);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblDonVi);
            this.Controls.Add(this.lblHanSuDung);
            this.Controls.Add(this.lblMaKho);

            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.cbLoai);
            this.Controls.Add(this.tbSoLuong);
            this.Controls.Add(this.cbDonVi);
            this.Controls.Add(this.dtpHanSuDung);
            this.Controls.Add(this.cbMaKho);

            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnHuy);

            this.Name = "fUpdateThucAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật Thức Ăn / Nước Uống";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblHanSuDung;
        private System.Windows.Forms.Label lblMaKho;
        private System.Windows.Forms.Label lblDonVi;

        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.DateTimePicker dtpHanSuDung;
        private System.Windows.Forms.ComboBox cbMaKho;
        private System.Windows.Forms.ComboBox cbDonVi;

        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy;
    }
}
