using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GiaoDien.DAO
{
    public class DataProvider
    {
        private static DataProvider instance; //Ctrl + R + E: đóng gói
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }
            private set { instance = value; }
        }
        private DataProvider() { }

        //Chuỗi kết nối đến cơ sở dữ liệu
        private string connectionSTR = @"Data Source=Tuan-PC;Initial Catalog=HeThongQuanLyChanNuoi;Integrated Security=True;Trust Server Certificate=True";

        //Trả về một DataTable từ câu truy vấn
        public DataTable ExecuteQuery(string query, object[]  parameters = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    // Tìm các tham số trong chuỗi query
                    string[] listPara = query.Split(' ');
                    int i = 0;

                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();

                //dtgvAccount.DataSource = data;
            }
            return data;
        }

        //Trả ra số dòng thành công
        public int ExecuteNonQuery(string query, object[]  parameters = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    // Tìm các tham số trong chuỗi query
                    string[] listPara = query.Split(' ');
                    int i = 0;

                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();

                //dtgvAccount.DataSource = data;
            }
            return data;
        }

        //Trả về giá trị đầu tiên của câu truy vấn
        public object ExecuteScalar(string query, object[] parameters)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                // đoạn này thêm tham số nếu có
                if (parameters != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();

                connection.Close();

                return data;
            }
        }
    }
}
