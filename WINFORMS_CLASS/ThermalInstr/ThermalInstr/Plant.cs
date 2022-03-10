using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThermalInstr
{
    public class Plant
    {
        public PlantStatii Status { get; set; } = PlantStatii.ShutDown;
        public int Temp { get; set; } = 0;
        public int Pressure { get; set; } = 0;
        public int Power { get; set; } = 0;
        public PlantParams TickHandler()
        {
            switch (Status)
            {
                case PlantStatii.StartUp:
                    DoStartUp();
                    break;
            }
            return new PlantParams
            {
                Temp = this.Temp,
                Power = this.Power,
                Pressure = this.Pressure,
                Status = (int)this.Status
            };
        }

        private void DoStartUp()
        {
            this.Temp += 20;
            if (Temp > 50)
            {
                this.Pressure += 10;
            }
        }

        public void StartHandler()
        {
            Status = PlantStatii.StartUp;
        }
        public void ConnectHandler()
        {

        }
        public void FullHandler()
        {

        }
        public void ShutHandler()
        {

        }
    }
}
