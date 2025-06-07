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
        }

        private void LoadKho()
        {
            string query = "SELECT maKho, tenKho FROM Kho ORDER BY maKho ASC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            dtgvKho.DataSource = dt;
        }
    }
}
