using System;
using System.Linq;

namespace Linq1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = { "one", "two", "three", "four", "six", "nine", "seven", "twelve" };
            //var sel = nums.Where(Pick);
            //var sel = nums.Where(s => s.Length == 3);
            //var sel = nums.Where(s => s.IndexOf("e") >= 0);
            //var sel = nums.Select(s => s.Length);
            var sel = nums.Select(s => s.Substring(0, 2));
            foreach (var item in sel)
            {
                Console.WriteLine(item);
            }
        }
        public static bool Pick(string str)
        {
            //return str.Length == 4;
            return str.IndexOf("o") >= 0;
        }
    }
}
