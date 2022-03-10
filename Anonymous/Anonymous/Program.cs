using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var x = 10;
            var y = new
            {
                Name = "abc",
                Age = 20,
            };
            Console.WriteLine("Name = " + y.Name + ", Age = " + y.Age);
        }
    }
}
