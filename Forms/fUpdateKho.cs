using System;
using System.Windows.Forms;
using GiaoDien.DAO;

namespace GiaoDien.Forms
{
    public partial class fEditKho : Form
    {
        private int maKhoCu;
        private string tenKhoCu;

        public fEditKho(int maKho, string tenKho)
        {
            InitializeComponent();
            tbTenKho.Text = tenKho;
            maKhoCu = maKho;
            tenKhoCu = tenKho;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenKhoMoi = tbTenKho.Text.Trim();

            if (string.IsNullOrEmpty(tenKhoMoi))
            {
                MessageBox.Show("Tên kho không được để trống.");
                return;
            }

            // Kiểm tra tên mới có bị trùng không (trừ khi không đổi tên)
            if (!tenKhoMoi.Equals(tenKhoCu, StringComparison.OrdinalIgnoreCase))
            {
                string checkQuery = "SELECT COUNT(*) FROM Kho WHERE tenKho = @tenKho ";
                int count = (int)DataProvider.Instance.ExecuteScalar(checkQuery, new object[] { tenKhoMoi });

                if (count > 0)
                {
                    MessageBox.Show("Tên kho đã tồn tại. Vui lòng chọn tên khác.");
                    return;
                }
            }

            // Cập nhật tên kho
            string query = "UPDATE Kho SET tenKho = @tenKhoMoi WHERE maKho = @maKho ";
            int rows = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenKhoMoi, maKhoCu });

            if (rows > 0)
                MessageBox.Show("Cập nhật kho thành công!");
            else
                MessageBox.Show("Cập nhật kho thất bại.");

            this.Close();
        }
    }
}
