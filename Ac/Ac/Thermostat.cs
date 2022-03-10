using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ac
{
    public delegate void Switch(bool state);
    public class Thermostat
    {
        private int currentTemp;
        public event Switch Control;
        public int TempHigh { get; set; }
        public int TempLow { get; set; }
        
        public void SetCurrentTemp(int temp)
        {
            this.currentTemp = temp;
            if (this.Control == null)
                return;
            if (currentTemp >= TempHigh)
            {
                this.Control(true);
                return;
            }
            if (currentTemp <= TempLow)
                this.Control(false);
        }
    }
}
