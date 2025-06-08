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
            this.dtgvKho = new System.Windows.Forms.DataGridView();
            this.dtgvChuong = new System.Windows.Forms.DataGridView();
            this.lblTitleKho = new System.Windows.Forms.Label();
            this.lblTitleChuong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChuong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleKho
            // 
            this.lblTitleKho.AutoSize = true;
            this.lblTitleKho.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleKho.Location = new System.Drawing.Point(30, 0);
            this.lblTitleKho.Name = "lblTitleKho";
            this.lblTitleKho.Size = new System.Drawing.Size(237, 38);
            this.lblTitleKho.TabIndex = 2;
            this.lblTitleKho.Text = "Danh sách kho";
            // 
            // dtgvKho
            // 
            this.dtgvKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKho.Location = new System.Drawing.Point(30, 70);
            this.dtgvKho.Name = "dtgvKho";
            this.dtgvKho.RowHeadersWidth = 62;
            this.dtgvKho.RowTemplate.Height = 33;
            this.dtgvKho.Size = new System.Drawing.Size(1000, 350);
            this.dtgvKho.TabIndex = 0;
            this.dtgvKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // lblTitleChuong
            // 
            this.lblTitleChuong.AutoSize = true;
            this.lblTitleChuong.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleChuong.Location = new System.Drawing.Point(30, 420);
            this.lblTitleChuong.Name = "lblTitleChuong";
            this.lblTitleChuong.Size = new System.Drawing.Size(284, 38);
            this.lblTitleChuong.TabIndex = 3;
            this.lblTitleChuong.Text = "Danh sách chuồng";
            // 
            // dtgvChuong
            // 
            this.dtgvChuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChuong.Location = new System.Drawing.Point(30, 490);
            this.dtgvChuong.Name = "dtgvChuong";
            this.dtgvChuong.RowHeadersWidth = 62;
            this.dtgvChuong.RowTemplate.Height = 33;
            this.dtgvChuong.Size = new System.Drawing.Size(1000, 500);
            this.dtgvChuong.TabIndex = 1;
            this.dtgvChuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // btnAddChuong
            // 
            this.btnAddChuong = new System.Windows.Forms.Button();
            this.btnAddChuong.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddChuong.Location = new System.Drawing.Point(1050, 490);
            this.btnAddChuong.Name = "btnAddChuong";
            this.btnAddChuong.Size = new System.Drawing.Size(500, 90);
            this.btnAddChuong.Text = "Thêm chuồng";
            this.btnAddChuong.UseVisualStyleBackColor = true;
            btnAddChuong.Click += btnAddChuong_Click;
            // 
            // btnDeleteChuong
            // 
            this.btnDeleteChuong = new System.Windows.Forms.Button();
            this.btnDeleteChuong.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDeleteChuong.Location = new System.Drawing.Point(1050, 600);
            this.btnDeleteChuong.Name = "btnDeleteChuong";
            this.btnDeleteChuong.Size = new System.Drawing.Size(500, 90);
            this.btnDeleteChuong.Text = "Xóa chuồng";
            this.btnDeleteChuong.UseVisualStyleBackColor = true;
            this.btnDeleteChuong.Click += new System.EventHandler(this.btnDeleteChuong_Click);
            // 
            // btnEditChuong
            // 
            this.btnEditChuong = new System.Windows.Forms.Button();
            this.btnEditChuong.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEditChuong.Location = new System.Drawing.Point(1050, 710);
            this.btnEditChuong.Name = "btnEditChuong";
            this.btnEditChuong.Size = new System.Drawing.Size(500, 90);
            this.btnEditChuong.Text = "Sửa chuồng";
            this.btnEditChuong.UseVisualStyleBackColor = true;
            this.btnEditChuong.Click += new System.EventHandler(this.btnEditChuong_Click);
            // 
            // btnAddKho
            // 
            this.btnAddKho = new System.Windows.Forms.Button();
            this.btnAddKho.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddKho.Location = new System.Drawing.Point(1050, 70);
            this.btnAddKho.Size = new System.Drawing.Size(500, 90);
            this.btnAddKho.Name = "btnAddKho";
            this.btnAddKho.TabIndex = 0;
            this.btnAddKho.Text = "Thêm kho";
            this.btnAddKho.UseVisualStyleBackColor = true;
            this.btnAddKho.Click += new System.EventHandler(this.btnAddKho_Click);
            //
            // btn Xóa kho
            //
            this.btnDeleteKho = new System.Windows.Forms.Button();
            this.btnDeleteKho.Text = "Xóa kho";
            this.btnDeleteKho.Location = new System.Drawing.Point(1050, 180);
            this.btnDeleteKho.Size = new System.Drawing.Size(500, 90);
            this.btnDeleteKho.Click += new System.EventHandler(this.btnDeleteKho_Click);
            this.btnDeleteKho.UseVisualStyleBackColor = true;
            this.btnDeleteKho.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDeleteKho.Name = "btnDeleteKho";
            this.btnDeleteKho.TabIndex = 1;
            // 
            // btnEditKho
            // 
            this.btnEditKho = new System.Windows.Forms.Button();
            this.btnEditKho.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEditKho.Location = new System.Drawing.Point(1050, 290);
            this.btnEditKho.Name = "btnEditKho";
            this.btnEditKho.Size = new System.Drawing.Size(500, 90);
            this.btnEditKho.TabIndex = 3;
            this.btnEditKho.Text = "Sửa kho";
            this.btnEditKho.UseVisualStyleBackColor = true;
            this.btnEditKho.Click += new System.EventHandler(this.btnEditKho_Click);
            //
            // FormQLKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 720);
            this.Controls.Add(this.lblTitleKho);
            this.Controls.Add(this.dtgvKho);
            this.Controls.Add(this.lblTitleChuong);
            this.Controls.Add(this.dtgvChuong);
            this.Controls.Add(this.btnAddChuong);
            this.Controls.Add(this.btnDeleteChuong);
            this.Controls.Add(this.btnEditChuong);
            this.Controls.Add(this.btnAddKho);
            this.Controls.Add(this.btnDeleteKho);
            this.Controls.Add(this.btnEditKho);
            this.Name = "FormQLKho";
            this.Text = "Quản lý kho và chuồng";
            this.Load += new System.EventHandler(this.FormQLKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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
