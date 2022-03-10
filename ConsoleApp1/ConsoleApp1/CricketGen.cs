using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CricketGen
    {
        public void Cricket()
        {

            int score = 0;
            while (true)
            {
                Console.WriteLine("Enter the Run: ");
                int n = int.Parse(Console.ReadLine());
                Random random = new Random();
                int n1 = random.Next(1, 7);
                Console.WriteLine("Computer guess: " + n1);
                if (n == n1)
                {
                    Console.WriteLine("Your Are Out, Your Score is: " + score);
                    break;
                }
                else if (n == 5 || n > 6)
                    continue;
                else if (n1 == 5)
                    score = score + 1;
                else
                    score += n;
                Console.WriteLine("Your Current Score IS: " + score);
            }
        }
    }
}
