using GiaoDien.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GiaoDien.DAO.AccountDAO;

namespace GiaoDien.Forms
{
    public partial class FormQLND : Form
    {
        private fManager fManager;
        public FormQLND(fManager fManager)
        {
            InitializeComponent();
            this.fManager = fManager;
        }

        private void FormQLND_Load(object sender, EventArgs e)
        {
            LoadTheme();
            LoadAccountList();
        }

        private void LoadTheme()
        {
            ApplyThemeToControls(this.Controls);
            //label1.ForeColor = ThemeColor.PrimaryColor;
            //label2.ForeColor = ThemeColor.PrimaryColor;
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
                }
                // Nếu control chứa các controls con, gọi đệ quy
                if (control.HasChildren)
                {
                    ApplyThemeToControls(control.Controls);
                }
            }
        }

        void LoadAccountList()
        {
            string query = @"
            SELECT 
            nd.IDNguoiDung AS [ID Người Dùng] ,
            nd.HoTen AS [Họ Tên] ,
            nd.GioiTinh AS [Giới Tính] ,
            nd.NgaySinh AS [Ngày Sinh] ,
            nd.CCCD ,
            nd.DiaChi AS [Địa Chỉ] ,
            tk.TenDangNhap AS [Tên Đăng Nhập] ,
            tk.TenHienThi AS [Tên Hiển Thị] ,
            tk.Email ,
            tk.LoaiTaiKhoan AS [Loại Tài Khoản] ,
            tk.MatKhau AS [Mật Khẩu]
            FROM 
            TaiKhoan tk
            JOIN 
            NguoiDung nd ON tk.TenDangNhap = nd.TenDangNhap";

            dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dtgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            fAddUsersByAdmin form = new fAddUsersByAdmin();
            form.ShowDialog();
            LoadAccountList();
        }

        private void XoaNguoiDung()
        {
            // Kiểm tra có dòng nào được chọn không
            if (dtgvAccount.SelectedRows.Count > 0)
            {
                // Lấy ID người dùng từ dòng được chọn
                string idNguoiDung = dtgvAccount.SelectedRows[0].Cells["ID người dùng"].Value?.ToString();

                // Xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa người dùng này?",
                                                   "Xác nhận xóa",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Thực hiện xóa từ database
                        string query = "DELETE FROM NguoiDung WHERE IDNguoiDung = @id";
                        if (string.IsNullOrEmpty(idNguoiDung)) return;
                        int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idNguoiDung });

                        if (rowsAffected > 0)
                        {
                            // Xóa khỏi DataGridView
                            dtgvAccount.Rows.Remove(dtgvAccount.SelectedRows[0]);
                            MessageBox.Show("Xóa người dùng thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy người dùng để xóa!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa người dùng: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn người dùng cần xóa!");
            }
        }
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            XoaNguoiDung();
        }


        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (dtgvAccount.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn người dùng cần cập nhật");
                return;
            }

            DataGridView selectedRow = dtgvAccount;
            string result = selectedRow.SelectedRows[0].Cells["ID người dùng"].Value?.ToString() ?? string.Empty;
            if (Session.IDNguoiDung == result)
            {
                this.fManager.checkSession = 1;
            }
            // Mở form cập nhật với ID đã chọn
            fUpdateUsers f = new fUpdateUsers(dtgvAccount, this.fManager);
            f.ShowDialog();

            // Refresh danh sách sau khi cập nhật
            LoadAccountList();

            if (Session.Role == "0")
            {
                this.Close();
            }
        }
        public void LoadAccountToDataGridView(DataTable dt)
        {
            dtgvAccount.DataSource = dt;
        }
        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            fSearchUser fSearchUser = new fSearchUser(this);
            fSearchUser.ShowDialog();
        }
    }
}
