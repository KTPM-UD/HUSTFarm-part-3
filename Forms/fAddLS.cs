using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using GiaoDien.DAO;

namespace GiaoDien.Forms
{
    public partial class fAddLS : Form
    {
        private fManager fManager;

        public fAddLS(fManager fManager)
        {
            InitializeComponent();
            this.fManager = fManager;
        }

        public void CapNhatTongVatNuoi()
        {
            this.fManager?.ReloadTotalLS();
        }

        private void btnCancelAddLS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmAddLS_Click(object sender, EventArgs e)
        {
            string loai = tbLoaiLS.Text.Trim();
            string gioiTinh = comboBoxGioiTinhLS.SelectedItem?.ToString();
            string tenGiong = tbGiongLS.Text.Trim();
            DateTime ngaySinh = dateTimePickerAddLS.Value;

            string tinhTrang = cbTinhTrangSucKhoe.SelectedItem?.ToString() ?? "Tốt";
            string ghiChu = string.IsNullOrWhiteSpace(tbGhiChu.Text) ? null : tbGhiChu.Text.Trim();

            if (string.IsNullOrEmpty(gioiTinh))
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(tbCanNangLS.Text.Trim(), out double canNang) || canNang <= 0)
            {
                MessageBox.Show("Cân nặng không hợp lệ hoặc nhỏ hơn 0!");
                return;
            }

            string IDNguoiDung = AccountDAO.Session.IDNguoiDung ?? string.Empty;
            string idMoi = tbIDVatNuoiLS.Text.Trim();
            string tenChuong = cbChuongLS.Text.Trim();

            if (string.IsNullOrWhiteSpace(loai) || string.IsNullOrWhiteSpace(tenGiong) ||
                string.IsNullOrWhiteSpace(tenChuong) || string.IsNullOrWhiteSpace(idMoi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string checkQuery = "SELECT COUNT(*) FROM VatNuoi WHERE IDVatNuoi = @IDVatNuoi";
            int count = (int)DataProvider.Instance.ExecuteScalar(checkQuery, new object[] { idMoi });
            if (count > 0)
            {
                MessageBox.Show("ID vật nuôi đã tồn tại!");
                return;
            }

            string query = @"INSERT INTO dbo.VatNuoi 
                (IDVatNuoi, loai, tenGiong, tenChuong, gioitinh, ngaySinh, canNang, IDNguoiDung, tinhTrangSucKhoe, ghiChu) 
                VALUES (@id, @loai, @tenGiong, @chuong, @gioiTinh, @ngaySinh, @canNang, @IDNguoiDung, @tinhTrang, @ghiChu)";

            int rows = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                idMoi, loai, tenGiong, tenChuong, gioiTinh, ngaySinh, canNang, IDNguoiDung, tinhTrang, (object)ghiChu ?? DBNull.Value
            });

            if (rows > 0)
            {
                MessageBox.Show("Thêm vật nuôi thành công!");
                CapNhatTongVatNuoi();
                this.fManager?.ReloadAddLS();
            }
            else
            {
                MessageBox.Show("Thêm vật nuôi thất bại!");
            }
        }

        private void tbLoaiLS_TextChanged(object sender, EventArgs e)
        {
            string loai = tbLoaiLS.Text.Trim();
            string prefix = GetPrefix(loai);
            string idMoi = TaoIDMoi(prefix);
            List<string> dsChuong = GetChuong(loai);

            tbIDVatNuoiLS.Text = idMoi;
            cbChuongLS.Items.Clear();
            cbChuongLS.Items.AddRange(dsChuong.ToArray());
            cbChuongLS.SelectedIndex = -1;
            cbChuongLS.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private string GetPrefix(string loai)
        {
            switch (loai.Trim().ToLower())
            {
                case "bò": return "BO";
                case "lợn": return "LON";
                case "heo": return "HEO";
                case "gà": return "GA";
                case "dê": return "DE";
                case "trâu": return "TRAU";
                case "cừu": return "CUU";
                case "ngựa": return "NGUA";
                case "vịt": return "VIT";
                case "ngỗng": return "NGONG";
                case "chim cút": return "CHIMC";
                case "cá": return "CA";
                case "tôm": return "TOM";
                case "cua": return "CUA";
                case "ếch": return "ECH";
                case "thỏ": return "THO";
                default: return "XX";
            }
        }

        private List<string> GetChuong(string loai)
        {
            loai = loai.Trim().ToLower();

            return loai switch
            {
                "bò" => new List<string> { "B1", "B2" },
                "dê" => new List<string> { "D1", "D2" },
                "heo" or "lợn" => new List<string> { "H1", "H2" },
                "gà" => new List<string> { "G1", "G2" },
                "vịt" => new List<string> { "V1", "V2" },
                _ => new List<string> { "Z0" }
            };
        }

        private string TaoIDMoi(string prefix)
        {
            string query = "SELECT MAX(IDVatNuoi) FROM VatNuoi WHERE IDVatNuoi LIKE @prefix";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { prefix + "%" });

            if (result == DBNull.Value || result == null)
            {
                return prefix + "001";
            }

            string lastID = result.ToString();
            if (string.IsNullOrEmpty(lastID))
            {
                return prefix + "001";
            }

            int num = int.Parse(lastID.Substring(prefix.Length));
            return prefix + (num + 1).ToString("D3");
        }

        private void fAddLS_Load(object sender, EventArgs e)
        {
            comboBoxGioiTinhLS.DropDownStyle = ComboBoxStyle.DropDownList;

            cbTinhTrangSucKhoe.Items.AddRange(new string[] {
                "Tốt", "Trung Bình", "Yếu", "Bệnh mức 1", "Bệnh mức 2", "Bệnh mức 3", "Đã chết", 
            });
            cbTinhTrangSucKhoe.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTinhTrangSucKhoe.SelectedIndex = 0; // mặc định là Tốt
        }
    }
}
