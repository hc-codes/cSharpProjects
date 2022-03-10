
namespace Basic_Calculator1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Div = new System.Windows.Forms.RadioButton();
            this.Mul = new System.Windows.Forms.RadioButton();
            this.Sub = new System.Windows.Forms.RadioButton();
            this.Add = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.t3 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t1 = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.Div);
            this.groupBox1.Controls.Add(this.Mul);
            this.groupBox1.Controls.Add(this.Sub);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Location = new System.Drawing.Point(557, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // Div
            // 
            this.Div.AutoSize = true;
            this.Div.BackColor = System.Drawing.Color.Fuchsia;
            this.Div.Location = new System.Drawing.Point(27, 204);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(78, 21);
            this.Div.TabIndex = 3;
            this.Div.TabStop = true;
            this.Div.Text = "Division";
            this.Div.UseVisualStyleBackColor = false;
            this.Div.CheckedChanged += new System.EventHandler(this.Div_CheckedChanged);
            // 
            // Mul
            // 
            this.Mul.AutoSize = true;
            this.Mul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Mul.Location = new System.Drawing.Point(27, 153);
            this.Mul.Name = "Mul";
            this.Mul.Size = new System.Drawing.Size(110, 21);
            this.Mul.TabIndex = 2;
            this.Mul.TabStop = true;
            this.Mul.Text = "Multiplication";
            this.Mul.UseVisualStyleBackColor = false;
            this.Mul.CheckedChanged += new System.EventHandler(this.Mul_CheckedChanged);
            // 
            // Sub
            // 
            this.Sub.AutoSize = true;
            this.Sub.BackColor = System.Drawing.Color.Aqua;
            this.Sub.Location = new System.Drawing.Point(27, 109);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(101, 21);
            this.Sub.TabIndex = 1;
            this.Sub.TabStop = true;
            this.Sub.Text = "Subtraction";
            this.Sub.UseVisualStyleBackColor = false;
            this.Sub.CheckedChanged += new System.EventHandler(this.Sub_CheckedChanged);
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.BackColor = System.Drawing.Color.Lime;
            this.Add.Location = new System.Drawing.Point(27, 58);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(80, 21);
            this.Add.TabIndex = 0;
            this.Add.TabStop = true;
            this.Add.Text = "Addition";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.CheckedChanged += new System.EventHandler(this.Add_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox2.Controls.Add(this.Label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.t3);
            this.groupBox2.Controls.Add(this.t2);
            this.groupBox2.Controls.Add(this.t1);
            this.groupBox2.Location = new System.Drawing.Point(67, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 251);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Numbers";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(28, 208);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(48, 17);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Result";
            this.Label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number 1";
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(151, 205);
            this.t3.Name = "t3";
            this.t3.ReadOnly = true;
            this.t3.Size = new System.Drawing.Size(210, 22);
            this.t3.TabIndex = 2;
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(151, 133);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(210, 22);
            this.t2.TabIndex = 1;
            this.t2.TextChanged += new System.EventHandler(this.t2_TextChanged);
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(151, 58);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(210, 22);
            this.t1.TabIndex = 0;
            this.t1.TextChanged += new System.EventHandler(this.t1_TextChanged);
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Calculate.Location = new System.Drawing.Point(217, 363);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(210, 60);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Clear.Location = new System.Drawing.Point(557, 363);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(175, 60);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(436, 68);
            this.label4.TabIndex = 4;
            this.label4.Text = "BASIC CALCULATOR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.RadioButton Div;
        private System.Windows.Forms.RadioButton Mul;
        private System.Windows.Forms.RadioButton Sub;
        private System.Windows.Forms.RadioButton Add;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label4;
    }
}

