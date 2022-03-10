using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PredictDice
{
    public partial class Form1 : Form
    {
        Random dice = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int randNum = dice.Next(1, 7);
            switch (randNum)
            {
                case 1:
                    pictureBox1.ImageLocation = @"C:\Users\Hari\source\repos\WINFORMS\PredictDice\PredictDice\Resources\1.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case 2:
                    pictureBox1.ImageLocation = @"C:\Users\Hari\source\repos\WINFORMS\PredictDice\PredictDice\Resources\2.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox1.ImageLocation = @"C:\Users\Hari\source\repos\WINFORMS\PredictDice\PredictDice\Resources\3.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox1.ImageLocation = @"C:\Users\Hari\source\repos\WINFORMS\PredictDice\PredictDice\Resources\4.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox1.ImageLocation = @"C:\Users\Hari\source\repos\WINFORMS\PredictDice\PredictDice\Resources\5.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox1.ImageLocation = @"C:\Users\Hari\source\repos\WINFORMS\PredictDice\PredictDice\Resources\6.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }
    }
}
