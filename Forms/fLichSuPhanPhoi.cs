using GiaoDien.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                SELECT ID, IDThucAn, soLuong, tenChuong, NgayPhanPhoi
                FROM PhanPhoiThucAn
                ORDER BY NgayPhanPhoi DESC";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            dtgvLichSu.DataSource = dt;
            dtgvLichSu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadLichSuPhanPhoi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
