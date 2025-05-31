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
    public partial class fSearchLS : Form
    {
        private FormQLVN fQLVN;
        public fSearchLS(FormQLVN fQLVN)
        {
            InitializeComponent();
            this.fQLVN = fQLVN;
        }

        private void tbSearchLS_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchform_Click(object sender, EventArgs e)
        {
            LivestockDAO f = new LivestockDAO();
            string idVatNuoi = tbSearchLS.Text.Trim();
            if (string.IsNullOrEmpty(idVatNuoi))
            {
                MessageBox.Show("Vui lòng nhập id vật nuôi để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable ketQua = f.GetLivestockByID(idVatNuoi);
            if (ketQua.Rows.Count > 0)
            {
                fQLVN.LoadLivestockToDataGridView(ketQua);
                this.Close();
            }
            else
            {
                MessageBox.Show("Không tìm thấy vật nuôi với ID: " + idVatNuoi, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
