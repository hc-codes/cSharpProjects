using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestThreeTier
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string q="";
            if (nudCb.Value > 0)
                q = $"select * from item where [name]='{lblCb.Text}'";
            var res= DBClass.Select(q);
            string qn = res.Tables[0].Rows[0]["quantity"].ToString();
            if (int.Parse(qn) - nudCb.Value < 0)
                MessageBox.Show("Error");
            else
            {
                q = $"update item set quantity = {int.Parse(qn) - nudCb.Value} where [name]='{lblCb.Text}'";
                DBClass.Insert(q);
                MessageBox.Show("Success");
            }



        }

        private void nudCb_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
