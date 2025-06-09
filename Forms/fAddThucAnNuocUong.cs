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
    public partial class fAddThucAnNuocUong : Form
    {
        public fAddThucAnNuocUong()
        {
            InitializeComponent();
            cbDonVi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLoai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaKho.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ten = tbTen.Text.Trim();
            string loai = cbLoai.SelectedItem?.ToString();
            string maKho = cbMaKho.SelectedItem?.ToString();
            string donVi = cbDonVi.SelectedItem?.ToString();
            DateTime hanSuDung = dtpHanSuDung.Value;

            // Kiểm tra thông tin đầu vào
            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(loai) ||
                string.IsNullOrEmpty(maKho) || string.IsNullOrEmpty(donVi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra số lượng hợp lệ
            if (!int.TryParse(tbSoLuong.Text.Trim(), out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo mã ID mới theo loại
            string idThucAn = TaoIDMoi(loai);

            // Câu lệnh SQL để thêm dữ liệu
            string query = @"
                INSERT INTO dbo.ThucAnNuocUong 
                    (IDThucAn, ten, loai, soLuong, donVi, hanSuDung, maKho)
                VALUES 
                    ( @id , @ten , @loai , @soLuong , @donVi , @hanSuDung , @maKho )";

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

        /// <summary>
        /// Tạo mã ID mới dựa trên loại thức ăn.
        /// Ví dụ: TA001, NU002, TH003
        /// </summary>
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

            // Lấy ID lớn nhất hiện tại của loại đó
            string query = $"SELECT MAX(IDThucAn) FROM ThucAnNuocUong WHERE IDThucAn LIKE '{prefix}%'";
            object result = DataProvider.Instance.ExecuteScalar(query, null);

            // Nếu chưa có => bắt đầu từ 001
            if (result == DBNull.Value || result == null)
                return prefix + "001";

            string lastID = result.ToString();
            string numberPart = new string(lastID.SkipWhile(c => !char.IsDigit(c)).ToArray());

            if (int.TryParse(numberPart, out int number))
            {
                number++;
                return $"{prefix}{number:D3}"; // VD: TA001, NU015
            }

            return prefix + "001"; // fallback
        }

        private void cbLoai_SelectedIndexChanged_1(object sender, EventArgs e)
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
    }
}
