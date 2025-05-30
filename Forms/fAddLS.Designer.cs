namespace GiaoDien.Forms
{
    partial class fAddLS
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
            btnConfirmAddLS = new Button();
            btnCancelAddLS = new Button();
            lblLoai = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dateTimePickerAddLS = new DateTimePicker();
            comboBoxGioiTinhLS = new ComboBox();
            tbLoaiLS = new TextBox();
            tbGiongLS = new TextBox();
            tbCanNangLS = new TextBox();
            tbIDVatNuoiLS = new TextBox();
            tbChuongLS = new TextBox();
            SuspendLayout();
            // 
            // btnConfirmAddLS
            // 
            btnConfirmAddLS.Anchor = AnchorStyles.None;
            btnConfirmAddLS.Font = new Font("Segoe UI", 12F);
            btnConfirmAddLS.Location = new Point(222, 530);
            btnConfirmAddLS.Name = "btnConfirmAddLS";
            btnConfirmAddLS.Size = new Size(302, 96);
            btnConfirmAddLS.TabIndex = 8;
            btnConfirmAddLS.Text = "Xác nhận";
            btnConfirmAddLS.UseVisualStyleBackColor = true;
            btnConfirmAddLS.Click += btnConfirmAddLS_Click;
            // 
            // btnCancelAddLS
            // 
            btnCancelAddLS.Anchor = AnchorStyles.None;
            btnCancelAddLS.Font = new Font("Segoe UI", 12F);
            btnCancelAddLS.Location = new Point(717, 530);
            btnCancelAddLS.Name = "btnCancelAddLS";
            btnCancelAddLS.Size = new Size(302, 96);
            btnCancelAddLS.TabIndex = 9;
            btnCancelAddLS.Text = "Hủy";
            btnCancelAddLS.UseVisualStyleBackColor = true;
            btnCancelAddLS.Click += btnCancelAddLS_Click;
            // 
            // lblLoai
            // 
            lblLoai.Anchor = AnchorStyles.None;
            lblLoai.AutoSize = true;
            lblLoai.Font = new Font("Segoe UI", 12F);
            lblLoai.Location = new Point(17, 34);
            lblLoai.Name = "lblLoai";
            lblLoai.Size = new Size(115, 65);
            lblLoai.TabIndex = 10;
            lblLoai.Text = "Loại";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(17, 154);
            label2.Name = "label2";
            label2.Size = new Size(209, 65);
            label2.TabIndex = 11;
            label2.Text = "Giới tính";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(17, 278);
            label3.Name = "label3";
            label3.Size = new Size(236, 65);
            label3.TabIndex = 12;
            label3.Text = "Tên giống";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(17, 402);
            label4.Name = "label4";
            label4.Size = new Size(238, 65);
            label4.TabIndex = 13;
            label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(663, 34);
            label5.Name = "label5";
            label5.Size = new Size(228, 65);
            label5.TabIndex = 14;
            label5.Text = "Cân nặng";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(663, 154);
            label6.Name = "label6";
            label6.Size = new Size(258, 65);
            label6.TabIndex = 15;
            label6.Text = "ID vật nuôi";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(663, 278);
            label7.Name = "label7";
            label7.Size = new Size(272, 65);
            label7.TabIndex = 16;
            label7.Text = "Tên chuồng";
            // 
            // dateTimePickerAddLS
            // 
            dateTimePickerAddLS.Anchor = AnchorStyles.None;
            dateTimePickerAddLS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerAddLS.Location = new Point(261, 396);
            dateTimePickerAddLS.Name = "dateTimePickerAddLS";
            dateTimePickerAddLS.Size = new Size(745, 71);
            dateTimePickerAddLS.TabIndex = 17;
            // 
            // comboBoxGioiTinhLS
            // 
            comboBoxGioiTinhLS.Anchor = AnchorStyles.None;
            comboBoxGioiTinhLS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxGioiTinhLS.FormattingEnabled = true;
            comboBoxGioiTinhLS.Items.AddRange(new object[] { "Đực", "Cái" });
            comboBoxGioiTinhLS.Location = new Point(261, 154);
            comboBoxGioiTinhLS.Name = "comboBoxGioiTinhLS";
            comboBoxGioiTinhLS.Size = new Size(300, 73);
            comboBoxGioiTinhLS.TabIndex = 18;
            // 
            // tbLoaiLS
            // 
            tbLoaiLS.Anchor = AnchorStyles.None;
            tbLoaiLS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbLoaiLS.Location = new Point(261, 34);
            tbLoaiLS.Name = "tbLoaiLS";
            tbLoaiLS.Size = new Size(300, 71);
            tbLoaiLS.TabIndex = 19;
            tbLoaiLS.TextChanged += tbLoaiLS_TextChanged;
            // 
            // tbGiongLS
            // 
            tbGiongLS.Anchor = AnchorStyles.None;
            tbGiongLS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbGiongLS.Location = new Point(261, 278);
            tbGiongLS.Name = "tbGiongLS";
            tbGiongLS.Size = new Size(300, 71);
            tbGiongLS.TabIndex = 20;
            // 
            // tbCanNangLS
            // 
            tbCanNangLS.Anchor = AnchorStyles.None;
            tbCanNangLS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCanNangLS.Location = new Point(941, 31);
            tbCanNangLS.Name = "tbCanNangLS";
            tbCanNangLS.Size = new Size(300, 71);
            tbCanNangLS.TabIndex = 21;
            // 
            // tbIDVatNuoiLS
            // 
            tbIDVatNuoiLS.Anchor = AnchorStyles.None;
            tbIDVatNuoiLS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbIDVatNuoiLS.Location = new Point(941, 156);
            tbIDVatNuoiLS.Name = "tbIDVatNuoiLS";
            tbIDVatNuoiLS.Size = new Size(300, 71);
            tbIDVatNuoiLS.TabIndex = 22;
            // 
            // tbChuongLS
            // 
            tbChuongLS.Anchor = AnchorStyles.None;
            tbChuongLS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbChuongLS.Location = new Point(941, 278);
            tbChuongLS.Name = "tbChuongLS";
            tbChuongLS.Size = new Size(300, 71);
            tbChuongLS.TabIndex = 23;
            // 
            // fAddLS
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 662);
            Controls.Add(tbChuongLS);
            Controls.Add(tbIDVatNuoiLS);
            Controls.Add(tbCanNangLS);
            Controls.Add(tbGiongLS);
            Controls.Add(tbLoaiLS);
            Controls.Add(comboBoxGioiTinhLS);
            Controls.Add(dateTimePickerAddLS);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblLoai);
            Controls.Add(btnCancelAddLS);
            Controls.Add(btnConfirmAddLS);
            Name = "fAddLS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form thêm vật nuôi";
            Load += fAddLS_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmAddLS;
        private Button btnCancelAddLS;
        private Label lblLoai;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTimePickerAddLS;
        private ComboBox comboBoxGioiTinhLS;
        private TextBox tbLoaiLS;
        private TextBox tbGiongLS;
        private TextBox tbCanNangLS;
        private TextBox tbIDVatNuoiLS;
        private TextBox tbChuongLS;
    }
}