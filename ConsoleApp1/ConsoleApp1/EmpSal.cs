using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EmpSal
    {
    }
    class Person
    {
        int s = 10000;
        public virtual int Salary()
        {
            Console.WriteLine("Person");
            return s * 12;
        }
    }
    class Employee : Person
    {
        public override int Salary()
        {
            Console.WriteLine("Employee");
            return 10000 + base.Salary();
        }
    }
    class JuniorEmployee : Person
    {
        public override int Salary()
        {
            Console.WriteLine("Junior");
            var s = base.Salary();
            return s - 20000;
        }
    }
}
