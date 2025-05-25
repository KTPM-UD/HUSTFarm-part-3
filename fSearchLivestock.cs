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
    public partial class fSearchLivestock : Form
    {
        private fTableManager mainForm;
        public fSearchLivestock(fTableManager mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void BtnSearchLivestock_Click(object sender, EventArgs e)
        {
            LivestockDAO f = new LivestockDAO();
            string idVatNuoi = TbLivestockSearch.Text.Trim();
            DataTable ketQua = f.GetLivestockByID(idVatNuoi);
            if (ketQua.Rows.Count > 0)
            {
                mainForm.LoadLivestockToDataGridView(ketQua);
                this.Close();
            }
            else
            {
                MessageBox.Show("Không tìm thấy vật nuôi với ID: " + idVatNuoi, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
