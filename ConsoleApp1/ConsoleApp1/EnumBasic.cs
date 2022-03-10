using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Format
    {
        Upper,
        Lower
    }
    class EnumBasic
    {
        private static void ShowData(string s, Format format)
        {
            switch (format)
            {
                case Format.Upper:
                    Console.WriteLine(s.ToUpper());
                    break;
                case Format.Lower:
                    Console.WriteLine(s.ToLower());
                    break;
                default:
                    break;
            }
        }
    }
}
