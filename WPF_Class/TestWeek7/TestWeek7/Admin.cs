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
    public partial class Admin : Form,IUsers
    {
        public string UName { get; set; }
        public string Password { get; set; }
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
        }

    
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployee add = new AddEmployee();
            add.Show();
            this.Hide();
        }

 

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteEmployee del = new DeleteEmployee();
            del.Show();
            this.Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewEmployees view = new ViewEmployees();
            view.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            var add=new AddSalary();
            add.Show();
            this.Hide();
        }
    }
}
