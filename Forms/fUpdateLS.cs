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
    public partial class fUpdateLS : Form
    {
        private string idCu;

        private fManager fManager;
        public fUpdateLS(DataGridView selectedRow, fManager fManager)
        {
            InitializeComponent();

            comboBoxGioiTinhUpdateLS.DropDownStyle = ComboBoxStyle.DropDownList; // Không cho nhập tay
            // Điền dữ liệu từ row được chọn vào các control
            tbIDVatNuoiUpdateLS.Text = selectedRow.SelectedRows[0].Cells["ID vật nuôi"].Value?.ToString();
            tbLoaiUpdateLS.Text = selectedRow.SelectedRows[0].Cells["Loại"].Value?.ToString();
            tbGiongUpdateLS.Text = selectedRow.SelectedRows[0].Cells["Giống"].Value?.ToString();
            tbChuongUpdateLS.Text = selectedRow.SelectedRows[0].Cells["Chuồng"].Value?.ToString();
            string gioiTinh = selectedRow.SelectedRows[0].Cells["Giới tính"].Value?.ToString();
            comboBoxGioiTinhUpdateLS.SelectedItem = gioiTinh;
            tbCanNangUpdateLS.Text = selectedRow!.SelectedRows[0].Cells["Cân nặng"].Value?.ToString();
            DateTime ngayNhap = Convert.ToDateTime(selectedRow.SelectedRows[0].Cells["Ngày sinh"].Value);
            dateTimePickerUpdateLS.Value = ngayNhap;
            idCu = selectedRow.SelectedRows[0].Cells["ID vật nuôi"].Value?.ToString() ?? string.Empty;
            tbIDNguoiDungUpdateLS.Text = selectedRow.SelectedRows[0].Cells["ID người dùng"].Value?.ToString() ?? string.Empty;
            if (AccountDAO.Session.Role == "1")
            {
                tbIDNguoiDungUpdateLS.ReadOnly = false;
            }
            else
            {
                tbIDNguoiDungUpdateLS.ReadOnly = true;
            }

            this.fManager = fManager;
        }

        private void btnCancelUpdateLS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmUpdateLS_Click(object sender, EventArgs e)
        {
            string loai = tbLoaiUpdateLS.Text.Trim();
            string gioiTinh = comboBoxGioiTinhUpdateLS.SelectedItem?.ToString();
            string tenGiong = tbGiongUpdateLS.Text.Trim();
            DateTime ngaySinh = dateTimePickerUpdateLS.Value;
            string idNguoiDung = tbIDNguoiDungUpdateLS.Text.Trim();
            if (string.IsNullOrEmpty(gioiTinh))
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(tbCanNangUpdateLS.Text.Trim(), out double canNang))
            {
                MessageBox.Show("Cân nặng không hợp lệ!");
                return;
            }
            string idMoi = tbIDVatNuoiUpdateLS.Text.Trim();
            string tenChuong = tbChuongUpdateLS.Text.Trim();
            if (string.IsNullOrWhiteSpace(loai) || string.IsNullOrWhiteSpace(tenGiong) ||
                string.IsNullOrWhiteSpace(tenChuong) || string.IsNullOrWhiteSpace(idMoi) || string.IsNullOrWhiteSpace(idNguoiDung))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (idMoi != idCu)
            {
                // Kiểm tra xem id vật nuôi đã tồn tại chưa
                string checkQuery = "SELECT COUNT(*) FROM dbo.VatNuoi WHERE IDVatNuoi = @idVatNuoi";
                int count1 = (int)DataProvider.Instance.ExecuteScalar(checkQuery, new object[] { idMoi });
                if (count1 > 0)
                {
                    MessageBox.Show("ID vật nuôi đã tồn tại!");
                    return;
                }
            }

            string query = "UPDATE dbo.VatNuoi SET IDVatNuoi = @id , loai = @loai , tenGiong = @tenGiong , tenChuong = @chuong , gioitinh = @gioiTinh , ngaySinh = @ngaySinh , canNang = @canNang , IDNguoiDung = @IDNguoiDung WHERE IDVatNuoi = @idCu";

            int rows = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                idMoi , loai , tenGiong , tenChuong , gioiTinh , ngaySinh , canNang , idNguoiDung , idCu
            });

            if (rows > 0)
            {
                MessageBox.Show("Cập nhật vật nuôi thành công!");
                this.fManager.ReloadTotalLS();
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật vật nuôi thất bại!");
            }
        }

        private void fUpdateLS_Load(object sender, EventArgs e)
        {
            
        }
    }
}
