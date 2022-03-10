using Shop.Library.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Library.Repositories
{
    public class FileProductRepository : IProductRepository
    {
        private readonly string fileName = "Products.data";
        private readonly char[] dlimiter = { ',', ',' };
        private readonly string productFieldPattern = "{0},,{1},,{2},,{3},,{4}\n";
        public FileProductRepository()
        {
            this.Load();
        }
        private void Load()
        {
            using (FileStream file = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                StreamReader reader = new StreamReader(file);
                while (true)
                {
                    string pstr = reader.ReadLine();
                    if (pstr == null)
                    {
                        break;
                    }
                    Product p = Parse(pstr);
                    this.products.Add(p);
                }
            }

        }

        private Product Parse(string pstr)
        {
            Product p = new Product();
            string[] strArr = pstr.Split(dlimiter, StringSplitOptions.RemoveEmptyEntries);
            p.Id = Convert.ToInt32(strArr[0]);
            p.Category = strArr[1];
            p.Name = strArr[2];
            p.Price = Convert.ToDouble(strArr[3]);
            p.Stock = Convert.ToInt32(strArr[4]);
            //Console.WriteLine($"{strArr[0]},{strArr[1]},{strArr[2]},{strArr[3]},{strArr[4]} ");

            return p;
        }

        private void Save()
        {
            StringBuilder builder = new StringBuilder();
            foreach (var item in this.products)
            {
                string str = string.Format(productFieldPattern, item.Id, item.Category, item.Name, item.Price, item.Stock);
                builder.Append(str);
            }
            StreamWriter writer = null;
            try//it will work without catch , if finally is there.
            {
                FileStream file = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(file);
                writer.Write(builder.ToString());
                writer.Flush();
            }
            /*catch(Exception)//if there is no catch the program will crash
            {
                throw;//whatever exception it catched it will throw back so tha the user will no something went wrong and couldn't save.
            }*/
            finally//If the try block worked finally will work 
            {
                if (writer != null)//if catch is worked then writer will be null
                                   //if the exception is thrown it will go to the main method's catch
                {
                    writer.Close();
                }
            }
        }
        private List<Product> products = new List<Product>();
        /// <summary>
        /// Stores a Product instance in the repository
        /// </summary>
        /// <param name="product">instance of product to be stored</param>
        public void Create(Product product)
        {
            this.products.Add(product);
            Save();
        }
        /// <summary>
        /// Read the instance of product with the given unique id 
        /// </summary>
        /// <param name="id">the id to look for</param>
        /// <returns>the instance of product with the id or null if not found</returns>
        public Product Read(int id)
        {
            foreach (var item in products)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
        /// <summary>
        /// returns a collection of products having the given category
        /// </summary>
        /// <param name="category">the category to search for</param>
        /// <returns>a not null collection of products</returns>
        public List<Product> Read(string category)
        {
            List<Product> lst = new List<Product>();
            foreach (var item in products)
            {
                if (item.Category == category)
                {
                    lst.Add(item);
                }
            }
            return lst;
        }
        /// <summary>
        /// returns a collection of all products in the store
        /// </summary>
        /// <returns>a not null collection of products</returns>
        public IEnumerable<Product> Read()
        {
            return this.products;
        }

        public int GetNextId()
        {
            int nextId = 1;
            foreach (var product in products)
            {
                if (product.Id > nextId)
                {
                    nextId = product.Id;
                }
            }
            return nextId + 1;
        }

        public List<string> GetCategories()
        {
            List<string> cats = new List<string>();
            foreach (var product in products)
            {
                string cat = product.Category;
                if (!cats.Contains(cat))
                {
                    cats.Add(cat);
                }
            }
            return cats;
        }
    }
}
