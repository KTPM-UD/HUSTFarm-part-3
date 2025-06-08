#nullable disable
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using GiaoDien.DAO;

namespace GiaoDien.Forms
{
    public partial class fDistributeThucAn : Form
    {
        private string idThucAn;
        private string tenThucAn;
        private string donVi;
        private int soLuongHienTai;

        // Constructor nhận thông tin thức ăn từ FormQLTANU
        public fDistributeThucAn(string id, string ten, string donVi, int soLuong)
        {
            InitializeComponent();

            this.idThucAn = id;
            this.tenThucAn = ten;
            this.donVi = donVi;
            this.soLuongHienTai = soLuong;

            // Hiển thị thông tin lên giao diện
            lblTenThucAn.Text = $"Tên: {ten}";
            lblSoLuong.Text = $"Hiện còn: {soLuong} {donVi}";
            lblDonVi.Text = donVi;

            // Đổ dữ liệu vào combo box chuồng
            comboBoxChuong.Items.AddRange(new string[] { "B1", "B2", "D1", "D2", "G1", "G2", "H1", "H2", "V1", "V2", "Z0" });
            comboBoxChuong.SelectedIndex = 0;
        }

        // Sự kiện khi nhấn nút Xác Nhận phân phối
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int soLuongNhap = (int)numericSoLuong.Value;

            // Kiểm tra số lượng phân phối không vượt quá hiện có
            if (soLuongNhap > soLuongHienTai)
            {
                MessageBox.Show("Số lượng phân phối vượt quá số lượng hiện có.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string chuong = comboBoxChuong.SelectedItem.ToString();

            // Giảm số lượng trong bảng chính
            string updateQuery = "UPDATE ThucAnNuocUong SET soLuong = soLuong - @soLuong WHERE IDThucAn = @id";
            DataProvider.Instance.ExecuteNonQuery(updateQuery, new object[] { soLuongNhap, idThucAn });

            // Nếu số lượng phân phối bằng hiện có => xóa bản ghi
            if (soLuongNhap == soLuongHienTai)
            {
                string deleteQuery = "DELETE FROM ThucAnNuocUong WHERE IDThucAn = @id";
                DataProvider.Instance.ExecuteNonQuery(deleteQuery, new object[] { idThucAn });
            }

            // Ghi lịch sử phân phối
            string insertHistory = @"
                INSERT INTO dbo.PhanPhoiThucAn (IDThucAn, soLuong, Chuong)
                VALUES (@idThucAn, @soLuong, @chuong)";
            DataProvider.Instance.ExecuteNonQuery(insertHistory, new object[]
            {
                idThucAn, soLuongNhap, chuong
            });

            MessageBox.Show("Phân phối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
