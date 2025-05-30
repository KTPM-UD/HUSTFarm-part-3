using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiaoDien.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace GiaoDien.Forms
{
    public partial class fAddLS : Form
    {
        private fManager? fManager;
        public fAddLS(fManager fManager)
        {
            InitializeComponent();
            this.fManager = fManager;
        }

        public void CapNhatTongVatNuoi()
        {
            this.fManager?.ReloadTotalLS();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelAddLS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmAddLS_Click(object sender, EventArgs e)
        {
            string loai = tbLoaiLS.Text.Trim();
            string? gioiTinh = comboBoxGioiTinhLS.SelectedItem?.ToString();
            string tenGiong = tbGiongLS.Text.Trim();
            DateTime ngaySinh = dateTimePickerAddLS.Value;
            if (string.IsNullOrEmpty(gioiTinh))
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(tbCanNangLS.Text.Trim(), out double canNang))
            {
                MessageBox.Show("Cân nặng không hợp lệ!");
                return;
            }
            string IDNguoiDung = AccountDAO.Session.IDNguoiDung ?? string.Empty;
            string idMoi = tbIDVatNuoiLS.Text.Trim();
            string tenChuong = tbChuongLS.Text.Trim();
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

            string query = "INSERT INTO dbo.VatNuoi ( IDVatNuoi , loai , tenGiong , tenChuong , gioitinh , ngaySinh , canNang , IDNguoiDung ) VALUES ( @id , @loai , @tenGiong , @chuong , @gioiTinh , @ngaySinh , @canNang , @IDNguoiDung )";

            int rows = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                idMoi , loai , tenGiong , tenChuong , gioiTinh , ngaySinh , canNang , IDNguoiDung
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
            string chuong = GetChuong(loai);

            tbIDVatNuoiLS.Text = idMoi;
            tbChuongLS.Text = chuong;
        }

        // Hàm sinh prefix ID theo loại
        private string GetPrefix(string loai)
        {
            switch (loai.Trim().ToLower())
            {
                case "bò": return "BO";
                case "lợn": return "LON";
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

        // Hàm lấy tên chuồng theo loại
        private string GetChuong(string loai)
        {
            switch (loai.Trim().ToLower())
            {
                case "bò": return "A1";
                case "lợn": return "A3";
                case "gà": return "C2";
                case "cừu": return "A5";
                case "dê": return "A4";
                case "trâu": return "A6";
                case "ngựa": return "A2";
                case "vịt": return "C1";
                case "ngỗng": return "C3";
                case "chim cút": return "B1";
                case "cá": return "BN1";
                case "tôm": return "BN2";
                case "cua": return "BN3";
                case "ếch": return "TS1";
                case "thỏ": return "D1";
                default: return "Z0";
            }
        }

        // Hàm tạo ID mới dựa trên prefix
        private string TaoIDMoi(string prefix)
        {
            string query = "SELECT MAX(IDVatNuoi) FROM VatNuoi WHERE IDVatNuoi LIKE @prefix";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { prefix + "%" });

            if (result == DBNull.Value || result == null)
            {
                return prefix + "001";
            }

            string? lastID = result.ToString();
            if (string.IsNullOrEmpty(lastID))
            {
                return prefix + "001";
            }
            int num = int.Parse(lastID.Substring(prefix.Length));
            return prefix + (num + 1).ToString("D3");
        }

        private void fAddLS_Load(object sender, EventArgs e)
        {
            comboBoxGioiTinhLS.DropDownStyle = ComboBoxStyle.DropDownList; // Không cho nhập tay
        }
    }
}
