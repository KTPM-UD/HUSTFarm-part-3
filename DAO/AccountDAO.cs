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
        string query = "EXEC dbo.USP_GetAccountByUserName @tenDangNhap";

        public DataTable GetAccountByUserName(string tenDangNhap)
        {
            return DataProvider.Instance.ExecuteQuery(query, new object[] { tenDangNhap });
        }
    }
}
