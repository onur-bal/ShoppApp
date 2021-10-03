using ShopApp.DataAccess.Abstract;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Concrete.Memory
{
    public class MemoryProductDal : IProductDal
    {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            var products = new List<Product>()
            {
                new Product() { Id=1,Name="Mitoloji Sözlüğü", ImageUrl="1.jpg", Price=50},
                new Product() { Id=1,Name="Tanrılar Okulu", ImageUrl="2.jpg", Price=50},
                new Product() { Id=1,Name="Aldatma Sanatı", ImageUrl="3.jpg", Price=50},
            };
            return products;

        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        

        public Product GetOne(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetPopularProducts()
        {
            throw new NotImplementedException();
        }


        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Uptade(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
