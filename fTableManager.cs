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
using static HTQLCN.DAO.AccountDAO;

namespace HTQLCN
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();

            LoadAccountList();
            LoadLivestockList();
            tBUsernameMain.Text = Session.Username;
            tBTypeMain.Text = Session.Role;
            tBTotalMain.Text = Session.TotalLS.ToString();
            tBID.Text = Session.IDNguoiDung != null ? Session.IDNguoiDung.ToString() : "";
            if (Session.Role == "Nhân viên")
            {
                // Ẩn hoặc xóa tab quản lý người dùng
                tcQLCN.TabPages.Remove(tbUserManage);
            }
        }

        void LoadAccountList()
        {
            string query = "SELECT TenDangNhap AS [Tên đăng nhập] , TenHienThi AS [Tên hiển thị] , Email , LoaiTaiKhoan AS [Loại tài khoản] FROM dbo.TaiKhoan";

            dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dtgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        void LoadLivestockList()
        {
            string query = "SELECT IDVatNuoi AS [ID vật nuôi] , loai AS [Loại] , tenGiong AS [Giống] , tenChuong AS [Chuồng] , gioitinh AS [Giới tính] , ngaySinh AS [Ngày sinh] , canNang AS [Cân nặng] , IDNguoiDung AS [ID người dùng] FROM dbo.VatNuoi";

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

        public void CapNhatTongVatNuoi()
        {
            // Cập nhật lại tổng vật nuôi
            string queryCount = "EXEC USP_TongVatNuoi @idNguoiDung";
            if(Session.IDNguoiDung == null)
            {
                Session.IDNguoiDung = string.Empty;
                return;
            }
            int total = (int)DataProvider.Instance.ExecuteScalar(queryCount, new object[] { Session.IDNguoiDung });
            Session.TotalLS = total;
            tBTotalMain.Text = Session.TotalLS.ToString();
        }
        private void XoaVatNuoi()
        {
            // Kiểm tra có dòng nào được chọn không
            if (dtgvLivestock.SelectedRows.Count > 0)
            {
                // Lấy ID vật nuôi từ dòng được chọn
                string? idVatNuoi = dtgvLivestock.SelectedRows[0].Cells["ID vật nuôi"].Value?.ToString();
                string? idid = dtgvLivestock.SelectedRows[0].Cells["ID người dùng"].Value?.ToString();

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
                        int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idVatNuoi } );

                        if (rowsAffected > 0)
                        {
                            // Xóa khỏi DataGridView
                            dtgvLivestock.Rows.Remove(dtgvLivestock.SelectedRows[0]);
                            MessageBox.Show("Xóa vật nuôi thành công!");

                            CapNhatTongVatNuoi();
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
            XoaVatNuoi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadLivestockList();
            CapNhatTongVatNuoi();

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
            if (dtgvLivestock.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn vật nuôi cần cập nhật");
                return;
            }

            DataGridView selectedRow = dtgvLivestock;
            string? id = selectedRow.SelectedRows[0].Cells["ID vật nuôi"].Value?.ToString();

            // Mở form cập nhật với ID đã chọn
            fUpdateLiveStock f = new fUpdateLiveStock(selectedRow,this);
            f.ShowDialog();

            // Refresh danh sách sau khi cập nhật
            LoadLivestockList();
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
