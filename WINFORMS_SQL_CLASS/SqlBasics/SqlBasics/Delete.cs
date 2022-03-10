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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Delete_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=BasicSql;Integrated Security=True");
            String query = "select * from STUDENT";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=BasicSql;Integrated Security=True");
            String query = $"delete from STUDENT where rollno={txtDelete.Text}";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            Delete_Load(sender, e);
        }
    }
}
