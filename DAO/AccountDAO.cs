using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace HTQLCN.DAO
{
    public class AccountDAO
    {
        private static AccountDAO? instance;
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
        string query = "EXEC dbo.USP_GetAccountByUserName @tenDangNhap";

        public DataTable GetAccountByUserName(string tenDangNhap)
        {
            return DataProvider.Instance.ExecuteQuery(query, new object[] { tenDangNhap });
        }

        public bool Login(string username, string password)
        {
            string query = "EXEC dbo.USP_Login @tenDangNhap , @matKhau";
            
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });

            return result.Rows.Count > 0;
        } 
    }
}
