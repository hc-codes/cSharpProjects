using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dictonary.Helpers;

namespace Dictonary
{
    class Program
    {
        static void Main()
        {
            List<Dictionary<string, string>> ls = new List<Dictionary<string, string>>();
            Dictionary<string, string> data1 = new Dictionary<string, string>()
           {
               {"1","one" },
               {"2","two" }
           };
            Dictionary<string, string> data2= new Dictionary<string, string>()
           {
               {"3","three" },
               {"4","four" }
           };
            ls.Add(data1);
            ls.Add(data2);
            foreach (var lst in ls)
            {
                foreach (var item in lst)
                {
                    Console.WriteLine($"{StringHelper.ToUpperCase(item.Key)}: {StringHelper.ToUpperCase(item.Value)}");
                }

            }
        }
    }
}
