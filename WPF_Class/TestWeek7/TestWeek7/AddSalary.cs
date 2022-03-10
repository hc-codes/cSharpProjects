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
    public partial class AddSalary : Form
    {
        public AddSalary()
        {
            InitializeComponent();
        }

        private void AddSalary_Load(object sender, EventArgs e)
        {

        }

  
        private void btnAddSalary_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (var item in Form1.employees)
            {
                if (item._Name == txtName.Text)
                {
                    found = true;
                    item.Salary = int.Parse(txtAddSalary.Text);
                    MessageBox.Show("Employee Salary Added successfully", "Salary Added", MessageBoxButtons.OK);
                    break;
                }
            }
            if(!found)
                MessageBox.Show( "Employee not found", "Error", MessageBoxButtons.RetryCancel);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
    }
}
