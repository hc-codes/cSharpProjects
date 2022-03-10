using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4._1
{
    abstract class Special
    {
       public abstract double Process(double p, double r);
    }
    class Discount : Special
    {
        public override double Process(double p, double r)
        {
            double net = p - p * r / 100;
            return net;
        }
    }
    class Tax : Special
    {
        public override double Process(double p, double r)
        {
            double total = p + p * r / 100;
            return total;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Discount discount = new Discount();
            Tax tax = new Tax();
            Console.Write("\n\tEnter The Price: ");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("\n\tEnter The Rate Of Interest: ");
            double rate = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"\n\tNet Value: {discount.Process(price, rate)}");
            Console.WriteLine($"\n\tTotal: {tax.Process(price,rate)}");


        }
    }
}
