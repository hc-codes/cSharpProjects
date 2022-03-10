using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RandomNoAndColor
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.ForegroundColor = GetRandomColors();
                int i = random.Next(1,1000);
                if (i == 5)
                    break;
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
        }

        private static ConsoleColor GetRandomColors()
        {
            var c = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)c.GetValue(random.Next(1,c.Length));
        }
    }
}
