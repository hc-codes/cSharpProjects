using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class2
    {
        static void fun()
        {
            string s = Console.ReadLine();
            string s1 = "";
            s1 = s1 + s[0];

            s1 = s1.ToUpper();
            for (int i = 1; i < s.Length; i++)
            {
                s1 = s1 + s[i];

            }
            Console.WriteLine(s1);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"5 * {0} = {1}", i, (i * 5));
            }
            string str = @"Line1
                    Line2";
            Console.WriteLine(str);


        }
    }
}
