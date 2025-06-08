using System;
using System.Data;
using System.Windows.Forms;
using GiaoDien.DAO;
#nullable disable
namespace GiaoDien.Forms
{
    public partial class fLichSuPhanPhoi : Form
    {
        public fLichSuPhanPhoi()
        {
            InitializeComponent();
            LoadLichSuPhanPhoi();
        }

        private void LoadLichSuPhanPhoi()
        {
            string query = @"
                SELECT ID, IDThucAn, soLuong, Chuong, NgayPhanPhoi
                FROM PhanPhoiThucAn
                ORDER BY NgayPhanPhoi DESC";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            dtgvLichSu.DataSource = dt;
            dtgvLichSu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadLichSuPhanPhoi();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
