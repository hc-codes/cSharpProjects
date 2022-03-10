using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class Form2 : Form
    {
        User user;
        public Form2(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string uName = txtUsername.Text;
            string password = txtPassword.Text;
            if (uName == user.UserName && password == user.Password)
            {
                MessageBox.Show("Login Succesful", "Success", MessageBoxButtons.OK);
                Application.Exit();
            }
            else
                MessageBox.Show("Wrong Credentials", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }
    }
}
