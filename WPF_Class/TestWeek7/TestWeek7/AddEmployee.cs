using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWeek7
{
    public partial class AddEmployee : Form
    {
        Admin admin = new Admin();
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPassword.Text == "" || txtUname.Text == "")
            {
                MessageBox.Show("Name, Username or Password can't be empty!!!", "Error", MessageBoxButtons.RetryCancel);
                return;
            }
            Form1.employees.Add(new Employee { _Name = txtName.Text, UName = txtUname.Text, Password = txtPassword.Text, Salary = 0 });
            MessageBox.Show("Success");
            txtName.Clear();
            txtPassword.Clear();
            txtUname.Clear();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            admin.Show();
            this.Hide();
        }
    }
}
