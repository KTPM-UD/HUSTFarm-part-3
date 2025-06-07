using GiaoDien.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien.Forms
{
    public partial class FormQLTANU : Form
    {
        private fManager? fManager;
        public FormQLTANU(fManager fManager)
        {
            InitializeComponent();
            this.fManager = fManager;
        }
        public FormQLTANU()
        {
            InitializeComponent();
        }
        private void FormQLTANU_Load(object sender, EventArgs e)
        {
            LoadTheme();
            LoadThucAnList();
        }

        private void LoadTheme()
        {
            ApplyThemeToControls(this.Controls);
        }

        private void ApplyThemeToControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is Button btn)
                {
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
                if (control.HasChildren)
                    ApplyThemeToControls(control.Controls);
            }
        }

        public void LoadThucAnList()
        {
            string query = @"
                SELECT 
                    IDThucAn AS [Mã Thức Ăn],
                    ten AS [Tên],
                    loai AS [Loại],
                    soLuong AS [Số Lượng],
                    donVi AS [Đơn Vị],
                    hanSuDung AS [Hạn Sử Dụng],
                    maKho AS [Mã Kho]
                FROM ThucAnNuocUong";

            dtgvThucAn.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dtgvThucAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddThucAn f = new fAddThucAn();
            f.ShowDialog();
            LoadThucAnList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtgvThucAn.SelectedRows.Count > 0)
            {
                string? idThucAn = dtgvThucAn.SelectedRows[0].Cells["Mã Thức Ăn"].Value?.ToString();
                if (string.IsNullOrEmpty(idThucAn)) return;
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa thức ăn này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM ThucAnNuocUong WHERE IDThucAn = @id";
                    int rows = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idThucAn });
                    if (rows > 0)
                        MessageBox.Show("Xóa thành công!");
                    else
                        MessageBox.Show("Không tìm thấy để xóa!");
                    LoadThucAnList();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thức ăn cần xóa.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtgvThucAn.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thức ăn cần sửa.");
                return;
            }

            fUpdateThucAn f = new fUpdateThucAn(dtgvThucAn, this);
            f.ShowDialog();
            LoadThucAnList();
        }
        private void btnLichSu_Click(object sender, EventArgs e)
  {
            var lichSuForm = new fLichSuPhanPhoi();
            lichSuForm.ShowDialog();
      }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            fSearchThucAn f = new fSearchThucAn(this);
            f.ShowDialog();
        }
        private void btnDistribute_Click(object sender, EventArgs e)
{
    if (dtgvThucAn.SelectedRows.Count == 0)
    {
        MessageBox.Show("Vui lòng chọn thức ăn để phân phối.");
        return;
    }

    var row = dtgvThucAn.SelectedRows[0];
    string?id = row.Cells["Mã Thức Ăn"].Value?.ToString();
    string?ten = row.Cells["Tên"].Value?.ToString();
    string?donVi = row.Cells["Đơn Vị"].Value?.ToString();
    int soLuong = Convert.ToInt32(row.Cells["Số Lượng"].Value); 

    var form = new fDistributeThucAn(id, ten, donVi, soLuong);
    form.ShowDialog();
    LoadThucAnList();
}
        public void LoadThucAnToGrid(DataTable dt)
        {
            dtgvThucAn.DataSource = dt;
        }
    }
}
