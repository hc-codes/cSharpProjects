using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWeek7
{
    public partial class ViewEmployees : Form
    {
        public ViewEmployees()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvlView.Items.Clear();
            lvlView.View = View.Details;

            foreach (var p in Form1.employees)
            {
                ListViewItem item = new ListViewItem(p._Name);
                item.SubItems.Add(p.UName);
                item.SubItems.Add(p.Password);
                item.SubItems.Add(p.Salary.ToString());
                lvlView.Items.Add(item);
            }
        }

        private void ViewEmployees_Load(object sender, EventArgs e)
        {
            listView1_SelectedIndexChanged(sender, e);
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
    }
}
