using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZellburyStoreApplication.Contracts;
using ZellburyStoreApplication.Data;

namespace ZellburyStoreApplication.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(Product entity)
        {
            _db.Products.Add(entity);
            return Save();
        }

        public bool Delete(Product entity)
        {
            _db.Products.Remove(entity);
            return Save();
        }

        public ICollection<Product> FindAll()
        {
            var products = _db.Products.ToList();
            return products;
        }

        public Product FindById(int id)
        {
            var product = _db.Products.Find(id);
            return product;
        }

        public bool isExist(int id)
        {
            var exists = _db.Products.Any(q => q.Id == id);
            return exists;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Product entity)
        {
            _db.Products.Update(entity);
            return Save();
        }
    }
}
