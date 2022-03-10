using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class arrayOfList
    {
        public void fun()
        {
            var l = new List<int[]>();
            for (int i = 0; i < 3; i++)
            {
                var row = new int[3];
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Enter the numbers");
                    row[j] = int.Parse(Console.ReadLine()); //1 2   in list //[1 ,2], [3 ,4]
                                                            //3 4
                }
                l.Add(row);
            }
            foreach (var rowl in l)
            {
                foreach (var col in rowl)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
