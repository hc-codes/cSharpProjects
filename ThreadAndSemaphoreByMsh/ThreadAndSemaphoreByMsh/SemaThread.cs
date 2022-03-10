using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadAndSemaphoreByMsh
{
    class SemaThread
    {
        public void Run()
        {
            SemaphoreSlim gate = new SemaphoreSlim(1);
            for (int i = 0; i < 20; i++)
            {
                gate.Wait();
                Thread.Sleep(1000);
                Console.WriteLine("Entering gate");
                Console.WriteLine("Passed");
                gate.Release();
            }
            Console.WriteLine("Done");
        }
    }
}
