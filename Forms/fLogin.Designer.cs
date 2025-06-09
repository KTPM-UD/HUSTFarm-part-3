namespace GiaoDien.Forms
{
    partial class fLogin
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
            tBtenDangNhapLogin = new TextBox();
            tBMatKhauLogin = new TextBox();
            label2 = new Label();
            btnConfirmLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(502, 384);
            label1.Name = "label1";
            label1.Size = new Size(398, 74);
            label1.TabIndex = 10;
            label1.Text = "Tên đăng nhập";
            // 
            // tBtenDangNhapLogin
            // 
            tBtenDangNhapLogin.Anchor = AnchorStyles.None;
            tBtenDangNhapLogin.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tBtenDangNhapLogin.Location = new Point(929, 384);
            tBtenDangNhapLogin.Name = "tBtenDangNhapLogin";
            tBtenDangNhapLogin.Size = new Size(422, 82);
            tBtenDangNhapLogin.TabIndex = 0;
            // 
            // tBMatKhauLogin
            // 
            tBMatKhauLogin.Anchor = AnchorStyles.None;
            tBMatKhauLogin.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tBMatKhauLogin.Location = new Point(929, 503);
            tBMatKhauLogin.Name = "tBMatKhauLogin";
            tBMatKhauLogin.Size = new Size(422, 82);
            tBMatKhauLogin.TabIndex = 1;
            tBMatKhauLogin.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(502, 503);
            label2.Name = "label2";
            label2.Size = new Size(264, 74);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu";
            label2.Click += label2_Click;
            // 
            // btnConfirmLogin
            // 
            btnConfirmLogin.Anchor = AnchorStyles.None;
            btnConfirmLogin.FlatStyle = FlatStyle.Flat;
            btnConfirmLogin.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmLogin.Location = new Point(742, 653);
            btnConfirmLogin.Name = "btnConfirmLogin";
            btnConfirmLogin.Size = new Size(385, 93);
            btnConfirmLogin.TabIndex = 2;
            btnConfirmLogin.Text = "Đăng nhập";
            btnConfirmLogin.UseVisualStyleBackColor = true;
            btnConfirmLogin.Click += button1_Click;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1837, 1128);
            Controls.Add(btnConfirmLogin);
            Controls.Add(tBMatKhauLogin);
            Controls.Add(label2);
            Controls.Add(tBtenDangNhapLogin);
            Controls.Add(label1);
            Name = "fLogin";
            Text = "Đăng nhập";
            Load += fLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tBtenDangNhapLogin;
        private TextBox tBMatKhauLogin;
        private Label label2;
        private Button btnConfirmLogin;
    }
}