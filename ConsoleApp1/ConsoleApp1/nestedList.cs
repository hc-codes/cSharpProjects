using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class nestedList
    {
        public void fun()
        {
            var l = new List<List<string>>();
            Console.WriteLine("enter the number of students");
            int n = int.Parse(Console.ReadLine());
            string[] a = new string[] { "Name", "Age", "Phone" };
            for (int j = 0; j < n; j++)
            {
                var data = new List<string>();   //Should be declared within the loop
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"Enter the {a[i]} of {j + 1} th student");
                    data.Add(Console.ReadLine());
                }
                l.Add(data);
            }
            foreach (var item in a)
            {
                Console.Write(item + "  ");

            }
            Console.WriteLine();

            foreach (var item in l)   //[[a,10,001],[b,20,002],[c,30,003]]
            {
                foreach (var i in item)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();

            }
        }
    }
}
