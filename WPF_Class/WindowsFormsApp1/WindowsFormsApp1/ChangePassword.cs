using System;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            if (txt1.Text == txt2.Text)
                f.pass = txt1.Text;
            this.Close();
            f.Show();
        }
    }
}