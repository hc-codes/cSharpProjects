using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThermalInstr
{
    public partial class Form1 : Form
    {
        private Plant plant = new Plant();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTick_Click(object sender, EventArgs e)
        {
            PlantParams status = plant.TickHandler();
            this.pbTemp.Value = status.Temp > 100 ? 100 : status.Temp;
            this.pbPressure.Value = status.Pressure > 100 ? 100 : status.Pressure;
            SetStatus(status.Status);
        }
        private void SetStatus(int status)
        {
            int shut = (int)PlantStatii.ShutDown;
            int start = (int)PlantStatii.StartUp;
            bool shutChecked = (status & shut) != 0;
            cbShut.Checked = shutChecked;
            cbStart.Checked = (status & start) != 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            plant.StartHandler();
        }
    }
}
