using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBasics
{
    class Employee
    {
        public string Name;
        public int empNo;
        public void ShowData()
        {
            Console.WriteLine($"{Name} is {empNo} years old");
        }
        static void EmployeeFun()
        {

            //emp.Name = Console.ReadLine();
            //emp.empNo = int.Parse(Console.ReadLine());
            Employee[] emp = new Employee[5]; // [null null null null null]
            for (int i = 0; i < 5; i++)
            {
                Employee e = new Employee(); //creates an e object
                Console.WriteLine($"Enter Name of {i + 1} th Employee");
                e.Name = Console.ReadLine();
                Console.WriteLine($"Enter Employee id of {i + 1} th Employee");
                e.empNo = int.Parse(Console.ReadLine());
                emp[i] = e;    //emp[e,e,e,e,e]

            }
            for (int i = 0; i < 5; i++)
            {
                emp[i].ShowData();
                Console.WriteLine($" Name of {i + 1} th Employee is: " + emp[i].Name);

                Console.WriteLine($" Employee id of {i + 1} th Employee is: " + emp[i].empNo);
            }
        }
    }
}
