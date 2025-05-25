using HTQLCN.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTQLCN
{
    public partial class fSearchUser : Form
    {
        private fTableManager mainForm;
        public fSearchUser(fTableManager mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void BtnSearchUser_Click(object sender, EventArgs e)
        {
            string tenDangNhap = TbUsernameSearch.Text.Trim();
            DataTable ketQua = AccountDAO.Instance.GetAccountByUserName(tenDangNhap);
            if (ketQua.Rows.Count > 0)
            {
                mainForm.LoadAccountToDataGridView(ketQua);
                this.Close();
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản với tên đăng nhập: " + tenDangNhap, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
            //this.Close();
        }
    }
}
