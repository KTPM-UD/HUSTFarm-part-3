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
    public partial class fUpdateTANU : Form
    {
        private string idCu = string.Empty; // ID cũ của thức ăn để cập nhật theo
        private FormQLTANU formQLTANU;      // Form cha để reload dữ liệu sau cập nhật
        public fUpdateTANU(DataGridView selectedRow, FormQLTANU form)
        {
            InitializeComponent();
            cbLoai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaKho.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDonVi.DropDownStyle = ComboBoxStyle.DropDownList;
            // Gán dữ liệu từ dòng được chọn
            this.idCu = selectedRow.SelectedRows[0].Cells["Mã Thức Ăn"].Value?.ToString();
            tbTen.Text = selectedRow.SelectedRows[0].Cells["Tên"].Value?.ToString();
            cbLoai.SelectedItem = selectedRow.SelectedRows[0].Cells["Loại"].Value?.ToString();
            tbSoLuong.Text = selectedRow.SelectedRows[0].Cells["Số Lượng"].Value?.ToString();
            cbDonVi.SelectedItem = selectedRow.SelectedRows[0].Cells["Đơn Vị"].Value?.ToString();

            // Chuyển đổi hạn sử dụng từ chuỗi sang DateTime
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
            // Lấy thông tin từ form
            string ten = tbTen.Text.Trim();
            string loai = cbLoai.SelectedItem?.ToString();
            string donVi = cbDonVi.SelectedItem?.ToString();
            string maKhoStr = cbMaKho.SelectedItem?.ToString();
            DateTime hanSuDung = dtpHanSuDung.Value;

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(loai) ||
                string.IsNullOrWhiteSpace(donVi) || string.IsNullOrWhiteSpace(maKhoStr))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra số lượng
            if (!int.TryParse(tbSoLuong.Text.Trim(), out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maKho = int.Parse(maKhoStr);

            // Câu truy vấn cập nhật
            string query = @"
                UPDATE ThucAnNuocUong 
                SET ten = @ten , loai = @loai , soLuong = @soLuong , 
                    donVi = @donVi , hanSuDung = @hanSuDung , maKho = @maKho 
                WHERE IDThucAn = @idCu";

            // Thực hiện truy vấn
            int rows = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                ten, loai, soLuong, donVi, hanSuDung, maKho, idCu
            });

            // Thông báo kết quả
            if (rows > 0)
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.formQLTANU.LoadThucAnList(); // Refresh lại danh sách
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbLoai.SelectedItem?.ToString())
            {
                case "Thức ăn":
                    cbMaKho.SelectedItem = "1";
                    break;
                case "Nước uống":
                    cbMaKho.SelectedItem = "2";
                    break;
                case "Thuốc":
                    cbMaKho.SelectedItem = "3";
                    break;
            }
        }
    }
}
