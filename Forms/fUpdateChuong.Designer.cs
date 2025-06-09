namespace GiaoDien.Forms
{
    partial class fEditChuong
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTenChuong = new System.Windows.Forms.Label();
            this.lblChuThich = new System.Windows.Forms.Label();
            this.tbTenChuong = new System.Windows.Forms.TextBox();
            this.tbChuThich = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 50);
            this.lblTitle.Text = "Cập nhật thông tin chuồng";
            // 
            // lblTenChuong
            // 
            this.lblTenChuong.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTenChuong.Location = new System.Drawing.Point(30, 100);
            this.lblTenChuong.Name = "lblTenChuong";
            this.lblTenChuong.Size = new System.Drawing.Size(150, 40);
            this.lblTenChuong.Text = "Tên chuồng:";
            // 
            // tbTenChuong
            // 
            this.tbTenChuong.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbTenChuong.Location = new System.Drawing.Point(200, 100);
            this.tbTenChuong.Name = "txtTenChuong";
            this.tbTenChuong.Size = new System.Drawing.Size(300, 39);
            // 
            // lblChuThich
            // 
            this.lblChuThich.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblChuThich.Location = new System.Drawing.Point(30, 160);
            this.lblChuThich.Name = "lblChuThich";
            this.lblChuThich.Size = new System.Drawing.Size(150, 40);
            this.lblChuThich.Text = "Chú thích:";
            // 
            // tbChuThich
            // 
            this.tbChuThich.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbChuThich.Location = new System.Drawing.Point(200, 160);
            this.tbChuThich.Name = "txtChuThich";
            this.tbChuThich.Size = new System.Drawing.Size(300, 39);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLuu.Location = new System.Drawing.Point(200, 230);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(150, 50);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // fEditChuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 320);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTenChuong);
            this.Controls.Add(this.tbTenChuong);
            this.Controls.Add(this.lblChuThich);
            this.Controls.Add(this.tbChuThich);
            this.Controls.Add(this.btnLuu);
            this.Name = "fEditChuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sửa chuồng";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTenChuong;
        private System.Windows.Forms.TextBox tbTenChuong;
        private System.Windows.Forms.Label lblChuThich;
        private System.Windows.Forms.TextBox tbChuThich;
        private System.Windows.Forms.Button btnLuu;
    }
}
