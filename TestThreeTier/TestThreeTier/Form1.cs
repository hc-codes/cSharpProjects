using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestThreeTier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BusinessLayer obj = new BusinessLayer();
            obj.Username = txtUsername.Text;
            obj.Password = txtPassword.Text;

            DataSet res = obj.GetSingleUsername();
            if (res.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("User already exist");
                txtUsername.Clear();
                txtPassword.Clear();
            }
            else
            {
                obj.AddRecord();
                MessageBox.Show("Inserted");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            BusinessLayer obj = new BusinessLayer();
            var r = obj.View();
            var res = obj.ViewItem();
            dataGridView1.DataSource = r.Tables[0];
           
            dataGridView1.Columns[1].HeaderText = "Username";
            dataGridView1.Columns[2].HeaderText = "Password";
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Label t1 = new Label();
            t1.Text = "new";
            Label t2 = new Label();
            t2.Text = "item";


            BusinessLayer obj = new BusinessLayer();
            obj.Username = txtUsername.Text;
            DataSet res = obj.GetSingleUsername();
            if (res.Tables[0].Rows.Count > 0)
            {
                if (txtPassword.Text == res.Tables[0].Rows[0]["pass"].ToString())
                {
                    MessageBox.Show("Success");
                }
                else
                    MessageBox.Show("Error");
            }
            else
                MessageBox.Show("User does not exist");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int q = int.Parse(textBox1.Text);
            BusinessLayer obj = new BusinessLayer();
            var res=obj.Check(q);
            var r = res.Tables[0].Rows[0]["quantity"].ToString();
            if (int.Parse(r) - q < 0)
                MessageBox.Show("Error");
            

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
