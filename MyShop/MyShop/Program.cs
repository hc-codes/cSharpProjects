using Shop.Library.Models;
using Shop.Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop
{
    class Program
    {
        static IProductRepository repo = new FileProductRepository();
        static void Main(string[] args)
        {
            Product p = new Product { Id = 1, Category = "Soaps", Name = "Santhoor", Price = 25, Stock = 15 };
            repo.Create(p);
            p = new Product { Id = 2, Category = "Soaps", Name = "Medimix", Price = 45, Stock = 23 };
            repo.Create(p);
            p = new Product { Id = 3, Category = "Grocery", Name = "Matta rice", Price = 40, Stock = 10 };
            repo.Create(p);
            p = new Product { Id = 4, Category = "Stationary", Name = "NatRaj Pencil", Price = 5, Stock = 20 };
            repo.Create(p);
            Cart cart = new Cart();
            while(true)
            {
                Console.Write("\n\nEnter Id: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Qty: ");
                int qty = Convert.ToInt32(Console.ReadLine());
                Product product = repo.Read(id);
                cart.Add(product, qty);
                Console.Write("\nType c to continue shopping: ");
                if("c"!= Console.ReadLine())
                {
                    break;
                }
            }
            Console.WriteLine("\n\n\tContents of Cart");
            Console.WriteLine("\tItem\t\tQty\tAmt");
            foreach (var item in cart.Contents)
            {
                Console.Write("\t" + item.Key + "\t" + item.Value + "\t" + item.Key.Price * item.Value + "\n");
            }
            Console.WriteLine("\tCart Total: " + cart.ComputeTotal());
            /*Console.Write("Enter Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(repo.Read(id));
            Console.Write("Enter Category: ");
            var products = repo.Read(Console.ReadLine());
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }
            foreach (var item in repo.Read())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(repo.Read(id));*/
        }
    }
}
