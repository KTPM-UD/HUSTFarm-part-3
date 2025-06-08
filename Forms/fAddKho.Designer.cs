namespace GiaoDien.Forms
{
    partial class fAddKho
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox tbTenKho;
        private System.Windows.Forms.Button btnConfirmAddKho;
        private System.Windows.Forms.Button btnCancelAddKho;
        private System.Windows.Forms.Label lblTenKho;
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
            this.tbTenKho = new System.Windows.Forms.TextBox();
            this.btnConfirmAddKho = new System.Windows.Forms.Button();
            this.btnCancelAddKho = new System.Windows.Forms.Button();
            this.lblTenKho = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(294, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thêm kho thức ăn";
            // 
            // lblTenKho
            // 
            this.lblTenKho.AutoSize = true;
            this.lblTenKho.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTenKho.Location = new System.Drawing.Point(30, 90);
            this.lblTenKho.Name = "lblTenKho";
            this.lblTenKho.Size = new System.Drawing.Size(106, 32);
            this.lblTenKho.TabIndex = 1;
            this.lblTenKho.Text = "Tên kho:";
            // 
            // tbTenKho
            // 
            this.tbTenKho.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbTenKho.Location = new System.Drawing.Point(150, 90);
            this.tbTenKho.Name = "tbTenKho";
            this.tbTenKho.Size = new System.Drawing.Size(250, 39);
            this.tbTenKho.TabIndex = 2;
            // 
            // btnConfirmAddKho
            // 
            this.btnConfirmAddKho.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnConfirmAddKho.Location = new System.Drawing.Point(80, 160);
            this.btnConfirmAddKho.Name = "btnConfirmAddKho";
            this.btnConfirmAddKho.Size = new System.Drawing.Size(150, 50);
            this.btnConfirmAddKho.TabIndex = 3;
            this.btnConfirmAddKho.Text = "Xác nhận";
            this.btnConfirmAddKho.UseVisualStyleBackColor = true;
            this.btnConfirmAddKho.Click += new System.EventHandler(this.btnConfirmAddKho_Click);
            // 
            // btnCancelAddKho
            // 
            this.btnCancelAddKho.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancelAddKho.Location = new System.Drawing.Point(250, 160);
            this.btnCancelAddKho.Name = "btnCancelAddKho";
            this.btnCancelAddKho.Size = new System.Drawing.Size(150, 50);
            this.btnCancelAddKho.TabIndex = 4;
            this.btnCancelAddKho.Text = "Hủy";
            this.btnCancelAddKho.UseVisualStyleBackColor = true;
            this.btnCancelAddKho.Click += new System.EventHandler(this.btnCancelAddKho_Click);
            // 
            // fAddKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 240);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTenKho);
            this.Controls.Add(this.tbTenKho);
            this.Controls.Add(this.btnConfirmAddKho);
            this.Controls.Add(this.btnCancelAddKho);
            this.Name = "fAddKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm kho";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
