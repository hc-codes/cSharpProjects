
namespace MyFirstApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.Screen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(70, 112);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(75, 60);
            this.one.TabIndex = 0;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.btn);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(167, 112);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(75, 60);
            this.two.TabIndex = 1;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.btn);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(260, 112);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(75, 60);
            this.three.TabIndex = 2;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.btn);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(70, 202);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(75, 60);
            this.four.TabIndex = 3;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.btn);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(167, 202);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(75, 60);
            this.five.TabIndex = 4;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.btn);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(260, 202);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(75, 60);
            this.six.TabIndex = 5;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.btn);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(70, 296);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(75, 60);
            this.seven.TabIndex = 6;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.btn);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(167, 296);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(75, 60);
            this.eight.TabIndex = 7;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.btn);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(260, 296);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(75, 60);
            this.nine.TabIndex = 8;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.btn);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(70, 376);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(75, 62);
            this.zero.TabIndex = 9;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.btn);
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(167, 376);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(75, 62);
            this.dot.TabIndex = 10;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.btn);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(260, 376);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(75, 62);
            this.equal.TabIndex = 11;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(372, 112);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 62);
            this.add.TabIndex = 12;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.btn);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(372, 201);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 62);
            this.minus.TabIndex = 13;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.btn);
            // 
            // mul
            // 
            this.mul.Location = new System.Drawing.Point(372, 296);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(75, 62);
            this.mul.TabIndex = 14;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.btn);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(372, 376);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 62);
            this.div.TabIndex = 15;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.btn);
            // 
            // Screen
            // 
            this.Screen.Location = new System.Drawing.Point(70, 12);
            this.Screen.Multiline = true;
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(377, 78);
            this.Screen.TabIndex = 16;
            this.Screen.TextChanged += new System.EventHandler(this.Screen_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.Screen);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.add);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.TextBox Screen;
    }
}

