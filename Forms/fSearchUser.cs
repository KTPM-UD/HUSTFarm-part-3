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
            string IDNguoiDung = tbSearchUser.Text.Trim();
            if (string.IsNullOrEmpty(IDNguoiDung))
            {
                MessageBox.Show("Vui lòng nhập ID người dùng để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable ketQua = AccountDAO.Instance.GetAccountByUserName(IDNguoiDung);
            if (ketQua.Rows.Count > 0)
            {
                this.fQLND.LoadAccountToDataGridView(ketQua);
                this.Close();
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản với ID người dùng: " + IDNguoiDung, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
