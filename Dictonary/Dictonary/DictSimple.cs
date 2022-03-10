using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictonary
{
    class DictSimple
    {
        public void Sample()
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("1", "One");
            data.Add("2", "Two");
            
            foreach (var item in data)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
        }
    }
}
