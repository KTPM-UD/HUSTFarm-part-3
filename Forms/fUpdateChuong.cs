using System;
using System.Windows.Forms;
using GiaoDien.DAO;

namespace GiaoDien.Forms
{
    public partial class fEditChuong : Form
    {
        private string tenChuongCu;

        public fEditChuong(string tenChuong, string chuThich)
        {
            InitializeComponent();
            tbTenChuong.Text = tenChuong;
            tbChuThich.Text = chuThich;
            tenChuongCu = tenChuong;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenChuongMoi = tbTenChuong.Text.Trim();
            string chuThich = tbChuThich.Text.Trim();

            if (string.IsNullOrEmpty(tenChuongMoi))
            {
                MessageBox.Show("Tên chuồng không được để trống.");
                return;
            }

            string query = "UPDATE Chuong SET tenChuong = @tenMoi , chuThich = @chuThich WHERE tenChuong = @tenCu ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenChuongMoi, chuThich, tenChuongCu });

            if (result > 0)
                MessageBox.Show("Cập nhật chuồng thành công!");
            else
                MessageBox.Show("Cập nhật thất bại.");

            this.Close();
        }
    }
}
