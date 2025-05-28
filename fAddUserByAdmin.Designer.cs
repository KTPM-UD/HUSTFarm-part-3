// fAddUserByAdmin.Designer.cs
namespace HTQLCN
{
    partial class fAddUserByAdmin
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxGioiTinhSignUp = new System.Windows.Forms.ComboBox();
            this.tBIDSignUp = new System.Windows.Forms.TextBox();
            this.tBHoTenSignUp = new System.Windows.Forms.TextBox();
            this.tBCCCDSignUp = new System.Windows.Forms.TextBox();
            this.tBDiaChiSignUp = new System.Windows.Forms.TextBox();
            this.tBTypeSignUp = new System.Windows.Forms.TextBox();
            this.tBtenDangNhapSignUp = new System.Windows.Forms.TextBox();
            this.tBDisplayNameSignUp = new System.Windows.Forms.TextBox();
            this.tBMatKhauSignUp = new System.Windows.Forms.TextBox();
            this.tBEmailSignUp = new System.Windows.Forms.TextBox();
            this.dateTimePickerSignUp = new System.Windows.Forms.DateTimePicker();
            this.BtnSaveSignUp = new System.Windows.Forms.Button();
            this.BtnCancelSignUp = new System.Windows.Forms.Button();

            int labelLeft = 20, inputLeft = 180, top = 20, spacing = 45;
            int labelWidth = 150, inputWidth = 420, inputHeight = 32;

            // Label and input definitions
            string[] labels = {
                "Tên đăng nhập", "Tên hiển thị", "Mật khẩu", "Email", "Họ tên", "Giới tính",
                "Ngày sinh", "CCCD", "Địa chỉ", "ID người dùng", "Loại tài khoản"
            };

            System.Windows.Forms.Control[] inputs = {
                this.tBtenDangNhapSignUp, this.tBDisplayNameSignUp, this.tBMatKhauSignUp,
                this.tBEmailSignUp, this.tBHoTenSignUp, this.comboBoxGioiTinhSignUp,
                this.dateTimePickerSignUp, this.tBCCCDSignUp, this.tBDiaChiSignUp,
                this.tBIDSignUp, this.tBTypeSignUp
            };

            for (int i = 0; i < labels.Length; i++)
            {
                var label = new System.Windows.Forms.Label();
                label.Text = labels[i];
                label.Location = new System.Drawing.Point(labelLeft, top + i * spacing);
                label.Size = new System.Drawing.Size(labelWidth, inputHeight);
                label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                this.Controls.Add(label);

                var input = inputs[i];
                input.Location = new System.Drawing.Point(inputLeft, top + i * spacing);
                input.Size = new System.Drawing.Size(inputWidth, inputHeight);
                this.Controls.Add(input);
            }

            this.comboBoxGioiTinhSignUp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGioiTinhSignUp.Items.AddRange(new object[] { "Nam", "Nữ" });
            this.tBIDSignUp.ReadOnly = true;
            this.tBTypeSignUp.ReadOnly = true;

            // Buttons
            this.BtnSaveSignUp.Text = "Xác nhận";
            this.BtnSaveSignUp.Location = new System.Drawing.Point(150, top + labels.Length * spacing + 10);
            this.BtnSaveSignUp.Size = new System.Drawing.Size(150, 40);
            this.BtnSaveSignUp.Click += new System.EventHandler(this.BtnSaveSignUp_Click);

            this.BtnCancelSignUp.Text = "Hủy";
            this.BtnCancelSignUp.Location = new System.Drawing.Point(350, top + labels.Length * spacing + 10);
            this.BtnCancelSignUp.Size = new System.Drawing.Size(150, 40);
            this.BtnCancelSignUp.Click += new System.EventHandler(this.BtnCancelSignUp_Click);

            this.Controls.Add(this.BtnSaveSignUp);
            this.Controls.Add(this.BtnCancelSignUp);

            // Form config
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, top + labels.Length * spacing + 70);
            this.Name = "fAddUserByAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm người dùng (Admin)";
            this.Load += new System.EventHandler(this.fAddUserByAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBoxGioiTinhSignUp;
        private System.Windows.Forms.TextBox tBIDSignUp;
        private System.Windows.Forms.TextBox tBHoTenSignUp;
        private System.Windows.Forms.TextBox tBCCCDSignUp;
        private System.Windows.Forms.TextBox tBDiaChiSignUp;
        private System.Windows.Forms.TextBox tBTypeSignUp;
        private System.Windows.Forms.TextBox tBtenDangNhapSignUp;
        private System.Windows.Forms.TextBox tBDisplayNameSignUp;
        private System.Windows.Forms.TextBox tBMatKhauSignUp;
        private System.Windows.Forms.TextBox tBEmailSignUp;
        private System.Windows.Forms.DateTimePicker dateTimePickerSignUp;
        private System.Windows.Forms.Button BtnSaveSignUp;
        private System.Windows.Forms.Button BtnCancelSignUp;
    }
}
