using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StrToCharToStr
    {   
        public void fun()
        {
            
            string s = null;
            Input(out s);
            char[] c = ConvertInputToChar(s);
            ConvertCharToString(c);
        }
        public static void Input(out string s)
        {
            Console.WriteLine("Enter A String");
            s = Console.ReadLine();
        }
        public static char[] ConvertInputToChar(string s)
        {
            var c = new char[] { };
            c = s.ToCharArray();
            Console.WriteLine("CharArray==");
            foreach (var item in c)
                Console.WriteLine(item);
            return c;
        }
        public static void ConvertCharToString(char[] c)
        {
            string s=null;
            foreach (var item in c)
            {
                s = s + item;
            }
            Console.WriteLine("String Array is = " + s);
        }
    }
}
