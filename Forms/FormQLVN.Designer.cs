namespace GiaoDien.Forms
{
    partial class FormQLVN
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
            btnAddLS = new Button();
            btnSearchLS = new Button();
            btnDeleteLS = new Button();
            btnUpdateLS = new Button();
            panel1 = new Panel();
            dtgvLiveStock = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvLiveStock).BeginInit();
            SuspendLayout();
            // 
            // btnAddLS
            // 
            btnAddLS.Anchor = AnchorStyles.None;
            btnAddLS.FlatStyle = FlatStyle.Flat;
            btnAddLS.Font = new Font("Segoe UI", 12F);
            btnAddLS.Location = new Point(350, 19);
            btnAddLS.Name = "btnAddLS";
            btnAddLS.Size = new Size(182, 86);
            btnAddLS.TabIndex = 6;
            btnAddLS.Text = "Thêm";
            btnAddLS.UseVisualStyleBackColor = true;
            btnAddLS.Click += btnAddLS_Click;
            btnAddLS.AutoSize = true;
            // 
            // btnSearchLS
            // 
            btnSearchLS.Anchor = AnchorStyles.None;
            btnSearchLS.FlatStyle = FlatStyle.Flat;
            btnSearchLS.Font = new Font("Segoe UI", 12F);
            btnSearchLS.Location = new Point(1314, 19);
            btnSearchLS.Name = "btnSearchLS";
            btnSearchLS.Size = new Size(270, 86);
            btnSearchLS.TabIndex = 10;
            btnSearchLS.Text = "Tìm kiếm";
            btnSearchLS.UseVisualStyleBackColor = true;
            btnSearchLS.Click += btnSearchLS_Click;
            btnSearchLS.AutoSize = true;
            // 
            // btnDeleteLS
            // 
            btnDeleteLS.Anchor = AnchorStyles.None;
            btnDeleteLS.FlatStyle = FlatStyle.Flat;
            btnDeleteLS.Font = new Font("Segoe UI", 12F);
            btnDeleteLS.Location = new Point(670, 19);
            btnDeleteLS.Name = "btnDeleteLS";
            btnDeleteLS.Size = new Size(200, 86);
            btnDeleteLS.TabIndex = 7;
            btnDeleteLS.Text = "Xóa";
            btnDeleteLS.UseVisualStyleBackColor = true;
            btnDeleteLS.Click += btnDeleteLS_Click;
            btnDeleteLS.AutoSize = true;
            // 
            // btnUpdateLS
            // 
            btnUpdateLS.Anchor = AnchorStyles.None;
            btnUpdateLS.FlatStyle = FlatStyle.Flat;
            btnUpdateLS.Font = new Font("Segoe UI", 12F);
            btnUpdateLS.Location = new Point(991, 19);
            btnUpdateLS.Name = "btnUpdateLS";
            btnUpdateLS.Size = new Size(200, 86);
            btnUpdateLS.TabIndex = 8;
            btnUpdateLS.Text = "Sửa";
            btnUpdateLS.UseVisualStyleBackColor = true;
            btnUpdateLS.Click += btnUpdateLS_Click;
            btnUpdateLS.AutoSize = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDeleteLS);
            panel1.Controls.Add(btnAddLS);
            panel1.Controls.Add(btnUpdateLS);
            panel1.Controls.Add(btnSearchLS);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1959, 131);
            panel1.TabIndex = 11;
            // 
            // dtgvLiveStock
            // 
            dtgvLiveStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvLiveStock.BackgroundColor = SystemColors.Control;
            dtgvLiveStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvLiveStock.Location = new Point(0, 136);
            dtgvLiveStock.MaximumSize = new Size(99999, 99999);
            dtgvLiveStock.MinimumSize = new Size(1954, 1008);
            dtgvLiveStock.Name = "dtgvLiveStock";
            dtgvLiveStock.RowHeadersWidth = 123;
            dtgvLiveStock.Size = new Size(1959, 1052);
            dtgvLiveStock.TabIndex = 12;
            // 
            // FormQLVN
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1959, 1189);
            Controls.Add(dtgvLiveStock);
            Controls.Add(panel1);
            Name = "FormQLVN";
            Text = "Quản lý vật nuôi";
            Load += FormQLVN_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvLiveStock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddLS;
        private Button btnSearchLS;
        private Button btnDeleteLS;
        private Button btnUpdateLS;
        private Panel panel1;
        private DataGridView dtgvLiveStock;
    }
}