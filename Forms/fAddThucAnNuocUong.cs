using System;
using System.Windows.Forms;
using GiaoDien.DAO; // Sử dụng lớp DataProvider có sẵn

namespace GiaoDien.Forms
{
    public partial class fAddThucAn : Form
    {
        public fAddThucAn()
        {
            InitializeComponent();
            cbLoai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLoai.Items.AddRange(new string[] { "Thức ăn", "Nước uống", "Thuốc" });
            cbLoai.SelectedIndexChanged += cbLoai_SelectedIndexChanged;

            cbMaKho.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaKho.Items.AddRange(new string[] { "1", "2", "3" });

            cbDonVi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDonVi.Items.AddRange(new string[] { "kg", "g", "lít", "ml", "bao", "chai", "viên", "túi", "thùng" });
        }

        private void cbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbLoai.SelectedItem?.ToString())
            {
                case "Thức ăn":
                    cbMaKho.SelectedItem = "1";
                    break;
                case "Nước uống":
                    cbMaKho.SelectedItem = "2";
                    break;
                case "Thuốc":
                    cbMaKho.SelectedItem = "3";
                    break;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string ten = tbTen.Text.Trim();
            string? loai = cbLoai.SelectedItem?.ToString();
            string? maKho = cbMaKho.SelectedItem?.ToString();
            string? donVi = cbDonVi.SelectedItem?.ToString();
            DateTime hanSuDung = dtpHanSuDung.Value;

            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(loai) || string.IsNullOrEmpty(maKho) || string.IsNullOrEmpty(donVi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tbSoLuong.Text.Trim(), out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string idThucAn = TaoIDMoi(loai);

            string query = "INSERT INTO dbo.ThucAnNuocUong ( IDThucAn, ten, loai, soLuong, donVi, hanSuDung, maKho) VALUES ( @id , @ten , @loai , @soLuong , @donVi , @hanSuDung , @maKho )";

            try
            {
                int rows = DataProvider.Instance.ExecuteNonQuery(query, new object[]
                {
                    idThucAn, ten, loai, soLuong, donVi, hanSuDung, int.Parse(maKho)
                });

                if (rows > 0)
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể thêm dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string TaoIDMoi(string loai)
        {
            string prefix;

            switch (loai)
            {
                case "Nước uống":
                    prefix = "NU";
                    break;
                case "Thức ăn":
                    prefix = "TA";
                    break;
                case "Thuốc":
                    prefix = "TH";
                    break;
                default:
                    throw new ArgumentException("Loại không hợp lệ", nameof(loai));
            }

            string query = $"SELECT MAX(IDThucAn) FROM ThucAnNuocUong WHERE IDThucAn LIKE '{prefix}%'";
            object result = DataProvider.Instance.ExecuteScalar(query, null);

            if (result == DBNull.Value || result == null)
                return prefix + "001";

            string? lastID = result.ToString();
            string? numberPart = new string(lastID.SkipWhile(c => !char.IsDigit(c)).ToArray());

            if (int.TryParse(numberPart, out int number))
            {
                number++;
                return $"{prefix}{number:D3}";
            }
            else
            {
                return prefix + "001";
            }
        }
    }
}
