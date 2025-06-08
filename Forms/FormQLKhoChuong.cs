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

        // Constructor mặc định
        public FormQLKho()
        {
            InitializeComponent();
        }

        // Constructor nhận tham chiếu đến form fManager (nếu cần)
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
            LoadTheme();   // Áp dụng giao diện chủ đề
        }

        // ========================== Load Data ==========================

        // Tải danh sách kho vào bảng
        private void LoadKho()
        {
            string query = @"
                SELECT 
                    maKho AS [Mã kho], 
                    tenKho AS [Tên kho] 
                FROM Kho 
                ORDER BY maKho ASC";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            dtgvKho.DataSource = dt;
        }

        // Tải danh sách chuồng vào bảng
        private void LoadChuong()
        {
            string query = @"
                SELECT 
                    tenChuong AS [Tên Chuồng], 
                    chuThich AS [Chú thích] 
                FROM Chuong 
                ORDER BY tenChuong ASC";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            dtgvChuong.DataSource = dt;
        }

        // ========================== Chức năng Chuồng ==========================

        // Mở form để thêm chuồng
        private void btnAddChuong_Click(object sender, EventArgs e)
        {
            fAddChuong form = new fAddChuong(fManager);
            form.ShowDialog();
            LoadChuong(); // Refresh danh sách chuồng sau khi thêm
        }

        // Mở form để sửa chuồng
        private void btnEditChuong_Click(object sender, EventArgs e)
        {
            if (dtgvChuong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn chuồng để sửa.");
                return;
            }

            // Lấy thông tin từ dòng được chọn
            string tenChuong = dtgvChuong.SelectedRows[0].Cells["Tên Chuồng"].Value?.ToString();
            string chuThich = dtgvChuong.SelectedRows[0].Cells["Chú thích"].Value?.ToString();

            if (string.IsNullOrWhiteSpace(tenChuong)) return;

            // Mở form sửa chuồng
            fEditChuong editForm = new fEditChuong(tenChuong, chuThich);
            editForm.ShowDialog();

            LoadChuong(); // Cập nhật lại danh sách sau khi sửa
        }

        // Xử lý khi nhấn nút xóa chuồng
        private void btnDeleteChuong_Click(object sender, EventArgs e)
        {
            if (dtgvChuong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn chuồng cần xóa.");
                return;
            }

            // Lấy tên chuồng từ dòng đang chọn
            string tenChuong = dtgvChuong.SelectedRows[0].Cells["Tên Chuồng"].Value?.ToString();
            if (string.IsNullOrWhiteSpace(tenChuong)) return;

            // Kiểm tra xem chuồng có vật nuôi không
            string checkQuery = "SELECT COUNT(*) FROM VatNuoi WHERE tenChuong = @tenChuong";
            int count = (int)DataProvider.Instance.ExecuteScalar(checkQuery, new object[] { tenChuong });

            if (count > 0)
            {
                MessageBox.Show("Không thể xóa chuồng vì đang có vật nuôi bên trong.");
                return;
            }

            // Hỏi người dùng xác nhận xóa
            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn xóa chuồng \"{tenChuong}\"?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                // Thực hiện xóa
                string deleteQuery = "DELETE FROM Chuong WHERE tenChuong = @tenChuong";
                int rows = DataProvider.Instance.ExecuteNonQuery(deleteQuery, new object[] { tenChuong });

                if (rows > 0)
                    MessageBox.Show("Xóa chuồng thành công!");
                else
                    MessageBox.Show("Không tìm thấy chuồng để xóa!");

                LoadChuong(); // Làm mới danh sách
            }
        }

        // ========================== Giao Diện ==========================

        // Thiết lập giao diện theme cho các nút
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

                // Đệ quy cho các control con
                if (control.HasChildren)
                    ApplyThemeToControls(control.Controls);
            }
        }
    }
}
