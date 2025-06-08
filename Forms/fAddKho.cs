using System;
using System.Windows.Forms;
using GiaoDien.DAO;

namespace GiaoDien.Forms
{
    public partial class fAddKho : Form
    {
        private fManager fManager;

        public fAddKho(fManager fManager)
        {
            InitializeComponent();
            this.fManager = fManager;
        }

        private void btnCancelAddKho_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmAddKho_Click(object sender, EventArgs e)
        {
            string tenKho = tbTenKho.Text.Trim();

            if (string.IsNullOrEmpty(tenKho))
            {
                MessageBox.Show("Vui lòng nhập tên kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng tên kho
            string checkQuery = "SELECT COUNT(*) FROM Kho WHERE tenKho = @tenKho ";
            int count = (int)DataProvider.Instance.ExecuteScalar(checkQuery, new object[] { tenKho });

            if (count > 0)
            {
                MessageBox.Show("Tên kho đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thêm kho
            string insertQuery = "INSERT INTO Kho (tenKho) VALUES ( @tenKho )";
            int rows = DataProvider.Instance.ExecuteNonQuery(insertQuery, new object[] { tenKho });

            if (rows > 0)
            {
                MessageBox.Show("Thêm kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm kho thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
