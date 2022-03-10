using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Sample
    {
        public Sample Name { get; set; }
        public void Get()
        {
            Name = 8;
            Console.WriteLine(Name);
        }

        public static implicit operator Sample(int v)
        {
            throw new NotImplementedException();
        }
    }
}
