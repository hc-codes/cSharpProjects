using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLib
{
    class Expence : object
    {
        public string Name { get; set; }
        public int Amount { get; set; }

        public override string ToString()
        {
            return $"Monthly Expence of {Name} is {Amount}";
        }
        public static Expence operator +(Expence e1, Expence e2)
        {
            return new Expence()
            {
                Name = "Monthly Expence",
                Amount = e1.Amount + e2.Amount
            };
        }
        public override bool Equals(object obj)
        {
            var expence = (Expence)obj;
            return expence.Amount == Amount;
        }
    }

    class OperatorOverride
    {
        void Run()
        {
            var e1 = new Expence() { Name = "Food", Amount = 300 };
            var e2 = new Expence() { Name = "Rent", Amount = 500 };
        }
    }
}
