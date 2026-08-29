using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced.Question__06
{
    internal class ProductRepository : IRepository<Product>
    {
        private readonly List<Product> _products=new List<Product>();
        public void Add(Product item) =>_products.Add(item);
        public Product GetByID(int ID) =>  _products.Find (p => p.ID == ID)!;
        public List<Product> GetAll() => _products;
        public void Remove(Product item) =>_products.Remove(item);
        

    }
}
