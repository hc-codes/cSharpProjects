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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=BasicSql;Integrated Security=True");
            //String query = String.Format("insert into STUDENT(rollno,name) values({0},'{1}')", (txtUsername.Text), txtPassword.Text);
            String query = $"insert into STUDENT(rollno,name) values( {txtRollNo.Text}, '{txtName.Text}')";
            conn.Open();
            //SqlCommand command = new SqlCommand();
            SqlCommand command = new SqlCommand(query,conn);
            //command.Connection = conn;
            //command.CommandText = query;
            command.ExecuteNonQuery();
            conn.Close();
            command.Dispose();
            MessageBox.Show("Data inserted");   
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var update = new Update();
            update.Show();
            this.Hide();
        }
    }
}
    