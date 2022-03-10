using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Employee();
            Console.WriteLine("HEllo");
            Person e = new Employee("hari", "28/08/1998");
            Person p = new Person("Steve", "14/05/1987");
            e.Email = "hari@gmail.com";
            e.Address = "Thrissur";
            ((Employee)e).Salary = 30000;
            Employee e1 = (Employee)e;
            //e1.Salary = 25000.0;
            e1.Designation = "Manager";
            Console.WriteLine(e.GetDetails());
            Console.WriteLine(e1.GetDetails());
            Console.WriteLine(p.GetDetails());


        }
    }
}