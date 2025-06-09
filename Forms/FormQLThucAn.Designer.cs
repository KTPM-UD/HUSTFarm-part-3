namespace GiaoDien.Forms
{
    partial class FormQLTANU
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dtgvThucAn = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSearch = new Button();
            btnDistribute = new Button();
            btnLichSu = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dtgvThucAn).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvThucAn
            // 
            dtgvThucAn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvThucAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvThucAn.BackgroundColor = SystemColors.Control;
            dtgvThucAn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvThucAn.Location = new Point(0, 137);
            dtgvThucAn.Name = "dtgvThucAn";
            dtgvThucAn.RowHeadersWidth = 123;
            dtgvThucAn.Size = new Size(1959, 1052);
            dtgvThucAn.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(509, 19);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(166, 86);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(732, 19);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(151, 86);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 12F);
            btnUpdate.Location = new Point(950, 19);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(173, 86);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.None;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 12F);
            btnSearch.Location = new Point(1210, 19);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(270, 86);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDistribute
            // 
            btnDistribute.Anchor = AnchorStyles.None;
            btnDistribute.FlatStyle = FlatStyle.Flat;
            btnDistribute.Font = new Font("Segoe UI", 12F);
            btnDistribute.Location = new Point(1556, 19);
            btnDistribute.Name = "btnDistribute";
            btnDistribute.Size = new Size(320, 86);
            btnDistribute.TabIndex = 6;
            btnDistribute.Text = "Phân phối";
            btnDistribute.UseVisualStyleBackColor = true;
            btnDistribute.Click += btnDistribute_Click;
            // 
            // btnLichSu
            // 
            btnLichSu.Anchor = AnchorStyles.None;
            btnLichSu.FlatStyle = FlatStyle.Flat;
            btnLichSu.Font = new Font("Segoe UI", 12F);
            btnLichSu.Location = new Point(22, 19);
            btnLichSu.Name = "btnLichSu";
            btnLichSu.Size = new Size(412, 86);
            btnLichSu.TabIndex = 7;
            btnLichSu.Text = "Lịch sử phân phối";
            btnLichSu.UseVisualStyleBackColor = true;
            btnLichSu.Click += btnLichSu_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLichSu);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDistribute);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1959, 131);
            panel1.TabIndex = 6;
            // 
            // FormQLTANU
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1959, 1189);
            Controls.Add(panel1);
            Controls.Add(dtgvThucAn);
            Name = "FormQLTANU";
            Text = "Quản lý thức ăn, nước uống và thuốc";
            WindowState = FormWindowState.Maximized;
            Load += FormQLTANU_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvThucAn).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvThucAn;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSearch;
        private Button btnDistribute;
        private Button btnLichSu;
        private Panel panel1;
    }
}