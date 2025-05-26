using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

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
        }

        // Sự kiện khi bấm nút Lưu
        private void button1_Click(object sender, EventArgs e)
        {
            string loai = textBox1.Text.Trim();
            string gioiTinh = textBox2.Text.Trim();
            string tenGiong = textBox3.Text.Trim();
            DateTime ngaySinh = dateTimePicker1.Value;

            if (!double.TryParse(textBox4.Text.Trim(), out double canNang))
            {
                MessageBox.Show("Cân nặng không hợp lệ!");
                return;
            }

            string idMoi = textBox5.Text.Trim();
            string tenChuong = textBox6.Text.Trim();

            string connectionString = @"Data Source=ADMIN-PC;Initial Catalog=HeThongQuanLyChanNuoi;Integrated Security=True;Trust Server Certificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO dbo.VatNuoi(IDVatNuoi, loai, tenGiong, tenChuong, gioitinh, ngaySinh, canNang)
                                 VALUES (@id, @loai, @tenGiong, @chuong, @gioiTinh, @ngaySinh, @canNang)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idMoi);
                cmd.Parameters.AddWithValue("@loai", loai);
                cmd.Parameters.AddWithValue("@tenGiong", tenGiong);
                cmd.Parameters.AddWithValue("@chuong", tenChuong);
                cmd.Parameters.AddWithValue("@gioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@ngaySinh", ngaySinh);
                cmd.Parameters.AddWithValue("@canNang", canNang);

                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show(rows > 0 ? "Thêm thành công!" : "Thêm thất bại!");
            }
        }

        // Khi thay đổi loại => cập nhật ID và tên chuồng
        private void textBox1_TextChanged(object sender, EventArgs e)
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
            string connectionString = @"Data Source=ADMIN-PC;Initial Catalog=HeThongQuanLyChanNuoi;Integrated Security=True;Trust Server Certificate=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = $"SELECT MAX(IDVatNuoi) FROM VatNuoi WHERE IDVatNuoi LIKE '{prefix}%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();

                if (result == DBNull.Value || result == null)
                {
                    return prefix + "001";
                }

                string lastID = result.ToString();
                int num = int.Parse(lastID.Substring(prefix.Length));
                return prefix + (num + 1).ToString("D3");
            }
        }
    }
}
