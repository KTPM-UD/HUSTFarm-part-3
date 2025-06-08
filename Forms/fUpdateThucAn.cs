using GiaoDien.DAO;
using System;
using System.Windows.Forms;

namespace GiaoDien.Forms
{
    public partial class fUpdateThucAn : Form
    {
        private string idCu=string.Empty;
        private FormQLTANU formQLTANU;

        public fUpdateThucAn(DataGridView selectedRow, FormQLTANU form)
        {
            InitializeComponent();
            cbLoai.Items.AddRange(new object[] { "Thức ăn", "Nước uống" });
            cbLoai.DropDownStyle = ComboBoxStyle.DropDownList;

            cbMaKho.Items.AddRange(new object[] { "1", "2" });
            cbMaKho.DropDownStyle = ComboBoxStyle.DropDownList;

            cbLoai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaKho.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDonVi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDonVi.Items.AddRange(new string[] { "kg", "g", "lít", "ml", "bao", "chai", "viên", "túi", "thùng" });

            // Gán dữ liệu từ dòng được chọn
            string idCu = selectedRow.SelectedRows[0].Cells["Mã Thức Ăn"].Value?.ToString();
            tbTen.Text = selectedRow.SelectedRows[0].Cells["Tên"].Value?.ToString();
            cbLoai.SelectedItem = selectedRow.SelectedRows[0].Cells["Loại"].Value?.ToString();
            tbSoLuong.Text = selectedRow.SelectedRows[0].Cells["Số Lượng"].Value?.ToString();
            cbDonVi.SelectedItem = selectedRow.SelectedRows[0].Cells["Đơn Vị"].Value?.ToString();
            dtpHanSuDung.Value = Convert.ToDateTime(selectedRow.SelectedRows[0].Cells["Hạn Sử Dụng"].Value);
            cbMaKho.SelectedItem = selectedRow.SelectedRows[0].Cells["Mã Kho"].Value?.ToString();

            this.formQLTANU = form;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string ten = tbTen.Text.Trim();
            string loai = cbLoai.SelectedItem?.ToString();
            string donVi = cbDonVi.SelectedItem?.ToString();
            string maKhoStr = cbMaKho.SelectedItem?.ToString();
            DateTime hanSuDung = dtpHanSuDung.Value;

            if (string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(loai) ||
                string.IsNullOrWhiteSpace(donVi) || string.IsNullOrWhiteSpace(maKhoStr))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tbSoLuong.Text.Trim(), out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maKho = int.Parse(maKhoStr);

            string query = "UPDATE ThucAnNuocUong SET ten = @ten , loai = @loai , soLuong = @soLuong , donVi = @donVi , hanSuDung = @hanSuDung , maKho = @maKho WHERE IDThucAn = @idCu";

            int rows = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                ten, loai, soLuong, donVi, hanSuDung, maKho, idCu
            });

            if (rows > 0)
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.formQLTANU.LoadThucAnList();
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fUpdateThucAn_Load(object sender, EventArgs e)
        {
            // Khởi tạo nếu cần
        }
    }
}
