
namespace ThermalInstr
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
            this.cbFault = new System.Windows.Forms.CheckBox();
            this.cbFull = new System.Windows.Forms.CheckBox();
            this.cbPartial = new System.Windows.Forms.CheckBox();
            this.cbIdle = new System.Windows.Forms.CheckBox();
            this.cbStart = new System.Windows.Forms.CheckBox();
            this.cbShut = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbPower = new System.Windows.Forms.ProgressBar();
            this.pbPressure = new System.Windows.Forms.ProgressBar();
            this.pbTemp = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnFull = new System.Windows.Forms.Button();
            this.btnTick = new System.Windows.Forms.Button();
            this.btnShut = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbFault);
            this.groupBox1.Controls.Add(this.cbFull);
            this.groupBox1.Controls.Add(this.cbPartial);
            this.groupBox1.Controls.Add(this.cbIdle);
            this.groupBox1.Controls.Add(this.cbStart);
            this.groupBox1.Controls.Add(this.cbShut);
            this.groupBox1.Location = new System.Drawing.Point(14, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plant Status";
            // 
            // cbFault
            // 
            this.cbFault.AutoSize = true;
            this.cbFault.BackColor = System.Drawing.Color.White;
            this.cbFault.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFault.ForeColor = System.Drawing.Color.Maroon;
            this.cbFault.Location = new System.Drawing.Point(770, 49);
            this.cbFault.Name = "cbFault";
            this.cbFault.Size = new System.Drawing.Size(66, 21);
            this.cbFault.TabIndex = 5;
            this.cbFault.Text = "Fault";
            this.cbFault.UseVisualStyleBackColor = false;
            // 
            // cbFull
            // 
            this.cbFull.AutoSize = true;
            this.cbFull.BackColor = System.Drawing.Color.White;
            this.cbFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFull.ForeColor = System.Drawing.Color.Maroon;
            this.cbFull.Location = new System.Drawing.Point(615, 49);
            this.cbFull.Name = "cbFull";
            this.cbFull.Size = new System.Drawing.Size(97, 21);
            this.cbFull.TabIndex = 4;
            this.cbFull.Text = "Full Load";
            this.cbFull.UseVisualStyleBackColor = false;
            // 
            // cbPartial
            // 
            this.cbPartial.AutoSize = true;
            this.cbPartial.BackColor = System.Drawing.Color.White;
            this.cbPartial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPartial.ForeColor = System.Drawing.Color.Maroon;
            this.cbPartial.Location = new System.Drawing.Point(459, 49);
            this.cbPartial.Name = "cbPartial";
            this.cbPartial.Size = new System.Drawing.Size(118, 21);
            this.cbPartial.TabIndex = 3;
            this.cbPartial.Text = "Partial Load";
            this.cbPartial.UseVisualStyleBackColor = false;
            // 
            // cbIdle
            // 
            this.cbIdle.AutoSize = true;
            this.cbIdle.BackColor = System.Drawing.Color.White;
            this.cbIdle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIdle.ForeColor = System.Drawing.Color.Maroon;
            this.cbIdle.Location = new System.Drawing.Point(338, 49);
            this.cbIdle.Name = "cbIdle";
            this.cbIdle.Size = new System.Drawing.Size(69, 21);
            this.cbIdle.TabIndex = 2;
            this.cbIdle.Text = "Idling";
            this.cbIdle.UseVisualStyleBackColor = false;
            // 
            // cbStart
            // 
            this.cbStart.AutoSize = true;
            this.cbStart.BackColor = System.Drawing.Color.White;
            this.cbStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStart.ForeColor = System.Drawing.Color.Maroon;
            this.cbStart.Location = new System.Drawing.Point(183, 49);
            this.cbStart.Name = "cbStart";
            this.cbStart.Size = new System.Drawing.Size(112, 21);
            this.cbStart.TabIndex = 1;
            this.cbStart.Text = "Starting Up";
            this.cbStart.UseVisualStyleBackColor = false;
            // 
            // cbShut
            // 
            this.cbShut.AutoSize = true;
            this.cbShut.BackColor = System.Drawing.Color.White;
            this.cbShut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShut.ForeColor = System.Drawing.Color.Maroon;
            this.cbShut.Location = new System.Drawing.Point(48, 49);
            this.cbShut.Name = "cbShut";
            this.cbShut.Size = new System.Drawing.Size(107, 21);
            this.cbShut.TabIndex = 0;
            this.cbShut.Text = "Shut Down";
            this.cbShut.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbPower);
            this.groupBox2.Controls.Add(this.pbPressure);
            this.groupBox2.Controls.Add(this.pbTemp);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(62, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(838, 214);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gauge";
            // 
            // pbPower
            // 
            this.pbPower.Location = new System.Drawing.Point(118, 136);
            this.pbPower.Name = "pbPower";
            this.pbPower.Size = new System.Drawing.Size(670, 23);
            this.pbPower.TabIndex = 5;
            // 
            // pbPressure
            // 
            this.pbPressure.Location = new System.Drawing.Point(118, 84);
            this.pbPressure.Name = "pbPressure";
            this.pbPressure.Size = new System.Drawing.Size(670, 23);
            this.pbPressure.TabIndex = 4;
            // 
            // pbTemp
            // 
            this.pbTemp.Location = new System.Drawing.Point(118, 30);
            this.pbTemp.Name = "pbTemp";
            this.pbTemp.Size = new System.Drawing.Size(670, 23);
            this.pbTemp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Power";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pressure";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boil Temp";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnConnect);
            this.groupBox3.Controls.Add(this.btnFull);
            this.groupBox3.Controls.Add(this.btnTick);
            this.groupBox3.Controls.Add(this.btnShut);
            this.groupBox3.Controls.Add(this.btnStart);
            this.groupBox3.Location = new System.Drawing.Point(62, 422);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(838, 144);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Connect";
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSize = true;
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(240, 53);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Padding = new System.Windows.Forms.Padding(5);
            this.btnConnect.Size = new System.Drawing.Size(108, 45);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            // 
            // btnFull
            // 
            this.btnFull.AutoSize = true;
            this.btnFull.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFull.ForeColor = System.Drawing.Color.White;
            this.btnFull.Location = new System.Drawing.Point(377, 53);
            this.btnFull.Name = "btnFull";
            this.btnFull.Padding = new System.Windows.Forms.Padding(5);
            this.btnFull.Size = new System.Drawing.Size(108, 45);
            this.btnFull.TabIndex = 3;
            this.btnFull.Text = "Full Load";
            this.btnFull.UseVisualStyleBackColor = false;
            // 
            // btnTick
            // 
            this.btnTick.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTick.ForeColor = System.Drawing.Color.White;
            this.btnTick.Location = new System.Drawing.Point(651, 53);
            this.btnTick.Name = "btnTick";
            this.btnTick.Padding = new System.Windows.Forms.Padding(5);
            this.btnTick.Size = new System.Drawing.Size(108, 45);
            this.btnTick.TabIndex = 2;
            this.btnTick.Text = "Tick";
            this.btnTick.UseVisualStyleBackColor = false;
            this.btnTick.Click += new System.EventHandler(this.btnTick_Click);
            // 
            // btnShut
            // 
            this.btnShut.AutoSize = true;
            this.btnShut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnShut.ForeColor = System.Drawing.Color.White;
            this.btnShut.Location = new System.Drawing.Point(514, 53);
            this.btnShut.Name = "btnShut";
            this.btnShut.Padding = new System.Windows.Forms.Padding(5);
            this.btnShut.Size = new System.Drawing.Size(108, 45);
            this.btnShut.TabIndex = 1;
            this.btnShut.Text = "Shut Down";
            this.btnShut.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(103, 53);
            this.btnStart.Name = "btnStart";
            this.btnStart.Padding = new System.Windows.Forms.Padding(5);
            this.btnStart.Size = new System.Drawing.Size(108, 45);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(982, 583);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "Form1";
            this.Text = "Plant Annunciation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbFault;
        private System.Windows.Forms.CheckBox cbFull;
        private System.Windows.Forms.CheckBox cbPartial;
        private System.Windows.Forms.CheckBox cbIdle;
        private System.Windows.Forms.CheckBox cbStart;
        private System.Windows.Forms.CheckBox cbShut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar pbPower;
        private System.Windows.Forms.ProgressBar pbPressure;
        private System.Windows.Forms.ProgressBar pbTemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnFull;
        private System.Windows.Forms.Button btnTick;
        private System.Windows.Forms.Button btnShut;
        private System.Windows.Forms.Button btnStart;
    }
}

