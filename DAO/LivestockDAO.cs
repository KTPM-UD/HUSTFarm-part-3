﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.DAO
{
    public class LivestockDAO
    {
        string query = "EXEC dbo.USP_GetLivestockByID @IDVatNuoi";

        public DataTable GetLivestockByID(string idvatNuoi)
        {
            return DataProvider.Instance.ExecuteQuery(query, new object[] { idvatNuoi });
        }
    }
}
