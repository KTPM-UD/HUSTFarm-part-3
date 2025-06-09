using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.DAO
{
    public class ThucAnDAO
    {
        string query = "EXEC dbo.USP_GetThucAnByIDorName @keyword";

        public DataTable GetThucAnByIDorName(string keyword)
        {
            return DataProvider.Instance.ExecuteQuery(query, new object[] { keyword });
        }
    }
}