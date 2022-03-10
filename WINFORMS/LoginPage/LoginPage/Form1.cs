using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class Form1 : Form
    {
        private string username = "";
        private string password = "";
        public string pass { get; set; } = "admin";
        private string uName = "admin";
        private Validator val = new Validator();

        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Submit.Enabled = false;
        }

        //Password
        private void txtPassword(object sender, EventArgs e)
        {
            string pVal = val.Validate(t2.Text);
            if (t2.Text != String.Empty)
            {
                if (t1.Text != String.Empty)
                    Submit.Enabled = true;
                label3.Visible = false;
                if (pVal != null)
                {
                    errorProvider1.SetError(t2, pVal);
                    t2.BackColor = Color.Yellow;
                }
                else
                {
                    t2.BackColor = SystemColors.Window;
                    errorProvider1.SetError(t2, null);
                }
            }
            else
            {
                errorProvider1.SetError(t2, pVal);
                label3.Visible = true;
                Submit.Enabled = false;
            }
        }

        //Username
        private void txtUserName(object sender, EventArgs e)
        {
            
            string uVal = val.Validate(t1.Text);
            if (t1.Text != String.Empty)
            {
                if (t2.Text != String.Empty)
                    Submit.Enabled = true;
                label2.Visible = false;
                if (uVal != null)
                {
                    errorProvider1.SetError(t1, uVal);
                    t1.BackColor = Color.Yellow;
                }
                else
                {
                    t1.BackColor = SystemColors.Window;
                    errorProvider1.SetError(t1, null);
                }
            }
            else
            {
                errorProvider1.SetError(t1, uVal);
                label2.Visible = true;
                Submit.Enabled = false;
            }
        }

        //Submit Click Event
        private void Submit_Click(object sender, EventArgs e)
        {
                username = t1.Text;
            password = t2.Text;
            bool isEmpty = false;
            // Check for empty username
            if (username == String.Empty)
            {
                t1.BackColor = Color.Yellow;
                isEmpty = true;
                SystemSounds.Exclamation.Play();
                MessageBox.Show($"Username can't be empty", "Alert", MessageBoxButtons.RetryCancel);
            }
            // Check for empty password
            else if (password == String.Empty)
            {
                isEmpty = true;
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Password Can't be empty", "Alert");
            }

            //Check for correct login credentials
            else if (username == uName && password == pass)
            {
                Form2 form2 = new Form2();
                form2.Tag = this;
                form2.Show(this);
                Hide();
            }

            //check for invalid username
            else if (username != uName)
            {
                MessageBox.Show("Invalid User", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            //check for invalid password
            else
            {
                MessageBox.Show("Wrong Password!!! Try Again!!!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                t2.Text = "";
            }
            if (!isEmpty)
                Submit.Enabled = true;
        }

        private void btnForget_Click(object sender, EventArgs e)
        {
            ChangePassword c = new ChangePassword();
            c.Show();
            this.Hide();
        }
    }
}