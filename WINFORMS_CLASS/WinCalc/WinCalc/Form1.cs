using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCalc
{
    public partial class Form1 : Form
    {
        double a, b;
        int f = 0;
        double res = 0.0;
        private string op1 = "", op2 = "", operator1;
        string[] oprArr = { "+", "-", "X", "/" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            op1 = op2 = operator1 = null;
            lblScreen.Text = "0";
            f = 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (lblScreen.Text == "0")
                lblScreen.Text = "";
            if (string.IsNullOrWhiteSpace(op1) || lblScreen.Text.EndsWith(".") && operator1 == default)
            {
                op1 += btn.Text;
            }
            else
            {
                op2 += btn.Text;
            }
            lblScreen.Text += btn.Text;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            char rem = lblScreen.Text.ElementAt(lblScreen.Text.Length - 1);
            if (rem.ToString() == "=")
                f = 0;
            if (lblScreen.Text != "")
                lblScreen.Text = lblScreen.Text.Remove(lblScreen.Text.Length - 1);
            else
                btnCancel_Click(null, null);
            if (op2 != "")
                op2 = op2.Remove(op2.Length - 1);
            else if (operator1 != "")
                operator1 = "";
            else if (op1 != "")
                op1 = op1.Remove(op1.Length - 1);
            else
                return;



        }

        private void btnDot_Click(object sender, EventArgs e)
        {

            if (lblScreen.Text.EndsWith("."))
                return;
            Button btn = (Button)sender;
            if (lblScreen.Text.EndsWith(".") && operator1 == default)
            {
                op1 += btn.Text;
            }
            else
            {
                op2 += btn.Text;
            }
            lblScreen.Text += ".";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            foreach (var item in oprArr)
            {
                if (lblScreen.Text.EndsWith(item + " "))
                    return;
            }
            lblScreen.Text += " " + btn.Text + " ";
            operator1 = btn.Text;

        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (f == 1)
                return;
            f++;

            if (lblScreen.Text == "0")
            {
                btnCancel_Click(sender, e);
                return;
            }

            a = double.Parse(op1);
            b = double.Parse(op2);

            switch (operator1)
            {
                case "+":
                    res = a + b;
                    break;
                case "-":
                    res = a - b;
                    break;
                case "X":
                    res = a * b;
                    break;
                case "/":
                    res = a / b;
                    break;


            }
            lblScreen.Text += " = " + res.ToString();
        }
    }
}




//double a, res = 0;
//string s = "";
//foreach (var ch in lblScreen.Text)
//{
//    var item = ch.ToString();
//    int f = 1;
//    foreach (var opr in oprArr)
//    {
//        if (item.ToString() == opr || item.ToString() == " ")
//            f = 0;
//    }
//    if (f == 1)
//        s = s + item;
//    if (item.ToString() == " ")
//        continue;
//    else
//    {
//        switch (item.ToString())
//        {
//            case "+":
//                res += double.Parse(s);
//                break;
//            case "-":
//                res -= double.Parse(s);
//                break;
//            case "X":
//                res *= double.Parse(s);
//                break;
//            case "/":
//                res /= double.Parse(s);
//                break;
//        }

//    }
//}
//lblScreen.Text += " = " + res.ToString() + " ";