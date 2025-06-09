using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using GiaoDien.DAO;

namespace GiaoDien.Forms
{
    public partial class FormQLKho : Form
    {
        private fManager fManager;

        // ========================== Constructors ==========================

        public FormQLKho() => InitializeComponent();

        public FormQLKho(fManager fManager)
        {
            InitializeComponent();
            this.fManager = fManager;
        }

        // ========================== Form Load ==========================

        private void FormQLKho_Load(object sender, EventArgs e)
        {
            LoadKho();     // Tải dữ liệu kho vào DataGridView
            LoadChuong();  // Tải dữ liệu chuồng vào DataGridView
            LoadTheme();   // Áp dụng giao diện theme cho form
        }

        // ========================== Load Data ==========================

        private void LoadKho()
        {
            string query = @"
                SELECT 
                    maKho AS [Mã Kho], 
                    tenKho AS [Tên Kho] 
                FROM Kho 
                ORDER BY maKho ASC";

            dtgvKho.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dtgvKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgvKho.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void LoadChuong()
        {
            string query = @"
                SELECT 
                    tenChuong AS [Tên Chuồng], 
                    chuThich AS [Chú thích] 
                FROM Chuong 
                ORDER BY tenChuong ASC";

            dtgvChuong.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dtgvChuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgvChuong.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        // ========================== Giao Diện ==========================

        private void LoadTheme()
        {
            ApplyThemeToControls(this.Controls);
        }

        private void ApplyThemeToControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is Button btn)
                {
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                    btn.FlatStyle = FlatStyle.Flat;
                }

                if (control.HasChildren)
                    ApplyThemeToControls(control.Controls);
            }
        }

        // ========================== Chức năng Chuồng ==========================

        private void btnAddChuong_Click(object sender, EventArgs e)
        {
            fAddChuong form = new fAddChuong(fManager);
            form.ShowDialog();
            LoadChuong();
        }

        private void btnEditChuong_Click(object sender, EventArgs e)
        {
            if (dtgvChuong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn chuồng để sửa.");
                return;
            }

            string tenChuong = dtgvChuong.SelectedRows[0].Cells["Tên Chuồng"].Value?.ToString();
            string chuThich = dtgvChuong.SelectedRows[0].Cells["Chú thích"].Value?.ToString();

            if (string.IsNullOrWhiteSpace(tenChuong)) return;

            fEditChuong editForm = new fEditChuong(tenChuong, chuThich);
            editForm.ShowDialog();
            LoadChuong();
        }

        private void btnDeleteChuong_Click(object sender, EventArgs e)
        {
            if (dtgvChuong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn chuồng cần xóa.");
                return;
            }

            string tenChuong = dtgvChuong.SelectedRows[0].Cells["Tên Chuồng"].Value?.ToString();
            if (string.IsNullOrWhiteSpace(tenChuong)) return;

            string checkQuery = "SELECT COUNT(*) FROM VatNuoi WHERE tenChuong = @tenChuong";
            int count = (int)DataProvider.Instance.ExecuteScalar(checkQuery, new object[] { tenChuong });

            if (count > 0)
            {
                MessageBox.Show("Không thể xóa chuồng vì đang có vật nuôi bên trong.");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn xóa chuồng \"{tenChuong}\"?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                string deleteQuery = "DELETE FROM Chuong WHERE tenChuong = @tenChuong";
                int rows = DataProvider.Instance.ExecuteNonQuery(deleteQuery, new object[] { tenChuong });

                if (rows > 0)
                    MessageBox.Show("Xóa chuồng thành công!");
                else
                    MessageBox.Show("Không tìm thấy chuồng để xóa!");

                LoadChuong();
            }
        }

        // ========================== Chức năng Kho ==========================

        private void btnAddKho_Click(object sender, EventArgs e)
        {
            fAddKho form = new fAddKho(fManager);
            form.ShowDialog();
            LoadKho();
        }

        private void btnEditKho_Click(object sender, EventArgs e)
        {
            if (dtgvKho.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn kho cần sửa.");
                return;
            }

            DataGridViewRow selectedRow = dtgvKho.SelectedRows[0];

            if (!int.TryParse(selectedRow.Cells["Mã Kho"].Value?.ToString(), out int maKho))
            {
                MessageBox.Show("Không thể lấy mã kho.");
                return;
            }

            string tenKho = selectedRow.Cells["Tên Kho"].Value?.ToString();
            if (string.IsNullOrWhiteSpace(tenKho))
            {
                MessageBox.Show("Không thể lấy tên kho.");
                return;
            }

            fEditKho form = new fEditKho(maKho, tenKho);
            form.FormClosed += (s, args) => LoadKho();
            form.ShowDialog();
        }

        private void btnDeleteKho_Click(object sender, EventArgs e)
        {
            if (dtgvKho.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn kho cần xóa.");
                return;
            }

            object maKhoObj = dtgvKho.SelectedRows[0].Cells["Mã Kho"].Value;
            object tenKhoObj = dtgvKho.SelectedRows[0].Cells["Tên Kho"].Value;

            if (maKhoObj == null || tenKhoObj == null) return;

            int maKho = Convert.ToInt32(maKhoObj);
            string tenKho = tenKhoObj.ToString();

            string checkQuery = "SELECT COUNT(*) FROM ThucAnNuocUong WHERE maKho = @maKho";
            int count = (int)DataProvider.Instance.ExecuteScalar(checkQuery, new object[] { maKho });

            if (count > 0)
            {
                MessageBox.Show("Không thể xóa kho vì vẫn còn đồ trong kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn xóa kho \"{tenKho}\" (Mã: {maKho}) không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                string deleteQuery = "DELETE FROM Kho WHERE maKho = @maKho";
                int rows = DataProvider.Instance.ExecuteNonQuery(deleteQuery, new object[] { maKho });

                if (rows > 0)
                {
                    MessageBox.Show("Xóa kho thành công!");

                    // Nếu mã vừa xóa là mã lớn nhất => điều chỉnh IDENTITY
                    string maxIdQuery = "SELECT ISNULL(MAX(maKho), 0) FROM Kho";
                    int maxId = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(maxIdQuery,null));

                    string reseedQuery = $"DBCC CHECKIDENT('Kho', RESEED, {maxId})";
                    DataProvider.Instance.ExecuteNonQuery(reseedQuery);
                }
                else
                    MessageBox.Show("Không tìm thấy kho để xóa!");

                LoadKho();
            }
        }
    }
}
