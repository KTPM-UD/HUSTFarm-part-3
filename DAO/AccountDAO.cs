using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace GiaoDien.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private AccountDAO() { }

        // SQL query to get account by username
        string query = "EXEC dbo.USP_GetAccountByUserID @IDNguoiDung";

        public DataTable GetAccountByUserName(string IDNguoiDung)
        {
            return DataProvider.Instance.ExecuteQuery(query, new object[] { IDNguoiDung });
        }

        public static class Session
        {
            public static string  Username { get; set; }

            public static string  Role { get; set; }

            public static int  TotalLS { get; set; }

            public static string IDNguoiDung { get; set; }

        }
        public bool Login(string username, string password)
        {
            string query = "EXEC dbo.USP_Login @tenDangNhap , @matKhau";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                Session.Username = username;

                //Phân quyền
                if (row["LoaiTaiKhoan"].ToString() == "1")
                {
                    Session.Role = "1";
                }
                else
                {
                    Session.Role = "0";
                }
                string idNguoiDung = row["IDNguoiDung"]?.ToString() ?? string.Empty;

                //Lấy tổng số lượng vật nuôi của người dùng
                string query1 = "SELECT COUNT(*) FROM VatNuoi WHERE IDNguoiDung = @id";
                int total = (int)DataProvider.Instance.ExecuteScalar(query1, new object[] { idNguoiDung });
                Session.TotalLS = total;
                Session.IDNguoiDung = idNguoiDung;
            }
            return result.Rows.Count > 0;
        }
    }
}
