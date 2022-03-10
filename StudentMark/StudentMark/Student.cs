using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMark
{
    class Student
    {
        public string Name { get; set; }
        public int Class { get; set; }
        public int Theory { get; set; }
        public int Practical { get; set; }
        public virtual double Total()
        {
            return Theory + Practical;
        }

    }
}
