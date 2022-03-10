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

namespace SqlBasics
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=BasicSql;Integrated Security=True");
            //String query = String.Format("insert into STUDENT(rollno,name) values({0},'{1}')", (txtUsername.Text), txtPassword.Text);
            String query = $"update STUDENT set name= '{txtName.Text}' where rollno= {txtUpdate.Text}";
            conn.Open();
            //SqlCommand command = new SqlCommand();
            SqlCommand command = new SqlCommand(query, conn);
            //command.Connection = conn;
            //command.CommandText = query;
            command.ExecuteNonQuery();
            conn.Close();
            command.Dispose();
            MessageBox.Show("Data Updated");
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
