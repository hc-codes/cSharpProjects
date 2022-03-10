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
    public partial class Employee : Form
    {
        public string _Name { get; set; }
        public string UName { get; set; }
        public string Password { get; set; }
        public int Salary { get; set; }
        Employee emp;
        public Employee()
        {

        }
        public Employee(Employee item)
        {
            emp = item;
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            var update = new UpdateDetails(emp);
            update.Show();
            this.Hide();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            var view = new ViewSalary(emp);
            view.Show();
            this.Hide();
        }
    }
}
