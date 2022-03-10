using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Library.Models
{
    [Serializable]
    public class Product
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public override string ToString()
        {
            return string.Format("[{0}] - {1} / {2} @ {3} ({4})", this.Id, this.Category, this.Name, this.Price, this.Stock);
        }
    }
}