using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ac
{
    public delegate void Conditioning(int temp);
    public class Ac
    {
        private bool isOn;
        public void Sense(int temp)
        {
            this.Controller.SetCurrentTemp(temp);
            if (AirConditioning == null)
                return;
            AirConditioning(isOn ? -1 : 1);
        }
        public void TempControl(bool onOrOff)
        {
            if (onOrOff)
            {
                this.compressor.SwitchOn();
                if (AirConditioning != null)
                {
                    //AirConditioning(-1);
                    isOn = true;
                }
            }
            else
            {
                this.compressor.SwitchOff();
                if (AirConditioning != null)
                {
                   // AirConditioning(+1);
                    isOn = false;
                }
            }

        }
        public event Conditioning AirConditioning;

        private Compressor compressor = new Compressor();
        public Thermostat Controller { get; set; } = new Thermostat(); //Auto Property. Can be initialized;
        public Ac()
        {
            this.Controller.Control += TempControl;
        }
        private class Compressor
        {
            public void SwitchOn()
            {

            }
            public void SwitchOff()
            {

            }

        }

    }

}
