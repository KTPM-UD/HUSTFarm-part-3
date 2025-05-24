using HTQLCN.DAO;
using System;
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
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();

            LoadAccountList();
        }

        void LoadAccountList()
        {
            string query = "SELECT TenHienThi AS [Tên hiển thị], Email FROM dbo.TaiKhoan";
            //query = "EXEC dbo.USP_GetAccountByUserName @tenDangNhap = N'tuank4'";
            DataProvider provider = new DataProvider();

            dtgvAccount.DataSource = provider.ExecuteQuery(query);
            dtgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void fTableManager_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddLivestock f = new fAddLivestock();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            fUpdateLiveStock f = new fUpdateLiveStock();
            f.ShowDialog();
        }
    }
}
