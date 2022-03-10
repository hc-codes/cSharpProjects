using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Class1.Show());
            Validate v = new Validate();
            var res = v.ValidateLogin(t1.Text, t2.Text);
            if (res)
            {
                Form2 form = new Form2();
                form.Show();
                this.Hide();
            }
        }
    }
}
