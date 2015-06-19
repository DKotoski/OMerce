using OMerce.Core;
using OMerce.Core.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMerce.Infrastructure
{
    public class ProductRepository:IBaseRepository<Product>
    {
        private OMerceDbContext db;
        public ProductRepository()
        {
                
        }
        public ProductRepository(OMerceDbContext dbContext)
        {
            db = dbContext;
        }
        public Product GetById(int id)
        {
            return db.Products.Find(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return db.Products as IEnumerable<Product>;
        }

        public void Save(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }
    }
}
