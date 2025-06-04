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
    public partial class fUpdateUsers : Form
    {
        private string idNguoiDungCu;
        private string tenDangNhapCu;
        private string emailCu;
        private string matKhauCu;

        private fManager fManager;
        public fUpdateUsers(DataGridView selectedRow, fManager fManager)
        {
            InitializeComponent();

            comboBoxGioiTinhUU.DropDownStyle = ComboBoxStyle.DropDownList; // Không cho nhập tay
            // Điền dữ liệu từ row được chọn vào các control
            tbIDUU.Text = selectedRow.SelectedRows[0].Cells["ID người dùng"].Value?.ToString();
            tbLoaiTaiKhoanUU.Text = selectedRow.SelectedRows[0].Cells["Loại tài khoản"].Value?.ToString();
            tbTenHienThiUU.Text = selectedRow.SelectedRows[0].Cells["Tên hiển thị"].Value?.ToString();
            tbTenDangNhapUU.Text = selectedRow.SelectedRows[0].Cells["Tên đăng nhập"].Value?.ToString();
            string? gioiTinh = selectedRow.SelectedRows[0].Cells["Giới tính"].Value?.ToString();
            comboBoxGioiTinhUU.SelectedItem = gioiTinh;
            tbMatKhauUU.Text = selectedRow!.SelectedRows[0].Cells["Mật khẩu"].Value?.ToString();
            DateTime ngayNhap = Convert.ToDateTime(selectedRow.SelectedRows[0].Cells["Ngày sinh"].Value);
            dateTimePickerUU.Value = ngayNhap;
            matKhauCu = selectedRow.SelectedRows[0].Cells["Mật khẩu"].Value?.ToString() ?? string.Empty;
            idNguoiDungCu = selectedRow.SelectedRows[0].Cells["ID người dùng"].Value?.ToString() ?? string.Empty;
            tenDangNhapCu = selectedRow.SelectedRows[0].Cells["Tên đăng nhập"].Value?.ToString() ?? string.Empty;
            tbHoTenUU.Text = selectedRow.SelectedRows[0].Cells["Họ tên"].Value?.ToString() ?? string.Empty;
            tbEmailUU.Text = selectedRow.SelectedRows[0].Cells["Email"].Value?.ToString() ?? string.Empty;
            tbCCCDUU.Text = selectedRow.SelectedRows[0].Cells["CCCD"].Value?.ToString() ?? string.Empty;
            tbDiaChiUU.Text = selectedRow.SelectedRows[0].Cells["Địa chỉ"].Value?.ToString() ?? string.Empty;
            emailCu = selectedRow.SelectedRows[0].Cells["Email"].Value?.ToString() ?? string.Empty;
            this.fManager = fManager;
        }

        private void btnCancelUU_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmUU_Click(object sender, EventArgs e)
        {
            string tenDangNhapMoi = tbTenDangNhapUU.Text.Trim();
            string tenHienThi = tbTenHienThiUU.Text.Trim();
            string matKhau = tbMatKhauUU.Text.Trim();
            string hoTen = tbHoTenUU.Text.Trim();
            string? gioiTinh = comboBoxGioiTinhUU.SelectedItem?.ToString();
            DateTime ngaySinh = dateTimePickerUU.Value;
            string email = tbEmailUU.Text.Trim();
            string cccd = tbCCCDUU.Text.Trim();
            string diaChi = tbDiaChiUU.Text.Trim();
            string loai = tbLoaiTaiKhoanUU.Text.Trim();
            string idNguoiDungMoi = tbIDUU.Text.Trim();

            // Kiểm tra hợp lệ
            if (string.IsNullOrWhiteSpace(tenDangNhapMoi) || string.IsNullOrWhiteSpace(matKhau) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(loai))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin tài khoản!");
                return;
            }

            if (string.IsNullOrWhiteSpace(idNguoiDungMoi) || string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(gioiTinh) ||
                string.IsNullOrWhiteSpace(cccd) || string.IsNullOrWhiteSpace(diaChi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin người dùng!");
                return;
            }

            if (tenDangNhapCu != tenDangNhapMoi)
            {
                // Kiểm tra xem tên đăng nhập đã tồn tại chưa
                string checkQuery = "SELECT COUNT(*) FROM dbo.TaiKhoan WHERE TenDangNhap = @TenDangNhap";
                int count1 = (int)DataProvider.Instance.ExecuteScalar(checkQuery, new object[] { tenDangNhapMoi });
                if (count1 > 0)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại, vui lòng chọn tên khác!");
                    return;
                }
            }

            if (emailCu != email)
            {
                // Kiểm tra xem tên đăng nhập đã tồn tại chưa
                string checkQueryEmail = "SELECT COUNT(*) FROM dbo.TaiKhoan WHERE Email = @email";
                int count2 = (int)DataProvider.Instance.ExecuteScalar(checkQueryEmail, new object[] { email });
                if (count2 > 0)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại, vui lòng chọn tên khác!");
                    return;
                }
            }

            if (idNguoiDungCu != idNguoiDungMoi)
            {
                string checkQueryIDNguoiDung = "SELECT COUNT(*) FROM dbo.NguoiDung WHERE IDNguoiDung = @idNguoiDung";
                int count = (int)DataProvider.Instance.ExecuteScalar(checkQueryIDNguoiDung, new object[] { idNguoiDungMoi });
                if (count > 0)
                {
                    MessageBox.Show("ID người dùng đã tồn tại!");
                    return;
                }
            }

            //Update bảng tài khoản trước
            string query1 = "UPDATE dbo.TaiKhoan SET TenDangNhap = @TenDangNhapMoi , MatKhau = @matKhau , Email = @email , TenHienThi = @tenHienThi , LoaiTaiKhoan = @loai WHERE TenDangNhap = @tenDangNhapCu";
            int result1 = DataProvider.Instance.ExecuteNonQuery(query1, new object[]
            {
                tenDangNhapMoi , matKhau , email , tenHienThi , loai , tenDangNhapCu
            });

            if (result1 <= 0)
            {
                MessageBox.Show("Cập nhật người dùng thất bại!");
                return;
            }

            // 2. Sau đó update bảng NguoiDung
            string query2 = "UPDATE dbo.NguoiDung SET IDNguoiDung = @idNguoiDungMoi , HoTen = @hoTen , gioitinh = @gioiTinh , NgaySinh = @ngaySinh , CCCD = @cccd , Diachi = @diaChi , TenDangNhap = @TenDangNhapMoi WHERE IDNguoiDung = @idNguoiDungCu";
            int result2 = DataProvider.Instance.ExecuteNonQuery(query2, new object[]
            {
                idNguoiDungMoi , hoTen , gioiTinh , ngaySinh , cccd , diaChi , tenDangNhapMoi , idNguoiDungCu
            });

            if (result2 > 0)
            {
                if(matKhau != matKhauCu || tenDangNhapMoi != tenDangNhapCu)
                {
                    MessageBox.Show("Đã cập nhật người dùng với\nTên đăng nhập: "+tenDangNhapMoi+"\nMật khẩu: "+matKhau);
                }
                else
                {
                    MessageBox.Show("Cập nhật người dùng thành công!");
                }
                if (this.fManager.checkSession == 1)
                {
                    this.fManager.UpdateUserInfo(tenDangNhapMoi, loai, idNguoiDungMoi);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật người dùng thất bại!");
            }
        }
    }
}
