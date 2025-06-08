using System;
using System.Data;
using System.Windows.Forms;
using GiaoDien.DAO;

namespace GiaoDien.Forms
{
    public partial class FormQLKho : Form
    {
        public FormQLKho()
        {
            InitializeComponent();
        }

        private void FormQLKho_Load(object sender, EventArgs e)
        {
            LoadKho();
            LoadChuong();
        }

        private void LoadKho()
        {
            string query = "SELECT maKho AS [Mã kho], tenKho AS [Tên kho] FROM Kho ORDER BY maKho ASC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            dtgvKho.DataSource = dt;
        }

        private void LoadChuong()
        {
            string query = "SELECT tenChuong AS [Tên chuồng], chuThich AS [Chú thích] FROM Chuong ORDER BY tenChuong ASC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            dtgvChuong.DataSource = dt;
        }
    }
}
