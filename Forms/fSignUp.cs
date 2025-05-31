using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using GiaoDien.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GiaoDien.Forms
{
    public partial class fSignUp : Form
    {
        private fManager? fManager;
        public fSignUp(fManager fManager)
        {
            InitializeComponent();
            this.fManager = fManager;
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btns.BackColor = ThemeColor.PrimaryColor;
                    btns.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            //label4.ForeColor = ThemeColor.PrimaryColor;
        }
        private void fSignUp_Load(object sender, EventArgs e)
        {
            LoadTheme();
            comboBoxGioiTinhSignUp.DropDownStyle = ComboBoxStyle.DropDownList; // Không cho nhập tay
            // Thông tin người dùng
            string idNguoiDung = TaoIDMoi();
            tBIDSignUp.Text = idNguoiDung; // Hiển thị ID mới trong TextBox
            string loaiTK = "0"; // Mặc định là người dùng bình thường
            tBTypeSignUp.Text = loaiTK; // Mặc định là người dùng bình thường

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void BtnConfirmSignUp_Click(object sender, EventArgs e)
        {
            // Thông tin tài khoản
            string tenDangNhap = tbTenDangNhapSignUp.Text.Trim();
            string tenHienThi = tbTenHienThiSignUp.Text.Trim();
            string matKhau = tbMatKhauSignUp.Text.Trim();
            string email = tbEmailSignUp.Text.Trim();

            // Thông tin người dùng
            string idNguoiDung = tBIDSignUp.Text.Trim();
            string loaiTK = tBTypeSignUp.Text.Trim();
            string hoTen = tbHoTenSignUp.Text.Trim();
            string gioiTinh = comboBoxGioiTinhSignUp.SelectedItem?.ToString() ?? "";
            DateTime ngaySinh = dateTimePickerSignUp.Value;
            string cccd = tbCCCDSignUp.Text.Trim();
            string diaChi = tbDiaChiSignUp.Text.Trim();
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

            string checkQueryEmail = "SELECT COUNT(*) FROM TaiKhoan WHERE Email = @email";
            int count1 = (int)DataProvider.Instance.ExecuteScalar(checkQueryEmail, new object[] { email });
            if (count1 > 0)
            {
                MessageBox.Show("Tài khoản với email này tồn tại!");
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
                MessageBox.Show("Đăng ký thành công với tên đăng nhập: "+tenDangNhap+" và mật khẩu: "+ matKhau);
                this.fManager?.SuccessSignUp();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại (Người dùng)!");
            }
        }
    }
}
