using GraphicsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics1
{
    public class Laptop
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public override bool Equals(object obj)
        {
            var res = (Laptop)obj;
            if (res.Brand.ToLower() == Brand.ToLower() && res.Model.ToLower() == Model.ToLower() && res.Price == Price)
                return true;
            return false;
        }

    }
   
    class Program
    {
        static void Main(string[] args)
        {
            Laptop[] lap = new Laptop[2];
            for (int i = 0; i < 2; i++)
            {
                Laptop l = new Laptop();
                l.Brand = Console.ReadLine();
                l.Model = Console.ReadLine();
                l.Price = int.Parse(Console.ReadLine());
                lap[i] = l;
            }
            var obj = new Laptop()
            {
                Brand = "Abc",
                Model = "xyz",
                Price = 1000
            };
            foreach (var item in lap)
            {
                if (item.Equals(obj))
                    Console.WriteLine("Same");
                else
                    Console.WriteLine("Different");

            }

            //Console.WriteLine(e1 + e2);
            //Point p = new Point(5, 6);
            //Point q = new Point(10, 4);
            //Point r = p + q;  //operator '+' overloaded
            //Console.WriteLine(r);
            //Console.WriteLine(r.ToString());
        }
    }
}
