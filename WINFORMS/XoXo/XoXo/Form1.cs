using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XoXo
{
    public partial class Form1 : Form
    {
        int count=0;
        bool turn = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (turn)
                btn.Text = "X";
            else
                btn.Text = "O";
            turn = !turn;
            btn.Enabled = false;
            count++;
            CheckWinner();
        }
        private void CheckWinner()
        {
            bool iswinner = false;
            if (btn1.Text == btn2.Text && btn2.Text == btn3.Text && !btn1.Enabled)
                iswinner = true;
            else if (btn4.Text == btn5.Text && btn5.Text == btn6.Text && !btn4.Enabled)
                iswinner = true;
            else if (btn7.Text == btn8.Text && btn8.Text == btn9.Text && !btn7.Enabled)
                iswinner = true;


            else if (btn1.Text == btn4.Text && btn4.Text == btn7.Text && !btn1.Enabled)
                iswinner = true;
            else if (btn2.Text == btn5.Text && btn5.Text == btn6.Text && !btn2.Enabled)
                iswinner = true;
            else if (btn3.Text == btn6.Text && btn6.Text == btn9.Text && !btn3.Enabled)
                iswinner = true;


            else if (btn1.Text == btn5.Text && btn5.Text == btn9.Text && !btn1.Enabled)
                iswinner = true;
            else if(btn3.Text == btn5.Text && btn5.Text == btn7.Text && !btn3.Enabled)
                iswinner = true;

            if (iswinner)
            {
                DisableButons();
                string winner = "";
                if (turn)
                    winner = "Player 2";
                else
                    winner = "Player 1";
                MessageBox.Show(winner + " Won", "Winner!!!");
                newGameToolStripMenuItem_Click(null, null);
            }
            else
            {
                if (count == 9)
                {
                    MessageBox.Show("Draw", "Oops");
                    newGameToolStripMenuItem_Click(null,null);
                }

            }
        }
        private void DisableButons()
        {
            try
            {

                foreach (var c in Controls)
                {
                    Button b = (Button)c;
                    btn1.Enabled = false;
                }
            }
            catch { }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            count = 0;
            try
            {
                foreach (Control c in Controls)
                {
                        Button btn = (Button)c;
                        btn.Enabled = true;
                        btn.Text = "";
                }
            }
            catch { }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in tableLayoutPanel1.Controls.OfType<Button>())
            {
                item.BackColor = Color.Red;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
