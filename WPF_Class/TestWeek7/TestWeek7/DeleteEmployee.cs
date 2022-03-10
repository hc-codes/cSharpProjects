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
    public partial class DeleteEmployee : Form
    {
        public DeleteEmployee()
        {
            InitializeComponent();
        }
        Admin admin = new Admin();
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var delEmp = txtDelete.Text;
            var found = false;
            foreach (var item in Form1.employees??null)
            {
                if (item._Name == delEmp)
                {
                    found = true;
                    Form1.employees.Remove(item);
                    MessageBox.Show( "Employee details deleted successfully", "Delete Sucessful", MessageBoxButtons.OK);
                    txtDelete.Clear();
                    break;
                }
                
            }
            if (!found)
                MessageBox.Show("Employee not found", "Error", MessageBoxButtons.RetryCancel);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            admin.Show();
            this.Hide();
        }
    }
}
