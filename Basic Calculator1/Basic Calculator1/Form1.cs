using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Calculator1
{
    public partial class Form1 : Form
    {
        double n1 = 0;
        double n2 = 0;
        double res = 0.0;
        string op = "";
        public Form1()
        {
            InitializeComponent();
            Add.Checked = true;
            op = "+";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void oPERATIONsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            t1.Text = "";
            t2.Text = "";
            t3.Text = "";
        }

        private void Add_CheckedChanged(object sender, EventArgs e)
        {
            op = "+";
        }

        private void Sub_CheckedChanged(object sender, EventArgs e)
        {
            op = "-";
        }

        private void Mul_CheckedChanged(object sender, EventArgs e)
        {
            op = "*";
        }

        private void Div_CheckedChanged(object sender, EventArgs e)
        {
            op = "/";
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            res = 0.0;
            bool num1Check = double.TryParse(t1.Text, out n1);
            bool num2Check = double.TryParse(t2.Text, out n2);

            if (num1Check && num2Check)
            {
                switch (op)
                {
                    case "+":
                        res = n1 + n2;
                        t3.Text = res.ToString();
                        break;
                    case "-":
                        res = n1 - n2;
                        t3.Text = res.ToString();
                        break;
                    case "*":
                        res = n1 * n2;
                        t3.Text = res.ToString();
                        break;
                    case "/":
                        if (n2 != 0)
                        {
                            res = n1 / n2;
                            t3.Text = res.ToString();

                        }
                        else
                        {
                            MessageBox.Show("Division By Zero!!! Can't DIvide by Zero(the second number cannot be zero).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Invalid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void t1_TextChanged(object sender, EventArgs e)
        {

        }

        private void t2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
