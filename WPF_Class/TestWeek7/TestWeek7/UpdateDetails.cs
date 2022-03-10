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
    public partial class UpdateDetails : Form
    {
        Employee emp;
        public UpdateDetails(Employee emp)
        {
            this.emp = emp;
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
                MessageBox.Show( "Username or Password can't be empty!!!","Error", MessageBoxButtons.RetryCancel);
            else
            {
                emp.UName = txtUsername.Text;
                emp.Password = txtPassword.Text;
                txtPassword.Clear();
                txtUsername.Clear();
                MessageBox.Show( "Successfully Updated Details!!!", "Update Success", MessageBoxButtons.OK);

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(emp);
            employee.Show();
            this.Hide();
        }
    }
}
