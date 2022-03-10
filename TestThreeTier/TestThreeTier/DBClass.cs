using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestThreeTier
{
    class DBClass
    {
        internal static void Insert(string q)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ThreeTier;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand command = new SqlCommand(q, conn);
            command.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            
        }
        //internal static void Update(string q)
        //{
        //    string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ThreeTier;Integrated Security=True";
        //    SqlConnection conn = new SqlConnection(connectionString);
        //    conn.Open();
        //    SqlCommand command = new SqlCommand(q, conn);
        //    command.ExecuteNonQuery();
        //    conn.Close();
        //    conn.Dispose();

        //}

        internal static DataSet Select(string q)
        {

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ThreeTier;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(q, conn);
            DataSet data = new DataSet();
            adapter.Fill(data);
            conn.Close();
            conn.Dispose();
            return data;
        }
    }
}
