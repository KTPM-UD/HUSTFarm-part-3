using GiaoDien.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien.Forms
{
    public partial class FormQLND : Form
    {
        public FormQLND()
        {
            InitializeComponent();
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
            tk.LoaiTaiKhoan AS [Loại Tài Khoản]
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
    }
}
