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
    public partial class fLogin : Form
    {
        private fManager? fManager;
        public fLogin(fManager f)
        {
            InitializeComponent();
            this.fManager = f;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btns.BackColor = ThemeColor.PrimaryColor;
                    btns.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            //label1.ForeColor = ThemeColor.PrimaryColor;
            //label2.ForeColor = ThemeColor.PrimaryColor;
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = tBtenDangNhapLogin.Text;
            string passWord = tBMatKhauLogin.Text;
            if (Login(userName, passWord))
            {
                tBMatKhauLogin.Clear();
                tBtenDangNhapLogin.Clear();
                this.fManager?.SuccessLogin();

            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //txbUsername.Focus();
            }
        }

        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }
    }
}
