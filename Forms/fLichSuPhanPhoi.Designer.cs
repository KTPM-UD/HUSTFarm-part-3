namespace GiaoDien.Forms
{
    partial class fLichSuPhanPhoi
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
            dtgvLichSu = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvLichSu).BeginInit();
            SuspendLayout();
            // 
            // dtgvLichSu
            // 
            dtgvLichSu.BackgroundColor = SystemColors.Control;
            dtgvLichSu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvLichSu.Location = new Point(58, 53);
            dtgvLichSu.Name = "dtgvLichSu";
            dtgvLichSu.RowHeadersWidth = 123;
            dtgvLichSu.Size = new Size(1337, 641);
            dtgvLichSu.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(406, 718);
            button1.Name = "button1";
            button1.Size = new Size(290, 81);
            button1.TabIndex = 1;
            button1.Text = "Làm mới";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(753, 718);
            button2.Name = "button2";
            button2.Size = new Size(285, 81);
            button2.TabIndex = 2;
            button2.Text = "Đóng";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // fLichSuPhanPhoi
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1460, 831);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dtgvLichSu);
            Name = "fLichSuPhanPhoi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lịch sử phân phối";
            ((System.ComponentModel.ISupportInitialize)dtgvLichSu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvLichSu;
        private Button button1;
        private Button button2;
    }
}