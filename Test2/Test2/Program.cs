using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    
    class Category
    {
        public int Code { get; set; }
        public string Name { get; set; }

    }
    class Item : Category
    {
        public int ItemCode { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }

    public class Program
    {
        
        static Item[] items = new Item[10];
        static int total = 0;
        public static void Main()
        {
            for (int i = 0; i < 2; i++)
            {
                Item item = new Item();
                Console.WriteLine("Enter Item Name:");
                item.ItemName = Console.ReadLine();
                Console.WriteLine("Enter Item Code:");
                item.ItemCode = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Item Quantity:");
                item.Quantity = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Item Price:");
                item.Price = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Item Category Name:");
                item.Name = Console.ReadLine();
                Console.WriteLine("Enter Item Category Code:");
                item.Code = int.Parse(Console.ReadLine());
                items[i] = item;

            }
            Bill();
        }
        public static void Bill()
        {

            foreach (var item in items)
            {
                if (item == null)
                    break;
                Console.WriteLine($"\n\t{item.Code}, {item.Name}, {item.ItemCode}, {item.ItemName}, {item.Quantity}, {item.Price}");
                total = total + item.Quantity * item.Price;
            }
            Console.Write($"\n\t\t\tTotal: {total}\n");
        }
    }


}



