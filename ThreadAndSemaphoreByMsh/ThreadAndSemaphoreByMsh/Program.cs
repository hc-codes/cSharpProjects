using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadAndSemaphoreByMsh
{
    class Program
    {
        static void DownloadMovie1()
        {
            Console.WriteLine("\tStarting Movie 1 Download:-  "+Thread.CurrentThread.Name);
            Thread.Sleep(5000);
            Console.WriteLine("\n\tFinished Movie 1 Download");
        }
        static void DownloadMovie2()
        {
            Console.WriteLine("\n\tStarting Movie 2 Download:-  "+Thread.CurrentThread.Name);
            Thread.Sleep(15000);
            Console.WriteLine("\n\tFinished Movie 2 Download");

        }
        static void Main(string[] args)
        {
            
            Thread movie1 = new Thread(DownloadMovie1);
            Thread movie2 = new Thread(DownloadMovie2);
            movie1.Name = "Movie1";
            movie2.Name = "Movie2";
            movie1.Start();
            movie2.Start();
            movie1.Join();
            movie2.Join();
            Console.WriteLine("Exiting Main Thread");

        }
    }
}
