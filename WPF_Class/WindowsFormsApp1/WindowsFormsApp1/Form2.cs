using System;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form1 = new LoginForm();
            form1.Tag = this;
            form1.Show(this);
            Hide();
        }
    }
}
