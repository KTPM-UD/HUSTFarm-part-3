namespace GiaoDien.Forms
{
    partial class fAddChuong
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox tbTenChuong;
        private System.Windows.Forms.TextBox tbChuThich;
        private System.Windows.Forms.Button btnConfirmAddChuong;
        private System.Windows.Forms.Button btnCancelAddChuong;
        private System.Windows.Forms.Label lblTenChuong;
        private System.Windows.Forms.Label lblChuThich;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tbTenChuong = new System.Windows.Forms.TextBox();
            this.tbChuThich = new System.Windows.Forms.TextBox();
            this.btnConfirmAddChuong = new System.Windows.Forms.Button();
            this.btnCancelAddChuong = new System.Windows.Forms.Button();
            this.lblTenChuong = new System.Windows.Forms.Label();
            this.lblChuThich = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(350, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thêm thông tin chuồng";
            // 
            // lblTenChuong
            // 
            this.lblTenChuong.AutoSize = true;
            this.lblTenChuong.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTenChuong.Location = new System.Drawing.Point(30, 90);
            this.lblTenChuong.Name = "lblTenChuong";
            this.lblTenChuong.Size = new System.Drawing.Size(138, 32);
            this.lblTenChuong.TabIndex = 1;
            this.lblTenChuong.Text = "Tên chuồng:";
            // 
            // tbTenChuong
            // 
            this.tbTenChuong.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbTenChuong.Location = new System.Drawing.Point(200, 90);
            this.tbTenChuong.Name = "tbTenChuong";
            this.tbTenChuong.Size = new System.Drawing.Size(250, 39);
            this.tbTenChuong.TabIndex = 2;
            // 
            // lblChuThich
            // 
            this.lblChuThich.AutoSize = true;
            this.lblChuThich.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblChuThich.Location = new System.Drawing.Point(30, 150);
            this.lblChuThich.Name = "lblChuThich";
            this.lblChuThich.Size = new System.Drawing.Size(138, 32);
            this.lblChuThich.TabIndex = 3;
            this.lblChuThich.Text = "Chú thích:";
            // 
            // tbChuThich
            // 
            this.tbChuThich.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbChuThich.Location = new System.Drawing.Point(200, 150);
            this.tbChuThich.Multiline = true;
            this.tbChuThich.Name = "tbChuThich";
            this.tbChuThich.Size = new System.Drawing.Size(250, 39);
            this.tbChuThich.TabIndex = 4;
            // 
            // btnConfirmAddChuong
            // 
            this.btnConfirmAddChuong.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnConfirmAddChuong.Location = new System.Drawing.Point(100, 220);
            this.btnConfirmAddChuong.Name = "btnConfirmAddChuong";
            this.btnConfirmAddChuong.Size = new System.Drawing.Size(150, 50);
            this.btnConfirmAddChuong.TabIndex = 5;
            this.btnConfirmAddChuong.Text = "Xác nhận";
            this.btnConfirmAddChuong.UseVisualStyleBackColor = true;
            this.btnConfirmAddChuong.Click += new System.EventHandler(this.btnConfirmAddChuong_Click);
            // 
            // btnCancelAddChuong
            // 
            this.btnCancelAddChuong.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancelAddChuong.Location = new System.Drawing.Point(270, 220);
            this.btnCancelAddChuong.Name = "btnCancelAddChuong";
            this.btnCancelAddChuong.Size = new System.Drawing.Size(150, 50);
            this.btnCancelAddChuong.TabIndex = 6;
            this.btnCancelAddChuong.Text = "Hủy";
            this.btnCancelAddChuong.UseVisualStyleBackColor = true;
            this.btnCancelAddChuong.Click += new System.EventHandler(this.btnCancelAddChuong_Click);
            // 
            // fAddChuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTenChuong);
            this.Controls.Add(this.tbTenChuong);
            this.Controls.Add(this.lblChuThich);
            this.Controls.Add(this.tbChuThich);
            this.Controls.Add(this.btnConfirmAddChuong);
            this.Controls.Add(this.btnCancelAddChuong);
            this.Name = "fAddChuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm chuồng";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
