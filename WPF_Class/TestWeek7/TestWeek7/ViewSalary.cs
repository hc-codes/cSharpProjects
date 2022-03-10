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
    public partial class ViewSalary : Form
    {
        Employee emp;
        public ViewSalary(Employee emp)
        {
            this.emp = emp;
            InitializeComponent();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(emp);
            employee.Show();
            this.Hide();
        }

        private void ViewSalary_Load(object sender, EventArgs e)
        {
            lblSalary.Text = emp.Salary.ToString();
        }
    }
}
