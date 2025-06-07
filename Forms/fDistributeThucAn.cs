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
    public partial class fDistributeThucAn : Form
    {
        private string idThucAn;
        private string tenThucAn;
        private string donVi;
        private int soLuongHienTai;

        public fDistributeThucAn(string id, string ten, string donVi, int soLuong)
        {
            InitializeComponent();
            this.idThucAn = id;
            this.tenThucAn = ten;
            this.donVi = donVi;
            this.soLuongHienTai = soLuong;

            lblTenThucAn.Text = $"Tên: {ten}";
            lblSoLuong.Text = $"Hiện còn: {soLuong} {donVi}";
            lblDonVi.Text = donVi;

            comboBoxChuong.Items.AddRange(new string[] { "B1", "B2", "D1", "D2", "G1", "G2", "H1", "H2", "V1", "V2", "Z0" });
            comboBoxChuong.SelectedIndex = 0;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int soLuongNhap = (int)numericSoLuong.Value;
            if (soLuongNhap > soLuongHienTai)
            {
                MessageBox.Show("Số lượng phân phối vượt quá số lượng hiện có.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string chuong = comboBoxChuong.SelectedItem.ToString();

            string updateQuery = "UPDATE ThucAnNuocUong SET soLuong = soLuong - @soLuong WHERE IDThucAn = @id";
            DataProvider.Instance.ExecuteNonQuery(updateQuery, new object[] { soLuongNhap, idThucAn });

            if (soLuongNhap == soLuongHienTai)
            {
                string deleteQuery = "DELETE FROM ThucAnNuocUong WHERE IDThucAn = @id";
                DataProvider.Instance.ExecuteNonQuery(deleteQuery, new object[] { idThucAn });
            }

            // TODO: Lưu lịch sử phân phối vào bảng khác

            MessageBox.Show("Phân phối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string insertHistory = "INSERT INTO dbo.PhanPhoiThucAn ( IDThucAn, soLuong, Chuong) VALUES ( @idThucAn , @soLuong , @chuong )";

            DataProvider.Instance.ExecuteNonQuery(insertHistory, new object[]
            {
               idThucAn, soLuongNhap, chuong
           });
           this.Close();

        }
        
    }
}
