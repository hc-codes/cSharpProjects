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
    public partial class Form1 : Form
    {
        public static List<Employee> employees = new List<Employee>();
        Admin admin = new Admin();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            admin.UName = "admin";
            admin.Password = "admin";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool login = false;
            if (txtUsername.Text == admin.UName && txtPassword.Text == admin.Password)
            {
                login = true;
                admin.Show();
                this.Hide();
            }

            else
            {
                foreach (var item in employees)
                {
                    if (txtUsername.Text == item.UName && txtPassword.Text == item.Password)
                    {
                        login = true;
                        Employee emp = new Employee(item);
                        emp.Show();
                        this.Hide();
                    }
                } 
            }
            if (!login)
                MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.RetryCancel);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
