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

namespace GiaoDien.Forms
{
    public partial class fSearchUser : Form
    {
        private FormQLND fQLND;
        public fSearchUser(FormQLND fQLND)
        {
            InitializeComponent();
            this.fQLND = fQLND;
        }

        private void btnSearchUSER_Click(object sender, EventArgs e)
        {
            string tenDangNhap = tbSearchUser.Text.Trim();
            if (string.IsNullOrEmpty(tenDangNhap))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable ketQua = AccountDAO.Instance.GetAccountByUserName(tenDangNhap);
            if (ketQua.Rows.Count > 0)
            {
                this.fQLND.LoadAccountToDataGridView(ketQua);
                this.Close();
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản với tên đăng nhập: " + tenDangNhap, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
