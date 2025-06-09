using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using GiaoDien.DAO;

namespace GiaoDien.Forms
{
    public partial class fAddChuong : Form
    {
        private fManager fManager;

        public fAddChuong(fManager fManager)
        {
            InitializeComponent();
            this.fManager = fManager;
        }

        private void btnCancelAddChuong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmAddChuong_Click(object sender, EventArgs e)
        {
            string tenChuong = tbTenChuong.Text.Trim();
            string chuThich = tbChuThich.Text.Trim();

            if (string.IsNullOrEmpty(tenChuong) || string.IsNullOrEmpty(chuThich))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string checkQuery = "SELECT COUNT(*) FROM Chuong WHERE tenChuong = @tenChuong";
            int count = (int)DataProvider.Instance.ExecuteScalar(checkQuery, new object[] { tenChuong });

            if (count > 0)
            {
                MessageBox.Show("Tên chuồng đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string insertQuery = "INSERT INTO Chuong (tenChuong, chuThich) VALUES ( @tenChuong , @chuThich )";
            int rows = DataProvider.Instance.ExecuteNonQuery(insertQuery, new object[] { tenChuong, chuThich });

            if (rows > 0)
            {
                MessageBox.Show("Thêm chuồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm chuồng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
