using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Library.Models
{
    public class Cart
    {
        public Dictionary<Product, int> Contents { get; set; } = new Dictionary<Product, int>();
        public void Add(Product p, int qty = 1)
        {
            if(Contents.ContainsKey(p))
            {
                qty += Contents[p];
            }
            Contents[p] = qty;
        }
        public void Remove(Product p, int qty)
        {
            if (Contents.ContainsKey(p))
            {
                qty = Contents[p] - qty;
            }
            if(qty <= 0)
            {
                Contents.Remove(p);
                return;
            }
            Contents[p] = qty;
        }
        public double ComputeTotal()
        {
            double total = 0.0;
            foreach (var item in this.Contents)
            {
                total += item.Key.Price * item.Value;
            }
            return total;
        }
    }
}
