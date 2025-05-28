using HTQLCN.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTQLCN
{
    public partial class fAddUsersByAdmin : Form
    {
        public fAddUsersByAdmin()
        {
            InitializeComponent();
            comboBoxGioiTinhAddUser.DropDownStyle = ComboBoxStyle.DropDownList; // Không cho nhập tay
            // Thông tin người dùng
            string idNguoiDung = TaoIDMoi();
            tBIDNguoiDungAddUser.Text = idNguoiDung; // Hiển thị ID mới trong TextBox
            string loaiTK = "0"; // Mặc định là người dùng bình thường
            tBLoaiTKAddUser.Text = loaiTK;
        }

        private string TaoIDMoi()
        {
            string query = "SELECT MAX(IDNguoiDung) FROM NguoiDung WHERE IDNguoiDung LIKE @ND";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { "ND%" });

            if (result == DBNull.Value || result == null)
            {
                return "ND" + "001";
            }

            string? lastID = result.ToString();
            if (string.IsNullOrEmpty(lastID))
            {
                return "ND" + "001";
            }
            int num = int.Parse(lastID.Substring(2));
            return "ND" + (num + 1).ToString("D3");
        }
        private void BtnSaveAddUser_Click(object sender, EventArgs e)
        {
            // Thông tin tài khoản
            string tenDangNhap = tBtenDangNhapAddUser.Text.Trim();
            string tenHienThi = tBTenHienThiAddUser.Text.Trim();
            string matKhau = tBMatKhauAddUser.Text.Trim();
            string email = tBEmailAddUser.Text.Trim();

            // Thông tin người dùng
            string idNguoiDung = tBIDNguoiDungAddUser.Text.Trim();
            string loaiTK = tBLoaiTKAddUser.Text.Trim();
            string hoTen = tBHoTenAddUser.Text.Trim();
            string gioiTinh = comboBoxGioiTinhAddUser.SelectedItem?.ToString() ?? "";
            DateTime ngaySinh = dateTimePickerAddUser.Value;
            string cccd = tBCCCDAddUser.Text.Trim();
            string diaChi = tBDiaChiAddUser.Text.Trim();
            // Kiểm tra hợp lệ
            if (string.IsNullOrWhiteSpace(tenDangNhap) || string.IsNullOrWhiteSpace(matKhau) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin tài khoản!");
                return;
            }

            if (string.IsNullOrWhiteSpace(idNguoiDung) || string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(gioiTinh) ||
                string.IsNullOrWhiteSpace(cccd) || string.IsNullOrWhiteSpace(diaChi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin người dùng!");
                return;
            }

            // 1. Chèn vào bảng TaiKhoan trước
            // Kiểm tra xem tên đăng nhập đã tồn tại chưa
            string checkQuery = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap";
            int count = (int)DataProvider.Instance.ExecuteScalar(checkQuery, new object[] { tenDangNhap });
            if (count > 0)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại, vui lòng chọn tên khác!");
                return;
            }
            string query1 = "INSERT INTO TaiKhoan ( TenDangNhap , MatKhau , Email , TenHienThi , LoaiTaiKhoan ) VALUES ( @TenDangNhap , @MatKhau , @Email , @TenHienThi , @loaiTK )";
            int result1 = DataProvider.Instance.ExecuteNonQuery(query1, new object[]
            {
                tenDangNhap , matKhau , email , tenHienThi , loaiTK
            });

            if (result1 <= 0)
            {
                MessageBox.Show("Đăng ký tài khoản thất bại!");
                return;
            }

            // 2. Sau đó chèn vào bảng NguoiDung
            string query2 = "INSERT INTO NguoiDung ( IDNguoiDung , HoTen , gioitinh , NgaySinh , CCCD , Diachi , TenDangNhap ) VALUES ( @IDNguoiDung , @HoTen , @GioiTinh , @NgaySinh , @CCCD , @DiaChi , @tenDangNhap )";
            int result2 = DataProvider.Instance.ExecuteNonQuery(query2, new object[]
            {
                idNguoiDung, hoTen, gioiTinh, ngaySinh, cccd, diaChi, tenDangNhap
            });

            if (result2 > 0)
            {
                MessageBox.Show("Đăng ký thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại (Người dùng)!");
            }
        }

        private void BtnCancelAddUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
