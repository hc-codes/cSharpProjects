using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLogin
{
    public class Validate
    {
        public bool ValidateLogin(string uname,string pass)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TestDatabase;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = $"select * from test where username='{uname}' and password='{pass}'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable data = new DataTable();
            sda.Fill(data);
            if (data.Rows.Count == 1)
                return true;
            else
             return false;

        }
    }
}
