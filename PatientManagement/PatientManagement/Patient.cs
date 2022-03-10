using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement
{
    public class Patient : Hospital
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
}
