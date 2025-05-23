using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public static class DatabaseHelper
    {
        private static string connectionString = @"Data Source=TUAN-PC;Initial Catalog=HeThongQuanLyChanNuoi;Integrated Security=True";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }

    public partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            txtIDVatNuoi = new TextBox();
            txtLoai = new TextBox();
            txtGiong = new TextBox();
            txtCanNang = new TextBox();
            txtTinhTrang = new TextBox();
            btnThem = new Button();
            dtpNgaySinh = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnXoaVatNuoi = new Button();
            SuspendLayout();
            // 
            // txtIDVatNuoi
            // 
            txtIDVatNuoi.Location = new Point(327, 79);
            txtIDVatNuoi.Name = "txtIDVatNuoi";
            txtIDVatNuoi.Size = new Size(300, 55);
            txtIDVatNuoi.TabIndex = 0;
            txtIDVatNuoi.TextChanged += textBox1_TextChanged;
            // 
            // txtLoai
            // 
            txtLoai.Location = new Point(327, 154);
            txtLoai.Name = "txtLoai";
            txtLoai.Size = new Size(300, 55);
            txtLoai.TabIndex = 1;
            // 
            // txtGiong
            // 
            txtGiong.Location = new Point(327, 233);
            txtGiong.Name = "txtGiong";
            txtGiong.Size = new Size(300, 55);
            txtGiong.TabIndex = 2;
            // 
            // txtCanNang
            // 
            txtCanNang.Location = new Point(327, 313);
            txtCanNang.Name = "txtCanNang";
            txtCanNang.Size = new Size(300, 55);
            txtCanNang.TabIndex = 3;
            // 
            // txtTinhTrang
            // 
            txtTinhTrang.Location = new Point(327, 387);
            txtTinhTrang.Name = "txtTinhTrang";
            txtTinhTrang.Size = new Size(300, 55);
            txtTinhTrang.TabIndex = 4;
            txtTinhTrang.TextChanged += textBox3_TextChanged;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(327, 621);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(300, 69);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += button1_Click;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(228, 500);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(600, 55);
            dtpNgaySinh.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 79);
            label1.Name = "label1";
            label1.Size = new Size(204, 48);
            label1.TabIndex = 7;
            label1.Text = "ID Vật Nuôi";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 161);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(85, 48);
            label2.TabIndex = 8;
            label2.Text = "Loại";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 240);
            label3.Name = "label3";
            label3.Size = new Size(0, 48);
            label3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 236);
            label4.Name = "label4";
            label4.Size = new Size(116, 48);
            label4.TabIndex = 10;
            label4.Text = "Giống";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 316);
            label5.Name = "label5";
            label5.Size = new Size(169, 48);
            label5.TabIndex = 11;
            label5.Text = "Cân nặng";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(64, 394);
            label6.Name = "label6";
            label6.Size = new Size(187, 48);
            label6.TabIndex = 12;
            label6.Text = "Tình Trạng";
            // 
            // btnXoaVatNuoi
            // 
            btnXoaVatNuoi.Location = new Point(684, 621);
            btnXoaVatNuoi.Name = "btnXoaVatNuoi";
            btnXoaVatNuoi.Size = new Size(225, 69);
            btnXoaVatNuoi.TabIndex = 13;
            btnXoaVatNuoi.Text = "Xóa";
            btnXoaVatNuoi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            ClientSize = new Size(996, 756);
            Controls.Add(btnXoaVatNuoi);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpNgaySinh);
            Controls.Add(btnThem);
            Controls.Add(txtTinhTrang);
            Controls.Add(txtCanNang);
            Controls.Add(txtGiong);
            Controls.Add(txtLoai);
            Controls.Add(txtIDVatNuoi);
            Name = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }
        public class VatNuoi
        {
            public string IDVatNuoi { get; set; }
            public string Loai { get; set; }
            public string Giong { get; set; }
            public DateTime NgaySinh { get; set; }
            public float CanNang { get; set; }
            public string TinhTrang { get; set; }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                VatNuoi vn = new VatNuoi
                {
                    IDVatNuoi = txtIDVatNuoi.Text,
                    Loai = txtLoai.Text,
                    Giong = txtGiong.Text,
                    NgaySinh = dtpNgaySinh.Value,
                    CanNang = float.Parse(txtCanNang.Text),
                    TinhTrang = txtTinhTrang.Text
                };

                if (VatNuoiDAO.ThemVatNuoi(vn))
                    MessageBox.Show("Thêm thành công");
                else
                    MessageBox.Show("Thêm thất bại");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        public class VatNuoiDAO
        {
            public static bool ThemVatNuoi(VatNuoi vn)
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = "INSERT INTO VatNuoi VALUES (@ID, @Loai, @Giong, @NgaySinh, @CanNang, @TinhTrang)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", vn.IDVatNuoi);
                    cmd.Parameters.AddWithValue("@Loai", vn.Loai);
                    cmd.Parameters.AddWithValue("@Giong", vn.Giong);
                    cmd.Parameters.AddWithValue("@NgaySinh", vn.NgaySinh);
                    cmd.Parameters.AddWithValue("@CanNang", vn.CanNang);
                    cmd.Parameters.AddWithValue("@TinhTrang", vn.TinhTrang);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }

            public static bool CapNhatVatNuoi(VatNuoi vn)
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = "UPDATE VatNuoi SET loai = @Loai, giong = @Giong, ngaySinh = @NgaySinh, canNang = @CanNang, tinhTrang = @TinhTrang WHERE IDVatNuoi = @ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", vn.IDVatNuoi);
                    cmd.Parameters.AddWithValue("@Loai", vn.Loai);
                    cmd.Parameters.AddWithValue("@Giong", vn.Giong);
                    cmd.Parameters.AddWithValue("@NgaySinh", vn.NgaySinh);
                    cmd.Parameters.AddWithValue("@CanNang", vn.CanNang);
                    cmd.Parameters.AddWithValue("@TinhTrang", vn.TinhTrang);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }

            public static bool XoaVatNuoi(string idVatNuoi)
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = "DELETE FROM VatNuoi WHERE IDVatNuoi = @ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", idVatNuoi);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }

            public static List<VatNuoi> LayDanhSach()
            {
                List<VatNuoi> ds = new List<VatNuoi>();
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT * FROM VatNuoi";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        VatNuoi vn = new VatNuoi
                        {
                            IDVatNuoi = reader["IDVatNuoi"].ToString(),
                            Loai = reader["loai"].ToString(),
                            Giong = reader["giong"].ToString(),
                            NgaySinh = Convert.ToDateTime(reader["ngaySinh"]),
                            CanNang = Convert.ToSingle(reader["canNang"]),
                            TinhTrang = reader["tinhTrang"].ToString()
                        };
                        ds.Add(vn);
                    }
                }
                return ds;
            }
        }
        private TextBox txtIDVatNuoi;
        private TextBox txtLoai;
        private TextBox txtGiong;
        private TextBox txtCanNang;
        private TextBox txtTinhTrang;
        private Button btnThem;
        private DateTimePicker dtpNgaySinh;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnXoaVatNuoi;
    }
    #endregion
}