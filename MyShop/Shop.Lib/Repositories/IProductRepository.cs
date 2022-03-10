using Shop.Library.Models;
using System.Collections.Generic;

namespace Shop.Library.Repositories
{
    public interface IProductRepository
    {
        void Create(Product product);
        IEnumerable<Product> Read();
        Product Read(int id);
        List<Product> Read(string category);
        int GetNextId();
        List<string> GetCategories();
    }
}