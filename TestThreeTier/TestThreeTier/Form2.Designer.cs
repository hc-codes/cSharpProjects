
namespace TestThreeTier
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCb = new System.Windows.Forms.Label();
            this.lblBb = new System.Windows.Forms.Label();
            this.lblPepsi = new System.Windows.Forms.Label();
            this.nudCb = new System.Windows.Forms.NumericUpDown();
            this.nudBb = new System.Windows.Forms.NumericUpDown();
            this.nudPep = new System.Windows.Forms.NumericUpDown();
            this.lblCbPrice = new System.Windows.Forms.Label();
            this.lblBbPrice = new System.Windows.Forms.Label();
            this.lblPepPrice = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPep)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBbPrice);
            this.groupBox1.Controls.Add(this.lblCbPrice);
            this.groupBox1.Controls.Add(this.nudBb);
            this.groupBox1.Controls.Add(this.nudCb);
            this.groupBox1.Controls.Add(this.lblBb);
            this.groupBox1.Controls.Add(this.lblCb);
            this.groupBox1.Location = new System.Drawing.Point(31, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPepPrice);
            this.groupBox2.Controls.Add(this.nudPep);
            this.groupBox2.Controls.Add(this.lblPepsi);
            this.groupBox2.Location = new System.Drawing.Point(31, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lblCb
            // 
            this.lblCb.AutoSize = true;
            this.lblCb.Location = new System.Drawing.Point(3, 18);
            this.lblCb.Name = "lblCb";
            this.lblCb.Size = new System.Drawing.Size(23, 17);
            this.lblCb.TabIndex = 0;
            this.lblCb.Text = "cb";
            // 
            // lblBb
            // 
            this.lblBb.AutoSize = true;
            this.lblBb.Location = new System.Drawing.Point(3, 58);
            this.lblBb.Name = "lblBb";
            this.lblBb.Size = new System.Drawing.Size(24, 17);
            this.lblBb.TabIndex = 1;
            this.lblBb.Text = "bb";
            // 
            // lblPepsi
            // 
            this.lblPepsi.AutoSize = true;
            this.lblPepsi.Location = new System.Drawing.Point(6, 35);
            this.lblPepsi.Name = "lblPepsi";
            this.lblPepsi.Size = new System.Drawing.Size(43, 17);
            this.lblPepsi.TabIndex = 0;
            this.lblPepsi.Text = "Pepsi";
            // 
            // nudCb
            // 
            this.nudCb.Location = new System.Drawing.Point(55, 18);
            this.nudCb.Name = "nudCb";
            this.nudCb.Size = new System.Drawing.Size(120, 22);
            this.nudCb.TabIndex = 1;
            this.nudCb.ValueChanged += new System.EventHandler(this.nudCb_ValueChanged);
            // 
            // nudBb
            // 
            this.nudBb.Location = new System.Drawing.Point(55, 56);
            this.nudBb.Name = "nudBb";
            this.nudBb.Size = new System.Drawing.Size(120, 22);
            this.nudBb.TabIndex = 2;
            // 
            // nudPep
            // 
            this.nudPep.Location = new System.Drawing.Point(74, 33);
            this.nudPep.Name = "nudPep";
            this.nudPep.Size = new System.Drawing.Size(120, 22);
            this.nudPep.TabIndex = 2;
            // 
            // lblCbPrice
            // 
            this.lblCbPrice.AutoSize = true;
            this.lblCbPrice.Location = new System.Drawing.Point(199, 18);
            this.lblCbPrice.Name = "lblCbPrice";
            this.lblCbPrice.Size = new System.Drawing.Size(32, 17);
            this.lblCbPrice.TabIndex = 3;
            this.lblCbPrice.Text = "100";
            // 
            // lblBbPrice
            // 
            this.lblBbPrice.AutoSize = true;
            this.lblBbPrice.Location = new System.Drawing.Point(199, 61);
            this.lblBbPrice.Name = "lblBbPrice";
            this.lblBbPrice.Size = new System.Drawing.Size(32, 17);
            this.lblBbPrice.TabIndex = 4;
            this.lblBbPrice.Text = "150";
            // 
            // lblPepPrice
            // 
            this.lblPepPrice.AutoSize = true;
            this.lblPepPrice.Location = new System.Drawing.Point(214, 38);
            this.lblPepPrice.Name = "lblPepPrice";
            this.lblPepPrice.Size = new System.Drawing.Size(24, 17);
            this.lblPepPrice.TabIndex = 3;
            this.lblPepPrice.Text = "40";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(306, 378);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 52);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "AddToCart";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBbPrice;
        private System.Windows.Forms.Label lblCbPrice;
        private System.Windows.Forms.NumericUpDown nudBb;
        private System.Windows.Forms.NumericUpDown nudCb;
        private System.Windows.Forms.Label lblBb;
        private System.Windows.Forms.Label lblCb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudPep;
        private System.Windows.Forms.Label lblPepsi;
        private System.Windows.Forms.Label lblPepPrice;
        private System.Windows.Forms.Button btnAdd;
    }
}