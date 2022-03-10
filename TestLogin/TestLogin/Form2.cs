using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestLogin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TestDatabase;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = $"select * from item";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0].DefaultView;


            //SqlCommand command = new SqlCommand(query, conn);
            //SqlDataReader reader = command.ExecuteReader();
            //lvShow.Items.Clear();
            
            //while (reader.Read())
            //{
            //    ListViewItem lv = new ListViewItem(reader.GetInt32(0).ToString());
            //    lv.SubItems.Add(reader.GetString(1));
            //    lv.SubItems.Add(reader.GetString(2));
            //    lvShow.Items.Add(lv);
            //}
            //reader.Close();
            conn.Close();

        }
    }
}
