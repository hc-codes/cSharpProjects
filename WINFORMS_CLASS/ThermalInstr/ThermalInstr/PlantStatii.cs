using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThermalInstr
{
    public enum PlantStatii
    {
        Fault=1, Full = 2, Partial = 4, Idle = 8, StartUp=16, ShutDown = 32
    };
}
