﻿namespace GiaoDien.Forms
{
    partial class FormQLKho
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
            dtgvKho = new DataGridView();
            dtgvChuong = new DataGridView();
            lblTitleKho = new Label();
            lblTitleChuong = new Label();
            btnAddChuong = new Button();
            btnDeleteChuong = new Button();
            btnEditChuong = new Button();
            btnAddKho = new Button();
            btnDeleteKho = new Button();
            btnEditKho = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvKho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvChuong).BeginInit();
            SuspendLayout();
            // 
            // dtgvKho
            // 
            dtgvKho.Anchor = AnchorStyles.None;
            dtgvKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvKho.BackgroundColor = SystemColors.Control;
            dtgvKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvKho.Location = new Point(30, 77);
            dtgvKho.Name = "dtgvKho";
            dtgvKho.RowHeadersWidth = 62;
            dtgvKho.RowTemplate.Height = 33;
            dtgvKho.Size = new Size(1000, 350);
            dtgvKho.TabIndex = 0;
            // 
            // dtgvChuong
            // 
            dtgvChuong.Anchor = AnchorStyles.None;
            dtgvChuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvChuong.BackgroundColor = SystemColors.Control;
            dtgvChuong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvChuong.Location = new Point(30, 497);
            dtgvChuong.Name = "dtgvChuong";
            dtgvChuong.RowHeadersWidth = 62;
            dtgvChuong.RowTemplate.Height = 33;
            dtgvChuong.Size = new Size(1000, 500);
            dtgvChuong.TabIndex = 1;
            // 
            // lblTitleKho
            // 
            lblTitleKho.Anchor = AnchorStyles.None;
            lblTitleKho.AutoSize = true;
            lblTitleKho.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitleKho.Location = new Point(30, 0);
            lblTitleKho.Name = "lblTitleKho";
            lblTitleKho.Size = new Size(416, 74);
            lblTitleKho.TabIndex = 2;
            lblTitleKho.Text = "Danh sách kho";
            // 
            // lblTitleChuong
            // 
            lblTitleChuong.Anchor = AnchorStyles.None;
            lblTitleChuong.AutoSize = true;
            lblTitleChuong.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitleChuong.Location = new Point(30, 420);
            lblTitleChuong.Name = "lblTitleChuong";
            lblTitleChuong.Size = new Size(515, 74);
            lblTitleChuong.TabIndex = 3;
            lblTitleChuong.Text = "Danh sách chuồng";
            // 
            // btnAddChuong
            // 
            btnAddChuong.Anchor = AnchorStyles.None;
            btnAddChuong.Font = new Font("Segoe UI", 12F);
            btnAddChuong.Location = new Point(1050, 497);
            btnAddChuong.Name = "btnAddChuong";
            btnAddChuong.Size = new Size(500, 90);
            btnAddChuong.TabIndex = 4;
            btnAddChuong.Text = "Thêm chuồng";
            btnAddChuong.UseVisualStyleBackColor = true;
            btnAddChuong.Click += btnAddChuong_Click;
            // 
            // btnDeleteChuong
            // 
            btnDeleteChuong.Anchor = AnchorStyles.None;
            btnDeleteChuong.Font = new Font("Segoe UI", 12F);
            btnDeleteChuong.Location = new Point(1050, 603);
            btnDeleteChuong.Name = "btnDeleteChuong";
            btnDeleteChuong.Size = new Size(500, 90);
            btnDeleteChuong.TabIndex = 5;
            btnDeleteChuong.Text = "Xóa chuồng";
            btnDeleteChuong.UseVisualStyleBackColor = true;
            btnDeleteChuong.Click += btnDeleteChuong_Click;
            // 
            // btnEditChuong
            // 
            btnEditChuong.Anchor = AnchorStyles.None;
            btnEditChuong.Font = new Font("Segoe UI", 12F);
            btnEditChuong.Location = new Point(1050, 710);
            btnEditChuong.Name = "btnEditChuong";
            btnEditChuong.Size = new Size(500, 90);
            btnEditChuong.TabIndex = 6;
            btnEditChuong.Text = "Sửa chuồng";
            btnEditChuong.UseVisualStyleBackColor = true;
            btnEditChuong.Click += btnEditChuong_Click;
            // 
            // btnAddKho
            // 
            btnAddKho.Anchor = AnchorStyles.None;
            btnAddKho.Font = new Font("Segoe UI", 12F);
            btnAddKho.Location = new Point(1050, 77);
            btnAddKho.Name = "btnAddKho";
            btnAddKho.Size = new Size(500, 90);
            btnAddKho.TabIndex = 0;
            btnAddKho.Text = "Thêm kho";
            btnAddKho.UseVisualStyleBackColor = true;
            btnAddKho.Click += btnAddKho_Click;
            // 
            // btnDeleteKho
            // 
            btnDeleteKho.Anchor = AnchorStyles.None;
            btnDeleteKho.Font = new Font("Segoe UI", 12F);
            btnDeleteKho.Location = new Point(1050, 189);
            btnDeleteKho.Name = "btnDeleteKho";
            btnDeleteKho.Size = new Size(500, 90);
            btnDeleteKho.TabIndex = 1;
            btnDeleteKho.Text = "Xóa kho";
            btnDeleteKho.UseVisualStyleBackColor = true;
            btnDeleteKho.Click += btnDeleteKho_Click;
            // 
            // btnEditKho
            // 
            btnEditKho.Anchor = AnchorStyles.None;
            btnEditKho.Font = new Font("Segoe UI", 12F);
            btnEditKho.Location = new Point(1050, 302);
            btnEditKho.Name = "btnEditKho";
            btnEditKho.Size = new Size(500, 90);
            btnEditKho.TabIndex = 3;
            btnEditKho.Text = "Sửa kho";
            btnEditKho.UseVisualStyleBackColor = true;
            btnEditKho.Click += btnEditKho_Click;
            // 
            // FormQLKho
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1959, 1189);
            Controls.Add(lblTitleKho);
            Controls.Add(dtgvKho);
            Controls.Add(lblTitleChuong);
            Controls.Add(dtgvChuong);
            Controls.Add(btnAddChuong);
            Controls.Add(btnDeleteChuong);
            Controls.Add(btnEditChuong);
            Controls.Add(btnAddKho);
            Controls.Add(btnDeleteKho);
            Controls.Add(btnEditKho);
            Name = "FormQLKho";
            Text = "Quản lý kho và chuồng";
            Load += FormQLKho_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvKho).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvChuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvKho;
        private System.Windows.Forms.DataGridView dtgvChuong;
        private System.Windows.Forms.Label lblTitleKho;
        private System.Windows.Forms.Label lblTitleChuong;
        private System.Windows.Forms.Button btnAddChuong;
        private System.Windows.Forms.Button btnDeleteChuong;
        private System.Windows.Forms.Button btnEditChuong;
        private System.Windows.Forms.Button btnAddKho;
        private System.Windows.Forms.Button btnDeleteKho;
        private System.Windows.Forms.Button btnEditKho;




    }
}
