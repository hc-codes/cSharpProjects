using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp
{
    public partial class Form1 : Form
    {
        double total = 0;
        string op = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {

            Screen.Text = Screen.Text + "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "8";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "9";

        }
        private void button10_Click(object sender, EventArgs e)
        {

        }
        private void button14_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "-";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "*";

        }

       

        private void add_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "+";
             var c= Screen.Text.Split('+');


        }

        private void div_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "/";

        }

        private void dot_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + ".";

        }

        private void equal_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "=";

            
        }

        private void Screen_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn(object sender, EventArgs e)
        {

        }
    }
}
