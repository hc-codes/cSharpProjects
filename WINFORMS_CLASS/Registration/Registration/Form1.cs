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
    public partial class Form1 : Form
    {
        public static string pass = "hari"; //can be accessed using Form1.pass;
        User user = new User();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
                MessageBox.Show( "Username or Password can't be empty", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            user.UserName = txtUsername.Text;
            user.Password = txtPassword.Text;
            var value = optMale.Checked ? optMale.Text : optFemale.Text;
            var chkPy = chkPython.Checked ? chkPython.Text : null;
            var chkjava= chkJava.Checked ? chkJava.Text : null;
            var chkcpp = chkCpp.Checked ? chkCpp.Text : null;
            var chkcsharp = chkCSharp.Checked ? chkCSharp.Text : null;
            MessageBox.Show($"Country: {cbCountry.Text.ToUpper()}\t" +
                $"State: {cbState.Text.ToUpper()}\n\nGender: {value}\tBOB: {dtDOB.Text}\n\n\nLanguages known\n\n" +
                $"{chkPy}\n{chkjava}\n{chkcsharp}\n{chkcpp}", "Success");
            var form2 = new Form2(user);
            form2.Show();
            this.Hide();

        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCountry.Text.ToLower()=="india")
            {
                cbState.Items.Add("Kerala");
                cbState.Items.Add("Maharastra");
                cbState.Items.Add("Tamil Nadu");
            }
            if (cbCountry.Text.ToLower() == "australia")
            {
                cbState.Items.Add("Victoria");
                cbState.Items.Add("Tasmania");
                cbState.Items.Add("Queensland");
            }
        }
    }
}
