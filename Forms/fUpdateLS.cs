using GiaoDien.DAO;
using System;
using System.Collections.Generic;
using System.Data;
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

            comboBoxGioiTinhUpdateLS.DropDownStyle = ComboBoxStyle.DropDownList;

            // Gán giá trị từ dòng được chọn
            tbIDVatNuoiUpdateLS.Text = selectedRow.SelectedRows[0].Cells["ID vật nuôi"].Value?.ToString();
            tbLoaiUpdateLS.Text = selectedRow.SelectedRows[0].Cells["Loại"].Value?.ToString();
            tbGiongUpdateLS.Text = selectedRow.SelectedRows[0].Cells["Giống"].Value?.ToString();
            cbChuongUpdateLS.Text = selectedRow.SelectedRows[0].Cells["Chuồng"].Value?.ToString();
            comboBoxGioiTinhUpdateLS.SelectedItem = selectedRow.SelectedRows[0].Cells["Giới tính"].Value?.ToString();
            tbCanNangUpdateLS.Text = selectedRow.SelectedRows[0].Cells["Cân nặng"].Value?.ToString();

            dateTimePickerUpdateLS.Value = Convert.ToDateTime(selectedRow.SelectedRows[0].Cells["Ngày sinh"].Value);

            idCu = selectedRow.SelectedRows[0].Cells["ID vật nuôi"].Value?.ToString() ?? string.Empty;
            tbIDNguoiDungUpdateLS.Text = selectedRow.SelectedRows[0].Cells["ID người dùng"].Value?.ToString() ?? string.Empty;

            // Phân quyền chỉnh sửa ID người dùng
            tbIDNguoiDungUpdateLS.ReadOnly = AccountDAO.Session.Role != "1";

            this.fManager = fManager;
        }

        private void fUpdateLS_Load(object sender, EventArgs e)
        {
            LoadDanhSachChuong();
        }

        private void btnCancelUpdateLS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmUpdateLS_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ form
            string loai = tbLoaiUpdateLS.Text.Trim();
            string gioiTinh = comboBoxGioiTinhUpdateLS.SelectedItem?.ToString();
            string tenGiong = tbGiongUpdateLS.Text.Trim();
            DateTime ngaySinh = dateTimePickerUpdateLS.Value;
            string idNguoiDung = tbIDNguoiDungUpdateLS.Text.Trim();
            string idMoi = tbIDVatNuoiUpdateLS.Text.Trim();
            string tenChuong = cbChuongUpdateLS.Text.Trim();

            // Kiểm tra dữ liệu
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

            if (string.IsNullOrWhiteSpace(loai) || string.IsNullOrWhiteSpace(tenGiong)
                || string.IsNullOrWhiteSpace(tenChuong) || string.IsNullOrWhiteSpace(idMoi)
                || string.IsNullOrWhiteSpace(idNguoiDung))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng ID nếu đổi ID vật nuôi
            if (idMoi != idCu)
            {
                string checkQuery = "SELECT COUNT(*) FROM dbo.VatNuoi WHERE IDVatNuoi = @idVatNuoi ";
                int count1 = (int)DataProvider.Instance.ExecuteScalar(checkQuery, new object[] { idMoi });
                if (count1 > 0)
                {
                    MessageBox.Show("ID vật nuôi đã tồn tại!");
                    return;
                }
            }

            // Thực hiện cập nhật
            string query = @"
                UPDATE dbo.VatNuoi
                SET IDVatNuoi = @id ,
                    loai = @loai ,
                    tenGiong = @tenGiong ,
                    tenChuong = @chuong ,
                    gioitinh = @gioiTinh ,
                    ngaySinh = @ngaySinh ,
                    canNang = @canNang ,
                    IDNguoiDung = @IDNguoiDung 
                WHERE IDVatNuoi = @idCu ";

            int rows = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                idMoi, loai, tenGiong, tenChuong, gioiTinh, ngaySinh, canNang, idNguoiDung, idCu
            });

            if (rows > 0)
            {
                MessageBox.Show("Cập nhật vật nuôi thành công!");
                fManager.ReloadTotalLS();
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật vật nuôi thất bại!");
            }
        }

        private void LoadDanhSachChuong()
        {
            List<string> danhSachChuong = GetChuongTuCSDL();
            cbChuongUpdateLS.Items.Clear();
            cbChuongUpdateLS.Items.AddRange(danhSachChuong.ToArray());

            cbChuongUpdateLS.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbChuongUpdateLS.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private List<string> GetChuongTuCSDL()
        {
            string query = "SELECT tenChuong FROM Chuong ORDER BY tenChuong ASC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            List<string> dsChuong = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                dsChuong.Add(row["tenChuong"].ToString());
            }

            return dsChuong;
        }
    }
}
