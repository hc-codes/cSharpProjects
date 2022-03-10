using Shop.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Library.Repositories
{
    /// <summary>
    /// Manages CRUD (create, read, update and delete) operations of product entity, in memory
    /// </summary>
    public class ListProductRepository : IProductRepository
    {
        private List<Product> products = new List<Product>();
        /// <summary>
        /// Stores a Product instance in the repository
        /// </summary>
        /// <param name="product">instance of product to be stored</param>
        public void Create(Product product)
        {
            this.products.Add(product);
        }

        public List<string> GetCategories()
        {
            throw new NotImplementedException();
        }

        public int GetNextId()
        {
            throw new NotImplementedException();
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
    }
}
