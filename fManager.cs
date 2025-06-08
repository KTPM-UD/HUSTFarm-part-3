using GiaoDien.DAO;
using GiaoDien.Forms;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static GiaoDien.DAO.AccountDAO;
using System.Data;


namespace GiaoDien
{
    public partial class fManager : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public int checkSession = 0;
        public fManager()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.FormBorderStyle = FormBorderStyle.None; // Ẩn viền form
            this.DoubleBuffered = true; // Giảm flickering


        }

        private void fManager_Load(object sender, EventArgs e)
        {
            btnLogin.PerformClick();
            BtnFood.Visible = false;
            BtnLiveStock.Visible = false;
            BtnUsers.Visible = false;
            BtnWareHouse.Visible = false;
            tbTenDangNhapHome.Text = Session.Username;
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        public void ShowHomeScreen()
        {
            if (activeForm != null)
                activeForm.Close();

            lblTitle.Text = "Màn hình chính";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null!;
            btnCloseChildForm.Visible = false;

            DisableButton(); // bỏ màu các nút
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }

            }
        }

        public void UpdateUserInfo(string username, string role, string idNguoiDung)
        {
            Session.Username = username;
            Session.Role = role;
            Session.IDNguoiDung = idNguoiDung;
            tbIDHome.Text = idNguoiDung;
            tbTypeHome.Text = role == "0" ? "Nhân viên" : "Admin";
            tbTenDangNhapHome.Text = username;
            if (role == "0")
            {
                // Ẩn hoặc xóa tab quản lý người dùng
                BtnUsers.Visible = false;
                Reset(); // Reset các nút và tiêu đề về mặc định
            }
            else
            {
                BtnUsers.Visible = true; // Hiển thị tab quản lý người dùng nếu là admin
            }
        }
        public void SuccessSignUp()
        {
            btnLogin.PerformClick();
        }

        public void SuccessLogin()
        {
            this.DisplayMenuButtons(true);
            this.ShowHomeScreen();
            tbTenDangNhapHome.Text = Session.Username;
            if (Session.Role == "0")
            {
                tbTypeHome.Text = "Nhân viên";
            }
            else
            {
                tbTypeHome.Text = "Admin";
            }
            tbTotalLSHome.Text = Session.TotalLS.ToString();
            tbIDHome.Text = Session.IDNguoiDung != null ? Session.IDNguoiDung.ToString() : "";
            if (Session.Role == "0")
            {
                // Ẩn hoặc xóa tab quản lý người dùng
                BtnUsers.Visible = false;
            }
        }

        public void ReloadTotalLS()
        {
            // Cập nhật lại tổng vật nuôi
            string queryCount = "EXEC USP_TongVatNuoi @idNguoiDung";
            if (Session.IDNguoiDung == null)
            {
                Session.IDNguoiDung = string.Empty;
                return;
            }
            int total = (int)DataProvider.Instance.ExecuteScalar(queryCount, new object[] { Session.IDNguoiDung });
            Session.TotalLS = total;
            tbTotalLSHome.Text = Session.TotalLS.ToString();
        }
        public void ReloadAddLS()
        {
            BtnLiveStock.PerformClick();
        }

        //public void SuccessAddLS()
        //{
        //    BtnLiveStock.PerformClick();
        //}

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLKho(), sender);
        }

        private void BtnMainHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void BtnLiveStock_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLVN(this), sender);

        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLND(this), sender);

        }

        private void BtnFood_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLTANU(), sender);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "Màn hình chính";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null!;
            btnCloseChildForm.Visible = false;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); // Thoát ứng dụng
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fLogin(this), sender);
            btnCloseChildForm.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fSignUp(this), sender);
            btnCloseChildForm.Visible = false;
        }

        public void DisplayMenuButtons(bool display)
        {
            BtnFood.Visible = display;
            BtnLiveStock.Visible = display;
            BtnUsers.Visible = display;
            BtnWareHouse.Visible = display;
            btnLogin.Visible = !display;
            btnSignUp.Visible = !display;
            // Đổi chữ nút thoát thành "Đăng xuất" khi đăng nhập, ngược lại là "Thoát"
            button3.Text = display ? "Đăng xuất" : "Thoát";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tbIDHome_TextChanged(object sender, EventArgs e)
        {

        }

        private void fManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Session.Username == null)
            {
                // Chưa đăng nhập -> cho thoát ứng dụng
                return;
            }

            // Đã đăng nhập -> hỏi người dùng, nếu OK thì trở về màn hình đăng nhập
            if (MessageBox.Show("Bạn muốn đăng xuất và trở về màn hình đăng nhập?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // Reset session
                Session.Username = null;
                Session.Role = null;
                Session.IDNguoiDung = null;
                Session.TotalLS = 0;

                // Quay lại form đăng nhập
                DisplayMenuButtons(false);
                btnLogin.PerformClick();
                e.Cancel = true; // Ngăn việc đóng form chính
                button3.Text = "Thoát"; // Đổi chữ nút thoát về "Thoát" thay vì "Đăng xuất"

            }
            else
            {
                e.Cancel = true; // Hủy đóng nếu người dùng bấm Cancel
            }
        }

    }
}
