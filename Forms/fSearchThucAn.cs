using System;
using System.Data;
using System.Windows.Forms;
using GiaoDien.DAO;

namespace GiaoDien.Forms
{
    public partial class fSearchThucAn : Form
    {
        private FormQLTANU fQLTANU;

        public fSearchThucAn(FormQLTANU fQLTANU)
        {
            InitializeComponent();
            this.fQLTANU = fQLTANU;
        }

        private void tbSearchThucAn_TextChanged(object sender, EventArgs e)
        {
            // Có thể để trống hoặc dùng cho tìm kiếm tức thời nếu muốn
        }

        private void btnSearchform_Click(object sender, EventArgs e)
        {
            ThucAnDAO f = new ThucAnDAO();
            string keyword = tbSearchThucAn.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập ID hoặc tên thức ăn để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable ketQua = f.GetThucAnByIDorName(keyword);

            if (ketQua.Rows.Count > 0)
            {
                fQLTANU.LoadThucAnToGrid(ketQua);
                this.Close();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thức ăn với từ khóa: " + keyword, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
