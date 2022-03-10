
namespace LoginPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Login = new System.Windows.Forms.GroupBox();
            this.btnForget = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t1 = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Login.Controls.Add(this.btnForget);
            this.Login.Controls.Add(this.label3);
            this.Login.Controls.Add(this.label2);
            this.Login.Controls.Add(this.Submit);
            this.Login.Controls.Add(this.t2);
            this.Login.Controls.Add(this.t1);
            this.Login.Controls.Add(this.Password);
            this.Login.Controls.Add(this.UserName);
            this.Login.Cursor = System.Windows.Forms.Cursors.Default;
            this.Login.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Login.Location = new System.Drawing.Point(131, 110);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(545, 339);
            this.Login.TabIndex = 0;
            this.Login.TabStop = false;
            this.Login.Text = "Login";
            this.Login.UseCompatibleTextRendering = true;
            // 
            // btnForget
            // 
            this.btnForget.Location = new System.Drawing.Point(332, 246);
            this.btnForget.Name = "btnForget";
            this.btnForget.Size = new System.Drawing.Size(103, 42);
            this.btnForget.TabIndex = 2;
            this.btnForget.Text = "Forgot Password";
            this.btnForget.UseVisualStyleBackColor = true;
            this.btnForget.Click += new System.EventHandler(this.btnForget_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(198, 163);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3);
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter Password";
            this.label3.Click += new System.EventHandler(this.txtPassword);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(198, 74);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter User Name";
            this.label2.Click += new System.EventHandler(this.txtUserName);
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(192, 246);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(103, 42);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            this.Submit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Submit_Click);
            // 
            // t2
            // 
            this.t2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t2.Location = new System.Drawing.Point(189, 157);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(280, 36);
            this.t2.TabIndex = 3;
            this.t2.UseSystemPasswordChar = true;
            this.t2.UseWaitCursor = true;
            this.t2.Click += new System.EventHandler(this.txtPassword);
            this.t2.TextChanged += new System.EventHandler(this.txtPassword);
            this.t2.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword);
            // 
            // t1
            // 
            this.t1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t1.Location = new System.Drawing.Point(189, 67);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(280, 36);
            this.t1.TabIndex = 2;
            this.t1.UseWaitCursor = true;
            this.t1.TextChanged += new System.EventHandler(this.txtUserName);
            this.t1.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(55, 163);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(98, 25);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(55, 73);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(110, 25);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "User Name";
            this.UserName.Click += new System.EventHandler(this.txtUserName);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(307, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 79);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnForget;
    }
}

