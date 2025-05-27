using HTQLCN.DAO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HTQLCN
{
    public partial class fUpdateLiveStock : Form
    {
        private string idCu;

        private fTableManager tableManager;
        public fUpdateLiveStock(DataGridView selectedRow, fTableManager tableManager)
        {
            InitializeComponent();
            // Điền dữ liệu từ row được chọn vào các control
            tbIDUpdate.Text = selectedRow.SelectedRows[0].Cells["ID vật nuôi"].Value?.ToString();
            tBLoaiUpdate.Text = selectedRow.SelectedRows[0].Cells["Loại"].Value?.ToString();
            tBtenGiongUpdate.Text = selectedRow.SelectedRows[0].Cells["Giống"].Value?.ToString();
            tBtenChuongUpdate.Text = selectedRow.SelectedRows[0].Cells["Chuồng"].Value?.ToString();
            string? gioiTinh = selectedRow.SelectedRows[0].Cells["Giới tính"].Value?.ToString();
            comboBoxGioiTinhUpdate.SelectedItem = gioiTinh;
            tbcanNangUpdate.Text = selectedRow!.SelectedRows[0].Cells["Cân nặng"].Value?.ToString();
            DateTime ngayNhap = Convert.ToDateTime(selectedRow.SelectedRows[0].Cells["Ngày sinh"].Value);
            dateTimePickerUpdate.Value = ngayNhap;
            idCu = selectedRow.SelectedRows[0].Cells["ID vật nuôi"].Value?.ToString() ?? string.Empty;
            tBIDNguoiDungUpdate.Text = selectedRow.SelectedRows[0].Cells["ID người dùng"].Value?.ToString() ?? string.Empty;
            if (AccountDAO.Session.Role == "Admin")
            {
                tBIDNguoiDungUpdate.ReadOnly = false;
            }
            else
            {
                tBIDNguoiDungUpdate.ReadOnly = true;
            }

            this.tableManager = tableManager;
        }
        private void BtnCancelUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnSaveUpdate_Click(object sender, EventArgs e)
        {
            string loai = tBLoaiUpdate.Text.Trim();
            string? gioiTinh = comboBoxGioiTinhUpdate.SelectedItem?.ToString();
            string tenGiong = tBtenGiongUpdate.Text.Trim();
            DateTime ngaySinh = dateTimePickerUpdate.Value;
            string? idNguoiDung = tBIDNguoiDungUpdate.Text.Trim();
            if (string.IsNullOrEmpty(gioiTinh))
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(tbcanNangUpdate.Text.Trim(), out double canNang))
            {
                MessageBox.Show("Cân nặng không hợp lệ!");
                return;
            }
            string idMoi = tbIDUpdate.Text.Trim();
            string tenChuong = tBtenChuongUpdate.Text.Trim();
            if (string.IsNullOrWhiteSpace(loai) || string.IsNullOrWhiteSpace(tenGiong) ||
                string.IsNullOrWhiteSpace(tenChuong) || string.IsNullOrWhiteSpace(idMoi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = "UPDATE dbo.VatNuoi SET IDVatNuoi = @id , loai = @loai , tenGiong = @tenGiong , tenChuong = @chuong , gioitinh = @gioiTinh , ngaySinh = @ngaySinh , canNang = @canNang , IDNguoiDung = @IDNguoiDung WHERE IDVatNuoi = @idCu";

            int rows = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                idMoi , loai , tenGiong , tenChuong , gioiTinh , ngaySinh , canNang , idNguoiDung, idCu
            });

            if (rows > 0)
            {
                MessageBox.Show("Cập nhật thành công!");
                this.tableManager.CapNhatTongVatNuoi();
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }
    }
}
