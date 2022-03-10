using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate1
{
    
    class Program
    {
        static Point p;
        static CPoint q;
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            table.Add("N", 1);
            table.Add("N", 2);
            table.Add("N", 3);
            table.Add("N", 4);
            table.Add("L", "A");
            table.Add("L", "B");
            table.Add("L", "C");
            //var keys=
            foreach (DictionaryEntry item in table)
            {
                Console.WriteLine($"{item.Key}");
            }
            //p.X = 10;
            //p.Y = 20;
            //Console.WriteLine($"X = {p.X}, Y = {p.Y}");
            //q.X = 10;
            //q.Y = 20;
            //Console.WriteLine($"X = {q.X}, Y = {q.Y}");

        }
    }
}
