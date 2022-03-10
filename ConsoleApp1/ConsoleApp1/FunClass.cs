using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class FunClass
    {
        public void fun()
        {
            var str = "************";
            for (int i = 0; i < 1; i++)
            {
                foreach (var item in str)
                {
                    Console.Write(item);
                    Thread.Sleep(100);

                }
                //Console.Clear();
                Console.WriteLine();
                Console.Write("\r");
                Thread.Sleep(100);
            }
        }
    

        public void funn()
        {
            var s = "/ | - \\";
            for(int i = 0; i < 1; i++) { 
                foreach (var item in s)
                {
                    Console.Write(item + "\r");
                    Thread.Sleep(500);
                }
            }
        }
    }
}
