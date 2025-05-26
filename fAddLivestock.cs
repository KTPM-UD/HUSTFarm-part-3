using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using HTQLCN.DAO;

namespace HTQLCN
{
    public partial class fAddLivestock : Form
    {
        public fAddLivestock()
        {
            InitializeComponent();

            // Gắn sự kiện cho nút Lưu
            button1.Click += button1_Click;

            // Gắn sự kiện khi thay đổi loại vật nuôi
            textBox1.TextChanged += textBox1_TextChanged;

            comboBoxGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList; // Không cho nhập tay
        }

        // Sự kiện khi bấm nút Lưu
        private void button1_Click(object? sender, EventArgs e)
        {
            string loai = textBox1.Text.Trim();
            string? gioiTinh = comboBoxGioiTinh.SelectedItem?.ToString();
            string tenGiong = textBox3.Text.Trim();
            DateTime ngaySinh = dateTimePicker1.Value;
            if (string.IsNullOrEmpty(gioiTinh))
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(textBox4.Text.Trim(), out double canNang))
            {
                MessageBox.Show("Cân nặng không hợp lệ!");
                return;
            }

            string idMoi = textBox5.Text.Trim();
            string tenChuong = textBox6.Text.Trim();
            if (string.IsNullOrWhiteSpace(loai) || string.IsNullOrWhiteSpace(tenGiong) ||
                string.IsNullOrWhiteSpace(tenChuong) || string.IsNullOrWhiteSpace(idMoi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = @"INSERT INTO dbo.VatNuoi ( IDVatNuoi , loai , tenGiong , tenChuong , gioitinh , ngaySinh , canNang ) VALUES ( @id , @loai , @tenGiong , @chuong , @gioiTinh , @ngaySinh , @canNang )";

            int rows = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                idMoi , loai , tenGiong , tenChuong , gioiTinh , ngaySinh , canNang
            });
            MessageBox.Show(rows > 0 ? "Thêm thành công!" : "Thêm thất bại!");
        }

        // Khi thay đổi loại => cập nhật ID và tên chuồng
        private void textBox1_TextChanged(object? sender, EventArgs e)
        {
            string loai = textBox1.Text.Trim();
            string prefix = GetPrefix(loai);
            string idMoi = TaoIDMoi(prefix);
            string chuong = GetChuong(loai);

            textBox5.Text = idMoi;
            textBox6.Text = chuong;
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
                default: return "XX";
            }
        }

        // Hàm lấy tên chuồng theo loại
        private string GetChuong(string loai)
        {
            switch (loai.Trim().ToLower())
            {
                case "bò": return "A1";
                case "lợn": return "B3";
                case "gà": return "C2";
                case "dê": return "D1";
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fAddLivestock_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
