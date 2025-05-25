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
            LoadLivestockList();
        }

        void LoadAccountList()
        {
            string query = "SELECT TenHienThi AS [Tên hiển thị] , Email FROM dbo.TaiKhoan";

            dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dtgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        void LoadLivestockList()
        {
            string query = "SELECT IDVatNuoi AS [ID vật nuôi] , loai AS [Loại] , tenGiong AS [Giống] , tenChuong AS [Chuồng] , gioitinh AS [Giới tính] , ngaySinh AS [Ngày sinh] , canNang AS [Cân nặng] , IDNguoiDung FROM dbo.VatNuoi";

            dtgvLivestock.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dtgvLivestock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public void LoadAccountToDataGridView(DataTable dt)
        {
            dtgvAccount.DataSource = dt;
        }

        public void LoadLivestockToDataGridView(DataTable dt)
        {
            dtgvLivestock.DataSource = dt;
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
            LoadLivestockList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fSearchLivestock f = new fSearchLivestock(this);
            f.ShowDialog();
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

        private void BtnSearch1_Click(object sender, EventArgs e)
        {
            fSearchUser f = new fSearchUser(this);
            f.ShowDialog();
        }

        private void BtnRefresh1_Click(object sender, EventArgs e)
        {
            LoadAccountList();
        }
    }
}
