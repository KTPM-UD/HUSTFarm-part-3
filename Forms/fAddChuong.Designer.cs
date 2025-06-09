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
            tbTenChuong = new TextBox();
            tbChuThich = new TextBox();
            btnConfirmAddChuong = new Button();
            btnCancelAddChuong = new Button();
            lblTenChuong = new Label();
            lblChuThich = new Label();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // tbTenChuong
            // 
            tbTenChuong.Font = new Font("Segoe UI", 12F);
            tbTenChuong.Location = new Point(400, 173);
            tbTenChuong.Margin = new Padding(6, 6, 6, 6);
            tbTenChuong.Name = "tbTenChuong";
            tbTenChuong.Size = new Size(496, 71);
            tbTenChuong.TabIndex = 2;
            // 
            // tbChuThich
            // 
            tbChuThich.Font = new Font("Segoe UI", 12F);
            tbChuThich.Location = new Point(400, 288);
            tbChuThich.Margin = new Padding(6, 6, 6, 6);
            tbChuThich.Multiline = true;
            tbChuThich.Name = "tbChuThich";
            tbChuThich.Size = new Size(496, 71);
            tbChuThich.TabIndex = 4;
            // 
            // btnConfirmAddChuong
            // 
            btnConfirmAddChuong.Font = new Font("Segoe UI", 12F);
            btnConfirmAddChuong.Location = new Point(200, 422);
            btnConfirmAddChuong.Margin = new Padding(6, 6, 6, 6);
            btnConfirmAddChuong.Name = "btnConfirmAddChuong";
            btnConfirmAddChuong.Size = new Size(300, 96);
            btnConfirmAddChuong.TabIndex = 5;
            btnConfirmAddChuong.Text = "Xác nhận";
            btnConfirmAddChuong.UseVisualStyleBackColor = true;
            btnConfirmAddChuong.Click += btnConfirmAddChuong_Click;
            // 
            // btnCancelAddChuong
            // 
            btnCancelAddChuong.Font = new Font("Segoe UI", 12F);
            btnCancelAddChuong.Location = new Point(540, 422);
            btnCancelAddChuong.Margin = new Padding(6, 6, 6, 6);
            btnCancelAddChuong.Name = "btnCancelAddChuong";
            btnCancelAddChuong.Size = new Size(300, 96);
            btnCancelAddChuong.TabIndex = 6;
            btnCancelAddChuong.Text = "Hủy";
            btnCancelAddChuong.UseVisualStyleBackColor = true;
            btnCancelAddChuong.Click += btnCancelAddChuong_Click;
            // 
            // lblTenChuong
            // 
            lblTenChuong.AutoSize = true;
            lblTenChuong.Font = new Font("Segoe UI", 12F);
            lblTenChuong.Location = new Point(60, 173);
            lblTenChuong.Margin = new Padding(6, 0, 6, 0);
            lblTenChuong.Name = "lblTenChuong";
            lblTenChuong.Size = new Size(282, 65);
            lblTenChuong.TabIndex = 1;
            lblTenChuong.Text = "Tên chuồng:";
            // 
            // lblChuThich
            // 
            lblChuThich.AutoSize = true;
            lblChuThich.Font = new Font("Segoe UI", 12F);
            lblChuThich.Location = new Point(60, 288);
            lblChuThich.Margin = new Padding(6, 0, 6, 0);
            lblChuThich.Name = "lblChuThich";
            lblChuThich.Size = new Size(239, 65);
            lblChuThich.TabIndex = 3;
            lblChuThich.Text = "Chú thích:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(102, 38);
            lblTitle.Margin = new Padding(6, 0, 6, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(753, 86);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thêm thông tin chuồng";
            // 
            // fAddChuong
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 576);
            Controls.Add(lblTitle);
            Controls.Add(lblTenChuong);
            Controls.Add(tbTenChuong);
            Controls.Add(lblChuThich);
            Controls.Add(tbChuThich);
            Controls.Add(btnConfirmAddChuong);
            Controls.Add(btnCancelAddChuong);
            Margin = new Padding(6, 6, 6, 6);
            Name = "fAddChuong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm chuồng";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
