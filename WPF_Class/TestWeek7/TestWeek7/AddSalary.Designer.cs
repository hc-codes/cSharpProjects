
namespace TestWeek7
{
    partial class AddSalary
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddSalary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddSalary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(369, 345);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 40);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddSalary
            // 
            this.btnAddSalary.BackColor = System.Drawing.Color.Lime;
            this.btnAddSalary.Location = new System.Drawing.Point(201, 345);
            this.btnAddSalary.Name = "btnAddSalary";
            this.btnAddSalary.Size = new System.Drawing.Size(115, 40);
            this.btnAddSalary.TabIndex = 13;
            this.btnAddSalary.Text = "Add Salary";
            this.btnAddSalary.UseVisualStyleBackColor = false;
            this.btnAddSalary.Click += new System.EventHandler(this.btnAddSalary_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter the name of employee to create pay slip";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(201, 170);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(298, 22);
            this.txtName.TabIndex = 11;
            // 
            // txtAddSalary
            // 
            this.txtAddSalary.Location = new System.Drawing.Point(201, 264);
            this.txtAddSalary.Name = "txtAddSalary";
            this.txtAddSalary.Size = new System.Drawing.Size(298, 22);
            this.txtAddSalary.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Enter the salary amount";
            // 
            // AddSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddSalary);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddSalary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "AddSalary";
            this.Text = "Add Salary";
            this.Load += new System.EventHandler(this.AddSalary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddSalary;
        private System.Windows.Forms.Label label2;
    }
}