// fAddUserByAdmin.cs
using System;
using System.Windows.Forms;
using HTQLCN.DAO;

namespace HTQLCN
{
    public partial class fAddUserByAdmin : Form
    {
        public fAddUserByAdmin()
        {
            InitializeComponent();
        }

        private void fAddUserByAdmin_Load(object sender, EventArgs e)
        {
            comboBoxGioiTinhSignUp.DropDownStyle = ComboBoxStyle.DropDownList;
            string idNguoiDung = TaoIDMoi();
            tBIDSignUp.Text = idNguoiDung;
            string loaiTK = "0"; // Người dùng bình thường
            tBTypeSignUp.Text = loaiTK;
        }

        private string TaoIDMoi()
        {
            string query = "SELECT MAX(IDNguoiDung) FROM NguoiDung WHERE IDNguoiDung LIKE @ND";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { "ND%" });

            if (result == DBNull.Value || result == null) return "ND001";
            string? lastID = result.ToString();
            if (string.IsNullOrEmpty(lastID)) return "ND001";
            int num = int.Parse(lastID.Substring(2));
            return "ND" + (num + 1).ToString("D3");
        }

        private void BtnCancelSignUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSaveSignUp_Click(object sender, EventArgs e)
        {
            string tenDangNhap = tBtenDangNhapSignUp.Text.Trim();
            string tenHienThi = tBDisplayNameSignUp.Text.Trim();
            string matKhau = tBMatKhauSignUp.Text.Trim();
            string email = tBEmailSignUp.Text.Trim();
            string idNguoiDung = tBIDSignUp.Text.Trim();
            string loaiTK = tBTypeSignUp.Text.Trim();
            string hoTen = tBHoTenSignUp.Text.Trim();
            string gioiTinh = comboBoxGioiTinhSignUp.SelectedItem?.ToString() ?? "";
            DateTime ngaySinh = dateTimePickerSignUp.Value;
            string cccd = tBCCCDSignUp.Text.Trim();
            string diaChi = tBDiaChiSignUp.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenDangNhap) || string.IsNullOrWhiteSpace(matKhau) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin tài khoản!");
                return;
            }
            if (string.IsNullOrWhiteSpace(idNguoiDung) || string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(gioiTinh) || string.IsNullOrWhiteSpace(cccd) || string.IsNullOrWhiteSpace(diaChi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin người dùng!");
                return;
            }

            string checkQuery = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap";
            int count = (int)DataProvider.Instance.ExecuteScalar(checkQuery, new object[] { tenDangNhap });
            if (count > 0)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại, vui lòng chọn tên khác!");
                return;
            }

            string query1 = "INSERT INTO TaiKhoan ( TenDangNhap , MatKhau , Email , TenHienThi , LoaiTaiKhoan ) VALUES ( @TenDangNhap , @MatKhau , @Email , @TenHienThi , @loaiTK )";
            int result1 = DataProvider.Instance.ExecuteNonQuery(query1, new object[] { tenDangNhap, matKhau, email, tenHienThi, loaiTK });

            if (result1 <= 0)
            {
                MessageBox.Show("Tạo tài khoản thất bại!");
                return;
            }

            string query2 = "INSERT INTO NguoiDung ( IDNguoiDung , HoTen , gioitinh , NgaySinh , CCCD , Diachi , TenDangNhap ) VALUES ( @IDNguoiDung , @HoTen , @GioiTinh , @NgaySinh , @CCCD , @DiaChi , @tenDangNhap )";
            int result2 = DataProvider.Instance.ExecuteNonQuery(query2, new object[]
            {
                idNguoiDung, hoTen, gioiTinh, ngaySinh, cccd, diaChi, tenDangNhap
            });

            if (result2 > 0)
            {
                MessageBox.Show("Thêm người dùng thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại (Người dùng)!");
            }
        }
    }
}
