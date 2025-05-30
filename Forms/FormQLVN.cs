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
using static GiaoDien.DAO.AccountDAO;

namespace GiaoDien.Forms
{
    public partial class FormQLVN : Form
    {
        private fManager? fManager;
        public FormQLVN(fManager fManager)
        {
            InitializeComponent();
            this.fManager = fManager;
        }

        private void LoadTheme()
        {
            ApplyThemeToControls(this.Controls);
            //label4.ForeColor = ThemeColor.PrimaryColor;
            LoadLivestockList();
        }

        void LoadLivestockList()
        {
            string query = "SELECT IDVatNuoi AS [ID vật nuôi] , loai AS [Loại] , tenGiong AS [Giống] , tenChuong AS [Chuồng] , gioitinh AS [Giới tính] , ngaySinh AS [Ngày sinh] , canNang AS [Cân nặng] , IDNguoiDung AS [ID người dùng] FROM dbo.VatNuoi";

            dtgvLiveStock.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dtgvLiveStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
                // Nếu control chứa các controls con, gọi đệ quy
                if (control.HasChildren)
                {
                    ApplyThemeToControls(control.Controls);
                }
            }
        }

        private void FormQLVN_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btnAddLS_Click(object sender, EventArgs e)
        {
            fAddLS fAddLS = new fAddLS(fManager!);
            fAddLS.ShowDialog();
        }

        private void XoaVatNuoi()
        {
            // Kiểm tra có dòng nào được chọn không
            if (dtgvLiveStock.SelectedRows.Count > 0)
            {
                // Lấy ID vật nuôi từ dòng được chọn
                string? idVatNuoi = dtgvLiveStock.SelectedRows[0].Cells["ID vật nuôi"].Value?.ToString();

                // Xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa vật nuôi này?",
                                                   "Xác nhận xóa",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Thực hiện xóa từ database
                        string query = "DELETE FROM VatNuoi WHERE IDVatNuoi = @id";
                        if (string.IsNullOrEmpty(idVatNuoi)) return;
                        int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idVatNuoi });

                        if (rowsAffected > 0)
                        {
                            // Xóa khỏi DataGridView
                            dtgvLiveStock.Rows.Remove(dtgvLiveStock.SelectedRows[0]);
                            MessageBox.Show("Xóa vật nuôi thành công!");

                            this.fManager?.ReloadTotalLS();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy vật nuôi để xóa!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa vật nuôi: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn vật nuôi cần xóa!");
            }
        }

        private void btnDeleteLS_Click(object sender, EventArgs e)
        {
            XoaVatNuoi();
        }

        private void btnUpdateLS_Click(object sender, EventArgs e)
        {
            if (dtgvLiveStock.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn vật nuôi cần cập nhật");
                return;
            }

            DataGridView selectedRow = dtgvLiveStock;
            string? id = selectedRow.SelectedRows[0].Cells["ID vật nuôi"].Value?.ToString();

            // Mở form cập nhật với ID đã chọn
            fUpdateLS f = new fUpdateLS(selectedRow, this.fManager!);
            f.ShowDialog();

            // Refresh danh sách sau khi cập nhật
            LoadLivestockList();
        }

        public void LoadLivestockToDataGridView(DataTable dt)
        {
            dtgvLiveStock.DataSource = dt;
        }

        private void btnSearchLS_Click(object sender, EventArgs e)
        {
            fSearchLS fSearch = new fSearchLS(this);
            fSearch.ShowDialog();
        }
    }
}
