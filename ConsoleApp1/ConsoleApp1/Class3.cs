using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class3
    {
        void fun()
        {

            Console.WriteLine("Please Enter A String To Check Whether It Is Palindrome Or Not...");
            Console.WriteLine();
            string s = Console.ReadLine();
            string s1 = "";


            for (int i = s.Length - 1; i >= 0; i--)
            {
                s1 = s1 + s[i];
            }
            Console.WriteLine("The Reverse Of The String is : " + s1);
            Console.WriteLine();
            if (s1 == s)
                Console.WriteLine(s + " Is A Palindrome");
            else
                Console.WriteLine(s + " Is Not A Palindrome");

        }
    }
}
